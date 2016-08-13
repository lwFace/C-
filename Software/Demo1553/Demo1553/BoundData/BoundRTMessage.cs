using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo1553.Class;

namespace Demo1553
{
    public class BoundRTMessage
    {
        public int NetId { get; set; }
        public string Name { get; set; }
        private byte rtAddr;
        private byte subRTAddr;
        private uint length;

        public BoundRTMessage()
        {
            NetId = NetIdGenerator.GenerateNetId();
            Payload = new ushort[32];
        }
        public byte RTAddr { get { return rtAddr; } set { rtAddr = value; } }
        public byte SubRTAddr { get { return subRTAddr; } set { subRTAddr = value; } }
        public uint Length { get; set; }
        public ushort[] Payload { get; set; }
        
    }
}
