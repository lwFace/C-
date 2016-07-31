using System;
using System.Threading;

namespace com.hirain.avionics.healthmanager.dds.client
{



    public class ClientDDSData : com.hirain.avionics.healthmanager.dds.DDSData
    {

        private const string ATTR_HOST = "host";

        private const string ATTR_SERVICES = "services";

        private const string TAG_CLIENT_INFO = "ClientInfo";

        protected internal int[] services;

        protected internal int hostId;

        public ClientDDSData(int time, int id, string name, int type, string version, string[] configs, int status, string statusMsg, string ior, int[] services, int hostId)
            : base(time, id, name, type, version, configs, status, statusMsg, ior)
        {
            this.services = services;
            this.hostId = hostId;
        }

        public ClientDDSData(datarouter.EVENT_msg msg)
            : base(msg)
        {
            datarouter.Node[] clientInfo = findChild(msg.info, TAG_CLIENT_INFO);
            if (clientInfo.Length == 1)
            {
                parse(clientInfo[0]);
            }
        }

        public virtual int[] Services
        {
            set
            {
                this.services = value;
            }
            get
            {
                return services;
            }
        }

        public virtual int HostId
        {
            set
            {
                this.hostId = value;
            }
            get
            {
                return hostId;
            }
        }

        public override datarouter.EVENT_msg toEventMsg()
        {
            datarouter.EVENT_msg msg = base.toEventMsg();
            msg.type = TYPE_CLIENT;
            datarouter.Node info = msg.info;
            datarouter.Node clientInfo = new datarouter.Node();
            clientInfo.name = ClientDDSData.TAG_CLIENT_INFO;
            string str = intarray2string(services);
            setAttribute(clientInfo, ClientDDSData.ATTR_SERVICES, str);
            setAttribute(clientInfo, ClientDDSData.ATTR_HOST, hostId + "");
            appendChild(info, clientInfo);
            return msg;
        }

        public virtual void parse(datarouter.Node client)
        {
            hostId = Convert.ToInt32(getAttribute(client, ATTR_HOST));
            string str = getAttribute(client, ATTR_SERVICES);
            services = string2intarray(str);
        }

        public override void clone(com.hirain.avionics.healthmanager.dds.DDSData data)
        {
            base.clone(data);
            this.hostId = ((ClientDDSData)data).hostId;
            this.services = ((ClientDDSData)data).services;
        }




    }
}