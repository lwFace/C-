using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Demo1553
{
    public enum NodeType { BC=0,RT=1,BM=2};
    public class BoundResourceNode : BoundResourceBase
    {
        private NodeType nodeType;
       // private BindingList<BoundMessage> msgList = new BindingList<BoundMessage>();
        public BoundResourceNode()
        {
            SetResourceType(ResourceType.Node);
        }

        /// <summary>
        /// 获取1553节点类型
        /// </summary>
        /// <returns></returns>
        public NodeType GetNodeType()
        {
            return nodeType;
        }

        public void SetNodeType(string nodeName)
        {
            switch(nodeName)
            {
                case "BC":
                    nodeType = NodeType.BC;
                    break;
                case "RT":
                    nodeType = NodeType.RT;
                    break;
                case "BM":
                    nodeType = NodeType.BM;
                    break;
                default:
                    throw new Exception("错误的节点类型：" + nodeName);
             }
        }

        //public void AddMsg(BoundMessage msg)
        //{
        //    msgList.Add(msg);
        //}
       
    }
}
