using DDS;
using DDS.OpenSplice.CustomMarshalers;
using System;
using System.Runtime.InteropServices;

namespace datarouter
{
    #region __AAMS_1394_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_1394_msg
    {
        public int id;
        public int channel;
        public int msgId;
        public int nodeId;
        public int healthStatus;
        public int healthBeat;
        public int vpcData;
        public char vpcError;
        public int headerCRC;
        public int dataCRC;
        public int payloadLen;
        public int src;
        public int sec;
        public int usec;
        public IntPtr payload;
    }
    #endregion

    #region AAMS_1394_msgMarshaler
    public sealed class AAMS_1394_msgMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_1394_msg);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_channel = (int)Marshal.OffsetOf(type, "channel");
        private static readonly int offset_msgId = (int)Marshal.OffsetOf(type, "msgId");
        private static readonly int offset_nodeId = (int)Marshal.OffsetOf(type, "nodeId");
        private static readonly int offset_healthStatus = (int)Marshal.OffsetOf(type, "healthStatus");
        private static readonly int offset_healthBeat = (int)Marshal.OffsetOf(type, "healthBeat");
        private static readonly int offset_vpcData = (int)Marshal.OffsetOf(type, "vpcData");
        private static readonly int offset_vpcError = (int)Marshal.OffsetOf(type, "vpcError");
        private static readonly int offset_headerCRC = (int)Marshal.OffsetOf(type, "headerCRC");
        private static readonly int offset_dataCRC = (int)Marshal.OffsetOf(type, "dataCRC");
        private static readonly int offset_payloadLen = (int)Marshal.OffsetOf(type, "payloadLen");
        private static readonly int offset_src = (int)Marshal.OffsetOf(type, "src");
        private static readonly int offset_sec = (int)Marshal.OffsetOf(type, "sec");
        private static readonly int offset_usec = (int)Marshal.OffsetOf(type, "usec");
        private static readonly int offset_payload = (int)Marshal.OffsetOf(type, "payload");

        private IntPtr attr14Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr14Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr14Marshaler == null) {
                attr14Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Payload));
                if (attr14Marshaler == null) {
                    attr14Marshaler = new datarouter.PayloadMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Payload), attr14Marshaler);
                    attr14Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_1394_msg[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_1394_msg from = untypedFrom as AAMS_1394_msg;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            Write(to, offset + offset_channel, from.channel);
            Write(to, offset + offset_msgId, from.msgId);
            Write(to, offset + offset_nodeId, from.nodeId);
            Write(to, offset + offset_healthStatus, from.healthStatus);
            Write(to, offset + offset_healthBeat, from.healthBeat);
            Write(to, offset + offset_vpcData, from.vpcData);
            Write(to, offset + offset_vpcError, from.vpcError);
            Write(to, offset + offset_headerCRC, from.headerCRC);
            Write(to, offset + offset_dataCRC, from.dataCRC);
            Write(to, offset + offset_payloadLen, from.payloadLen);
            Write(to, offset + offset_src, from.src);
            Write(to, offset + offset_sec, from.sec);
            Write(to, offset + offset_usec, from.usec);
            int attr14Cursor0 = offset + offset_payload;
            if (from.payload == null) return false;
            int attr14Seq0Length = from.payload.Length;
            // Unbounded sequence: bounds check not required...
            if (attr14Seq0Type == IntPtr.Zero) {
                attr14Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::C_SEQUENCE<datarouter::Payload>");
            }
            IntPtr attr14Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr14Seq0Type, attr14Seq0Length);
            Write(to, attr14Cursor0, attr14Seq0Buf);
            attr14Cursor0 += 4;
            int attr14Cursor1 = 0;
            for (int i0 = 0; i0 < attr14Seq0Length; i0++) {
                if (!attr14Marshaler.CopyIn(basePtr, from.payload[i0], attr14Seq0Buf, attr14Cursor1)) return false;
                attr14Cursor1 += 1;
            }
            return true;
        }

        public override void CopyOut(System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
            object toObj = tmpGCHandleTo.Target;
            CopyOut(from, ref toObj, 0);
            if (toObj != tmpGCHandleTo.Target) tmpGCHandleTo.Target = toObj;
        }

        public override void CopyOut(System.IntPtr from, ref object to, int offset)
        {
            AAMS_1394_msg dataTo = to as AAMS_1394_msg;
            if (dataTo == null) {
                dataTo = new AAMS_1394_msg();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            dataTo.channel = ReadUInt32(from, offset + offset_channel);
            dataTo.msgId = ReadUInt32(from, offset + offset_msgId);
            dataTo.nodeId = ReadUInt32(from, offset + offset_nodeId);
            dataTo.healthStatus = ReadUInt32(from, offset + offset_healthStatus);
            dataTo.healthBeat = ReadUInt32(from, offset + offset_healthBeat);
            dataTo.vpcData = ReadUInt32(from, offset + offset_vpcData);
            dataTo.vpcError = ReadBoolean(from, offset + offset_vpcError);
            dataTo.headerCRC = ReadUInt32(from, offset + offset_headerCRC);
            dataTo.dataCRC = ReadUInt32(from, offset + offset_dataCRC);
            dataTo.payloadLen = ReadUInt32(from, offset + offset_payloadLen);
            dataTo.src = ReadUInt32(from, offset + offset_src);
            dataTo.sec = ReadUInt32(from, offset + offset_sec);
            dataTo.usec = ReadUInt32(from, offset + offset_usec);
            int attr14Cursor0 = offset + offset_payload;
            IntPtr attr14Seq0Buf = ReadIntPtr(from, attr14Cursor0);
            int attr14Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr14Seq0Buf);
            if (dataTo.payload == null || dataTo.payload.Length != attr14Seq0Length) {
                datarouter.Payload[] target = new datarouter.Payload[attr14Seq0Length];
                initObjectSeq(dataTo.payload, target);
                dataTo.payload = target as datarouter.Payload[];
            }
            attr14Cursor0 += 4;
            int attr14Cursor1 = 0;
            for (int i0 = 0; i0 < attr14Seq0Length; i0++) {
                object elementObj = dataTo.payload[i0];
                attr14Marshaler.CopyOut(attr14Seq0Buf, ref elementObj, attr14Cursor1);
                if (dataTo.payload[i0] == null) {
                    dataTo.payload[i0] = elementObj as datarouter.Payload;
                }
                attr14Cursor1 += 1;
            }
        }

    }
    #endregion

    #region __AAMS_1394_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_1394_Channel
    {
        public int id;
        public IntPtr msgs;
    }
    #endregion

    #region AAMS_1394_ChannelMarshaler
    public sealed class AAMS_1394_ChannelMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_1394_Channel);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_msgs = (int)Marshal.OffsetOf(type, "msgs");

        private IntPtr attr1Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr1Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr1Marshaler == null) {
                attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.AAMS_1394_msg));
                if (attr1Marshaler == null) {
                    attr1Marshaler = new datarouter.AAMS_1394_msgMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.AAMS_1394_msg), attr1Marshaler);
                    attr1Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_1394_Channel[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_1394_Channel from = untypedFrom as AAMS_1394_Channel;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            int attr1Cursor0 = offset + offset_msgs;
            if (from.msgs == null) return false;
            int attr1Seq0Length = from.msgs.Length;
            // Unbounded sequence: bounds check not required...
            if (attr1Seq0Type == IntPtr.Zero) {
                attr1Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::AAMS_1394_Channel::C_SEQUENCE<datarouter::AAMS_1394_msg>");
            }
            IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Seq0Type, attr1Seq0Length);
            Write(to, attr1Cursor0, attr1Seq0Buf);
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                if (!attr1Marshaler.CopyIn(basePtr, from.msgs[i0], attr1Seq0Buf, attr1Cursor1)) return false;
                attr1Cursor1 += 60;
            }
            return true;
        }

        public override void CopyOut(System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandleTo = GCHandle.FromIntPtr(to);
            object toObj = tmpGCHandleTo.Target;
            CopyOut(from, ref toObj, 0);
            if (toObj != tmpGCHandleTo.Target) tmpGCHandleTo.Target = toObj;
        }

        public override void CopyOut(System.IntPtr from, ref object to, int offset)
        {
            AAMS_1394_Channel dataTo = to as AAMS_1394_Channel;
            if (dataTo == null) {
                dataTo = new AAMS_1394_Channel();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            int attr1Cursor0 = offset + offset_msgs;
            IntPtr attr1Seq0Buf = ReadIntPtr(from, attr1Cursor0);
            int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
            if (dataTo.msgs == null || dataTo.msgs.Length != attr1Seq0Length) {
                datarouter.AAMS_1394_msg[] target = new datarouter.AAMS_1394_msg[attr1Seq0Length];
                initObjectSeq(dataTo.msgs, target);
                dataTo.msgs = target as datarouter.AAMS_1394_msg[];
            }
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                object elementObj = dataTo.msgs[i0];
                attr1Marshaler.CopyOut(attr1Seq0Buf, ref elementObj, attr1Cursor1);
                if (dataTo.msgs[i0] == null) {
                    dataTo.msgs[i0] = elementObj as datarouter.AAMS_1394_msg;
                }
                attr1Cursor1 += 60;
            }
        }

    }
    #endregion

}

