using DDS;
using DDS.OpenSplice.CustomMarshalers;
using System;
using System.Runtime.InteropServices;

namespace datarouter
{
    #region __AAMS_FC_AE_ASM_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_FC_AE_ASM_msg
    {
        public int id;
        public int msgId;
        public int vendorSpecificSecurity;
        public int reserved;
        public int priority;
        public int msgLength;
        public int lByte;
        public int sec;
        public int usec;
        public IntPtr payload;
    }
    #endregion

    #region AAMS_FC_AE_ASM_msgMarshaler
    public sealed class AAMS_FC_AE_ASM_msgMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_FC_AE_ASM_msg);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_msgId = (int)Marshal.OffsetOf(type, "msgId");
        private static readonly int offset_vendorSpecificSecurity = (int)Marshal.OffsetOf(type, "vendorSpecificSecurity");
        private static readonly int offset_reserved = (int)Marshal.OffsetOf(type, "reserved");
        private static readonly int offset_priority = (int)Marshal.OffsetOf(type, "priority");
        private static readonly int offset_msgLength = (int)Marshal.OffsetOf(type, "msgLength");
        private static readonly int offset_lByte = (int)Marshal.OffsetOf(type, "lByte");
        private static readonly int offset_sec = (int)Marshal.OffsetOf(type, "sec");
        private static readonly int offset_usec = (int)Marshal.OffsetOf(type, "usec");
        private static readonly int offset_payload = (int)Marshal.OffsetOf(type, "payload");

        private IntPtr attr9Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr9Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr9Marshaler == null) {
                attr9Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Payload));
                if (attr9Marshaler == null) {
                    attr9Marshaler = new datarouter.PayloadMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Payload), attr9Marshaler);
                    attr9Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_FC_AE_ASM_msg[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_FC_AE_ASM_msg from = untypedFrom as AAMS_FC_AE_ASM_msg;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            Write(to, offset + offset_msgId, from.msgId);
            Write(to, offset + offset_vendorSpecificSecurity, from.vendorSpecificSecurity);
            Write(to, offset + offset_reserved, from.reserved);
            Write(to, offset + offset_priority, from.priority);
            Write(to, offset + offset_msgLength, from.msgLength);
            Write(to, offset + offset_lByte, from.lByte);
            Write(to, offset + offset_sec, from.sec);
            Write(to, offset + offset_usec, from.usec);
            int attr9Cursor0 = offset + offset_payload;
            if (from.payload == null) return false;
            int attr9Seq0Length = from.payload.Length;
            // Unbounded sequence: bounds check not required...
            if (attr9Seq0Type == IntPtr.Zero) {
                attr9Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::C_SEQUENCE<datarouter::Payload>");
            }
            IntPtr attr9Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr9Seq0Type, attr9Seq0Length);
            Write(to, attr9Cursor0, attr9Seq0Buf);
            attr9Cursor0 += 4;
            int attr9Cursor1 = 0;
            for (int i0 = 0; i0 < attr9Seq0Length; i0++) {
                if (!attr9Marshaler.CopyIn(basePtr, from.payload[i0], attr9Seq0Buf, attr9Cursor1)) return false;
                attr9Cursor1 += 1;
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
            AAMS_FC_AE_ASM_msg dataTo = to as AAMS_FC_AE_ASM_msg;
            if (dataTo == null) {
                dataTo = new AAMS_FC_AE_ASM_msg();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            dataTo.msgId = ReadUInt32(from, offset + offset_msgId);
            dataTo.vendorSpecificSecurity = ReadUInt32(from, offset + offset_vendorSpecificSecurity);
            dataTo.reserved = ReadUInt32(from, offset + offset_reserved);
            dataTo.priority = ReadUInt32(from, offset + offset_priority);
            dataTo.msgLength = ReadUInt32(from, offset + offset_msgLength);
            dataTo.lByte = ReadUInt32(from, offset + offset_lByte);
            dataTo.sec = ReadUInt32(from, offset + offset_sec);
            dataTo.usec = ReadUInt32(from, offset + offset_usec);
            int attr9Cursor0 = offset + offset_payload;
            IntPtr attr9Seq0Buf = ReadIntPtr(from, attr9Cursor0);
            int attr9Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr9Seq0Buf);
            if (dataTo.payload == null || dataTo.payload.Length != attr9Seq0Length) {
                datarouter.Payload[] target = new datarouter.Payload[attr9Seq0Length];
                initObjectSeq(dataTo.payload, target);
                dataTo.payload = target as datarouter.Payload[];
            }
            attr9Cursor0 += 4;
            int attr9Cursor1 = 0;
            for (int i0 = 0; i0 < attr9Seq0Length; i0++) {
                object elementObj = dataTo.payload[i0];
                attr9Marshaler.CopyOut(attr9Seq0Buf, ref elementObj, attr9Cursor1);
                if (dataTo.payload[i0] == null) {
                    dataTo.payload[i0] = elementObj as datarouter.Payload;
                }
                attr9Cursor1 += 1;
            }
        }

    }
    #endregion

    #region __AAMS_FC_AE_ASM_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_FC_AE_ASM_Channel
    {
        public int id;
        public IntPtr msgs;
    }
    #endregion

    #region AAMS_FC_AE_ASM_ChannelMarshaler
    public sealed class AAMS_FC_AE_ASM_ChannelMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_FC_AE_ASM_Channel);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_msgs = (int)Marshal.OffsetOf(type, "msgs");

        private IntPtr attr1Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr1Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr1Marshaler == null) {
                attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.AAMS_FC_AE_ASM_msg));
                if (attr1Marshaler == null) {
                    attr1Marshaler = new datarouter.AAMS_FC_AE_ASM_msgMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.AAMS_FC_AE_ASM_msg), attr1Marshaler);
                    attr1Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_FC_AE_ASM_Channel[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_FC_AE_ASM_Channel from = untypedFrom as AAMS_FC_AE_ASM_Channel;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            int attr1Cursor0 = offset + offset_msgs;
            if (from.msgs == null) return false;
            int attr1Seq0Length = from.msgs.Length;
            // Unbounded sequence: bounds check not required...
            if (attr1Seq0Type == IntPtr.Zero) {
                attr1Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::AAMS_FC_AE_ASM_Channel::C_SEQUENCE<datarouter::AAMS_FC_AE_ASM_msg>");
            }
            IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Seq0Type, attr1Seq0Length);
            Write(to, attr1Cursor0, attr1Seq0Buf);
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                if (!attr1Marshaler.CopyIn(basePtr, from.msgs[i0], attr1Seq0Buf, attr1Cursor1)) return false;
                attr1Cursor1 += 40;
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
            AAMS_FC_AE_ASM_Channel dataTo = to as AAMS_FC_AE_ASM_Channel;
            if (dataTo == null) {
                dataTo = new AAMS_FC_AE_ASM_Channel();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            int attr1Cursor0 = offset + offset_msgs;
            IntPtr attr1Seq0Buf = ReadIntPtr(from, attr1Cursor0);
            int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
            if (dataTo.msgs == null || dataTo.msgs.Length != attr1Seq0Length) {
                datarouter.AAMS_FC_AE_ASM_msg[] target = new datarouter.AAMS_FC_AE_ASM_msg[attr1Seq0Length];
                initObjectSeq(dataTo.msgs, target);
                dataTo.msgs = target as datarouter.AAMS_FC_AE_ASM_msg[];
            }
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                object elementObj = dataTo.msgs[i0];
                attr1Marshaler.CopyOut(attr1Seq0Buf, ref elementObj, attr1Cursor1);
                if (dataTo.msgs[i0] == null) {
                    dataTo.msgs[i0] = elementObj as datarouter.AAMS_FC_AE_ASM_msg;
                }
                attr1Cursor1 += 40;
            }
        }

    }
    #endregion

}

