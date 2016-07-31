using DDS;
using DDS.OpenSplice.CustomMarshalers;
using System;
using System.Runtime.InteropServices;

namespace datarouter
{
    #region __SIL_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __SIL_msg
    {
        public int id;
        public int length;
        public IntPtr payload;
        public IntPtr payload_mask;
    }
    #endregion

    #region SIL_msgMarshaler
    public sealed class SIL_msgMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__SIL_msg);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_length = (int)Marshal.OffsetOf(type, "length");
        private static readonly int offset_payload = (int)Marshal.OffsetOf(type, "payload");
        private static readonly int offset_payload_mask = (int)Marshal.OffsetOf(type, "payload_mask");

        private IntPtr attr2Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr2Marshaler;
        private IntPtr attr3Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr3Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr2Marshaler == null) {
                attr2Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Payload));
                if (attr2Marshaler == null) {
                    attr2Marshaler = new datarouter.PayloadMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Payload), attr2Marshaler);
                    attr2Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
            if (attr3Marshaler == null) {
                attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Payload));
                if (attr3Marshaler == null) {
                    attr3Marshaler = new datarouter.PayloadMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Payload), attr3Marshaler);
                    attr3Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new SIL_msg[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            SIL_msg from = untypedFrom as SIL_msg;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            Write(to, offset + offset_length, from.length);
            int attr2Cursor0 = offset + offset_payload;
            if (from.payload == null) return false;
            int attr2Seq0Length = from.payload.Length;
            // Unbounded sequence: bounds check not required...
            if (attr2Seq0Type == IntPtr.Zero) {
                attr2Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::C_SEQUENCE<datarouter::Payload>");
            }
            IntPtr attr2Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr2Seq0Type, attr2Seq0Length);
            Write(to, attr2Cursor0, attr2Seq0Buf);
            attr2Cursor0 += 4;
            int attr2Cursor1 = 0;
            for (int i0 = 0; i0 < attr2Seq0Length; i0++) {
                if (!attr2Marshaler.CopyIn(basePtr, from.payload[i0], attr2Seq0Buf, attr2Cursor1)) return false;
                attr2Cursor1 += 1;
            }
            int attr3Cursor0 = offset + offset_payload_mask;
            if (from.payload_mask == null) return false;
            int attr3Seq0Length = from.payload_mask.Length;
            // Unbounded sequence: bounds check not required...
            if (attr3Seq0Type == IntPtr.Zero) {
                attr3Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::C_SEQUENCE<datarouter::Payload>");
            }
            IntPtr attr3Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr3Seq0Type, attr3Seq0Length);
            Write(to, attr3Cursor0, attr3Seq0Buf);
            attr3Cursor0 += 4;
            int attr3Cursor1 = 0;
            for (int i0 = 0; i0 < attr3Seq0Length; i0++) {
                if (!attr3Marshaler.CopyIn(basePtr, from.payload_mask[i0], attr3Seq0Buf, attr3Cursor1)) return false;
                attr3Cursor1 += 1;
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
            SIL_msg dataTo = to as SIL_msg;
            if (dataTo == null) {
                dataTo = new SIL_msg();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            dataTo.length = ReadUInt32(from, offset + offset_length);
            int attr2Cursor0 = offset + offset_payload;
            IntPtr attr2Seq0Buf = ReadIntPtr(from, attr2Cursor0);
            int attr2Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr2Seq0Buf);
            if (dataTo.payload == null || dataTo.payload.Length != attr2Seq0Length) {
                datarouter.Payload[] target = new datarouter.Payload[attr2Seq0Length];
                initObjectSeq(dataTo.payload, target);
                dataTo.payload = target as datarouter.Payload[];
            }
            attr2Cursor0 += 4;
            int attr2Cursor1 = 0;
            for (int i0 = 0; i0 < attr2Seq0Length; i0++) {
                object elementObj = dataTo.payload[i0];
                attr2Marshaler.CopyOut(attr2Seq0Buf, ref elementObj, attr2Cursor1);
                if (dataTo.payload[i0] == null) {
                    dataTo.payload[i0] = elementObj as datarouter.Payload;
                }
                attr2Cursor1 += 1;
            }
            int attr3Cursor0 = offset + offset_payload_mask;
            IntPtr attr3Seq0Buf = ReadIntPtr(from, attr3Cursor0);
            int attr3Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr3Seq0Buf);
            if (dataTo.payload_mask == null || dataTo.payload_mask.Length != attr3Seq0Length) {
                datarouter.Payload[] target = new datarouter.Payload[attr3Seq0Length];
                initObjectSeq(dataTo.payload_mask, target);
                dataTo.payload_mask = target as datarouter.Payload[];
            }
            attr3Cursor0 += 4;
            int attr3Cursor1 = 0;
            for (int i0 = 0; i0 < attr3Seq0Length; i0++) {
                object elementObj = dataTo.payload_mask[i0];
                attr3Marshaler.CopyOut(attr3Seq0Buf, ref elementObj, attr3Cursor1);
                if (dataTo.payload_mask[i0] == null) {
                    dataTo.payload_mask[i0] = elementObj as datarouter.Payload;
                }
                attr3Cursor1 += 1;
            }
        }

    }
    #endregion

    #region __SIL_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __SIL_Channel
    {
        public int id;
        public IntPtr msgs;
    }
    #endregion

    #region SIL_ChannelMarshaler
    public sealed class SIL_ChannelMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__SIL_Channel);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_msgs = (int)Marshal.OffsetOf(type, "msgs");

        private IntPtr attr1Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr1Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr1Marshaler == null) {
                attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.SIL_msg));
                if (attr1Marshaler == null) {
                    attr1Marshaler = new datarouter.SIL_msgMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.SIL_msg), attr1Marshaler);
                    attr1Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new SIL_Channel[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            SIL_Channel from = untypedFrom as SIL_Channel;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            int attr1Cursor0 = offset + offset_msgs;
            if (from.msgs == null) return false;
            int attr1Seq0Length = from.msgs.Length;
            // Unbounded sequence: bounds check not required...
            if (attr1Seq0Type == IntPtr.Zero) {
                attr1Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::SIL_Channel::C_SEQUENCE<datarouter::SIL_msg>");
            }
            IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Seq0Type, attr1Seq0Length);
            Write(to, attr1Cursor0, attr1Seq0Buf);
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                if (!attr1Marshaler.CopyIn(basePtr, from.msgs[i0], attr1Seq0Buf, attr1Cursor1)) return false;
                attr1Cursor1 += 16;
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
            SIL_Channel dataTo = to as SIL_Channel;
            if (dataTo == null) {
                dataTo = new SIL_Channel();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            int attr1Cursor0 = offset + offset_msgs;
            IntPtr attr1Seq0Buf = ReadIntPtr(from, attr1Cursor0);
            int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
            if (dataTo.msgs == null || dataTo.msgs.Length != attr1Seq0Length) {
                datarouter.SIL_msg[] target = new datarouter.SIL_msg[attr1Seq0Length];
                initObjectSeq(dataTo.msgs, target);
                dataTo.msgs = target as datarouter.SIL_msg[];
            }
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                object elementObj = dataTo.msgs[i0];
                attr1Marshaler.CopyOut(attr1Seq0Buf, ref elementObj, attr1Cursor1);
                if (dataTo.msgs[i0] == null) {
                    dataTo.msgs[i0] = elementObj as datarouter.SIL_msg;
                }
                attr1Cursor1 += 16;
            }
        }

    }
    #endregion

}

