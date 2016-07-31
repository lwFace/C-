using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using datarouter;

namespace ESPHelper.DDSInc
{
    [StructLayout(LayoutKind.Sequential)]
    public class AAMSNobusMsg
    {
        public AAMSNobusMsg(AAMS_NoBus_msg msg)
        {
            this.id = msg.id;
            this.length = (uint)msg.payload.Length;
            this.payload = msg.payload;
            this.src = msg.src;
            this.sec = msg.sec;
            this.usec = msg.usec;
        }
        public uint sn;
        public uint id;
        public uint src;
        public uint reserved;
        public uint sec;
        public uint usec;
        public uint length;
        public datarouter.Payload[] payload = new datarouter.Payload[0];

        public System.TimeSpan Time
        {
            get
            {
                Int64 addTime = usec + Convert.ToInt64(sec) * 10000000;
                DateTime dt = new DateTime(1970, 1, 1, 8, 0, 0);
                DateTime nowT =  dt.AddMilliseconds(addTime);
                return nowT.TimeOfDay;
            }
            set
            {
                DateTime dt = new DateTime(1970, 1, 1, 8, 0, 0);
                double milsec = value.TotalMilliseconds - dt.TimeOfDay.TotalMilliseconds;
                sec = (uint)milsec / 1000000;
                usec = (uint)milsec % 1000000;
            }
        }
        public int DTime { get; set; }
        public uint SN
        {
            get { return sn; }
            set { sn = value; }
        }
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
