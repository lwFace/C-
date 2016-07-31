using DDS;
using System.Runtime.InteropServices;

namespace datarouter
{
    #region AAMS_FC_AE_ASM_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class AAMS_FC_AE_ASM_msg
    {
        public uint id;
        public uint msgId;
        public uint vendorSpecificSecurity;
        public uint reserved;
        public uint priority;
        public uint msgLength;
        public uint lByte;
        public uint sec;
        public uint usec;
        public datarouter.Payload[] payload = new datarouter.Payload[0];
    };
    #endregion

    #region AAMS_FC_AE_ASM_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class AAMS_FC_AE_ASM_Channel
    {
        public uint id;
        public datarouter.AAMS_FC_AE_ASM_msg[] msgs = new datarouter.AAMS_FC_AE_ASM_msg[0];
    };
    #endregion

}

