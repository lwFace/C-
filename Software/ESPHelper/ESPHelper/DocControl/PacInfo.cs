using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESPHelper.DocControl
{
    public enum PacType { 模拟量=0,离散量=1,数据块=2};
    public class PacInfo
    {
        string name;
       int length;
       int ddsKey;
       byte discrete;
       double analog;
       byte[] payload;
       PacType type;
       public PacInfo(string name)
       {
           this.name = name;
           this.analog = 0;
           this.discrete = 0;
           this.payload = new byte[1];
       }
        public PacType Type
       {
           get { return type; }
           set { type = value; }
       }
        public byte Discrete
        {
            get { return discrete; }
            set { discrete = value; }
        }
        public double Analog
        {
            get { return analog; }
            set { analog = value; }
          }
        public string Name
       {
           get { return name; }
           set { name = value; }
        }
        public int Length
        {
           get { return length; }
           set { length = value; }
        }

        public int DDSKey
        {
            get { return ddsKey; }
            set{ddsKey = value;}
        }

        public byte[] Payload
        {
            get { return payload; }
            set { payload = value; }
        }
    }
}
