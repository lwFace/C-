using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Demo1553
{
    public class BC:Node
    {
        public BindingList<BoundMessage> MsgList;
        /*BC配置信息*/
        public BC()
        {
            this.Type = NodeType.BC;
            MsgList = new BindingList<BoundMessage>();

           
        }
    }
}
