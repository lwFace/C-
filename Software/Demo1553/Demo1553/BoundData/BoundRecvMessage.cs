using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo1553.BoundData
{
    public class BoundRecvMessage
    {
        public DateTime Time { get; set; }
        public long dt{get; set;}
        public int msgId { get; set; }
        public int src{ get; set; }
        /*物理通道信息，具体含义如下
			  0-7：节点ID，BC为0，RT为1，BM为2 
			  8-15：通道ID 
			  16-23：板卡ID	*/
        public byte srcAddr{ get; set; }
        public byte subSrcAddr{ get; set; }
        public byte dstAddr{ get; set; }
        public byte subDstAddr { get; set; }
        public ushort cmd1{ get; set; }
        public ushort cmd2{ get; set; }
        public ushort status1 { get; set; }
        public ushort status2{ get; set; }

        public int WordSize { get; set; }
        public byte[] Payload { get; set; }
     

        public BoundRecvMessage(CALLBACK_1553 msg,long dt)
        {
            msgId = msg.msgId;
            src = msg.src;
            srcAddr = msg.srcAddr;
            subSrcAddr = msg.subSrcAddr;
            dstAddr = msg.dstAddr;
            subDstAddr = msg.subDstAddr;
            cmd1 = msg.cmd1;
            cmd2 = msg.cmd2;
            status1 = msg.status1;
            status2 = msg.status2;
            long t = ((long)msg.sec) * 10000000 + msg.usec * 10;
            Time = new DateTime(t + new DateTime(1970, 1, 1).Ticks);
            WordSize = msg.length;
            Payload = msg.payload;
            this.dt = dt;
        }
    }
}
