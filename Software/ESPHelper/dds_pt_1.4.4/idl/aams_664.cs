using DDS;
using System.Runtime.InteropServices;

namespace datarouter
{
    #region AAMS_AFDX_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class AAMS_AFDX_msg
    {
        public uint id;
        public uint vl;
        public uint comPort;
        public uint net_flag;
        public uint src;
        public uint sec;
        public uint usec;
        public uint length;
        public datarouter.Payload[] packet_header = new datarouter.Payload[0];
        public datarouter.Payload[] packet_payload = new datarouter.Payload[0];
        public datarouter.Payload[] packet_crc = new datarouter.Payload[0];
    };
    #endregion

    #region AAMS_AFDX_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class AAMS_AFDX_Channel
    {
        public uint id;
        public datarouter.AAMS_AFDX_msg[] msgs = new datarouter.AAMS_AFDX_msg[0];
    };
    #endregion

}

