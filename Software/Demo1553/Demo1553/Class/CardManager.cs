using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Xml;
using Demo1553.BoundData;
using Demo1553.Class;

namespace Demo1553
{
    public static class CardManager
    {
        /*定义card的Dictionary*/
        public static Dictionary<int, Card> cards = new Dictionary<int, Card>();
        public static HR_CALLBACK m_callback;
       
        /// <summary>
        /// 解析xml配置文件，获取板卡信息，建立板卡对象
        /// </summary>
        /// <param name="xmlInfo"></param>
        public static void Register(string xmlInfo)
        {
            if (m_callback == null)
            {
                m_callback = new HR_CALLBACK(intFunc);
            }           
            Interface1553.addListener(m_callback);
        }

        
        /// <summary>
        /// 中断处理函数，获取数据，更新到Node的消息列表
        /// </summary>
        /// <param name="pCallbackInfo"></param>
        /// <param name="pParam"></param>
        static void intFunc(IntPtr pCallbackInfo, IntPtr pParam)
        {
            CALLBACK_1553 pInfo = new CALLBACK_1553();
            pInfo = (CALLBACK_1553)Marshal.PtrToStructure(pCallbackInfo, typeof(CALLBACK_1553));
            //GetNodeBySrc(pInfo.src).moniMsgList.Add(new BoundRecvMessage(pInfo));
            if (CardManager.GetNodeBySrc(pInfo.src).Type == NodeType.BC)
            {
                BC bc = CardManager.GetCard(GetCardIdBySrc(pInfo.src)).GetChannle(GetChnIdBySrc(pInfo.src)).GetBC();
                if (bc.IsRunning)
                {
                    long dt = 0;
                    int count = bc.MonitorMsgList.Count;
                    if (count != 0)
                    {                        
                        dt = ((long)pInfo.sec * 1000000 + pInfo.usec) - bc.MonitorMsgList[count - 1].Time.Ticks / 10 + new DateTime(1970, 1, 1).Ticks / 10;
                    }
                    bc.MonitorMsgList.Add(new BoundRecvMessage(pInfo, dt));
                }                
            }
            if (CardManager.GetNodeBySrc(pInfo.src).Type == NodeType.RT)
            {
                RT rt = CardManager.GetCard(GetCardIdBySrc(pInfo.src)).GetChannle(GetChnIdBySrc(pInfo.src)).GetRT();
                if (rt.IsRunning)
                {
                    long dt = 0;
                    int count = rt.MonitorMsgList.Count;
                    if (count != 0)
                    {
                        dt = ((long)pInfo.sec * 1000000 + pInfo.usec) - rt.MonitorMsgList[count - 1].Time.Ticks / 10 + new DateTime(1970, 1, 1).Ticks / 10;
                    }
                    rt.MonitorMsgList.Add(new BoundRecvMessage(pInfo, dt));
                }
            }
            if (CardManager.GetNodeBySrc(pInfo.src).Type == NodeType.BM)
            {
                BM bm = CardManager.GetCard(GetCardIdBySrc(pInfo.src)).GetChannle(GetChnIdBySrc(pInfo.src)).GetBM();
                if (bm.IsRunning)
                {
                    long dt = 0;
                    int count = bm.MonitorMsgList.Count;
                    if (count != 0)
                    {
                        dt = ((long)pInfo.sec * 1000000 + pInfo.usec) - bm.MonitorMsgList[count - 1].Time.Ticks / 10 + new DateTime(1970, 1, 1).Ticks / 10;
                    }
                    bm.MonitorMsgList.Add(new BoundRecvMessage(pInfo, dt));
                }
            }

        }
        static private Node GetNodeBySrc(int src)
        {
            int nodeID = src & 0xff;
            int chnId = (src >> 8) & 0xff;
            int cardId = (src >> 16) & 0xff;
            return cards[cardId].channels[chnId].nodes[nodeID];
        }

        static private int GetChnIdBySrc(int src)
        {
            int chnId = (src >> 8) & 0xff;
            return chnId;
        }
        static private int GetCardIdBySrc(int src)
        {
            int cardId = (src >> 16) & 0xff;
            return cardId;
        }

        /// <summary>
        /// 获取板卡对象
        /// </summary>
        /// <param name="cardId">板卡ID</param>
        /// <returns></returns>
        public static Card GetCard(int cardId)
        {
            return cards[cardId];
        }
        #region 初始化
        /// <summary>
        /// 初始化按钮调用该方法
        /// </summary>
        /// <returns></returns>
        public static int Init()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("init");
            xmlDoc.AppendChild(root);
            
            foreach (var card in cards)
            {
                if (card.Value.IsEnable == true)
                {
                     XmlElement elementCard = xmlDoc.CreateElement("card");
                     elementCard.SetAttribute("Id", card.Value.Id.ToString());
                     elementCard.SetAttribute("Name", card.Value.Name);
                     root.AppendChild(elementCard);
                     foreach (var channel in card.Value.channels)
                     {
                         if (channel.Value.IsEnable == true)
                         {
                             XmlElement elementChn = xmlDoc.CreateElement("channel");
                             elementChn.SetAttribute("Flag", "1");
                             elementChn.SetAttribute("Id", channel.Value.Id.ToString());
                             elementCard.AppendChild(elementChn);
                             XmlElement elementpara = xmlDoc.CreateElement("paramemter");
                             elementpara.SetAttribute("Name", "Terminal");
                             #region Terminal
                             string terminalStr = "";
                             if (channel.Value.GetBC().IsEnable)
                             {
                                 terminalStr += "BC;";
                             }
                             if (channel.Value.GetRT().IsEnable)
                             {
                                 terminalStr += "RT;";
                             }
                             if (channel.Value.GetBM().IsEnable)
                             {
                                 terminalStr += "BM;";
                             }
                             #endregion
                             elementpara.SetAttribute("Value", terminalStr);
                             elementChn.AppendChild(elementpara);
                             
                             XmlElement elementpara1 = xmlDoc.CreateElement("paramemter");
                             elementpara1.SetAttribute("Name", "BusType");
                             elementpara1.SetAttribute("Value", "A");
                             elementChn.AppendChild(elementpara1);

                             #region BC
                             if (channel.Value.GetBC().IsEnable)
                             {
                                 XmlElement elementBC = xmlDoc.CreateElement("BC");
                                 elementBC.SetAttribute("Flag", "1");
                                 elementChn.AppendChild(elementBC);
                                 XmlElement elementparaBC = xmlDoc.CreateElement("paramemter");
                                 elementparaBC.SetAttribute("Name", "PeriodBlockNum");
                                 elementparaBC.SetAttribute("Value", channel.Value.GetBC().GetBlockNum().periodNum.ToString());
                                 //int[] period = channel.Value.GetBC().GetPeriod();
                                // elementparaBC.SetAttribute("Value",period[1].ToString());
                                 elementBC.AppendChild(elementparaBC);
                                 XmlElement elementparaBC1 = xmlDoc.CreateElement("paramemter");
                                 elementparaBC1.SetAttribute("Name", "AperiodBlockNum");
                                 elementparaBC1.SetAttribute("Value", channel.Value.GetBC().GetBlockNum().aperiodNum.ToString());
                                 //elementparaBC1.SetAttribute("Value", period[0].ToString());
                                 elementBC.AppendChild(elementparaBC1);

                                 XmlElement elementbusTab = xmlDoc.CreateElement("busTable");
                                 elementBC.AppendChild(elementbusTab);
                                 foreach (var msg in channel.Value.GetBC().ScheduMsgList)
                                 {
                                     XmlElement elementitem = xmlDoc.CreateElement("item");
                                     elementitem.SetAttribute("MsgId", msg.NetId.ToString());
                                     elementitem.SetAttribute("BCPeriod", msg.Period.ToString());
                                     elementitem.SetAttribute("DstAddress", msg.DstRTAddr.ToString());
                                     elementitem.SetAttribute("DstSubAddress", msg.DstSubRTAddr.ToString());
                                     elementitem.SetAttribute("MsgType", msg.MsgType.ToString());
                                     elementitem.SetAttribute("SrcAddress", msg.SrcRTAddr.ToString());
                                     elementitem.SetAttribute("SrcSubAddress", msg.SrcSubRTAddr.ToString());
                                     elementitem.SetAttribute("WordSize", msg.WordSize.ToString());
                                     elementbusTab.AppendChild(elementitem);
                                 }
                             }
                             #endregion
                             #region RT
                             if (channel.Value.GetRT().IsEnable)
                             {
                                 XmlElement elementRT = xmlDoc.CreateElement("RT");
                                 elementRT.SetAttribute("Flag", "1");
                                 elementChn.AppendChild(elementRT);
                                 XmlElement elementaddrTab = xmlDoc.CreateElement("addrTable");
                                 elementRT.AppendChild(elementaddrTab);
                                 XmlElement elementbusTab = xmlDoc.CreateElement("busTable");
                                 elementRT.AppendChild(elementbusTab);

                                 bool[] rtStatus = channel.Value.GetRT().GetRTStatus();
                                 for (int i = 0; i < rtStatus.Length; i++)
                                 {
                                     if (rtStatus[i] == true)
                                     {
                                         XmlElement elementrtAddr = xmlDoc.CreateElement("rtAddress");
                                         elementrtAddr.SetAttribute("Value", (i + 1).ToString());
                                         elementaddrTab.AppendChild(elementrtAddr);
                                     }
                                 }
                                 foreach (var RTmsg in channel.Value.GetRT().RTMsgList)
                                 {
                                     XmlElement elementitem = xmlDoc.CreateElement("item");
                                     elementitem.SetAttribute("MsgId", RTmsg.NetId.ToString());
                                     elementitem.SetAttribute("RTAddr", RTmsg.RTAddr.ToString());
                                     elementitem.SetAttribute("SubRTAddr", RTmsg.SubRTAddr.ToString());
                                     elementbusTab.AppendChild(elementitem);
                                 }
                             }
                             #endregion
                             if (channel.Value.GetBM().IsEnable)
                             {
                                 XmlElement elementBM = xmlDoc.CreateElement("BM");
                                 elementBM.SetAttribute("Flag", "1");
                                 elementChn.AppendChild(elementBM);
                             }

                         }
                     }
                }
            }
            xmlDoc.Save("e://data.xml");
            //Interface1553.init(xmlConf);
            return 0;
        }
        #endregion

        #region 启停
        /// <summary>
        /// 开始按钮调用该方法
        /// </summary>
        public static void Start()
        {
            Interface1553.start();
        }

        public static void Stop()
        {
            Interface1553.stop();
        }
        #endregion

        #region 数据发送
        public static void WriteMsg(int msgId, System.IntPtr pPayload, int nLen)
        {
            Interface1553.writeMsg(msgId, pPayload, nLen);
        }
        #endregion
        /// <summary>
        /// 增加card的对象
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="card"></param>
        public static void AddCard(int cardId, Card card)
        {
            cards.Add(cardId,card);
        }

        /*start stop open close 等函数实现*/
       
    }
}
