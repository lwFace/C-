using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Xml;

namespace Demo1553
{
    public static class CardManager
    {
        /*定义card的Dictionary*/
        static Dictionary<int, Card> cards = new Dictionary<int, Card>();
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
            //string xmlConf = "";
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("init");
            xmlDoc.AppendChild(root);
            
            foreach (var card in cards)
            {
                //Card card = new Card();
                //Channel channel=new Channel();
                //Node node=new Node();
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
                                 foreach (var msg in channel.Value.GetBC().MsgList)
                                 {
                                     XmlElement elementitem = xmlDoc.CreateElement("item");
                                     elementitem.SetAttribute("MsgId", msg.UUID);
                                     elementitem.SetAttribute("BCPeriod", msg.Period.ToString());
                                     elementitem.SetAttribute("DstAddress", msg.DstRTAddr.ToString());
                                     elementitem.SetAttribute("DstSubAddress", msg.DstSubRTAddr.ToString());
                                     elementitem.SetAttribute("MsgType", msg.MsgType.ToString());
                                     elementitem.SetAttribute("SrcAddress", msg.SrcRTAddr.ToString());
                                     elementitem.SetAttribute("SrcSubAddress", msg.SrcSubRTAddr.ToString());
                                     elementitem.SetAttribute("WordSize", msg.Length.ToString());
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
                                     elementitem.SetAttribute("MsgId", RTmsg.UUID);
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

        #region 开始
        public static void Start()
        {
            Interface1553.start();
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
