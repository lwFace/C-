using DDS;
using DDS.OpenSplice.CustomMarshalers;
using System;
using System.Runtime.InteropServices;

namespace datarouter
{
    #region __AAMS_FlexRay_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_FlexRay_msg
    {
        public int id;
        public int PPI;
        public int NUF;
        public int SYF;
        public int SUF;
        public int frameId;
        public int cyccnt;
        public int payloadLength;
        public int headerCRC;
        public int chAorBrecv;
        public int syntaxError;
        public int contentError;
        public int violationError;
        public int chipReadError;
        public int sec;
        public int usec;
        public int nanos;
        public IntPtr payload;
    }
    #endregion

    #region AAMS_FlexRay_msgMarshaler
    public sealed class AAMS_FlexRay_msgMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_FlexRay_msg);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_PPI = (int)Marshal.OffsetOf(type, "PPI");
        private static readonly int offset_NUF = (int)Marshal.OffsetOf(type, "NUF");
        private static readonly int offset_SYF = (int)Marshal.OffsetOf(type, "SYF");
        private static readonly int offset_SUF = (int)Marshal.OffsetOf(type, "SUF");
        private static readonly int offset_frameId = (int)Marshal.OffsetOf(type, "frameId");
        private static readonly int offset_cyccnt = (int)Marshal.OffsetOf(type, "cyccnt");
        private static readonly int offset_payloadLength = (int)Marshal.OffsetOf(type, "payloadLength");
        private static readonly int offset_headerCRC = (int)Marshal.OffsetOf(type, "headerCRC");
        private static readonly int offset_chAorBrecv = (int)Marshal.OffsetOf(type, "chAorBrecv");
        private static readonly int offset_syntaxError = (int)Marshal.OffsetOf(type, "syntaxError");
        private static readonly int offset_contentError = (int)Marshal.OffsetOf(type, "contentError");
        private static readonly int offset_violationError = (int)Marshal.OffsetOf(type, "violationError");
        private static readonly int offset_chipReadError = (int)Marshal.OffsetOf(type, "chipReadError");
        private static readonly int offset_sec = (int)Marshal.OffsetOf(type, "sec");
        private static readonly int offset_usec = (int)Marshal.OffsetOf(type, "usec");
        private static readonly int offset_nanos = (int)Marshal.OffsetOf(type, "nanos");
        private static readonly int offset_payload = (int)Marshal.OffsetOf(type, "payload");

        private IntPtr attr17Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr17Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr17Marshaler == null) {
                attr17Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Payload));
                if (attr17Marshaler == null) {
                    attr17Marshaler = new datarouter.PayloadMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Payload), attr17Marshaler);
                    attr17Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_FlexRay_msg[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_FlexRay_msg from = untypedFrom as AAMS_FlexRay_msg;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            Write(to, offset + offset_PPI, from.PPI);
            Write(to, offset + offset_NUF, from.NUF);
            Write(to, offset + offset_SYF, from.SYF);
            Write(to, offset + offset_SUF, from.SUF);
            Write(to, offset + offset_frameId, from.frameId);
            Write(to, offset + offset_cyccnt, from.cyccnt);
            Write(to, offset + offset_payloadLength, from.payloadLength);
            Write(to, offset + offset_headerCRC, from.headerCRC);
            Write(to, offset + offset_chAorBrecv, from.chAorBrecv);
            Write(to, offset + offset_syntaxError, from.syntaxError);
            Write(to, offset + offset_contentError, from.contentError);
            Write(to, offset + offset_violationError, from.violationError);
            Write(to, offset + offset_chipReadError, from.chipReadError);
            Write(to, offset + offset_sec, from.sec);
            Write(to, offset + offset_usec, from.usec);
            Write(to, offset + offset_nanos, from.nanos);
            int attr17Cursor0 = offset + offset_payload;
            if (from.payload == null) return false;
            int attr17Seq0Length = from.payload.Length;
            // Unbounded sequence: bounds check not required...
            if (attr17Seq0Type == IntPtr.Zero) {
                attr17Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::C_SEQUENCE<datarouter::Payload>");
            }
            IntPtr attr17Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr17Seq0Type, attr17Seq0Length);
            Write(to, attr17Cursor0, attr17Seq0Buf);
            attr17Cursor0 += 4;
            int attr17Cursor1 = 0;
            for (int i0 = 0; i0 < attr17Seq0Length; i0++) {
                if (!attr17Marshaler.CopyIn(basePtr, from.payload[i0], attr17Seq0Buf, attr17Cursor1)) return false;
                attr17Cursor1 += 1;
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
            AAMS_FlexRay_msg dataTo = to as AAMS_FlexRay_msg;
            if (dataTo == null) {
                dataTo = new AAMS_FlexRay_msg();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            dataTo.PPI = ReadUInt32(from, offset + offset_PPI);
            dataTo.NUF = ReadUInt32(from, offset + offset_NUF);
            dataTo.SYF = ReadUInt32(from, offset + offset_SYF);
            dataTo.SUF = ReadUInt32(from, offset + offset_SUF);
            dataTo.frameId = ReadUInt32(from, offset + offset_frameId);
            dataTo.cyccnt = ReadUInt32(from, offset + offset_cyccnt);
            dataTo.payloadLength = ReadUInt32(from, offset + offset_payloadLength);
            dataTo.headerCRC = ReadUInt32(from, offset + offset_headerCRC);
            dataTo.chAorBrecv = ReadUInt32(from, offset + offset_chAorBrecv);
            dataTo.syntaxError = ReadUInt32(from, offset + offset_syntaxError);
            dataTo.contentError = ReadUInt32(from, offset + offset_contentError);
            dataTo.violationError = ReadUInt32(from, offset + offset_violationError);
            dataTo.chipReadError = ReadUInt32(from, offset + offset_chipReadError);
            dataTo.sec = ReadUInt32(from, offset + offset_sec);
            dataTo.usec = ReadUInt32(from, offset + offset_usec);
            dataTo.nanos = ReadUInt32(from, offset + offset_nanos);
            int attr17Cursor0 = offset + offset_payload;
            IntPtr attr17Seq0Buf = ReadIntPtr(from, attr17Cursor0);
            int attr17Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr17Seq0Buf);
            if (dataTo.payload == null || dataTo.payload.Length != attr17Seq0Length) {
                datarouter.Payload[] target = new datarouter.Payload[attr17Seq0Length];
                initObjectSeq(dataTo.payload, target);
                dataTo.payload = target as datarouter.Payload[];
            }
            attr17Cursor0 += 4;
            int attr17Cursor1 = 0;
            for (int i0 = 0; i0 < attr17Seq0Length; i0++) {
                object elementObj = dataTo.payload[i0];
                attr17Marshaler.CopyOut(attr17Seq0Buf, ref elementObj, attr17Cursor1);
                if (dataTo.payload[i0] == null) {
                    dataTo.payload[i0] = elementObj as datarouter.Payload;
                }
                attr17Cursor1 += 1;
            }
        }

    }
    #endregion

    #region __AAMS_FlexRay_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_FlexRay_Channel
    {
        public int id;
        public IntPtr msgs;
    }
    #endregion

    #region AAMS_FlexRay_ChannelMarshaler
    public sealed class AAMS_FlexRay_ChannelMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_FlexRay_Channel);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_msgs = (int)Marshal.OffsetOf(type, "msgs");

        private IntPtr attr1Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr1Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr1Marshaler == null) {
                attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.AAMS_FlexRay_msg));
                if (attr1Marshaler == null) {
                    attr1Marshaler = new datarouter.AAMS_FlexRay_msgMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.AAMS_FlexRay_msg), attr1Marshaler);
                    attr1Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_FlexRay_Channel[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_FlexRay_Channel from = untypedFrom as AAMS_FlexRay_Channel;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            int attr1Cursor0 = offset + offset_msgs;
            if (from.msgs == null) return false;
            int attr1Seq0Length = from.msgs.Length;
            // Unbounded sequence: bounds check not required...
            if (attr1Seq0Type == IntPtr.Zero) {
                attr1Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::AAMS_FlexRay_Channel::C_SEQUENCE<datarouter::AAMS_FlexRay_msg>");
            }
            IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Seq0Type, attr1Seq0Length);
            Write(to, attr1Cursor0, attr1Seq0Buf);
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                if (!attr1Marshaler.CopyIn(basePtr, from.msgs[i0], attr1Seq0Buf, attr1Cursor1)) return false;
                attr1Cursor1 += 72;
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
            AAMS_FlexRay_Channel dataTo = to as AAMS_FlexRay_Channel;
            if (dataTo == null) {
                dataTo = new AAMS_FlexRay_Channel();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            int attr1Cursor0 = offset + offset_msgs;
            IntPtr attr1Seq0Buf = ReadIntPtr(from, attr1Cursor0);
            int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
            if (dataTo.msgs == null || dataTo.msgs.Length != attr1Seq0Length) {
                datarouter.AAMS_FlexRay_msg[] target = new datarouter.AAMS_FlexRay_msg[attr1Seq0Length];
                initObjectSeq(dataTo.msgs, target);
                dataTo.msgs = target as datarouter.AAMS_FlexRay_msg[];
            }
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                object elementObj = dataTo.msgs[i0];
                attr1Marshaler.CopyOut(attr1Seq0Buf, ref elementObj, attr1Cursor1);
                if (dataTo.msgs[i0] == null) {
                    dataTo.msgs[i0] = elementObj as datarouter.AAMS_FlexRay_msg;
                }
                attr1Cursor1 += 72;
            }
        }

    }
    #endregion

}

