using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo1553.Class;

namespace Demo1553
{
    public enum MessageType { BC_RT = 0, RT_BC = 1, RT_RT = 2 };
    public class BoundMessage
    {
        private MessageType msgType;
        private int srcSubRTAddr;
        private int srcRTAddr;
        private int dstRTAddr;
        private int dstSubRTAddr;
        private int length;
        private ushort cmd2;
        private ushort cmd1;
        private uint period;
        public BoundMessage()
        {
            NetId = NetIdGenerator.GenerateNetId();
            Payload = new byte[64];
            msgType = MessageType.BC_RT;
            srcRTAddr = 1;
            srcSubRTAddr = 1;
            srcRTAddr = 1;
            dstSubRTAddr = 1;
            Tag = this;
        }
       
        public int NetId { get; set; }
        public ushort Cmd1
        {
            get
            {
                return cmd1;
            }
            set
            {
                cmd1 = value;
            }
        }
        public ushort Cmd2
        {
            get
            {
                return cmd2;
            }
            set
            {
                cmd2 = value;
            }
        }
     //   public string Name { get; set; }
        public MessageType MsgType
        {
            get
            {
                return msgType;
            }
            set
            {
                msgType = value ;
                UpdateCmd();
            }
        }
        
        public int SrcRTAddr { get { return srcRTAddr; } set { srcRTAddr = value; UpdateCmd(); } }
        public int SrcSubRTAddr { get { return srcSubRTAddr; } set { srcSubRTAddr = value; UpdateCmd(); } }
        public int DstRTAddr { get { return dstRTAddr; } set { dstRTAddr = value; UpdateCmd(); } }
        public int DstSubRTAddr { get { return dstSubRTAddr; } set { dstSubRTAddr = value; UpdateCmd(); } }

        public uint Period
        {
            get
            {
                return period;
            }
            set
            {
                period = value;
            }
        }
  
        

        public int WordSize { get { return length; } set { length = value; UpdateCmd(); } }
        public byte[] Payload { get; set; }
        public object Tag { get; set; }
        private void UpdateCmd()
        {
            ushort wSize = (ushort)length;
            switch (msgType)
            {

                case MessageType.BC_RT:
                    cmd1 = (ushort)((wSize & 0x1f) | (dstSubRTAddr & 0x1f) << 5 | (dstRTAddr & 0x1f) << 11);
                    break;
                case MessageType.RT_BC:
                    cmd1 = (ushort)((wSize & 0x1f) | (srcSubRTAddr & 0x1f) << 5 | (1 << 10) | (srcRTAddr & 0x1f) << 11);
                    break;
                case MessageType.RT_RT:
                    cmd1 = (ushort)((wSize & 0x1f) | (dstSubRTAddr & 0x1f) << 5 | (dstRTAddr & 0x1f) << 11);
                    cmd2 = (ushort)((wSize & 0x1f) | (srcSubRTAddr & 0x1f) << 5 | (1 << 10) | (srcRTAddr & 0x1f) << 11);
                    break;
                default:
                    break;
            }
        }

        
    }
}
