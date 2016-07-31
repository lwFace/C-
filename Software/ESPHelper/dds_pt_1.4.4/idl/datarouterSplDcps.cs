using DDS;
using DDS.OpenSplice.CustomMarshalers;
using System;
using System.Runtime.InteropServices;

namespace datarouter
{
    #region __Payload
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __Payload
    {
        public char _value;
    }
    #endregion

    #region PayloadMarshaler
    public sealed class PayloadMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__Payload);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset__value = (int)Marshal.OffsetOf(type, "_value");


        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new Payload[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            Payload from = untypedFrom as Payload;
            if (from == null) return false;
            Write(to, offset + offset__value, from._value);
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
            Payload dataTo = to as Payload;
            if (dataTo == null) {
                dataTo = new Payload();
                to = dataTo;
            }
            dataTo._value = ReadByte(from, offset + offset__value);
        }

    }
    #endregion


    #region __Node
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __Node
    {
        public IntPtr name;
        public IntPtr _value;
        public IntPtr children;
        public IntPtr attributes;
    }
    #endregion

    #region NodeMarshaler
    public sealed class NodeMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__Node);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_name = (int)Marshal.OffsetOf(type, "name");
        private static readonly int offset__value = (int)Marshal.OffsetOf(type, "_value");
        private static readonly int offset_children = (int)Marshal.OffsetOf(type, "children");
        private static readonly int offset_attributes = (int)Marshal.OffsetOf(type, "attributes");

        private IntPtr attr2Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr2Marshaler;
        private IntPtr attr3Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr3Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr2Marshaler == null) {
                attr2Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Node));
                if (attr2Marshaler == null) {
                    attr2Marshaler = new datarouter.NodeMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Node), attr2Marshaler);
                    attr2Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
            if (attr3Marshaler == null) {
                attr3Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Node));
                if (attr3Marshaler == null) {
                    attr3Marshaler = new datarouter.NodeMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Node), attr3Marshaler);
                    attr3Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new Node[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            Node from = untypedFrom as Node;
            if (from == null) return false;
            if (from.name == null) return false;
            // Unbounded string: bounds check not required...
            Write(basePtr, to, offset + offset_name, ref from.name);
            if (from._value == null) return false;
            // Unbounded string: bounds check not required...
            Write(basePtr, to, offset + offset__value, ref from._value);
            int attr2Cursor0 = offset + offset_children;
            if (from.children == null) return false;
            int attr2Seq0Length = from.children.Length;
            // Unbounded sequence: bounds check not required...
            if (attr2Seq0Type == IntPtr.Zero) {
                attr2Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::Node::C_SEQUENCE<datarouter::Node>");
            }
            IntPtr attr2Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr2Seq0Type, attr2Seq0Length);
            Write(to, attr2Cursor0, attr2Seq0Buf);
            attr2Cursor0 += 4;
            int attr2Cursor1 = 0;
            for (int i0 = 0; i0 < attr2Seq0Length; i0++) {
                if (!attr2Marshaler.CopyIn(basePtr, from.children[i0], attr2Seq0Buf, attr2Cursor1)) return false;
                attr2Cursor1 += 16;
            }
            int attr3Cursor0 = offset + offset_attributes;
            if (from.attributes == null) return false;
            int attr3Seq0Length = from.attributes.Length;
            // Unbounded sequence: bounds check not required...
            if (attr3Seq0Type == IntPtr.Zero) {
                attr3Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::Node::C_SEQUENCE<datarouter::Node>");
            }
            IntPtr attr3Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr3Seq0Type, attr3Seq0Length);
            Write(to, attr3Cursor0, attr3Seq0Buf);
            attr3Cursor0 += 4;
            int attr3Cursor1 = 0;
            for (int i0 = 0; i0 < attr3Seq0Length; i0++) {
                if (!attr3Marshaler.CopyIn(basePtr, from.attributes[i0], attr3Seq0Buf, attr3Cursor1)) return false;
                attr3Cursor1 += 16;
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
            Node dataTo = to as Node;
            if (dataTo == null) {
                dataTo = new Node();
                to = dataTo;
            }
            dataTo.name = ReadString(from, offset + offset_name);
            dataTo._value = ReadString(from, offset + offset__value);
            int attr2Cursor0 = offset + offset_children;
            IntPtr attr2Seq0Buf = ReadIntPtr(from, attr2Cursor0);
            int attr2Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr2Seq0Buf);
            if (dataTo.children == null || dataTo.children.Length != attr2Seq0Length) {
                datarouter.Node[] target = new datarouter.Node[attr2Seq0Length];
                initObjectSeq(dataTo.children, target);
                dataTo.children = target as datarouter.Node[];
            }
            attr2Cursor0 += 4;
            int attr2Cursor1 = 0;
            for (int i0 = 0; i0 < attr2Seq0Length; i0++) {
                object elementObj = dataTo.children[i0];
                attr2Marshaler.CopyOut(attr2Seq0Buf, ref elementObj, attr2Cursor1);
                if (dataTo.children[i0] == null) {
                    dataTo.children[i0] = elementObj as datarouter.Node;
                }
                attr2Cursor1 += 16;
            }
            int attr3Cursor0 = offset + offset_attributes;
            IntPtr attr3Seq0Buf = ReadIntPtr(from, attr3Cursor0);
            int attr3Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr3Seq0Buf);
            if (dataTo.attributes == null || dataTo.attributes.Length != attr3Seq0Length) {
                datarouter.Node[] target = new datarouter.Node[attr3Seq0Length];
                initObjectSeq(dataTo.attributes, target);
                dataTo.attributes = target as datarouter.Node[];
            }
            attr3Cursor0 += 4;
            int attr3Cursor1 = 0;
            for (int i0 = 0; i0 < attr3Seq0Length; i0++) {
                object elementObj = dataTo.attributes[i0];
                attr3Marshaler.CopyOut(attr3Seq0Buf, ref elementObj, attr3Cursor1);
                if (dataTo.attributes[i0] == null) {
                    dataTo.attributes[i0] = elementObj as datarouter.Node;
                }
                attr3Cursor1 += 16;
            }
        }

    }
    #endregion

    #region __EVENT_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __EVENT_msg
    {
        public int event_id;
        public int time;
        public int nodeId;
        public IntPtr name;
        public IntPtr type;
        public datarouter.__Node info;
    }
    #endregion

    #region EVENT_msgMarshaler
    public sealed class EVENT_msgMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__EVENT_msg);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_event_id = (int)Marshal.OffsetOf(type, "event_id");
        private static readonly int offset_time = (int)Marshal.OffsetOf(type, "time");
        private static readonly int offset_nodeId = (int)Marshal.OffsetOf(type, "nodeId");
        private static readonly int offset_name = (int)Marshal.OffsetOf(type, "name");
        private static readonly int offset_type = (int)Marshal.OffsetOf(type, "type");
        private static readonly int offset_info = (int)Marshal.OffsetOf(type, "info");

        private DatabaseMarshaler attr5Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr5Marshaler == null) {
                attr5Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Node));
                if (attr5Marshaler == null) {
                    attr5Marshaler = new datarouter.NodeMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Node), attr5Marshaler);
                    attr5Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new EVENT_msg[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            EVENT_msg from = untypedFrom as EVENT_msg;
            if (from == null) return false;
            Write(to, offset + offset_event_id, from.event_id);
            Write(to, offset + offset_time, from.time);
            Write(to, offset + offset_nodeId, from.nodeId);
            if (from.name == null) return false;
            // Unbounded string: bounds check not required...
            Write(basePtr, to, offset + offset_name, ref from.name);
            if (from.type == null) return false;
            // Unbounded string: bounds check not required...
            Write(basePtr, to, offset + offset_type, ref from.type);
            if (!attr5Marshaler.CopyIn(basePtr, from.info, to, offset + offset_info)) return false;
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
            EVENT_msg dataTo = to as EVENT_msg;
            if (dataTo == null) {
                dataTo = new EVENT_msg();
                to = dataTo;
            }
            dataTo.event_id = ReadUInt32(from, offset + offset_event_id);
            dataTo.time = ReadUInt32(from, offset + offset_time);
            dataTo.nodeId = ReadUInt32(from, offset + offset_nodeId);
            dataTo.name = ReadString(from, offset + offset_name);
            dataTo.type = ReadString(from, offset + offset_type);
            object attr5Val = dataTo.info;
            attr5Marshaler.CopyOut(from, ref attr5Val, offset + offset_info);
            if (dataTo.info == null) {
                dataTo.info = attr5Val as datarouter.Node;
            }
        }

    }
    #endregion

    #region __CONTROL_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __CONTROL_msg
    {
        public int hardware;
        public IntPtr cmd;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=128)]
        public IntPtr[] information;
        public IntPtr payload;
    }
    #endregion

    #region CONTROL_msgMarshaler
    public sealed class CONTROL_msgMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__CONTROL_msg);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_hardware = (int)Marshal.OffsetOf(type, "hardware");
        private static readonly int offset_cmd = (int)Marshal.OffsetOf(type, "cmd");
        private static readonly int offset_information = (int)Marshal.OffsetOf(type, "information");
        private static readonly int offset_payload = (int)Marshal.OffsetOf(type, "payload");

        private IntPtr attr3Seq0Type = IntPtr.Zero;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new CONTROL_msg[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            CONTROL_msg from = untypedFrom as CONTROL_msg;
            if (from == null) return false;
            Write(to, offset + offset_hardware, from.hardware);
            if (from.cmd == null) return false;
            // Unbounded string: bounds check not required...
            Write(basePtr, to, offset + offset_cmd, ref from.cmd);
            int attr2Cursor0 = offset + offset_information;
            for (int i0 = 0; i0 < 128; i0++) {
                if (from.information[i0] == null) return false;
                // Unbounded string: bounds check not required...
                Write(basePtr, to, attr2Cursor0, ref from.information[i0]);
                attr2Cursor0 += 4;
            }
            int attr3Cursor0 = offset + offset_payload;
            if (from.payload == null) return false;
            int attr3Seq0Length = from.payload.Length;
            // Unbounded sequence: bounds check not required...
            if (attr3Seq0Type == IntPtr.Zero) {
                attr3Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::CONTROL_msg::C_SEQUENCE<c_octet>");
            }
            IntPtr attr3Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr3Seq0Type, attr3Seq0Length);
            Write(to, attr3Cursor0, attr3Seq0Buf);
            attr3Cursor0 += 4;
            int attr3Cursor1 = 0;
            for (int i0 = 0; i0 < attr3Seq0Length; i0++) {
                Write(attr3Seq0Buf, attr3Cursor1, from.payload[i0]);
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
            CONTROL_msg dataTo = to as CONTROL_msg;
            if (dataTo == null) {
                dataTo = new CONTROL_msg();
                to = dataTo;
            }
            dataTo.hardware = ReadUInt32(from, offset + offset_hardware);
            dataTo.cmd = ReadString(from, offset + offset_cmd);
            int attr2Cursor0 = offset + offset_information;
            if (dataTo.information == null || dataTo.information.GetLength(0) != 128) {
                string[] target = new string[128];
                initObjectSeq(dataTo.information, target);
                dataTo.information = target as string[];
            }
            for (int i0 = 0; i0 < 128; i0++) {
                dataTo.information[i0] = ReadString(from, attr2Cursor0);
                attr2Cursor0 += 4;
            }
            int attr3Cursor0 = offset + offset_payload;
            IntPtr attr3Seq0Buf = ReadIntPtr(from, attr3Cursor0);
            int attr3Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr3Seq0Buf);
            if (dataTo.payload == null || dataTo.payload.Length != attr3Seq0Length) {
                dataTo.payload = new byte[attr3Seq0Length];
            }
            attr3Cursor0 += 4;
            int attr3Cursor1 = 0;
            for (int i0 = 0; i0 < attr3Seq0Length; i0++) {
                dataTo.payload[i0] = ReadByte(attr3Seq0Buf, attr3Cursor1);
                attr3Cursor1 += 1;
            }
        }

    }
    #endregion

    #region __CONTROL_STATUS_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __CONTROL_STATUS_msg
    {
        public int hardware;
        public IntPtr cmd;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=128)]
        public IntPtr[] information;
        public IntPtr payload;
    }
    #endregion

    #region CONTROL_STATUS_msgMarshaler
    public sealed class CONTROL_STATUS_msgMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__CONTROL_STATUS_msg);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_hardware = (int)Marshal.OffsetOf(type, "hardware");
        private static readonly int offset_cmd = (int)Marshal.OffsetOf(type, "cmd");
        private static readonly int offset_information = (int)Marshal.OffsetOf(type, "information");
        private static readonly int offset_payload = (int)Marshal.OffsetOf(type, "payload");

        private IntPtr attr3Seq0Type = IntPtr.Zero;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new CONTROL_STATUS_msg[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            CONTROL_STATUS_msg from = untypedFrom as CONTROL_STATUS_msg;
            if (from == null) return false;
            Write(to, offset + offset_hardware, from.hardware);
            if (from.cmd == null) return false;
            // Unbounded string: bounds check not required...
            Write(basePtr, to, offset + offset_cmd, ref from.cmd);
            int attr2Cursor0 = offset + offset_information;
            for (int i0 = 0; i0 < 128; i0++) {
                if (from.information[i0] == null) return false;
                // Unbounded string: bounds check not required...
                Write(basePtr, to, attr2Cursor0, ref from.information[i0]);
                attr2Cursor0 += 4;
            }
            int attr3Cursor0 = offset + offset_payload;
            if (from.payload == null) return false;
            int attr3Seq0Length = from.payload.Length;
            // Unbounded sequence: bounds check not required...
            if (attr3Seq0Type == IntPtr.Zero) {
                attr3Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::CONTROL_STATUS_msg::C_SEQUENCE<c_octet>");
            }
            IntPtr attr3Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr3Seq0Type, attr3Seq0Length);
            Write(to, attr3Cursor0, attr3Seq0Buf);
            attr3Cursor0 += 4;
            int attr3Cursor1 = 0;
            for (int i0 = 0; i0 < attr3Seq0Length; i0++) {
                Write(attr3Seq0Buf, attr3Cursor1, from.payload[i0]);
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
            CONTROL_STATUS_msg dataTo = to as CONTROL_STATUS_msg;
            if (dataTo == null) {
                dataTo = new CONTROL_STATUS_msg();
                to = dataTo;
            }
            dataTo.hardware = ReadUInt32(from, offset + offset_hardware);
            dataTo.cmd = ReadString(from, offset + offset_cmd);
            int attr2Cursor0 = offset + offset_information;
            if (dataTo.information == null || dataTo.information.GetLength(0) != 128) {
                string[] target = new string[128];
                initObjectSeq(dataTo.information, target);
                dataTo.information = target as string[];
            }
            for (int i0 = 0; i0 < 128; i0++) {
                dataTo.information[i0] = ReadString(from, attr2Cursor0);
                attr2Cursor0 += 4;
            }
            int attr3Cursor0 = offset + offset_payload;
            IntPtr attr3Seq0Buf = ReadIntPtr(from, attr3Cursor0);
            int attr3Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr3Seq0Buf);
            if (dataTo.payload == null || dataTo.payload.Length != attr3Seq0Length) {
                dataTo.payload = new byte[attr3Seq0Length];
            }
            attr3Cursor0 += 4;
            int attr3Cursor1 = 0;
            for (int i0 = 0; i0 < attr3Seq0Length; i0++) {
                dataTo.payload[i0] = ReadByte(attr3Seq0Buf, attr3Cursor1);
                attr3Cursor1 += 1;
            }
        }

    }
    #endregion

    #region __AAMS_429_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_429_msg
    {
        public int id;
        public short label;
        public int src;
        public int reserved;
        public int sec;
        public int usec;
        public IntPtr payload;
    }
    #endregion

    #region AAMS_429_msgMarshaler
    public sealed class AAMS_429_msgMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_429_msg);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_label = (int)Marshal.OffsetOf(type, "label");
        private static readonly int offset_src = (int)Marshal.OffsetOf(type, "src");
        private static readonly int offset_reserved = (int)Marshal.OffsetOf(type, "reserved");
        private static readonly int offset_sec = (int)Marshal.OffsetOf(type, "sec");
        private static readonly int offset_usec = (int)Marshal.OffsetOf(type, "usec");
        private static readonly int offset_payload = (int)Marshal.OffsetOf(type, "payload");

        private IntPtr attr6Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr6Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr6Marshaler == null) {
                attr6Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Payload));
                if (attr6Marshaler == null) {
                    attr6Marshaler = new datarouter.PayloadMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Payload), attr6Marshaler);
                    attr6Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_429_msg[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_429_msg from = untypedFrom as AAMS_429_msg;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            Write(to, offset + offset_label, from.label);
            Write(to, offset + offset_src, from.src);
            Write(to, offset + offset_reserved, from.reserved);
            Write(to, offset + offset_sec, from.sec);
            Write(to, offset + offset_usec, from.usec);
            int attr6Cursor0 = offset + offset_payload;
            if (from.payload == null) return false;
            int attr6Seq0Length = from.payload.Length;
            // Unbounded sequence: bounds check not required...
            if (attr6Seq0Type == IntPtr.Zero) {
                attr6Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::C_SEQUENCE<datarouter::Payload>");
            }
            IntPtr attr6Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr6Seq0Type, attr6Seq0Length);
            Write(to, attr6Cursor0, attr6Seq0Buf);
            attr6Cursor0 += 4;
            int attr6Cursor1 = 0;
            for (int i0 = 0; i0 < attr6Seq0Length; i0++) {
                if (!attr6Marshaler.CopyIn(basePtr, from.payload[i0], attr6Seq0Buf, attr6Cursor1)) return false;
                attr6Cursor1 += 1;
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
            AAMS_429_msg dataTo = to as AAMS_429_msg;
            if (dataTo == null) {
                dataTo = new AAMS_429_msg();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            dataTo.label = ReadUInt16(from, offset + offset_label);
            dataTo.src = ReadUInt32(from, offset + offset_src);
            dataTo.reserved = ReadUInt32(from, offset + offset_reserved);
            dataTo.sec = ReadUInt32(from, offset + offset_sec);
            dataTo.usec = ReadUInt32(from, offset + offset_usec);
            int attr6Cursor0 = offset + offset_payload;
            IntPtr attr6Seq0Buf = ReadIntPtr(from, attr6Cursor0);
            int attr6Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr6Seq0Buf);
            if (dataTo.payload == null || dataTo.payload.Length != attr6Seq0Length) {
                datarouter.Payload[] target = new datarouter.Payload[attr6Seq0Length];
                initObjectSeq(dataTo.payload, target);
                dataTo.payload = target as datarouter.Payload[];
            }
            attr6Cursor0 += 4;
            int attr6Cursor1 = 0;
            for (int i0 = 0; i0 < attr6Seq0Length; i0++) {
                object elementObj = dataTo.payload[i0];
                attr6Marshaler.CopyOut(attr6Seq0Buf, ref elementObj, attr6Cursor1);
                if (dataTo.payload[i0] == null) {
                    dataTo.payload[i0] = elementObj as datarouter.Payload;
                }
                attr6Cursor1 += 1;
            }
        }

    }
    #endregion

    #region __AAMS_429_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_429_Channel
    {
        public int id;
        public IntPtr msgs;
    }
    #endregion

    #region AAMS_429_ChannelMarshaler
    public sealed class AAMS_429_ChannelMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_429_Channel);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_msgs = (int)Marshal.OffsetOf(type, "msgs");

        private IntPtr attr1Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr1Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr1Marshaler == null) {
                attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.AAMS_429_msg));
                if (attr1Marshaler == null) {
                    attr1Marshaler = new datarouter.AAMS_429_msgMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.AAMS_429_msg), attr1Marshaler);
                    attr1Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_429_Channel[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_429_Channel from = untypedFrom as AAMS_429_Channel;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            int attr1Cursor0 = offset + offset_msgs;
            if (from.msgs == null) return false;
            int attr1Seq0Length = from.msgs.Length;
            // Unbounded sequence: bounds check not required...
            if (attr1Seq0Type == IntPtr.Zero) {
                attr1Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::AAMS_429_Channel::C_SEQUENCE<datarouter::AAMS_429_msg>");
            }
            IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Seq0Type, attr1Seq0Length);
            Write(to, attr1Cursor0, attr1Seq0Buf);
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                if (!attr1Marshaler.CopyIn(basePtr, from.msgs[i0], attr1Seq0Buf, attr1Cursor1)) return false;
                attr1Cursor1 += 28;
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
            AAMS_429_Channel dataTo = to as AAMS_429_Channel;
            if (dataTo == null) {
                dataTo = new AAMS_429_Channel();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            int attr1Cursor0 = offset + offset_msgs;
            IntPtr attr1Seq0Buf = ReadIntPtr(from, attr1Cursor0);
            int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
            if (dataTo.msgs == null || dataTo.msgs.Length != attr1Seq0Length) {
                datarouter.AAMS_429_msg[] target = new datarouter.AAMS_429_msg[attr1Seq0Length];
                initObjectSeq(dataTo.msgs, target);
                dataTo.msgs = target as datarouter.AAMS_429_msg[];
            }
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                object elementObj = dataTo.msgs[i0];
                attr1Marshaler.CopyOut(attr1Seq0Buf, ref elementObj, attr1Cursor1);
                if (dataTo.msgs[i0] == null) {
                    dataTo.msgs[i0] = elementObj as datarouter.AAMS_429_msg;
                }
                attr1Cursor1 += 28;
            }
        }

    }
    #endregion

    #region __AAMS_NoBus_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_NoBus_msg
    {
        public int id;
        public int src;
        public int reserved;
        public int sec;
        public int usec;
        public IntPtr payload;
    }
    #endregion

    #region AAMS_NoBus_msgMarshaler
    public sealed class AAMS_NoBus_msgMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_NoBus_msg);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_src = (int)Marshal.OffsetOf(type, "src");
        private static readonly int offset_reserved = (int)Marshal.OffsetOf(type, "reserved");
        private static readonly int offset_sec = (int)Marshal.OffsetOf(type, "sec");
        private static readonly int offset_usec = (int)Marshal.OffsetOf(type, "usec");
        private static readonly int offset_payload = (int)Marshal.OffsetOf(type, "payload");

        private IntPtr attr5Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr5Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr5Marshaler == null) {
                attr5Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Payload));
                if (attr5Marshaler == null) {
                    attr5Marshaler = new datarouter.PayloadMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Payload), attr5Marshaler);
                    attr5Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_NoBus_msg[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_NoBus_msg from = untypedFrom as AAMS_NoBus_msg;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            Write(to, offset + offset_src, from.src);
            Write(to, offset + offset_reserved, from.reserved);
            Write(to, offset + offset_sec, from.sec);
            Write(to, offset + offset_usec, from.usec);
            int attr5Cursor0 = offset + offset_payload;
            if (from.payload == null) return false;
            int attr5Seq0Length = from.payload.Length;
            // Unbounded sequence: bounds check not required...
            if (attr5Seq0Type == IntPtr.Zero) {
                attr5Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::C_SEQUENCE<datarouter::Payload>");
            }
            IntPtr attr5Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr5Seq0Type, attr5Seq0Length);
            Write(to, attr5Cursor0, attr5Seq0Buf);
            attr5Cursor0 += 4;
            int attr5Cursor1 = 0;
            for (int i0 = 0; i0 < attr5Seq0Length; i0++) {
                if (!attr5Marshaler.CopyIn(basePtr, from.payload[i0], attr5Seq0Buf, attr5Cursor1)) return false;
                attr5Cursor1 += 1;
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
            AAMS_NoBus_msg dataTo = to as AAMS_NoBus_msg;
            if (dataTo == null) {
                dataTo = new AAMS_NoBus_msg();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            dataTo.src = ReadUInt32(from, offset + offset_src);
            dataTo.reserved = ReadUInt32(from, offset + offset_reserved);
            dataTo.sec = ReadUInt32(from, offset + offset_sec);
            dataTo.usec = ReadUInt32(from, offset + offset_usec);
            int attr5Cursor0 = offset + offset_payload;
            IntPtr attr5Seq0Buf = ReadIntPtr(from, attr5Cursor0);
            int attr5Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr5Seq0Buf);
            if (dataTo.payload == null || dataTo.payload.Length != attr5Seq0Length) {
                datarouter.Payload[] target = new datarouter.Payload[attr5Seq0Length];
                initObjectSeq(dataTo.payload, target);
                dataTo.payload = target as datarouter.Payload[];
            }
            attr5Cursor0 += 4;
            int attr5Cursor1 = 0;
            for (int i0 = 0; i0 < attr5Seq0Length; i0++) {
                object elementObj = dataTo.payload[i0];
                attr5Marshaler.CopyOut(attr5Seq0Buf, ref elementObj, attr5Cursor1);
                if (dataTo.payload[i0] == null) {
                    dataTo.payload[i0] = elementObj as datarouter.Payload;
                }
                attr5Cursor1 += 1;
            }
        }

    }
    #endregion

    #region __AAMS_NoBus_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_NoBus_Channel
    {
        public int id;
        public IntPtr msgs;
    }
    #endregion

    #region AAMS_NoBus_ChannelMarshaler
    public sealed class AAMS_NoBus_ChannelMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_NoBus_Channel);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_msgs = (int)Marshal.OffsetOf(type, "msgs");

        private IntPtr attr1Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr1Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr1Marshaler == null) {
                attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.AAMS_NoBus_msg));
                if (attr1Marshaler == null) {
                    attr1Marshaler = new datarouter.AAMS_NoBus_msgMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.AAMS_NoBus_msg), attr1Marshaler);
                    attr1Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_NoBus_Channel[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_NoBus_Channel from = untypedFrom as AAMS_NoBus_Channel;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            int attr1Cursor0 = offset + offset_msgs;
            if (from.msgs == null) return false;
            int attr1Seq0Length = from.msgs.Length;
            // Unbounded sequence: bounds check not required...
            if (attr1Seq0Type == IntPtr.Zero) {
                attr1Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::AAMS_NoBus_Channel::C_SEQUENCE<datarouter::AAMS_NoBus_msg>");
            }
            IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Seq0Type, attr1Seq0Length);
            Write(to, attr1Cursor0, attr1Seq0Buf);
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                if (!attr1Marshaler.CopyIn(basePtr, from.msgs[i0], attr1Seq0Buf, attr1Cursor1)) return false;
                attr1Cursor1 += 24;
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
            AAMS_NoBus_Channel dataTo = to as AAMS_NoBus_Channel;
            if (dataTo == null) {
                dataTo = new AAMS_NoBus_Channel();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            int attr1Cursor0 = offset + offset_msgs;
            IntPtr attr1Seq0Buf = ReadIntPtr(from, attr1Cursor0);
            int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
            if (dataTo.msgs == null || dataTo.msgs.Length != attr1Seq0Length) {
                datarouter.AAMS_NoBus_msg[] target = new datarouter.AAMS_NoBus_msg[attr1Seq0Length];
                initObjectSeq(dataTo.msgs, target);
                dataTo.msgs = target as datarouter.AAMS_NoBus_msg[];
            }
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                object elementObj = dataTo.msgs[i0];
                attr1Marshaler.CopyOut(attr1Seq0Buf, ref elementObj, attr1Cursor1);
                if (dataTo.msgs[i0] == null) {
                    dataTo.msgs[i0] = elementObj as datarouter.AAMS_NoBus_msg;
                }
                attr1Cursor1 += 24;
            }
        }

    }
    #endregion

    #region __DATA_STATUS
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __DATA_STATUS
    {
        public short tf;
        public short dba;
        public short sf;
        public short busy;
        public short bcr;
        public short res;
        public short sr;
        public short inst;
        public short me;
        public short rtaddr;
    }
    #endregion

    #region DATA_STATUSMarshaler
    public sealed class DATA_STATUSMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__DATA_STATUS);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_tf = (int)Marshal.OffsetOf(type, "tf");
        private static readonly int offset_dba = (int)Marshal.OffsetOf(type, "dba");
        private static readonly int offset_sf = (int)Marshal.OffsetOf(type, "sf");
        private static readonly int offset_busy = (int)Marshal.OffsetOf(type, "busy");
        private static readonly int offset_bcr = (int)Marshal.OffsetOf(type, "bcr");
        private static readonly int offset_res = (int)Marshal.OffsetOf(type, "res");
        private static readonly int offset_sr = (int)Marshal.OffsetOf(type, "sr");
        private static readonly int offset_inst = (int)Marshal.OffsetOf(type, "inst");
        private static readonly int offset_me = (int)Marshal.OffsetOf(type, "me");
        private static readonly int offset_rtaddr = (int)Marshal.OffsetOf(type, "rtaddr");


        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new DATA_STATUS[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            DATA_STATUS from = untypedFrom as DATA_STATUS;
            if (from == null) return false;
            Write(to, offset + offset_tf, from.tf);
            Write(to, offset + offset_dba, from.dba);
            Write(to, offset + offset_sf, from.sf);
            Write(to, offset + offset_busy, from.busy);
            Write(to, offset + offset_bcr, from.bcr);
            Write(to, offset + offset_res, from.res);
            Write(to, offset + offset_sr, from.sr);
            Write(to, offset + offset_inst, from.inst);
            Write(to, offset + offset_me, from.me);
            Write(to, offset + offset_rtaddr, from.rtaddr);
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
            DATA_STATUS dataTo = to as DATA_STATUS;
            if (dataTo == null) {
                dataTo = new DATA_STATUS();
                to = dataTo;
            }
            dataTo.tf = ReadUInt16(from, offset + offset_tf);
            dataTo.dba = ReadUInt16(from, offset + offset_dba);
            dataTo.sf = ReadUInt16(from, offset + offset_sf);
            dataTo.busy = ReadUInt16(from, offset + offset_busy);
            dataTo.bcr = ReadUInt16(from, offset + offset_bcr);
            dataTo.res = ReadUInt16(from, offset + offset_res);
            dataTo.sr = ReadUInt16(from, offset + offset_sr);
            dataTo.inst = ReadUInt16(from, offset + offset_inst);
            dataTo.me = ReadUInt16(from, offset + offset_me);
            dataTo.rtaddr = ReadUInt16(from, offset + offset_rtaddr);
        }

    }
    #endregion

    #region __AAMS_1553_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_1553_msg
    {
        public int id;
        public int mode;
        public int src_addr;
        public int sub_src_addr;
        public int dst_addr;
        public int sub_dst_addr;
        public datarouter.__DATA_STATUS status1;
        public datarouter.__DATA_STATUS status2;
        public int src;
        public int reserved;
        public int sec;
        public int usec;
        public int length;
        public IntPtr payload;
    }
    #endregion

    #region AAMS_1553_msgMarshaler
    public sealed class AAMS_1553_msgMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_1553_msg);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_mode = (int)Marshal.OffsetOf(type, "mode");
        private static readonly int offset_src_addr = (int)Marshal.OffsetOf(type, "src_addr");
        private static readonly int offset_sub_src_addr = (int)Marshal.OffsetOf(type, "sub_src_addr");
        private static readonly int offset_dst_addr = (int)Marshal.OffsetOf(type, "dst_addr");
        private static readonly int offset_sub_dst_addr = (int)Marshal.OffsetOf(type, "sub_dst_addr");
        private static readonly int offset_status1 = (int)Marshal.OffsetOf(type, "status1");
        private static readonly int offset_status2 = (int)Marshal.OffsetOf(type, "status2");
        private static readonly int offset_src = (int)Marshal.OffsetOf(type, "src");
        private static readonly int offset_reserved = (int)Marshal.OffsetOf(type, "reserved");
        private static readonly int offset_sec = (int)Marshal.OffsetOf(type, "sec");
        private static readonly int offset_usec = (int)Marshal.OffsetOf(type, "usec");
        private static readonly int offset_length = (int)Marshal.OffsetOf(type, "length");
        private static readonly int offset_payload = (int)Marshal.OffsetOf(type, "payload");

        private DatabaseMarshaler attr6Marshaler;
        private DatabaseMarshaler attr7Marshaler;
        private IntPtr attr13Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr13Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr6Marshaler == null) {
                attr6Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.DATA_STATUS));
                if (attr6Marshaler == null) {
                    attr6Marshaler = new datarouter.DATA_STATUSMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.DATA_STATUS), attr6Marshaler);
                    attr6Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
            if (attr7Marshaler == null) {
                attr7Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.DATA_STATUS));
                if (attr7Marshaler == null) {
                    attr7Marshaler = new datarouter.DATA_STATUSMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.DATA_STATUS), attr7Marshaler);
                    attr7Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
            if (attr13Marshaler == null) {
                attr13Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Payload));
                if (attr13Marshaler == null) {
                    attr13Marshaler = new datarouter.PayloadMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Payload), attr13Marshaler);
                    attr13Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_1553_msg[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_1553_msg from = untypedFrom as AAMS_1553_msg;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            Write(to, offset + offset_mode, from.mode);
            Write(to, offset + offset_src_addr, from.src_addr);
            Write(to, offset + offset_sub_src_addr, from.sub_src_addr);
            Write(to, offset + offset_dst_addr, from.dst_addr);
            Write(to, offset + offset_sub_dst_addr, from.sub_dst_addr);
            if (!attr6Marshaler.CopyIn(basePtr, from.status1, to, offset + offset_status1)) return false;
            if (!attr7Marshaler.CopyIn(basePtr, from.status2, to, offset + offset_status2)) return false;
            Write(to, offset + offset_src, from.src);
            Write(to, offset + offset_reserved, from.reserved);
            Write(to, offset + offset_sec, from.sec);
            Write(to, offset + offset_usec, from.usec);
            Write(to, offset + offset_length, from.length);
            int attr13Cursor0 = offset + offset_payload;
            if (from.payload == null) return false;
            int attr13Seq0Length = from.payload.Length;
            // Unbounded sequence: bounds check not required...
            if (attr13Seq0Type == IntPtr.Zero) {
                attr13Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::C_SEQUENCE<datarouter::Payload>");
            }
            IntPtr attr13Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr13Seq0Type, attr13Seq0Length);
            Write(to, attr13Cursor0, attr13Seq0Buf);
            attr13Cursor0 += 4;
            int attr13Cursor1 = 0;
            for (int i0 = 0; i0 < attr13Seq0Length; i0++) {
                if (!attr13Marshaler.CopyIn(basePtr, from.payload[i0], attr13Seq0Buf, attr13Cursor1)) return false;
                attr13Cursor1 += 1;
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
            AAMS_1553_msg dataTo = to as AAMS_1553_msg;
            if (dataTo == null) {
                dataTo = new AAMS_1553_msg();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            dataTo.mode = ReadUInt32(from, offset + offset_mode);
            dataTo.src_addr = ReadUInt32(from, offset + offset_src_addr);
            dataTo.sub_src_addr = ReadUInt32(from, offset + offset_sub_src_addr);
            dataTo.dst_addr = ReadUInt32(from, offset + offset_dst_addr);
            dataTo.sub_dst_addr = ReadUInt32(from, offset + offset_sub_dst_addr);
            object attr6Val = dataTo.status1;
            attr6Marshaler.CopyOut(from, ref attr6Val, offset + offset_status1);
            if (dataTo.status1 == null) {
                dataTo.status1 = attr6Val as datarouter.DATA_STATUS;
            }
            object attr7Val = dataTo.status2;
            attr7Marshaler.CopyOut(from, ref attr7Val, offset + offset_status2);
            if (dataTo.status2 == null) {
                dataTo.status2 = attr7Val as datarouter.DATA_STATUS;
            }
            dataTo.src = ReadUInt32(from, offset + offset_src);
            dataTo.reserved = ReadUInt32(from, offset + offset_reserved);
            dataTo.sec = ReadUInt32(from, offset + offset_sec);
            dataTo.usec = ReadUInt32(from, offset + offset_usec);
            dataTo.length = ReadUInt32(from, offset + offset_length);
            int attr13Cursor0 = offset + offset_payload;
            IntPtr attr13Seq0Buf = ReadIntPtr(from, attr13Cursor0);
            int attr13Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr13Seq0Buf);
            if (dataTo.payload == null || dataTo.payload.Length != attr13Seq0Length) {
                datarouter.Payload[] target = new datarouter.Payload[attr13Seq0Length];
                initObjectSeq(dataTo.payload, target);
                dataTo.payload = target as datarouter.Payload[];
            }
            attr13Cursor0 += 4;
            int attr13Cursor1 = 0;
            for (int i0 = 0; i0 < attr13Seq0Length; i0++) {
                object elementObj = dataTo.payload[i0];
                attr13Marshaler.CopyOut(attr13Seq0Buf, ref elementObj, attr13Cursor1);
                if (dataTo.payload[i0] == null) {
                    dataTo.payload[i0] = elementObj as datarouter.Payload;
                }
                attr13Cursor1 += 1;
            }
        }

    }
    #endregion

    #region __AAMS_1553_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_1553_Channel
    {
        public int id;
        public IntPtr msgs;
    }
    #endregion

    #region AAMS_1553_ChannelMarshaler
    public sealed class AAMS_1553_ChannelMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_1553_Channel);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_msgs = (int)Marshal.OffsetOf(type, "msgs");

        private IntPtr attr1Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr1Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr1Marshaler == null) {
                attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.AAMS_1553_msg));
                if (attr1Marshaler == null) {
                    attr1Marshaler = new datarouter.AAMS_1553_msgMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.AAMS_1553_msg), attr1Marshaler);
                    attr1Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_1553_Channel[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_1553_Channel from = untypedFrom as AAMS_1553_Channel;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            int attr1Cursor0 = offset + offset_msgs;
            if (from.msgs == null) return false;
            int attr1Seq0Length = from.msgs.Length;
            // Unbounded sequence: bounds check not required...
            if (attr1Seq0Type == IntPtr.Zero) {
                attr1Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::AAMS_1553_Channel::C_SEQUENCE<datarouter::AAMS_1553_msg>");
            }
            IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Seq0Type, attr1Seq0Length);
            Write(to, attr1Cursor0, attr1Seq0Buf);
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                if (!attr1Marshaler.CopyIn(basePtr, from.msgs[i0], attr1Seq0Buf, attr1Cursor1)) return false;
                attr1Cursor1 += 88;
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
            AAMS_1553_Channel dataTo = to as AAMS_1553_Channel;
            if (dataTo == null) {
                dataTo = new AAMS_1553_Channel();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            int attr1Cursor0 = offset + offset_msgs;
            IntPtr attr1Seq0Buf = ReadIntPtr(from, attr1Cursor0);
            int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
            if (dataTo.msgs == null || dataTo.msgs.Length != attr1Seq0Length) {
                datarouter.AAMS_1553_msg[] target = new datarouter.AAMS_1553_msg[attr1Seq0Length];
                initObjectSeq(dataTo.msgs, target);
                dataTo.msgs = target as datarouter.AAMS_1553_msg[];
            }
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                object elementObj = dataTo.msgs[i0];
                attr1Marshaler.CopyOut(attr1Seq0Buf, ref elementObj, attr1Cursor1);
                if (dataTo.msgs[i0] == null) {
                    dataTo.msgs[i0] = elementObj as datarouter.AAMS_1553_msg;
                }
                attr1Cursor1 += 88;
            }
        }

    }
    #endregion

    #region __AAMS_422_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_422_msg
    {
        public int id;
        public IntPtr frame_begin;
        public IntPtr frame_end;
        public int src;
        public int reserved;
        public int sec;
        public int usec;
        public int length;
        public IntPtr payload;
    }
    #endregion

    #region AAMS_422_msgMarshaler
    public sealed class AAMS_422_msgMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_422_msg);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_frame_begin = (int)Marshal.OffsetOf(type, "frame_begin");
        private static readonly int offset_frame_end = (int)Marshal.OffsetOf(type, "frame_end");
        private static readonly int offset_src = (int)Marshal.OffsetOf(type, "src");
        private static readonly int offset_reserved = (int)Marshal.OffsetOf(type, "reserved");
        private static readonly int offset_sec = (int)Marshal.OffsetOf(type, "sec");
        private static readonly int offset_usec = (int)Marshal.OffsetOf(type, "usec");
        private static readonly int offset_length = (int)Marshal.OffsetOf(type, "length");
        private static readonly int offset_payload = (int)Marshal.OffsetOf(type, "payload");

        private IntPtr attr1Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr1Marshaler;
        private IntPtr attr2Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr2Marshaler;
        private IntPtr attr8Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr8Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr1Marshaler == null) {
                attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Payload));
                if (attr1Marshaler == null) {
                    attr1Marshaler = new datarouter.PayloadMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Payload), attr1Marshaler);
                    attr1Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
            if (attr2Marshaler == null) {
                attr2Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Payload));
                if (attr2Marshaler == null) {
                    attr2Marshaler = new datarouter.PayloadMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Payload), attr2Marshaler);
                    attr2Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
            if (attr8Marshaler == null) {
                attr8Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Payload));
                if (attr8Marshaler == null) {
                    attr8Marshaler = new datarouter.PayloadMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Payload), attr8Marshaler);
                    attr8Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_422_msg[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_422_msg from = untypedFrom as AAMS_422_msg;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            int attr1Cursor0 = offset + offset_frame_begin;
            if (from.frame_begin == null) return false;
            int attr1Seq0Length = from.frame_begin.Length;
            // Unbounded sequence: bounds check not required...
            if (attr1Seq0Type == IntPtr.Zero) {
                attr1Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::C_SEQUENCE<datarouter::Payload>");
            }
            IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Seq0Type, attr1Seq0Length);
            Write(to, attr1Cursor0, attr1Seq0Buf);
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                if (!attr1Marshaler.CopyIn(basePtr, from.frame_begin[i0], attr1Seq0Buf, attr1Cursor1)) return false;
                attr1Cursor1 += 1;
            }
            int attr2Cursor0 = offset + offset_frame_end;
            if (from.frame_end == null) return false;
            int attr2Seq0Length = from.frame_end.Length;
            // Unbounded sequence: bounds check not required...
            if (attr2Seq0Type == IntPtr.Zero) {
                attr2Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::C_SEQUENCE<datarouter::Payload>");
            }
            IntPtr attr2Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr2Seq0Type, attr2Seq0Length);
            Write(to, attr2Cursor0, attr2Seq0Buf);
            attr2Cursor0 += 4;
            int attr2Cursor1 = 0;
            for (int i0 = 0; i0 < attr2Seq0Length; i0++) {
                if (!attr2Marshaler.CopyIn(basePtr, from.frame_end[i0], attr2Seq0Buf, attr2Cursor1)) return false;
                attr2Cursor1 += 1;
            }
            Write(to, offset + offset_src, from.src);
            Write(to, offset + offset_reserved, from.reserved);
            Write(to, offset + offset_sec, from.sec);
            Write(to, offset + offset_usec, from.usec);
            Write(to, offset + offset_length, from.length);
            int attr8Cursor0 = offset + offset_payload;
            if (from.payload == null) return false;
            int attr8Seq0Length = from.payload.Length;
            // Unbounded sequence: bounds check not required...
            if (attr8Seq0Type == IntPtr.Zero) {
                attr8Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::C_SEQUENCE<datarouter::Payload>");
            }
            IntPtr attr8Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr8Seq0Type, attr8Seq0Length);
            Write(to, attr8Cursor0, attr8Seq0Buf);
            attr8Cursor0 += 4;
            int attr8Cursor1 = 0;
            for (int i0 = 0; i0 < attr8Seq0Length; i0++) {
                if (!attr8Marshaler.CopyIn(basePtr, from.payload[i0], attr8Seq0Buf, attr8Cursor1)) return false;
                attr8Cursor1 += 1;
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
            AAMS_422_msg dataTo = to as AAMS_422_msg;
            if (dataTo == null) {
                dataTo = new AAMS_422_msg();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            int attr1Cursor0 = offset + offset_frame_begin;
            IntPtr attr1Seq0Buf = ReadIntPtr(from, attr1Cursor0);
            int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
            if (dataTo.frame_begin == null || dataTo.frame_begin.Length != attr1Seq0Length) {
                datarouter.Payload[] target = new datarouter.Payload[attr1Seq0Length];
                initObjectSeq(dataTo.frame_begin, target);
                dataTo.frame_begin = target as datarouter.Payload[];
            }
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                object elementObj = dataTo.frame_begin[i0];
                attr1Marshaler.CopyOut(attr1Seq0Buf, ref elementObj, attr1Cursor1);
                if (dataTo.frame_begin[i0] == null) {
                    dataTo.frame_begin[i0] = elementObj as datarouter.Payload;
                }
                attr1Cursor1 += 1;
            }
            int attr2Cursor0 = offset + offset_frame_end;
            IntPtr attr2Seq0Buf = ReadIntPtr(from, attr2Cursor0);
            int attr2Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr2Seq0Buf);
            if (dataTo.frame_end == null || dataTo.frame_end.Length != attr2Seq0Length) {
                datarouter.Payload[] target = new datarouter.Payload[attr2Seq0Length];
                initObjectSeq(dataTo.frame_end, target);
                dataTo.frame_end = target as datarouter.Payload[];
            }
            attr2Cursor0 += 4;
            int attr2Cursor1 = 0;
            for (int i0 = 0; i0 < attr2Seq0Length; i0++) {
                object elementObj = dataTo.frame_end[i0];
                attr2Marshaler.CopyOut(attr2Seq0Buf, ref elementObj, attr2Cursor1);
                if (dataTo.frame_end[i0] == null) {
                    dataTo.frame_end[i0] = elementObj as datarouter.Payload;
                }
                attr2Cursor1 += 1;
            }
            dataTo.src = ReadUInt32(from, offset + offset_src);
            dataTo.reserved = ReadUInt32(from, offset + offset_reserved);
            dataTo.sec = ReadUInt32(from, offset + offset_sec);
            dataTo.usec = ReadUInt32(from, offset + offset_usec);
            dataTo.length = ReadUInt32(from, offset + offset_length);
            int attr8Cursor0 = offset + offset_payload;
            IntPtr attr8Seq0Buf = ReadIntPtr(from, attr8Cursor0);
            int attr8Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr8Seq0Buf);
            if (dataTo.payload == null || dataTo.payload.Length != attr8Seq0Length) {
                datarouter.Payload[] target = new datarouter.Payload[attr8Seq0Length];
                initObjectSeq(dataTo.payload, target);
                dataTo.payload = target as datarouter.Payload[];
            }
            attr8Cursor0 += 4;
            int attr8Cursor1 = 0;
            for (int i0 = 0; i0 < attr8Seq0Length; i0++) {
                object elementObj = dataTo.payload[i0];
                attr8Marshaler.CopyOut(attr8Seq0Buf, ref elementObj, attr8Cursor1);
                if (dataTo.payload[i0] == null) {
                    dataTo.payload[i0] = elementObj as datarouter.Payload;
                }
                attr8Cursor1 += 1;
            }
        }

    }
    #endregion

    #region __AAMS_422_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_422_Channel
    {
        public int id;
        public IntPtr msgs;
    }
    #endregion

    #region AAMS_422_ChannelMarshaler
    public sealed class AAMS_422_ChannelMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_422_Channel);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_msgs = (int)Marshal.OffsetOf(type, "msgs");

        private IntPtr attr1Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr1Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr1Marshaler == null) {
                attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.AAMS_422_msg));
                if (attr1Marshaler == null) {
                    attr1Marshaler = new datarouter.AAMS_422_msgMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.AAMS_422_msg), attr1Marshaler);
                    attr1Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_422_Channel[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_422_Channel from = untypedFrom as AAMS_422_Channel;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            int attr1Cursor0 = offset + offset_msgs;
            if (from.msgs == null) return false;
            int attr1Seq0Length = from.msgs.Length;
            // Unbounded sequence: bounds check not required...
            if (attr1Seq0Type == IntPtr.Zero) {
                attr1Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::AAMS_422_Channel::C_SEQUENCE<datarouter::AAMS_422_msg>");
            }
            IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Seq0Type, attr1Seq0Length);
            Write(to, attr1Cursor0, attr1Seq0Buf);
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                if (!attr1Marshaler.CopyIn(basePtr, from.msgs[i0], attr1Seq0Buf, attr1Cursor1)) return false;
                attr1Cursor1 += 36;
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
            AAMS_422_Channel dataTo = to as AAMS_422_Channel;
            if (dataTo == null) {
                dataTo = new AAMS_422_Channel();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            int attr1Cursor0 = offset + offset_msgs;
            IntPtr attr1Seq0Buf = ReadIntPtr(from, attr1Cursor0);
            int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
            if (dataTo.msgs == null || dataTo.msgs.Length != attr1Seq0Length) {
                datarouter.AAMS_422_msg[] target = new datarouter.AAMS_422_msg[attr1Seq0Length];
                initObjectSeq(dataTo.msgs, target);
                dataTo.msgs = target as datarouter.AAMS_422_msg[];
            }
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                object elementObj = dataTo.msgs[i0];
                attr1Marshaler.CopyOut(attr1Seq0Buf, ref elementObj, attr1Cursor1);
                if (dataTo.msgs[i0] == null) {
                    dataTo.msgs[i0] = elementObj as datarouter.AAMS_422_msg;
                }
                attr1Cursor1 += 36;
            }
        }

    }
    #endregion

    #region __AAMS_CAN_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_CAN_msg
    {
        public int id;
        public int type;
        public int can_id;
        public int src;
        public int reserved;
        public int sec;
        public int usec;
        public IntPtr payload;
    }
    #endregion

    #region AAMS_CAN_msgMarshaler
    public sealed class AAMS_CAN_msgMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_CAN_msg);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_type = (int)Marshal.OffsetOf(type, "type");
        private static readonly int offset_can_id = (int)Marshal.OffsetOf(type, "can_id");
        private static readonly int offset_src = (int)Marshal.OffsetOf(type, "src");
        private static readonly int offset_reserved = (int)Marshal.OffsetOf(type, "reserved");
        private static readonly int offset_sec = (int)Marshal.OffsetOf(type, "sec");
        private static readonly int offset_usec = (int)Marshal.OffsetOf(type, "usec");
        private static readonly int offset_payload = (int)Marshal.OffsetOf(type, "payload");

        private IntPtr attr7Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr7Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr7Marshaler == null) {
                attr7Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Payload));
                if (attr7Marshaler == null) {
                    attr7Marshaler = new datarouter.PayloadMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Payload), attr7Marshaler);
                    attr7Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_CAN_msg[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_CAN_msg from = untypedFrom as AAMS_CAN_msg;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            Write(to, offset + offset_type, from.type);
            Write(to, offset + offset_can_id, from.can_id);
            Write(to, offset + offset_src, from.src);
            Write(to, offset + offset_reserved, from.reserved);
            Write(to, offset + offset_sec, from.sec);
            Write(to, offset + offset_usec, from.usec);
            int attr7Cursor0 = offset + offset_payload;
            if (from.payload == null) return false;
            int attr7Seq0Length = from.payload.Length;
            // Unbounded sequence: bounds check not required...
            if (attr7Seq0Type == IntPtr.Zero) {
                attr7Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::C_SEQUENCE<datarouter::Payload>");
            }
            IntPtr attr7Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr7Seq0Type, attr7Seq0Length);
            Write(to, attr7Cursor0, attr7Seq0Buf);
            attr7Cursor0 += 4;
            int attr7Cursor1 = 0;
            for (int i0 = 0; i0 < attr7Seq0Length; i0++) {
                if (!attr7Marshaler.CopyIn(basePtr, from.payload[i0], attr7Seq0Buf, attr7Cursor1)) return false;
                attr7Cursor1 += 1;
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
            AAMS_CAN_msg dataTo = to as AAMS_CAN_msg;
            if (dataTo == null) {
                dataTo = new AAMS_CAN_msg();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            dataTo.type = ReadUInt32(from, offset + offset_type);
            dataTo.can_id = ReadUInt32(from, offset + offset_can_id);
            dataTo.src = ReadUInt32(from, offset + offset_src);
            dataTo.reserved = ReadUInt32(from, offset + offset_reserved);
            dataTo.sec = ReadUInt32(from, offset + offset_sec);
            dataTo.usec = ReadUInt32(from, offset + offset_usec);
            int attr7Cursor0 = offset + offset_payload;
            IntPtr attr7Seq0Buf = ReadIntPtr(from, attr7Cursor0);
            int attr7Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr7Seq0Buf);
            if (dataTo.payload == null || dataTo.payload.Length != attr7Seq0Length) {
                datarouter.Payload[] target = new datarouter.Payload[attr7Seq0Length];
                initObjectSeq(dataTo.payload, target);
                dataTo.payload = target as datarouter.Payload[];
            }
            attr7Cursor0 += 4;
            int attr7Cursor1 = 0;
            for (int i0 = 0; i0 < attr7Seq0Length; i0++) {
                object elementObj = dataTo.payload[i0];
                attr7Marshaler.CopyOut(attr7Seq0Buf, ref elementObj, attr7Cursor1);
                if (dataTo.payload[i0] == null) {
                    dataTo.payload[i0] = elementObj as datarouter.Payload;
                }
                attr7Cursor1 += 1;
            }
        }

    }
    #endregion

    #region __AAMS_CAN_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_CAN_Channel
    {
        public int id;
        public IntPtr msgs;
    }
    #endregion

    #region AAMS_CAN_ChannelMarshaler
    public sealed class AAMS_CAN_ChannelMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_CAN_Channel);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_msgs = (int)Marshal.OffsetOf(type, "msgs");

        private IntPtr attr1Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr1Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr1Marshaler == null) {
                attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.AAMS_CAN_msg));
                if (attr1Marshaler == null) {
                    attr1Marshaler = new datarouter.AAMS_CAN_msgMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.AAMS_CAN_msg), attr1Marshaler);
                    attr1Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_CAN_Channel[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_CAN_Channel from = untypedFrom as AAMS_CAN_Channel;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            int attr1Cursor0 = offset + offset_msgs;
            if (from.msgs == null) return false;
            int attr1Seq0Length = from.msgs.Length;
            // Unbounded sequence: bounds check not required...
            if (attr1Seq0Type == IntPtr.Zero) {
                attr1Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::AAMS_CAN_Channel::C_SEQUENCE<datarouter::AAMS_CAN_msg>");
            }
            IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Seq0Type, attr1Seq0Length);
            Write(to, attr1Cursor0, attr1Seq0Buf);
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                if (!attr1Marshaler.CopyIn(basePtr, from.msgs[i0], attr1Seq0Buf, attr1Cursor1)) return false;
                attr1Cursor1 += 32;
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
            AAMS_CAN_Channel dataTo = to as AAMS_CAN_Channel;
            if (dataTo == null) {
                dataTo = new AAMS_CAN_Channel();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            int attr1Cursor0 = offset + offset_msgs;
            IntPtr attr1Seq0Buf = ReadIntPtr(from, attr1Cursor0);
            int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
            if (dataTo.msgs == null || dataTo.msgs.Length != attr1Seq0Length) {
                datarouter.AAMS_CAN_msg[] target = new datarouter.AAMS_CAN_msg[attr1Seq0Length];
                initObjectSeq(dataTo.msgs, target);
                dataTo.msgs = target as datarouter.AAMS_CAN_msg[];
            }
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                object elementObj = dataTo.msgs[i0];
                attr1Marshaler.CopyOut(attr1Seq0Buf, ref elementObj, attr1Cursor1);
                if (dataTo.msgs[i0] == null) {
                    dataTo.msgs[i0] = elementObj as datarouter.AAMS_CAN_msg;
                }
                attr1Cursor1 += 32;
            }
        }

    }
    #endregion

    #region __AAMS_RFM_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_RFM_msg
    {
        public int id;
        public int src;
        public long addr;
        public int sec;
        public int usec;
        public int length;
        public IntPtr payload;
    }
    #endregion

    #region AAMS_RFM_msgMarshaler
    public sealed class AAMS_RFM_msgMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_RFM_msg);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_src = (int)Marshal.OffsetOf(type, "src");
        private static readonly int offset_addr = (int)Marshal.OffsetOf(type, "addr");
        private static readonly int offset_sec = (int)Marshal.OffsetOf(type, "sec");
        private static readonly int offset_usec = (int)Marshal.OffsetOf(type, "usec");
        private static readonly int offset_length = (int)Marshal.OffsetOf(type, "length");
        private static readonly int offset_payload = (int)Marshal.OffsetOf(type, "payload");

        private IntPtr attr6Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr6Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr6Marshaler == null) {
                attr6Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Payload));
                if (attr6Marshaler == null) {
                    attr6Marshaler = new datarouter.PayloadMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Payload), attr6Marshaler);
                    attr6Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_RFM_msg[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_RFM_msg from = untypedFrom as AAMS_RFM_msg;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            Write(to, offset + offset_src, from.src);
            Write(to, offset + offset_addr, from.addr);
            Write(to, offset + offset_sec, from.sec);
            Write(to, offset + offset_usec, from.usec);
            Write(to, offset + offset_length, from.length);
            int attr6Cursor0 = offset + offset_payload;
            if (from.payload == null) return false;
            int attr6Seq0Length = from.payload.Length;
            // Unbounded sequence: bounds check not required...
            if (attr6Seq0Type == IntPtr.Zero) {
                attr6Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::C_SEQUENCE<datarouter::Payload>");
            }
            IntPtr attr6Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr6Seq0Type, attr6Seq0Length);
            Write(to, attr6Cursor0, attr6Seq0Buf);
            attr6Cursor0 += 4;
            int attr6Cursor1 = 0;
            for (int i0 = 0; i0 < attr6Seq0Length; i0++) {
                if (!attr6Marshaler.CopyIn(basePtr, from.payload[i0], attr6Seq0Buf, attr6Cursor1)) return false;
                attr6Cursor1 += 1;
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
            AAMS_RFM_msg dataTo = to as AAMS_RFM_msg;
            if (dataTo == null) {
                dataTo = new AAMS_RFM_msg();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            dataTo.src = ReadUInt32(from, offset + offset_src);
            dataTo.addr = ReadUInt64(from, offset + offset_addr);
            dataTo.sec = ReadUInt32(from, offset + offset_sec);
            dataTo.usec = ReadUInt32(from, offset + offset_usec);
            dataTo.length = ReadUInt32(from, offset + offset_length);
            int attr6Cursor0 = offset + offset_payload;
            IntPtr attr6Seq0Buf = ReadIntPtr(from, attr6Cursor0);
            int attr6Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr6Seq0Buf);
            if (dataTo.payload == null || dataTo.payload.Length != attr6Seq0Length) {
                datarouter.Payload[] target = new datarouter.Payload[attr6Seq0Length];
                initObjectSeq(dataTo.payload, target);
                dataTo.payload = target as datarouter.Payload[];
            }
            attr6Cursor0 += 4;
            int attr6Cursor1 = 0;
            for (int i0 = 0; i0 < attr6Seq0Length; i0++) {
                object elementObj = dataTo.payload[i0];
                attr6Marshaler.CopyOut(attr6Seq0Buf, ref elementObj, attr6Cursor1);
                if (dataTo.payload[i0] == null) {
                    dataTo.payload[i0] = elementObj as datarouter.Payload;
                }
                attr6Cursor1 += 1;
            }
        }

    }
    #endregion

    #region __AAMS_RFM_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_RFM_Channel
    {
        public int id;
        public IntPtr msgs;
    }
    #endregion

    #region AAMS_RFM_ChannelMarshaler
    public sealed class AAMS_RFM_ChannelMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_RFM_Channel);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_msgs = (int)Marshal.OffsetOf(type, "msgs");

        private IntPtr attr1Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr1Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr1Marshaler == null) {
                attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.AAMS_RFM_msg));
                if (attr1Marshaler == null) {
                    attr1Marshaler = new datarouter.AAMS_RFM_msgMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.AAMS_RFM_msg), attr1Marshaler);
                    attr1Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_RFM_Channel[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_RFM_Channel from = untypedFrom as AAMS_RFM_Channel;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            int attr1Cursor0 = offset + offset_msgs;
            if (from.msgs == null) return false;
            int attr1Seq0Length = from.msgs.Length;
            // Unbounded sequence: bounds check not required...
            if (attr1Seq0Type == IntPtr.Zero) {
                attr1Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::AAMS_RFM_Channel::C_SEQUENCE<datarouter::AAMS_RFM_msg>");
            }
            IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Seq0Type, attr1Seq0Length);
            Write(to, attr1Cursor0, attr1Seq0Buf);
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                if (!attr1Marshaler.CopyIn(basePtr, from.msgs[i0], attr1Seq0Buf, attr1Cursor1)) return false;
                attr1Cursor1 += 32;
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
            AAMS_RFM_Channel dataTo = to as AAMS_RFM_Channel;
            if (dataTo == null) {
                dataTo = new AAMS_RFM_Channel();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            int attr1Cursor0 = offset + offset_msgs;
            IntPtr attr1Seq0Buf = ReadIntPtr(from, attr1Cursor0);
            int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
            if (dataTo.msgs == null || dataTo.msgs.Length != attr1Seq0Length) {
                datarouter.AAMS_RFM_msg[] target = new datarouter.AAMS_RFM_msg[attr1Seq0Length];
                initObjectSeq(dataTo.msgs, target);
                dataTo.msgs = target as datarouter.AAMS_RFM_msg[];
            }
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                object elementObj = dataTo.msgs[i0];
                attr1Marshaler.CopyOut(attr1Seq0Buf, ref elementObj, attr1Cursor1);
                if (dataTo.msgs[i0] == null) {
                    dataTo.msgs[i0] = elementObj as datarouter.AAMS_RFM_msg;
                }
                attr1Cursor1 += 32;
            }
        }

    }
    #endregion

    #region __HDLC_PARA
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __HDLC_PARA
    {
        public char slave_addr;
        public char type;
        public char control_order;
    }
    #endregion

    #region HDLC_PARAMarshaler
    public sealed class HDLC_PARAMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__HDLC_PARA);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_slave_addr = (int)Marshal.OffsetOf(type, "slave_addr");
        private static readonly int offset_type = (int)Marshal.OffsetOf(type, "type");
        private static readonly int offset_control_order = (int)Marshal.OffsetOf(type, "control_order");


        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new HDLC_PARA[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            HDLC_PARA from = untypedFrom as HDLC_PARA;
            if (from == null) return false;
            Write(to, offset + offset_slave_addr, from.slave_addr);
            Write(to, offset + offset_type, from.type);
            Write(to, offset + offset_control_order, from.control_order);
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
            HDLC_PARA dataTo = to as HDLC_PARA;
            if (dataTo == null) {
                dataTo = new HDLC_PARA();
                to = dataTo;
            }
            dataTo.slave_addr = ReadByte(from, offset + offset_slave_addr);
            dataTo.type = ReadByte(from, offset + offset_type);
            dataTo.control_order = ReadByte(from, offset + offset_control_order);
        }

    }
    #endregion

    #region __AAMS_HDLC_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_HDLC_msg
    {
        public int id;
        public int src;
        public int block_id;
        public int offset;
        public int reserved;
        public datarouter.__HDLC_PARA parse;
        public int sec;
        public int usec;
        public int length;
        public IntPtr payload;
    }
    #endregion

    #region AAMS_HDLC_msgMarshaler
    public sealed class AAMS_HDLC_msgMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_HDLC_msg);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_src = (int)Marshal.OffsetOf(type, "src");
        private static readonly int offset_block_id = (int)Marshal.OffsetOf(type, "block_id");
        private static readonly int offset_offset = (int)Marshal.OffsetOf(type, "offset");
        private static readonly int offset_reserved = (int)Marshal.OffsetOf(type, "reserved");
        private static readonly int offset_parse = (int)Marshal.OffsetOf(type, "parse");
        private static readonly int offset_sec = (int)Marshal.OffsetOf(type, "sec");
        private static readonly int offset_usec = (int)Marshal.OffsetOf(type, "usec");
        private static readonly int offset_length = (int)Marshal.OffsetOf(type, "length");
        private static readonly int offset_payload = (int)Marshal.OffsetOf(type, "payload");

        private DatabaseMarshaler attr5Marshaler;
        private IntPtr attr9Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr9Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr5Marshaler == null) {
                attr5Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.HDLC_PARA));
                if (attr5Marshaler == null) {
                    attr5Marshaler = new datarouter.HDLC_PARAMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.HDLC_PARA), attr5Marshaler);
                    attr5Marshaler.InitEmbeddedMarshalers(participant);
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
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_HDLC_msg[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_HDLC_msg from = untypedFrom as AAMS_HDLC_msg;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            Write(to, offset + offset_src, from.src);
            Write(to, offset + offset_block_id, from.block_id);
            Write(to, offset + offset_offset, from.offset);
            Write(to, offset + offset_reserved, from.reserved);
            if (!attr5Marshaler.CopyIn(basePtr, from.parse, to, offset + offset_parse)) return false;
            Write(to, offset + offset_sec, from.sec);
            Write(to, offset + offset_usec, from.usec);
            Write(to, offset + offset_length, from.length);
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
            AAMS_HDLC_msg dataTo = to as AAMS_HDLC_msg;
            if (dataTo == null) {
                dataTo = new AAMS_HDLC_msg();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            dataTo.src = ReadUInt32(from, offset + offset_src);
            dataTo.block_id = ReadUInt32(from, offset + offset_block_id);
            dataTo.offset = ReadUInt32(from, offset + offset_offset);
            dataTo.reserved = ReadUInt32(from, offset + offset_reserved);
            object attr5Val = dataTo.parse;
            attr5Marshaler.CopyOut(from, ref attr5Val, offset + offset_parse);
            if (dataTo.parse == null) {
                dataTo.parse = attr5Val as datarouter.HDLC_PARA;
            }
            dataTo.sec = ReadUInt32(from, offset + offset_sec);
            dataTo.usec = ReadUInt32(from, offset + offset_usec);
            dataTo.length = ReadUInt32(from, offset + offset_length);
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

    #region __AAMS_HDLC_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_HDLC_Channel
    {
        public int id;
        public IntPtr msgs;
    }
    #endregion

    #region AAMS_HDLC_ChannelMarshaler
    public sealed class AAMS_HDLC_ChannelMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_HDLC_Channel);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_msgs = (int)Marshal.OffsetOf(type, "msgs");

        private IntPtr attr1Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr1Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr1Marshaler == null) {
                attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.AAMS_HDLC_msg));
                if (attr1Marshaler == null) {
                    attr1Marshaler = new datarouter.AAMS_HDLC_msgMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.AAMS_HDLC_msg), attr1Marshaler);
                    attr1Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_HDLC_Channel[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_HDLC_Channel from = untypedFrom as AAMS_HDLC_Channel;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            int attr1Cursor0 = offset + offset_msgs;
            if (from.msgs == null) return false;
            int attr1Seq0Length = from.msgs.Length;
            // Unbounded sequence: bounds check not required...
            if (attr1Seq0Type == IntPtr.Zero) {
                attr1Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::AAMS_HDLC_Channel::C_SEQUENCE<datarouter::AAMS_HDLC_msg>");
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
            AAMS_HDLC_Channel dataTo = to as AAMS_HDLC_Channel;
            if (dataTo == null) {
                dataTo = new AAMS_HDLC_Channel();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            int attr1Cursor0 = offset + offset_msgs;
            IntPtr attr1Seq0Buf = ReadIntPtr(from, attr1Cursor0);
            int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
            if (dataTo.msgs == null || dataTo.msgs.Length != attr1Seq0Length) {
                datarouter.AAMS_HDLC_msg[] target = new datarouter.AAMS_HDLC_msg[attr1Seq0Length];
                initObjectSeq(dataTo.msgs, target);
                dataTo.msgs = target as datarouter.AAMS_HDLC_msg[];
            }
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                object elementObj = dataTo.msgs[i0];
                attr1Marshaler.CopyOut(attr1Seq0Buf, ref elementObj, attr1Cursor1);
                if (dataTo.msgs[i0] == null) {
                    dataTo.msgs[i0] = elementObj as datarouter.AAMS_HDLC_msg;
                }
                attr1Cursor1 += 40;
            }
        }

    }
    #endregion

    #region __Eth_PARA
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __Eth_PARA
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=6)]
        public char[] src_mac;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=6)]
        public char[] dst_mac;
        public int src_ip;
        public int dst_ip;
        public short src_port;
        public short dst_port;
    }
    #endregion

    #region Eth_PARAMarshaler
    public sealed class Eth_PARAMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__Eth_PARA);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_src_mac = (int)Marshal.OffsetOf(type, "src_mac");
        private static readonly int offset_dst_mac = (int)Marshal.OffsetOf(type, "dst_mac");
        private static readonly int offset_src_ip = (int)Marshal.OffsetOf(type, "src_ip");
        private static readonly int offset_dst_ip = (int)Marshal.OffsetOf(type, "dst_ip");
        private static readonly int offset_src_port = (int)Marshal.OffsetOf(type, "src_port");
        private static readonly int offset_dst_port = (int)Marshal.OffsetOf(type, "dst_port");


        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new Eth_PARA[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            Eth_PARA from = untypedFrom as Eth_PARA;
            if (from == null) return false;
            int attr0Cursor0 = offset + offset_src_mac;
            for (int i0 = 0; i0 < 6; i0++) {
                Write(to, attr0Cursor0, from.src_mac[i0]);
                attr0Cursor0 += 1;
            }
            int attr1Cursor0 = offset + offset_dst_mac;
            for (int i0 = 0; i0 < 6; i0++) {
                Write(to, attr1Cursor0, from.dst_mac[i0]);
                attr1Cursor0 += 1;
            }
            Write(to, offset + offset_src_ip, from.src_ip);
            Write(to, offset + offset_dst_ip, from.dst_ip);
            Write(to, offset + offset_src_port, from.src_port);
            Write(to, offset + offset_dst_port, from.dst_port);
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
            Eth_PARA dataTo = to as Eth_PARA;
            if (dataTo == null) {
                dataTo = new Eth_PARA();
                to = dataTo;
            }
            int attr0Cursor0 = offset + offset_src_mac;
            if (dataTo.src_mac == null || dataTo.src_mac.GetLength(0) != 6) {
                dataTo.src_mac = new byte[6];
            }
            for (int i0 = 0; i0 < 6; i0++) {
                dataTo.src_mac[i0] = ReadByte(from, attr0Cursor0);
                attr0Cursor0 += 1;
            }
            int attr1Cursor0 = offset + offset_dst_mac;
            if (dataTo.dst_mac == null || dataTo.dst_mac.GetLength(0) != 6) {
                dataTo.dst_mac = new byte[6];
            }
            for (int i0 = 0; i0 < 6; i0++) {
                dataTo.dst_mac[i0] = ReadByte(from, attr1Cursor0);
                attr1Cursor0 += 1;
            }
            dataTo.src_ip = ReadUInt32(from, offset + offset_src_ip);
            dataTo.dst_ip = ReadUInt32(from, offset + offset_dst_ip);
            dataTo.src_port = ReadUInt16(from, offset + offset_src_port);
            dataTo.dst_port = ReadUInt16(from, offset + offset_dst_port);
        }

    }
    #endregion

    #region __AAMS_Eth_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_Eth_msg
    {
        public int id;
        public datarouter.__Eth_PARA parameter;
        public int sec;
        public int usec;
        public int length;
        public IntPtr payload;
    }
    #endregion

    #region AAMS_Eth_msgMarshaler
    public sealed class AAMS_Eth_msgMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_Eth_msg);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_parameter = (int)Marshal.OffsetOf(type, "parameter");
        private static readonly int offset_sec = (int)Marshal.OffsetOf(type, "sec");
        private static readonly int offset_usec = (int)Marshal.OffsetOf(type, "usec");
        private static readonly int offset_length = (int)Marshal.OffsetOf(type, "length");
        private static readonly int offset_payload = (int)Marshal.OffsetOf(type, "payload");

        private DatabaseMarshaler attr1Marshaler;
        private IntPtr attr5Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr5Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr1Marshaler == null) {
                attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Eth_PARA));
                if (attr1Marshaler == null) {
                    attr1Marshaler = new datarouter.Eth_PARAMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Eth_PARA), attr1Marshaler);
                    attr1Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
            if (attr5Marshaler == null) {
                attr5Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.Payload));
                if (attr5Marshaler == null) {
                    attr5Marshaler = new datarouter.PayloadMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.Payload), attr5Marshaler);
                    attr5Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_Eth_msg[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_Eth_msg from = untypedFrom as AAMS_Eth_msg;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            if (!attr1Marshaler.CopyIn(basePtr, from.parameter, to, offset + offset_parameter)) return false;
            Write(to, offset + offset_sec, from.sec);
            Write(to, offset + offset_usec, from.usec);
            Write(to, offset + offset_length, from.length);
            int attr5Cursor0 = offset + offset_payload;
            if (from.payload == null) return false;
            int attr5Seq0Length = from.payload.Length;
            // Unbounded sequence: bounds check not required...
            if (attr5Seq0Type == IntPtr.Zero) {
                attr5Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::C_SEQUENCE<datarouter::Payload>");
            }
            IntPtr attr5Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr5Seq0Type, attr5Seq0Length);
            Write(to, attr5Cursor0, attr5Seq0Buf);
            attr5Cursor0 += 4;
            int attr5Cursor1 = 0;
            for (int i0 = 0; i0 < attr5Seq0Length; i0++) {
                if (!attr5Marshaler.CopyIn(basePtr, from.payload[i0], attr5Seq0Buf, attr5Cursor1)) return false;
                attr5Cursor1 += 1;
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
            AAMS_Eth_msg dataTo = to as AAMS_Eth_msg;
            if (dataTo == null) {
                dataTo = new AAMS_Eth_msg();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            object attr1Val = dataTo.parameter;
            attr1Marshaler.CopyOut(from, ref attr1Val, offset + offset_parameter);
            if (dataTo.parameter == null) {
                dataTo.parameter = attr1Val as datarouter.Eth_PARA;
            }
            dataTo.sec = ReadUInt32(from, offset + offset_sec);
            dataTo.usec = ReadUInt32(from, offset + offset_usec);
            dataTo.length = ReadUInt32(from, offset + offset_length);
            int attr5Cursor0 = offset + offset_payload;
            IntPtr attr5Seq0Buf = ReadIntPtr(from, attr5Cursor0);
            int attr5Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr5Seq0Buf);
            if (dataTo.payload == null || dataTo.payload.Length != attr5Seq0Length) {
                datarouter.Payload[] target = new datarouter.Payload[attr5Seq0Length];
                initObjectSeq(dataTo.payload, target);
                dataTo.payload = target as datarouter.Payload[];
            }
            attr5Cursor0 += 4;
            int attr5Cursor1 = 0;
            for (int i0 = 0; i0 < attr5Seq0Length; i0++) {
                object elementObj = dataTo.payload[i0];
                attr5Marshaler.CopyOut(attr5Seq0Buf, ref elementObj, attr5Cursor1);
                if (dataTo.payload[i0] == null) {
                    dataTo.payload[i0] = elementObj as datarouter.Payload;
                }
                attr5Cursor1 += 1;
            }
        }

    }
    #endregion

    #region __AAMS_Eth_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_Eth_Channel
    {
        public int id;
        public IntPtr msgs;
    }
    #endregion

    #region AAMS_Eth_ChannelMarshaler
    public sealed class AAMS_Eth_ChannelMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_Eth_Channel);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_msgs = (int)Marshal.OffsetOf(type, "msgs");

        private IntPtr attr1Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr1Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr1Marshaler == null) {
                attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.AAMS_Eth_msg));
                if (attr1Marshaler == null) {
                    attr1Marshaler = new datarouter.AAMS_Eth_msgMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.AAMS_Eth_msg), attr1Marshaler);
                    attr1Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_Eth_Channel[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_Eth_Channel from = untypedFrom as AAMS_Eth_Channel;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            int attr1Cursor0 = offset + offset_msgs;
            if (from.msgs == null) return false;
            int attr1Seq0Length = from.msgs.Length;
            // Unbounded sequence: bounds check not required...
            if (attr1Seq0Type == IntPtr.Zero) {
                attr1Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::AAMS_Eth_Channel::C_SEQUENCE<datarouter::AAMS_Eth_msg>");
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
            AAMS_Eth_Channel dataTo = to as AAMS_Eth_Channel;
            if (dataTo == null) {
                dataTo = new AAMS_Eth_Channel();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            int attr1Cursor0 = offset + offset_msgs;
            IntPtr attr1Seq0Buf = ReadIntPtr(from, attr1Cursor0);
            int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
            if (dataTo.msgs == null || dataTo.msgs.Length != attr1Seq0Length) {
                datarouter.AAMS_Eth_msg[] target = new datarouter.AAMS_Eth_msg[attr1Seq0Length];
                initObjectSeq(dataTo.msgs, target);
                dataTo.msgs = target as datarouter.AAMS_Eth_msg[];
            }
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                object elementObj = dataTo.msgs[i0];
                attr1Marshaler.CopyOut(attr1Seq0Buf, ref elementObj, attr1Cursor1);
                if (dataTo.msgs[i0] == null) {
                    dataTo.msgs[i0] = elementObj as datarouter.AAMS_Eth_msg;
                }
                attr1Cursor1 += 44;
            }
        }

    }
    #endregion

    #region __AAMS_IMBADB_msg
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_IMBADB_msg
    {
        public int id;
        public int src;
        public int type;
        public int label;
        public int err;
        public int crc;
        public int sec;
        public int usec;
        public IntPtr payload;
    }
    #endregion

    #region AAMS_IMBADB_msgMarshaler
    public sealed class AAMS_IMBADB_msgMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_IMBADB_msg);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_src = (int)Marshal.OffsetOf(type, "src");
        private static readonly int offset_type = (int)Marshal.OffsetOf(type, "type");
        private static readonly int offset_label = (int)Marshal.OffsetOf(type, "label");
        private static readonly int offset_err = (int)Marshal.OffsetOf(type, "err");
        private static readonly int offset_crc = (int)Marshal.OffsetOf(type, "crc");
        private static readonly int offset_sec = (int)Marshal.OffsetOf(type, "sec");
        private static readonly int offset_usec = (int)Marshal.OffsetOf(type, "usec");
        private static readonly int offset_payload = (int)Marshal.OffsetOf(type, "payload");

        private IntPtr attr8Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr8Marshaler;

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
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_IMBADB_msg[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_IMBADB_msg from = untypedFrom as AAMS_IMBADB_msg;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            Write(to, offset + offset_src, from.src);
            Write(to, offset + offset_type, from.type);
            Write(to, offset + offset_label, from.label);
            Write(to, offset + offset_err, from.err);
            Write(to, offset + offset_crc, from.crc);
            Write(to, offset + offset_sec, from.sec);
            Write(to, offset + offset_usec, from.usec);
            int attr8Cursor0 = offset + offset_payload;
            if (from.payload == null) return false;
            int attr8Seq0Length = from.payload.Length;
            // Unbounded sequence: bounds check not required...
            if (attr8Seq0Type == IntPtr.Zero) {
                attr8Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::C_SEQUENCE<datarouter::Payload>");
            }
            IntPtr attr8Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr8Seq0Type, attr8Seq0Length);
            Write(to, attr8Cursor0, attr8Seq0Buf);
            attr8Cursor0 += 4;
            int attr8Cursor1 = 0;
            for (int i0 = 0; i0 < attr8Seq0Length; i0++) {
                if (!attr8Marshaler.CopyIn(basePtr, from.payload[i0], attr8Seq0Buf, attr8Cursor1)) return false;
                attr8Cursor1 += 1;
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
            AAMS_IMBADB_msg dataTo = to as AAMS_IMBADB_msg;
            if (dataTo == null) {
                dataTo = new AAMS_IMBADB_msg();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            dataTo.src = ReadUInt32(from, offset + offset_src);
            dataTo.type = ReadUInt32(from, offset + offset_type);
            dataTo.label = ReadUInt32(from, offset + offset_label);
            dataTo.err = ReadUInt32(from, offset + offset_err);
            dataTo.crc = ReadUInt32(from, offset + offset_crc);
            dataTo.sec = ReadUInt32(from, offset + offset_sec);
            dataTo.usec = ReadUInt32(from, offset + offset_usec);
            int attr8Cursor0 = offset + offset_payload;
            IntPtr attr8Seq0Buf = ReadIntPtr(from, attr8Cursor0);
            int attr8Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr8Seq0Buf);
            if (dataTo.payload == null || dataTo.payload.Length != attr8Seq0Length) {
                datarouter.Payload[] target = new datarouter.Payload[attr8Seq0Length];
                initObjectSeq(dataTo.payload, target);
                dataTo.payload = target as datarouter.Payload[];
            }
            attr8Cursor0 += 4;
            int attr8Cursor1 = 0;
            for (int i0 = 0; i0 < attr8Seq0Length; i0++) {
                object elementObj = dataTo.payload[i0];
                attr8Marshaler.CopyOut(attr8Seq0Buf, ref elementObj, attr8Cursor1);
                if (dataTo.payload[i0] == null) {
                    dataTo.payload[i0] = elementObj as datarouter.Payload;
                }
                attr8Cursor1 += 1;
            }
        }

    }
    #endregion

    #region __AAMS_IMBADB_Channel
    [StructLayout(LayoutKind.Sequential)]
    public sealed class __AAMS_IMBADB_Channel
    {
        public int id;
        public IntPtr msgs;
    }
    #endregion

    #region AAMS_IMBADB_ChannelMarshaler
    public sealed class AAMS_IMBADB_ChannelMarshaler : DDS.OpenSplice.CustomMarshalers.DatabaseMarshaler
    {
        private static readonly Type type = typeof(__AAMS_IMBADB_Channel);
        public static readonly int Size = Marshal.SizeOf(type);

        private static readonly int offset_id = (int)Marshal.OffsetOf(type, "id");
        private static readonly int offset_msgs = (int)Marshal.OffsetOf(type, "msgs");

        private IntPtr attr1Seq0Type = IntPtr.Zero;
        private DatabaseMarshaler attr1Marshaler;

        public override void InitEmbeddedMarshalers(IDomainParticipant participant)
        {
            if (attr1Marshaler == null) {
                attr1Marshaler = DatabaseMarshaler.GetMarshaler(participant, typeof(datarouter.AAMS_IMBADB_msg));
                if (attr1Marshaler == null) {
                    attr1Marshaler = new datarouter.AAMS_IMBADB_msgMarshaler();
                    DatabaseMarshaler.Add(participant, typeof(datarouter.AAMS_IMBADB_msg), attr1Marshaler);
                    attr1Marshaler.InitEmbeddedMarshalers(participant);
                }
            }
        }

        public override object[] SampleReaderAlloc(int length)
        {
            return new AAMS_IMBADB_Channel[length];
        }

        public override bool CopyIn(System.IntPtr basePtr, System.IntPtr from, System.IntPtr to)
        {
            GCHandle tmpGCHandle = GCHandle.FromIntPtr(from);
            object fromData = tmpGCHandle.Target;
            return CopyIn(basePtr, fromData, to, 0);
        }

        public override bool CopyIn(System.IntPtr basePtr, object untypedFrom, System.IntPtr to, int offset)
        {
            AAMS_IMBADB_Channel from = untypedFrom as AAMS_IMBADB_Channel;
            if (from == null) return false;
            Write(to, offset + offset_id, from.id);
            int attr1Cursor0 = offset + offset_msgs;
            if (from.msgs == null) return false;
            int attr1Seq0Length = from.msgs.Length;
            // Unbounded sequence: bounds check not required...
            if (attr1Seq0Type == IntPtr.Zero) {
                attr1Seq0Type = DDS.OpenSplice.Database.c.resolve(basePtr, "datarouter::AAMS_IMBADB_Channel::C_SEQUENCE<datarouter::AAMS_IMBADB_msg>");
            }
            IntPtr attr1Seq0Buf = DDS.OpenSplice.Database.c.newSequence(attr1Seq0Type, attr1Seq0Length);
            Write(to, attr1Cursor0, attr1Seq0Buf);
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                if (!attr1Marshaler.CopyIn(basePtr, from.msgs[i0], attr1Seq0Buf, attr1Cursor1)) return false;
                attr1Cursor1 += 36;
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
            AAMS_IMBADB_Channel dataTo = to as AAMS_IMBADB_Channel;
            if (dataTo == null) {
                dataTo = new AAMS_IMBADB_Channel();
                to = dataTo;
            }
            dataTo.id = ReadUInt32(from, offset + offset_id);
            int attr1Cursor0 = offset + offset_msgs;
            IntPtr attr1Seq0Buf = ReadIntPtr(from, attr1Cursor0);
            int attr1Seq0Length = DDS.OpenSplice.Database.c.arraySize(attr1Seq0Buf);
            if (dataTo.msgs == null || dataTo.msgs.Length != attr1Seq0Length) {
                datarouter.AAMS_IMBADB_msg[] target = new datarouter.AAMS_IMBADB_msg[attr1Seq0Length];
                initObjectSeq(dataTo.msgs, target);
                dataTo.msgs = target as datarouter.AAMS_IMBADB_msg[];
            }
            attr1Cursor0 += 4;
            int attr1Cursor1 = 0;
            for (int i0 = 0; i0 < attr1Seq0Length; i0++) {
                object elementObj = dataTo.msgs[i0];
                attr1Marshaler.CopyOut(attr1Seq0Buf, ref elementObj, attr1Cursor1);
                if (dataTo.msgs[i0] == null) {
                    dataTo.msgs[i0] = elementObj as datarouter.AAMS_IMBADB_msg;
                }
                attr1Cursor1 += 36;
            }
        }

    }
    #endregion

}

