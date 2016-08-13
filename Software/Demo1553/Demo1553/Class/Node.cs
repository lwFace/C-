using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Demo1553.BoundData;

namespace Demo1553
{
    public class Node
    {
        public NodeType Type;
        public string Name;
        public bool IsEnable;
        public BindingList<BoundRecvMessage> moniMsgList;
        public Node()
        {
            IsEnable = false;
            moniMsgList = new BindingList<BoundRecvMessage>();
        }

        /*定义MsgList，用于存储来自板卡的消息*/

        /*定义增加消息到List的方法*/

    }
}
