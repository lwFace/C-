using DDS;
using System.Runtime.InteropServices;

namespace datarouter
{
    #region AAMS_1394_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class AAMS_1394_msg
    {
        public uint id;
        public uint channel;
        public uint msgId;
        public uint nodeId;
        public uint healthStatus;
        public uint healthBeat;
        public uint vpcData;
        public bool vpcError;
        public uint headerCRC;
        public uint dataCRC;
        public uint payloadLen;
        public uint src;
        public uint sec;
        public uint usec;
        public datarouter.Payload[] payload = new datarouter.Payload[0];
    };
    #endregion

    #region AAMS_1394_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class AAMS_1394_Channel
    {
        public uint id;
        public datarouter.AAMS_1394_msg[] msgs = new datarouter.AAMS_1394_msg[0];
    };
    #endregion

}

