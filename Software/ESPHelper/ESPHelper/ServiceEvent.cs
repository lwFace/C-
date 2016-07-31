using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESPHelper
{
    public class ServiceEvent
    {
        bool selected;
        int id;
        public string IOR;
        string name;
        string version;
        string statusMsg;
        int status;
       // string type;

        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ServiceID
        {
            get { return id; }
            set { id = value; }
        }
//         public string Type
//         {
//             get { return type; }
//             set { type = value; }
//         }
        public string StatusMsg
        {
            get { return statusMsg; }
            set { statusMsg = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Version
        {
            get { return version; }
            set { version = value; }
        }        
//         public string IOR
//         {
//             get { return ior; }
//             set { ior = value; }
//         }
       
    }
}
