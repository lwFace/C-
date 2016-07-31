using DDS;
using System.Runtime.InteropServices;
using com.hirain.avionics.dds;
using System;

namespace datarouter
{
    #region Payload
    [StructLayout(LayoutKind.Sequential)]
    public sealed class Payload
    {
        public byte _value;
    };
    #endregion

    #region DataType
    public enum DataType
    {
        F_SHORT,
        F_UNSIGNED_SHORT,
        F_LONG,
        F_UNSIGNED_LONG,
        F_LONG_LONG,
        F_UNSIGNED_LONG_LONG,
        F_FLOAT,
        F_DOUBLE,
        F_CHAR,
        F_BOOLEAN,
        F_STRING,
        F_RAWDATA
    };
    #endregion
    
#region Node
    [StructLayout(LayoutKind.Sequential)]
    public sealed class Node
    {
        public string name = string.Empty;
        public string _value = string.Empty;
        public datarouter.Node[] children = new datarouter.Node[0];
        public datarouter.Node[] attributes = new datarouter.Node[0];
    };
#endregion

#region EVENT_msg
[StructLayout(LayoutKind.Sequential)]
public sealed class EVENT_msg
{
    public uint event_id = 0;
    public uint time;
    public uint nodeId = 0;
    public string name = string.Empty;
    public string type = string.Empty;
    public datarouter.Node info = new datarouter.Node(); 
};
#endregion

#region CONTROL_msg
[StructLayout(LayoutKind.Sequential)]
public sealed class CONTROL_msg
{
    public uint hardware;
    public string cmd = string.Empty;
    public string[] information = new string[128];
    public byte[] payload = new byte[0];
};
#endregion

#region CONTROL_STATUS_msg
[StructLayout(LayoutKind.Sequential)]
public sealed class CONTROL_STATUS_msg
{
    public uint hardware;
    public string cmd = string.Empty;
    public string[] information = new string[128];
    public byte[] payload = new byte[0];
};
#endregion

#region AAMS_429_msg
[StructLayout(LayoutKind.Sequential)]
public sealed class AAMS_429_msg
{
    public uint id;
    public ushort label;
    public uint src;
    public uint reserved;
    public uint sec;
    public uint usec;
    public datarouter.Payload[] payload = new datarouter.Payload[0];
};
#endregion

#region AAMS_429_Channel
[StructLayout(LayoutKind.Sequential)]
public sealed class AAMS_429_Channel
{
    public uint id;
    public datarouter.AAMS_429_msg[] msgs = new datarouter.AAMS_429_msg[0];
};
#endregion

#region AAMS_NoBus_msg
[StructLayout(LayoutKind.Sequential)]
public sealed class AAMS_NoBus_msg
{
    public uint id;
    public uint src;
    public uint reserved;
    public uint sec;
    public uint usec;
    public datarouter.Payload[] payload = new datarouter.Payload[0];
};
#endregion

#region AAMS_NoBus_Channel
[StructLayout(LayoutKind.Sequential)]
public sealed class AAMS_NoBus_Channel
{
    public uint id;
    public datarouter.AAMS_NoBus_msg[] msgs = new datarouter.AAMS_NoBus_msg[0];
};
#endregion

#region DATA_STATUS
[StructLayout(LayoutKind.Sequential)]
public sealed class DATA_STATUS
{
    public ushort tf;
    public ushort dba;
    public ushort sf;
    public ushort busy;
    public ushort bcr;
    public ushort res;
    public ushort sr;
    public ushort inst;
    public ushort me;
    public ushort rtaddr;
};
#endregion

#region AAMS_1553_msg
[StructLayout(LayoutKind.Sequential)]
public sealed class AAMS_1553_msg
{
    public uint id;
    public uint mode;
    public uint src_addr;
    public uint sub_src_addr;
    public uint dst_addr;
    public uint sub_dst_addr;
    public datarouter.DATA_STATUS status1 = new datarouter.DATA_STATUS();
    public datarouter.DATA_STATUS status2 = new datarouter.DATA_STATUS();
    public uint src;
    public uint reserved;
    public uint sec;
    public uint usec;
    public uint length;
    public datarouter.Payload[] payload = new datarouter.Payload[0];
};
#endregion

#region AAMS_1553_Channel
[StructLayout(LayoutKind.Sequential)]
public sealed class AAMS_1553_Channel
{
    public uint id;
    public datarouter.AAMS_1553_msg[] msgs = new datarouter.AAMS_1553_msg[0];
};
#endregion

#region AAMS_422_msg
[StructLayout(LayoutKind.Sequential)]
public sealed class AAMS_422_msg
{
    public uint id;
    public datarouter.Payload[] frame_begin = new datarouter.Payload[0];
    public datarouter.Payload[] frame_end = new datarouter.Payload[0];
    public uint src;
    public uint reserved;
    public uint sec;
    public uint usec;
    public uint length;
    public datarouter.Payload[] payload = new datarouter.Payload[0];

    
};
#endregion

#region AAMS_422_Channel
[StructLayout(LayoutKind.Sequential)]
public sealed class AAMS_422_Channel
{
    public uint id;
    public datarouter.AAMS_422_msg[] msgs = new datarouter.AAMS_422_msg[0];
};
#endregion

#region AAMS_CAN_msg
[StructLayout(LayoutKind.Sequential)]
public sealed class AAMS_CAN_msg
{
    public uint id;
    public uint type;
    public uint can_id;
    public uint src;
    public uint reserved;
    public uint sec;
    public uint usec;
    public datarouter.Payload[] payload = new datarouter.Payload[0];
};
#endregion

#region AAMS_CAN_Channel
[StructLayout(LayoutKind.Sequential)]
public sealed class AAMS_CAN_Channel
{
    public uint id;
    public datarouter.AAMS_CAN_msg[] msgs = new datarouter.AAMS_CAN_msg[0];
};
#endregion

#region AAMS_RFM_msg
[StructLayout(LayoutKind.Sequential)]
public sealed class AAMS_RFM_msg
{
    public uint id;
    public uint src;
    public ulong addr;
    public uint sec;
    public uint usec;
    public uint length;
    public datarouter.Payload[] payload = new datarouter.Payload[0];
};
#endregion

#region AAMS_RFM_Channel
[StructLayout(LayoutKind.Sequential)]
public sealed class AAMS_RFM_Channel
{
    public uint id;
    public datarouter.AAMS_RFM_msg[] msgs = new datarouter.AAMS_RFM_msg[0];
};
#endregion

#region HDLC_PARA
[StructLayout(LayoutKind.Sequential)]
public sealed class HDLC_PARA
{
    public byte slave_addr;
    public byte type;
    public byte control_order;
};
#endregion

#region AAMS_HDLC_msg
[StructLayout(LayoutKind.Sequential)]
public sealed class AAMS_HDLC_msg
{
    public uint id;
    public uint src;
    public uint block_id;
    public uint offset;
    public uint reserved;
    public datarouter.HDLC_PARA parse = new datarouter.HDLC_PARA();
    public uint sec;
    public uint usec;
    public uint length;
    public datarouter.Payload[] payload = new datarouter.Payload[0];
};
#endregion

#region AAMS_HDLC_Channel
[StructLayout(LayoutKind.Sequential)]
public sealed class AAMS_HDLC_Channel
{
    public uint id;
    public datarouter.AAMS_HDLC_msg[] msgs = new datarouter.AAMS_HDLC_msg[0];
};
#endregion

#region Eth_PARA
[StructLayout(LayoutKind.Sequential)]
public sealed class Eth_PARA
{
    public byte[] src_mac = new byte[6];
    public byte[] dst_mac = new byte[6];
    public uint src_ip;
    public uint dst_ip;
    public ushort src_port;
    public ushort dst_port;
};
#endregion

#region AAMS_Eth_msg
[StructLayout(LayoutKind.Sequential)]
public sealed class AAMS_Eth_msg
{
    public uint id;
    public datarouter.Eth_PARA parameter = new datarouter.Eth_PARA();
    public uint sec;
    public uint usec;
    public uint length;
    public datarouter.Payload[] payload = new datarouter.Payload[0];
};
#endregion

#region AAMS_Eth_Channel
[StructLayout(LayoutKind.Sequential)]
public sealed class AAMS_Eth_Channel
{
    public uint id;
    public datarouter.AAMS_Eth_msg[] msgs = new datarouter.AAMS_Eth_msg[0];
};
#endregion

#region AAMS_IMBADB_msg
[StructLayout(LayoutKind.Sequential)]
public sealed class AAMS_IMBADB_msg
{
    public uint id;
    public uint src;
    public uint type;
    public uint label;
    public uint err;
    public uint crc;
    public uint sec;
    public uint usec;
    public datarouter.Payload[] payload = new datarouter.Payload[0];
};
#endregion

#region AAMS_IMBADB_Channel
[StructLayout(LayoutKind.Sequential)]
public sealed class AAMS_IMBADB_Channel
{
    public uint id;
    public datarouter.AAMS_IMBADB_msg[] msgs = new datarouter.AAMS_IMBADB_msg[0];
};
#endregion

}

