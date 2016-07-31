using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using datarouter;

namespace ESPHelper.DDSInc
{
     [StructLayout(LayoutKind.Sequential)]
    public class EventMsg
    {
        public uint event_id = 0;
        public uint time;
        public uint nodeId = 0;
        public string name = string.Empty;
        public string type = string.Empty;
        public datarouter.Node info = new datarouter.Node();

        public EventMsg(EVENT_msg msg)
        {
            this.event_id = msg.event_id;
            this.name = msg.name;
            this.nodeId = msg.nodeId;
            this.type = msg.type;
            this.info = msg.info;
        }
        public System.TimeSpan Time
        {
            get;
            set;
        }
        public int DTime { get; set; }
        public uint ServiceId
        {
            get { return event_id; }
            set { event_id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public uint NodeId
        {
            get { return nodeId; }
            set { nodeId = value; }
        }

        public object Payload
        {
            get
            {
                return null;
            }
        }
    }
}
