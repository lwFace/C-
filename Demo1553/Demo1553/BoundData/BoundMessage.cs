using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo1553
{
    public enum MessageType { BC_RT = 0, RT_BC = 1, RT_RT = 2 };
    public class BoundMessage
    {
        private MessageType msgType;
        private byte srcSubRTAddr;
        private byte srcRTAddr;
        private byte dstRTAddr;
        private byte dstSubRTAddr;
        private uint length;
        private ushort cmd2;
        private ushort cmd1;

        public BoundMessage()
        {
            UUID = Guid.NewGuid().ToString();
            Payload = new ushort[32];
            msgType = MessageType.BC_RT;
        }
       
        public string UUID { get; set; }
        public string Name { get; set; }
        public MessageType MsgType
        {
            get
            {
                return msgType;
            }
            set
            {
                msgType = value ;
                switch (value)
                {
                    case MessageType.BC_RT:
                        srcRTAddr = 0xFF;
                        srcSubRTAddr = 0xFF;
                        if (dstRTAddr == 0xFF)
                        {
                            dstRTAddr = 1;
                        }
                        if (dstSubRTAddr == 0xFF)
                        {
                            dstSubRTAddr = 1;
                        }
                        break;
                    case MessageType.RT_BC:
                        if (srcRTAddr == 0xFF)
                        {
                            srcRTAddr = 1;
                        }
                        if (srcSubRTAddr == 0xFF)
                        {
                            srcSubRTAddr = 1;
                        }
                        dstRTAddr = 0xFF;
                        dstSubRTAddr = 0xFF;
                        break;
                    case MessageType.RT_RT:
                        if (srcRTAddr == 0xFF)
                        {
                            srcRTAddr = 1;
                        }
                        if (srcSubRTAddr == 0xFF)
                        {
                            srcSubRTAddr = 1;
                        }
                        if (dstRTAddr == 0xFF)
                        {
                            dstRTAddr = 1;
                        }
                        if (dstSubRTAddr == 0xFF)
                        {
                            dstSubRTAddr = 1;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        public ushort Cmd1
        {
            get
            {
                return cmd1;
            }
            set
            {
                cmd1 = value;
                if (cmd2 == 0)
                {

                }

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
        public byte SrcRTAddr { get { return srcRTAddr; } set { srcRTAddr = value; UpdateCmd(); } }
        public byte SrcSubRTAddr { get { return srcSubRTAddr; } set { srcSubRTAddr = value; UpdateCmd(); } }
        public byte DstRTAddr { get { return dstRTAddr; } set { dstRTAddr = value; UpdateCmd(); } }
        public byte DstSubRTAddr { get { return dstSubRTAddr; } set { dstSubRTAddr = value; UpdateCmd(); } }
        public uint status1;
        public uint status2;
        public uint Period{get;set;}


        public uint Length { get { return length; } set { length = value; UpdateCmd(); } }
        public ushort[] Payload { get; set; }
        
        private void UpdateCmd()
        {
            if (srcRTAddr == 0xFF)//BC-RT
            {
                //cmd1 = 
            }
            else if (dstRTAddr == 0xFF)//RT-BC
            {
                //cmd1 = 
            }
            else//RT-RT
            {
                //cmd1 =
                //cmd2 =
            }
        }


       
    }
}
