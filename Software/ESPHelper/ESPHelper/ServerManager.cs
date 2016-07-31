using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using io;
using com.hirain.avionics.healthmanager.dds;
using com.hirain.avionics.healthmanager.dds.service;
using Ch.Elca.Iiop;
using System.Runtime.Remoting.Channels;
using Ch.Elca.Iiop.Services;
using System.Runtime.Remoting;
using core;
using com.hirain.avionics.dds.util;
namespace ESPHelper
{
    public class ServerManager
    {
        /// <summary>
        /// 所有扫描道到的IO服务
        /// </summary>
        public static Dictionary<int, ServiceEvent> IOAll = new Dictionary<int, ServiceEvent>(); 
        /// <summary>
        /// 当前使用的IO，key值为serverId，value为serverId对应的POA对象
        /// </summary>
        public static Dictionary<int, IODevice> IOMap = new Dictionary<int, IODevice>();

        /// <summary>
        ///  key值为serverId，value为serverId对应的server对象
        /// </summary>
        //        public static Dictionary<int, Project> ServerMap = new Dictionary<int, Project>();

        public static Project Project = new Project("Project");
        public static object threadServerStatusLock = new object();
        
        public static void ParseDDSData(IDDSData data)
        {
            ServiceDDSData sdd = (ServiceDDSData)data;
            //new server
            if (!IOAll.ContainsKey(sdd.Id))
            {
                ServiceEvent info = new ServiceEvent();
                info.ServiceID = sdd.Id;
                info.Name = sdd.Name;
                info.IOR = sdd.Ior;
                info.Version = sdd.Version;
                info.Status = sdd.Status;
                info.StatusMsg = sdd.StatusMsg;
                IOAll.Add(sdd.Id, info);
            }
        }

        public static void AddServer(ServiceEvent sdd)
        {
            //new server
            if (!IOMap.ContainsKey(sdd.ServiceID))
            {
                // 建立并注册IIOP通道，与服务器corba进行通信 
                IiopClientChannel channel = new IiopClientChannel();
                ChannelServices.RegisterChannel(channel, false);
                //本地corba初始化 
                CorbaInit init = CorbaInit.GetInit();
                //根据ior字符串获取对方服务 
                IODevice ioManager = (IODevice)RemotingServices.Connect(typeof(IODevice), sdd.IOR);
                IOMap.Add(sdd.ServiceID, ioManager);
                Project serverPrj = new Project(sdd.Name);
                serverPrj.Status = sdd.StatusMsg;
                serverPrj.StatusId = sdd.Status;
                serverPrj.Version = sdd.Version;
                serverPrj.No = (short)sdd.ServiceID;
                Project.Projects.Add(serverPrj);
                Project.ChildNode.Add(sdd.ServiceID, serverPrj);
                UpdateServer(sdd.ServiceID, ioManager);
            }
        }
        /// <summary>
        /// 更新设备信息
        /// </summary>
        public static void UpdateServer(int serviceId, IODevice dev)
        {
            try
            {
                if (!Project.ChildNode.ContainsKey(serviceId))
                {
                    return;
                }
                lock (threadServerStatusLock)
                {
                    Project.ChildNode[serviceId].Projects.Clear();
                    Project.ChildNode[serviceId].ChildNode.Clear();
                    card[] cards;
                    dev.getCardsInfo(out cards);
                    foreach (var cardInfo in cards)
                    {
                        int cardSlot = cardInfo.cardNo;
                        Project cardPrj = new Project(cardInfo.cardName);
                        cardPrj.No = (short)cardSlot;
                        cardPrj.type = cardInfo.type;
                        cardPrj.parameters = cardInfo.cardParameter;
                        string devId;
                        dev.bitCard(cardPrj.type, cardPrj.No, out devId);
                        try
                        {
                            cardPrj.devId = int.Parse(devId);
                        }
                        catch (System.Exception ex)
                        {
                            Program.mainFrm.LogError("Invalid device id : " + devId + "(" + cardInfo.cardName + ")");
                        }

                        Project.ChildNode[serviceId].Projects.Add(cardPrj);
                        Project.ChildNode[serviceId].ChildNode.Add(cardSlot, cardPrj);

                        channel[] chnsInfo;
                        dev.getChannelsInfo(cardPrj.type, cardPrj.No, out chnsInfo);
                        foreach (var chn in chnsInfo)
                        {
                            Project chnPrj = new Project("Chn" + chn.channelID.ToString());
                            chnPrj.type = cardPrj.type;
                            chnPrj.No = chn.channelID;
                            chnPrj.parameters = chn.channelParameter;
                            chnPrj.Mode = chn.mode;
                            chnPrj.Direction = chn.direction;
                            cardPrj.Projects.Add(chnPrj);
                            ChannelSNConvert.ChannelInfo info = new ChannelSNConvert.ChannelInfo(ChannelSNConvert.IO_TYPE_COMMON_IO, cardPrj.devId, cardPrj.No, chnPrj.No);
                            chnPrj.channelSn = ChannelSNConvert.Channel2SN(info);
                            cardPrj.ChildNode.Add(chn.channelID, chnPrj);
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        /// <summary>
        /// 更新服务和设备状态信息
        /// </summary>
        public static void UpdateServerStatus()
        {
            foreach (var item in IOMap)
            {
                try
                {
                    StatusInfo info;
                    item.Value.getServerStatus(out info);
                    if (Project.ChildNode.ContainsKey(item.Key))
                    {
                        lock (threadServerStatusLock)
                        {
                            Project.ChildNode[item.Key].StatusId = info.targetStatus.status;
                            Project.ChildNode[item.Key].Status = info.targetStatus.statusMsg;

                            Project serverPrj = Project.ChildNode[item.Key];
                            //更新板卡状态
                            foreach (var cardInfo in info.cardStatusInfos)
                            {
                                if (serverPrj.ChildNode.ContainsKey(cardInfo.cardID))
                                {
                                    Project cardPrj = serverPrj.ChildNode[cardInfo.cardID];
                                    cardPrj.StatusId = cardInfo.cardStatus.status;
                                    cardPrj.Status = cardInfo.cardStatus.statusMsg;
                                    //更新通道状态
                                    foreach (var chnInfo in cardInfo.channelStatusInfos)
                                    {
                                        if (cardPrj.ChildNode.ContainsKey(chnInfo.id))
                                        {
                                            Project chnPrj = cardPrj.ChildNode[chnInfo.id];
                                            chnPrj.Status = chnInfo.statusMsg;
                                            chnPrj.StatusId = chnInfo.status;
                                        }
                                    }
                                }

                            }
                        }

                    }
                }
                catch (System.Exception ex)
                {
                    if (Project.ChildNode.ContainsKey(item.Key))
                    {
                        Project.ChildNode[item.Key].StatusId = 2;
                        Project.ChildNode[item.Key].Status = "timeout";
                    }
                }

            }
        }

        public static void SetServerOffline(short serverID)
        {
            if (Project.ChildNode.ContainsKey(serverID))
            {
                Project.ChildNode[serverID].StatusId = 2;
                Project.ChildNode[serverID].Status = "offline";
                foreach (var card in Project.ChildNode[serverID].Projects)
                {
                    card.Status = "offline";
                    card.StatusId = 2;
                    foreach (var chn in card.Projects)
                    {
                        chn.Status = "offline";
                        chn.StatusId = 2;
                    }
                }
            }
        }
    }
}
