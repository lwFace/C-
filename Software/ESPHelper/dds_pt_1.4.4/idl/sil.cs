using DDS;
using System.Runtime.InteropServices;
using com.hirain.avionics.dds;

namespace datarouter
{
    #region SIL_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class SIL_msg
    {
        public uint id;
        public uint length;
        public datarouter.Payload[] payload = new datarouter.Payload[0];
        public datarouter.Payload[] payload_mask = new datarouter.Payload[0];
    };
    #endregion

    #region SIL_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class SIL_Channel
    {
        public uint id;
        public datarouter.SIL_msg[] msgs = new datarouter.SIL_msg[0];
    };
    #endregion

}

