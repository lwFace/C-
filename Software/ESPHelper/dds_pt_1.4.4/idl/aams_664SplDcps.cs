using DDS;
using DDS.OpenSplice.CustomMarshalers;
using System;
using System.Runtime.InteropServices;

namespace datarouter
{
    #region __AAMS_AFDX_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_AFDX_msg
    {
        public int id;
        public int vl;
        public int comPort;
        public int net_flag;
        public int src;
        public int sec;
        public int usec;
        public int length;
        public IntPtr packet_header;
        public IntPtr packet_payload;
        public IntPtr packet_crc;
    }
    #endregion

    #region AAMS_AFDX_msgMarshaler
    public sealed class AAMS_AFDX_msgMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_AFDX_msg);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_vl = (int)Marshal.OffsetOf(type, "vl");
        private static readonly int offset_comPort = (int)Marshal.OffsetOf(type, "comPort");
        private static readonly int offset_net_flag = (int)Marshal.OffsetOf(type, "net_flag");
        private static readonly int offset_src = (int)Marshal.OffsetOf(type, "src");
        private static readonly int offset_sec = (int)Marshal.OffsetOf(type, "sec");
        private static readonly int offset_usec = (int)Marshal.OffsetOf(type, "usec");
        private static readonly int offset_length = (int)Marshal.OffsetOf(type, "length");
        private static readonly int offset_packet_header = (int)Marshal.OffsetOf(type, "packet_header");
        private static readonly int offset_packet_payload = (int)Marshal.OffsetOf(type, "packet_payload");
        private static readonly int offset_packet_crc = (int)Marshal.OffsetOf(type, "packet_crc");

        private IntPtr attr8Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr8Marshaler;
        private IntPtr attr9Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr9Marshaler;
        private IntPtr attr10Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr10Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr8Marshaler == null) {
                attr8Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Payload));
                if (attr8Marshaler == null) {
                    attr8Marshaler = new datarouter.PayloadMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Payload), attr8Marshaler);
                    attr8Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
            if (attr9Marshaler == null) {
                attr9Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Payload));
                if (attr9Marshaler == null) {
                    attr9Marshaler = new datarouter.PayloadMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Payload), attr9Marshaler);
                    attr9Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
            if (attr10Marshaler == null) {
                attr10Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Payload));
                if (attr10Marshaler == null) {
                    attr10Marshaler = new datarouter.PayloadMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Payload), attr10Marshaler);
                    attr10Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_AFDX_msg[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_AFDX_msg from = untypedFrom as AAMS_AFDX_msg;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            Write(to, offset + offset_vl, from.vl);
            Write(to, offset + offset_comPort, from.comPort);
            Write(to, offset + offset_net_flag, from.net_flag);
            Write(to, offset + offset_src, from.src);
            Write(to, offset + offset_sec, from.sec);
            Write(to, offset + offset_usec, from.usec);
            Write(to, offset + offset_length, from.length);
            int attr8Cursor0 = offset + offset_packet_header;
            if (from.packet_header == null) return false;
            int attr8Seq0Length = from.packet_header.Length;
            // Unbounded sequence: bounds check not required...
            if (attr8Seq0Type == IntPtr.Zero) {
                attr8Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::C_SEQUENCE<datarouter::Payload>");
            }
            IntPtr attr8Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr8Seq0Type, attr8Seq0Length);
            Write(to, attr8Cursor0, attr8Seq0Buf);
            attr8Cursor0 += 4;
            int attr8Cursor1 = 0;
            for (int i0 = 0; i0 < attr8Seq0Length; i0++) {
                if (!attr8Marshaler.CopyIn(basePtr, from.packet_header[i0], attr8Seq0Buf, attr8Cursor1)) return false;
                attr8Cursor1 += 1;
            }
            int attr9Cursor0 = offset + offset_packet_payload;
            if (from.packet_payload == null) return false;
            int attr9Seq0Length = from.packet_payload.Length;
            // Unbounded sequence: bounds check not required...
            if (attr9Seq0Type == IntPtr.Zero) {
                attr9Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::C_SEQUENCE<datarouter::Payload>");
            }
            IntPtr attr9Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr9Seq0Type, attr9Seq0Length);
            Write(to, attr9Cursor0, attr9Seq0Buf);
            attr9Cursor0 += 4;
            int attr9Cursor1 = 0;
            for (int i0 = 0; i0 < attr9Seq0Length; i0++) {
                if (!attr9Marshaler.CopyIn(basePtr, from.packet_payload[i0], attr9Seq0Buf, attr9Cursor1)) return false;
                attr9Cursor1 += 1;
            }
            int attr10Cursor0 = offset + offset_packet_crc;
            if (from.packet_crc == null) return false;
            int attr10Seq0Length = from.packet_crc.Length;
            // Unbounded sequence: bounds check not required...
            if (attr10Seq0Type == IntPtr.Zero) {
                attr10Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::C_SEQUENCE<datarouter::Payload>");
            }
            IntPtr attr10Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr10Seq0Type, attr10Seq0Length);
            Write(to, attr10Cursor0, attr10Seq0Buf);
            attr10Cursor0 += 4;
            int attr10Cursor1 = 0;
            for (int i0 = 0; i0 < attr10Seq0Length; i0++) {
                if (!attr10Marshaler.CopyIn(basePtr, from.packet_crc[i0], attr10Seq0Buf, attr10Cursor1)) return false;
                attr10Cursor1 += 1;
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
            AAMS_AFDX_msg dataTo = to as AAMS_AFDX_msg;
            if (dataTo == null) {
                dataTo = new AAMS_AFDX_msg();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            dataTo.vl = ReadUInt32(from, offset + offset_vl);
            dataTo.comPort = ReadUInt32(from, offset + offset_comPort);
            dataTo.net_flag = ReadUInt32(from, offset + offset_net_flag);
            dataTo.src = ReadUInt32(from, offset + offset_src);
            dataTo.sec = ReadUInt32(from, offset + offset_sec);
            dataTo.usec = ReadUInt32(from, offset + offset_usec);
            dataTo.length = ReadUInt32(from, offset + offset_length);
            int attr8Cursor0 = offset + offset_packet_header;
            IntPtr attr8Seq0Buf = ReadIntPtr(from, attr8Cursor0);
            int attr8Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr8Seq0Buf);
            if (dataTo.packet_header == null || dataTo.packet_header.Length != attr8Seq0Length) {
                datarouter.Payload[] target = new datarouter.Payload[attr8Seq0Length];
                initObjectSeq(dataTo.packet_header, target);
                dataTo.packet_header = target as datarouter.Payload[];
            }
            attr8Cursor0 += 4;
            int attr8Cursor1 = 0;
            for (int i0 = 0; i0 < attr8Seq0Length; i0++) {
                object elementObj = dataTo.packet_header[i0];
                attr8Marshaler.CopyOut(attr8Seq0Buf, ref elementObj, attr8Cursor1);
                if (dataTo.packet_header[i0] == null) {
                    dataTo.packet_header[i0] = elementObj as datarouter.Payload;
                }
                attr8Cursor1 += 1;
            }
            int attr9Cursor0 = offset + offset_packet_payload;
            IntPtr attr9Seq0Buf = ReadIntPtr(from, attr9Cursor0);
            int attr9Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr9Seq0Buf);
            if (dataTo.packet_payload == null || dataTo.packet_payload.Length != attr9Seq0Length) {
                datarouter.Payload[] target = new datarouter.Payload[attr9Seq0Length];
                initObjectSeq(dataTo.packet_payload, target);
                dataTo.packet_payload = target as datarouter.Payload[];
            }
            attr9Cursor0 += 4;
            int attr9Cursor1 = 0;
            for (int i0 = 0; i0 < attr9Seq0Length; i0++) {
                object elementObj = dataTo.packet_payload[i0];
                attr9Marshaler.CopyOut(attr9Seq0Buf, ref elementObj, attr9Cursor1);
                if (dataTo.packet_payload[i0] == null) {
                    dataTo.packet_payload[i0] = elementObj as datarouter.Payload;
                }
                attr9Cursor1 += 1;
            }
            int attr10Cursor0 = offset + offset_packet_crc;
            IntPtr attr10Seq0Buf = ReadIntPtr(from, attr10Cursor0);
            int attr10Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr10Seq0Buf);
            if (dataTo.packet_crc == null || dataTo.packet_crc.Length != attr10Seq0Length) {
                datarouter.Payload[] target = new datarouter.Payload[attr10Seq0Length];
                initObjectSeq(dataTo.packet_crc, target);
                dataTo.packet_crc = target as datarouter.Payload[];
            }
            attr10Cursor0 += 4;
            int attr10Cursor1 = 0;
            for (int i0 = 0; i0 < attr10Seq0Length; i0++) {
                object elementObj = dataTo.packet_crc[i0];
                attr10Marshaler.CopyOut(attr10Seq0Buf, ref elementObj, attr10Cursor1);
                if (dataTo.packet_crc[i0] == null) {
                    dataTo.packet_crc[i0] = elementObj as datarouter.Payload;
                }
                attr10Cursor1 += 1;
            }
        }

    }
    #endregion

    #region __AAMS_AFDX_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_AFDX_Channel
    {
        public int id;
        public IntPtr msgs;
    }
    #endregion

    #region AAMS_AFDX_ChannelMarshaler
    public sealed class AAMS_AFDX_ChannelMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_AFDX_Channel);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_msgs = (int)Marshal.OffsetOf(type, "msgs");

        private IntPtr attr1Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr1Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr1Marshaler == null) {
                attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.AAMS_AFDX_msg));
                if (attr1Marshaler == null) {
                    attr1Marshaler = new datarouter.AAMS_AFDX_msgMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.AAMS_AFDX_msg), attr1Marshaler);
                    attr1Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_AFDX_Channel[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_AFDX_Channel from = untypedFrom as AAMS_AFDX_Channel;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            int attr1Cursor0 = offset + offset_msgs;
            if (from.msgs == null) return false;
            int attr1Seq0Length = from.msgs.Length;
            // Unbounded sequence: bounds check not required...
            if (attr1Seq0Type == IntPtr.Zero) {
                attr1Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::AAMS_AFDX_Channel::C_SEQUENCE<datarouter::AAMS_AFDX_msg>");
            }
            IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Seq0Type, attr1Seq0Length);
            Write(to, attr1Cursor0, attr1Seq0Buf);
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                if (!attr1Marshaler.CopyIn(basePtr, from.msgs[i0], attr1Seq0Buf, attr1Cursor1)) return false;
                attr1Cursor1 += 44;
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
            AAMS_AFDX_Channel dataTo = to as AAMS_AFDX_Channel;
            if (dataTo == null) {
                dataTo = new AAMS_AFDX_Channel();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            int attr1Cursor0 = offset + offset_msgs;
            IntPtr attr1Seq0Buf = ReadIntPtr(from, attr1Cursor0);
            int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
            if (dataTo.msgs == null || dataTo.msgs.Length != attr1Seq0Length) {
                datarouter.AAMS_AFDX_msg[] target = new datarouter.AAMS_AFDX_msg[attr1Seq0Length];
                initObjectSeq(dataTo.msgs, target);
                dataTo.msgs = target as datarouter.AAMS_AFDX_msg[];
            }
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                object elementObj = dataTo.msgs[i0];
                attr1Marshaler.CopyOut(attr1Seq0Buf, ref elementObj, attr1Cursor1);
                if (dataTo.msgs[i0] == null) {
                    dataTo.msgs[i0] = elementObj as datarouter.AAMS_AFDX_msg;
                }
                attr1Cursor1 += 44;
            }
        }

    }
    #endregion

}

