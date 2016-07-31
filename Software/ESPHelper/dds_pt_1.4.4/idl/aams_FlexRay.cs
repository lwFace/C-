using DDS;
using System.Runtime.InteropServices;

namespace datarouter
{
    #region AAMS_FlexRay_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class AAMS_FlexRay_msg
    {
        public uint id;
        public uint PPI;
        public uint NUF;
        public uint SYF;
        public uint SUF;
        public uint frameId;
        public uint cyccnt;
        public uint payloadLength;
        public uint headerCRC;
        public uint chAorBrecv;
        public uint syntaxError;
        public uint contentError;
        public uint violationError;
        public uint chipReadError;
        public uint sec;
        public uint usec;
        public uint nanos;
        public datarouter.Payload[] payload = new datarouter.Payload[0];
    };
    #endregion

    #region AAMS_FlexRay_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class AAMS_FlexRay_Channel
    {
        public uint id;
        public datarouter.AAMS_FlexRay_msg[] msgs = new datarouter.AAMS_FlexRay_msg[0];
    };
    #endregion

}

