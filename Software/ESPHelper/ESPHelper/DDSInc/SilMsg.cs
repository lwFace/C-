using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using datarouter;

namespace ESPHelper.DDSInc
{
    [StructLayout(LayoutKind.Sequential)]
    public class SilMsg
    {
        public uint id;
        public uint length;
        public datarouter.Payload[] payload = new datarouter.Payload[0];
        public datarouter.Payload[] payload_mask = new datarouter.Payload[0];
        public SilMsg(SIL_msg msg)
        {
            this.id = msg.id;
            this.length = msg.length;
            this.payload = msg.payload;
        }
        public System.TimeSpan Time
        {
            get;
            set;
        }
        public int DTime { get; set; }
        public uint DDSKey
        {
            get { return id; }
            set { id = value; }
        }
        public uint Length
        {
            get { return length; }
            set { length = value; }
        }
        public object Payload
        {
            get
            {
                return DataTransmit.PayloadToByte(payload);
            }
            set
            {
                payload = DataTransmit.ByteToPayload(value as byte[]);
            }
        }
    }
}
