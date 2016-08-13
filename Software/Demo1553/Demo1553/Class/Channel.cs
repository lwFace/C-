using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo1553.Class;

namespace Demo1553
{
    public class Channel
    {
        //NodeType { BC=0,RT=1,BM=2};
        /*定义Node的Dictionary*/
        public Dictionary<int, Node> nodes;

        public int Id;
        public string Name;
        public bool IsEnable;

        public Channel()
        {
            IsEnable = false;
            nodes = new Dictionary<int, Node>();
        }

        public BC GetBC()
        {
            /*查找Dictionary，获取到BC对象*/
            return (BC)nodes[(int)NodeType.BC];
        }
        public RT GetRT()
        {
          //  return new RT();
            return (RT)nodes[(int)NodeType.RT];
        }
        public BM GetBM()
        {
            return (BM)nodes[(int)NodeType.BM];
        }

        /// <summary>
        /// 增加node对象
        /// </summary>
        /// <param name="node"></param>
        public void AddNode(Node node)
        {
            /*加入到Node的Dictionary*/
            nodes.Add((int)node.Type,node);
        }
    }
}
