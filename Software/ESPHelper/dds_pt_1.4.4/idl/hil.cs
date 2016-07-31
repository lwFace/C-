using DDS;
using System.Runtime.InteropServices;

namespace datarouter
{
    #region HIL_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class HIL_msg
    {
        public uint id;
        public uint length;
        public datarouter.Payload[] payload = new datarouter.Payload[0];
        public datarouter.Payload[] payload_mask = new datarouter.Payload[0];
    };
    #endregion

    #region HIL_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class HIL_Channel
    {
        public uint id;
        public datarouter.HIL_msg[] msgs = new datarouter.HIL_msg[0];
    };
    #endregion

}

