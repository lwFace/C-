using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Demo1553
{
    public static class CardManager
    {
        /*定义card的Dictionary*/
        static Dictionary<int, Card> cards;
        public static HR_CALLBACK m_callback;
        /// <summary>
        /// 解析xml配置文件，获取板卡信息，建立板卡对象
        /// </summary>
        /// <param name="xmlInfo"></param>
        public static void Register(string xmlInfo)
        {
            cards = new Dictionary<int, Card>();
            m_callback = new HR_CALLBACK(intFunc);
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
        /// <summary>
        /// 初始化按钮调用该方法
        /// </summary>
        /// <returns></returns>
        public static int Init()
        {
            string xmlConf = "";

            Interface1553.init(xmlConf);
            return 0;
        }
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
