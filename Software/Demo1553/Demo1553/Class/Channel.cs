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


        public BC GetBC()
        {
            /*查找Dictionary，获取到BC对象*/
            return new BC();
        }
        public RT GetRT()
        {
            return new RT();
        }
        public BM GetBC()
        {
            return new BM();
        }

        public void AddNode()
        {
            /*加入到Node的Dictionary*/
        }
    }
}
