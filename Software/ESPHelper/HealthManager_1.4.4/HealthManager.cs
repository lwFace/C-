using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Threading;
using com.hirain.avionics.healthmanager.dds;
using System;
using System.Net;
using com.hirain.avionics.healthmanager.igmp;
using datarouter;

namespace com.hirain.avionics.healthmanager
{
    public class HealthManager
    {
        // public static final int DEAD_NODE = DDSData.STATUS_OFFLINE;
        private const string STATUS_DEAD = "timeout";

        public const int NEW_STYLE_SIM_MODEL = 1;

        public const int NEW_STYLE_DEVICE_CONTROL = 2;

        public const int NEW_STYLE_CARD_CONTROL = 4;

        public const int NEW_STYLE_PATCH_DEVICE_CONTROL = 8;

        public const int NEW_STYLE_PATCH_CARD_CONTROL = 16;

        public const int NEW_STYLE_STORAGE = 32;

        public const int NEW_STYLE_PTPD = 64;

        public const int NEW_STYLE_CPM = 128;

        public static readonly int NEW_STYLE_CLIENT_ITB = 1 << 20;

        public static readonly int NEW_STYLE_CLIENT_PSS = 1 << 21;

        public static readonly int NEW_STYLE_CLIENT_MATRIX = 1 << 22;

        public static readonly int NEW_STYLE_CLIENT_AUTOTEST = 1 << 23;

        public const int STYLE_FLY_SIM = NEW_STYLE_SIM_MODEL;

        public const int STYLE_AVIONICS_SIM = NEW_STYLE_SIM_MODEL;

        public const int STYLE_NON_AVIONICS_SIM = NEW_STYLE_SIM_MODEL;

        public const int STYLE_AFDX_SIM = NEW_STYLE_DEVICE_CONTROL;

        public const int STYLE_INTEGRATE_429 = NEW_STYLE_DEVICE_CONTROL;

        public const int STYLE_IO_ROUTER = NEW_STYLE_CARD_CONTROL;

        public const int STYLE_IO_COLLECTOR = NEW_STYLE_CARD_CONTROL;

        public const int STYLE_STORAGE = NEW_STYLE_STORAGE;

        public const int STYLE_AFDX_COLLECTOR = NEW_STYLE_DEVICE_CONTROL;

        public const int STYLE_AFDX_MATRIX = NEW_STYLE_PATCH_DEVICE_CONTROL;

        public const int STYLE_POWER_MANAGER = NEW_STYLE_PATCH_CARD_CONTROL;

        public const int STYLE_NONAFDX_MATRIX = NEW_STYLE_PATCH_CARD_CONTROL;

        public const int STYLE_RDC_CAN = NEW_STYLE_DEVICE_CONTROL;

        public const int STYLE_COMMON_RDC = NEW_STYLE_DEVICE_CONTROL;

        public static readonly int STYLE_CLIENT_MATRIX = NEW_STYLE_CLIENT_MATRIX;

        public static readonly int STYLE_CLIENT_MONITOR = NEW_STYLE_CLIENT_ITB;

        public static readonly int STYLE_CLIENT_ROUTER = NEW_STYLE_CLIENT_ITB;

        public static readonly int STYLE_CLIENT_HISIMX = NEW_STYLE_CLIENT_PSS;

        public static readonly int STYLE_CLIENT_FLYSIM = NEW_STYLE_CLIENT_PSS;

        public static readonly int STYLE_CLIENT_AUTOTEST = NEW_STYLE_CLIENT_AUTOTEST;

        public static readonly int STYLE_INTEGRATE_CONTROL = NEW_STYLE_CLIENT_ITB;

        public const int STYLE_NONE = 0;

        public static readonly int STYLE_ALL_SRVER = NEW_STYLE_SIM_MODEL | NEW_STYLE_DEVICE_CONTROL | NEW_STYLE_CARD_CONTROL | NEW_STYLE_PATCH_DEVICE_CONTROL | NEW_STYLE_PATCH_CARD_CONTROL | NEW_STYLE_PTPD | NEW_STYLE_CPM | NEW_STYLE_STORAGE;

        public static readonly int STYLE_ALL_CLIENT = NEW_STYLE_CLIENT_ITB | NEW_STYLE_CLIENT_PSS | NEW_STYLE_CLIENT_MATRIX | NEW_STYLE_CLIENT_AUTOTEST;

        public static readonly int STYLE_ALL = STYLE_ALL_SRVER | STYLE_ALL_CLIENT;

        public static readonly int STATUS_MASK = 1 << 31;

        private int fStyle;

        // private TimerTask writeTask;

        private IDictionary<int?, IList<com.hirain.avionics.healthmanager.dds.DDSData>> fListMap;

        private List<MessageEventListener> fMessageListeners = new List<HealthManager.MessageEventListener>();

        private List<IStatusChangeListener> statusChangeListeners = new List<IStatusChangeListener>();

        private List<DDSData> statusDaemonNodes = new List<com.hirain.avionics.healthmanager.dds.DDSData>();

        private Timer fTimer;
        private int timecount = 0;

        public static int defaultTimeout = 7000;

        private bool isWindows = false;
       
        internal class StatusEventListener : IEventListener
        {
            private readonly HealthManager outerInstance;

            internal IList<com.hirain.avionics.healthmanager.dds.DDSData> serverlist;

            internal int id;

            public StatusEventListener(HealthManager outerInstance, int id, IList<com.hirain.avionics.healthmanager.dds.DDSData> sl)
            {
                this.outerInstance = outerInstance;
                this.id = id | STATUS_MASK;
                this.serverlist = sl;
            }

            public  int ID
            {
                get
                {
                    return id;
                }
            }

            public  void handleMsgs(EVENT_msg msg)
            {
                if (msg == null)
                {
                    return;
                }

                if (msg.name == null || msg.type == null)
                {
                    return;
                }

                com.hirain.avionics.healthmanager.dds.DDSData newNode = com.hirain.avionics.healthmanager.dds.DDSData.newInstance(msg);
                bool statusChanged = false;
                int oldStatus = 0;
                string oldStatusStr = "";
                int newStatus = newNode.Status;
                string newStatusStr = newNode.StatusMsg;
                if (serverlist.Contains(newNode))
                {
                    int index = serverlist.IndexOf(newNode);
                    com.hirain.avionics.healthmanager.dds.DDSData node = serverlist[index];
                    DateTime d1 = DateTime.Now;
                    DateTime d2 = new DateTime(1970, 1, 1);
                    node.daemonTime = (long)d1.Subtract(d2).TotalMilliseconds;
                    oldStatus = node.Status;
                    oldStatusStr = node.StatusMsg;

                    if (oldStatus != newStatus || !oldStatusStr.Equals(newStatusStr))
                    {
                        statusChanged = true;
                    }
                    node.clone(newNode);

                }
                else
                {
                    oldStatus = DDSData.STATUS_OFFLINE;
                    DateTime d2 = new DateTime(1970, 1, 1);
                    double d = DateTime.Now.Subtract(d2).TotalMilliseconds;
                    newNode.daemonTime = (int)d;
                    serverlist.Add(newNode);
                    statusChanged = true;
                }

                if (!outerInstance.statusDaemonNodes.Contains(newNode))
                {
                    outerInstance.statusDaemonNodes.Add(newNode);
                }
                if (statusChanged)
                {
                    outerInstance.notifyStatusChange(oldStatus, newStatus, newNode);
                }
            }
        }

        internal class MessageEventListener : IEventListener
        {
            private readonly HealthManager outerInstance;
            internal MessageReceiveListener listener;

            internal List<datarouter.EVENT_msg> msgs;

            public MessageEventListener(HealthManager outerInstance, MessageReceiveListener listener)
            {
                this.outerInstance = outerInstance;
                this.listener = listener;
                msgs = new List<datarouter.EVENT_msg>();
            }

            public int ID
            {
                get
                {
                    return listener.eventID();
                }
            }

            public void handleMsgs(EVENT_msg msg)
            {
                // messageMap.put(id, msg);
                msgs.Add(msg);
            }

        }

        /// <summary>
        /// ���췽����
        /// </summary>
        /// <param name="style">
        ///          ���STYLE�Ļ�ֵ�� </param>
        public HealthManager(int style)
        {
            this.fStyle = style;

                try
                {
                    string hostName = Dns.GetHostName();//������ 
                    IPAddress[] addressList = Dns.GetHostAddresses(hostName);
                    string localAddr = addressList[0].ToString();
                    IGMPManager.joinGroup(localAddr, "239.255.0.1");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    Console.Write(e.StackTrace);
                }
        }

        public virtual int startDDS()
        {
            return startDDS(fStyle);
        }
        void Excute(object obj)
        {
            timecount++;
            if (defaultTimeout / 500 == timecount)
            {
                timecount = 0;
                DateTime d1 = DateTime.Now;
                DateTime d2 = new DateTime(1970, 1, 1);
                long now = (long)d1.Subtract(d2).TotalMilliseconds;
                Object[] nodes = statusDaemonNodes.ToArray();
                for (int i = 0; i < nodes.Length; i++)
                {
                    DDSData node = (DDSData)nodes[i];
                    long delay = now - node.daemonTime;
                    if (delay > defaultTimeout && node.Status != DDSData.STATUS_OFFLINE)
                    {
                        int oldStatus = node.Status;
                        node.Status = DDSData.STATUS_OFFLINE;
                        node.StatusMsg = STATUS_DEAD;
                        notifyStatusChange(oldStatus, DDSData.STATUS_OFFLINE, node);
                        statusDaemonNodes.Remove(node);
                        getList(node.Type).Remove(node);
                    }
                }
            }

            MessageEventListener[] listeners = fMessageListeners.ToArray();
            foreach (MessageEventListener listener in listeners)
            {
                EVENT_msg[] msgs = listener.msgs.ToArray();
            	listener.msgs.Clear();
            	listener.listener.handleMessage(msgs);
            }
            
        }
        public virtual int startDDS(int style)
        {
            DDSEventControler.init();

            addEventListeners(style);

            int rtcode = DDSEventControler.startMonitor();

            if (fTimer == null)
            {
                fTimer = new Timer(Excute, null, 0, 500);
                startStatusDaemonTimer();
                startMessageTimer();
            }
            // if (isWindows) {
            // IGMPManager.start();
            // }
            return rtcode;
        }

        private void startStatusDaemonTimer()
        {
          
        }

        private void startMessageTimer()
        {
            
        }

        private void addListener(int style)
        {
            List<com.hirain.avionics.healthmanager.dds.DDSData> list = new List<com.hirain.avionics.healthmanager.dds.DDSData>();
            DDSEventControler.addListener(new StatusEventListener(this, style, list));
            fListMap[style] = list;
        }

        private void addEventListeners(int style)
        {
            fListMap = new Dictionary<int?, IList<com.hirain.avionics.healthmanager.dds.DDSData>>();

            if ((style & NEW_STYLE_DEVICE_CONTROL) != 0)
            {
                addListener(NEW_STYLE_DEVICE_CONTROL);
            }
            if ((style & NEW_STYLE_CARD_CONTROL) != 0)
            {
                addListener(NEW_STYLE_CARD_CONTROL);
            }
            if ((style & NEW_STYLE_PATCH_CARD_CONTROL) != 0)
            {
                addListener(NEW_STYLE_PATCH_CARD_CONTROL);
            }
            if ((style & NEW_STYLE_PATCH_DEVICE_CONTROL) != 0)
            {
                addListener(NEW_STYLE_PATCH_DEVICE_CONTROL);
            }
            if ((style & NEW_STYLE_SIM_MODEL) != 0)
            {
                addListener(NEW_STYLE_SIM_MODEL);
            }
            if ((style & NEW_STYLE_STORAGE) != 0)
            {
                addListener(NEW_STYLE_STORAGE);
            }
            if ((style & NEW_STYLE_PTPD) != 0)
            {
                addListener(NEW_STYLE_PTPD);
            }
            if ((style & NEW_STYLE_CPM) != 0)
            {
                addListener(NEW_STYLE_CPM);
            }
            if ((style & NEW_STYLE_CLIENT_ITB) != 0)
            {
                addListener(NEW_STYLE_CLIENT_ITB);
            }
            if ((style & NEW_STYLE_CLIENT_PSS) != 0)
            {
                addListener(NEW_STYLE_CLIENT_PSS);
            }
            if ((style & NEW_STYLE_CLIENT_MATRIX) != 0)
            {
                addListener(NEW_STYLE_CLIENT_MATRIX);
            }
            if ((style & NEW_STYLE_CLIENT_AUTOTEST) != 0)
            {
                addListener(NEW_STYLE_CLIENT_AUTOTEST);
            }
        }

//         public virtual void addMessageListeners(MessageReceiveListener listener)
//         {            
//             if (!fMessageListeners.Contains(listener))
//             {
//                 MessageEventListener lis = new MessageEventListener(this, listener);
//                 DDSEventControler.addListener(lis);
//                 fMessageListeners.Add(lis);
//             }
//         }

        private IList<com.hirain.avionics.healthmanager.dds.DDSData> getList(int style)
        {
            return fListMap[style];
        }

        public virtual int broadcastStatus(com.hirain.avionics.healthmanager.dds.DDSData data)
        {
            return DDSEventControler.write(data.toEventMsg());
        }

        /// <summary>
        /// ֹͣDDS��������ع��ߣ���ȫ�˳���?
        /// </summary>
        /// <exception cref="InterruptedException"> </exception>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public virtual void stopDDS()
        {
            fTimer.Dispose();
            fTimer = null;
            DDSData[] nodes = statusDaemonNodes.ToArray();
            foreach (com.hirain.avionics.healthmanager.dds.DDSData node in nodes)
            {
                node.Status = com.hirain.avionics.healthmanager.dds.DDSData.STATUS_OFFLINE;
                node.StatusMsg = "DDS stopped";
                notifyStatusChange(node.Status, com.hirain.avionics.healthmanager.dds.DDSData.STATUS_OFFLINE, node);
                statusDaemonNodes.Remove(node);
            }
            DDSEventControler.stopMonitor();
            // if (isWindows) {
            // IGMPManager.stop();
            // }
        }

        public virtual void sendMessage(com.hirain.avionics.healthmanager.dds.IDDSData data)
        {
            DDSEventControler.write(data.toEventMsg());
        }

        private void notifyStatusChange(int oldStatus, int newStatus, com.hirain.avionics.healthmanager.dds.DDSData node)
        {
            StatusChangeEvent @event = new StatusChangeEvent(oldStatus, newStatus, node);
            foreach (IStatusChangeListener l in statusChangeListeners)
            {
                l.statusChanged(@event);
            }
        }

        /// <summary>
        /// ����һ��״̬ԾǨ�����������Ѽ�ؽڵ㷢��״̬ԾǨʱ������������?
        /// </summary>
        /// <seealso cref= IStatusChangeListener </seealso>
        /// <param name="listener">
        ///          ״̬ԾǨ������ </param>
        public virtual void addStatusChangeListener(IStatusChangeListener listener)
        {
            com.hirain.avionics.healthmanager.dds.DDSData[] nodes = getDDSData(fStyle);
            foreach (com.hirain.avionics.healthmanager.dds.DDSData node in nodes)
            {
                listener.statusChanged(new StatusChangeEvent(node.Status, node.Status, node));
            }
            statusChangeListeners.Add(listener);
        }

        /// <summary>
        /// ���ó�ʱʱ�䣬�����ʱ��û�н�����Ϣ�Ľڵ㽫����Ϊ���ߡ�?
        /// </summary>
        /// <param name="timeout">
        ///          ��ʱ������ </param>
        public static int Timeout
        {
            set
            {
                defaultTimeout = value;
            }
        }

        /// <summary>
        /// �Ƴ�״̬ԾǨ������
        /// </summary>
        /// <param name="listener">
        ///          ��Ҫ�Ƴ�ļ�����? </param>
        public virtual void removeStatusChangeListener(IStatusChangeListener listener)
        {
            statusChangeListeners.Remove(listener);
        }

        /// <summary>
        /// ��������ѱ���Ľڵ㽡����Ϣ�������»�ȡ��<b>�˲�����������������ߵĽڵ�?/>
        /// </summary>
        public virtual void clear()
        {
            for (int i = 1; i < 20; i++)
            {
                IList<com.hirain.avionics.healthmanager.dds.DDSData> list = getList(i);
                if (list != null)
                {
                    list.Clear();
                }
            }
            statusDaemonNodes.Clear();
        }

        /// <summary>
        /// ��ָ�����ͻ�ȡ�����ͽڵ�
        /// <p>
        /// <code>
        /// HealthManager hm = new HealthManaer(HealthManager.STYLE_AFDX_SIM | HealthManager.STYLE_AVIONICS_SIM);<br>
        /// DDSData[] nodes = hm.getDDSData(HealthManager.STYLE_AFDX_SIM);
        /// </code>
        /// </summary>
        /// <param name="type">
        ///          ���� </param>
        public virtual com.hirain.avionics.healthmanager.dds.DDSData[] getDDSData(int style)
        {
            style = style & fStyle;

            List<com.hirain.avionics.healthmanager.dds.DDSData> list = new List<com.hirain.avionics.healthmanager.dds.DDSData>();
            // corba servers
            if ((style & NEW_STYLE_SIM_MODEL) != 0)
            {
                list.AddRange(fListMap[NEW_STYLE_SIM_MODEL]);
            }
            if ((style & NEW_STYLE_CARD_CONTROL) != 0)
            {
                list.AddRange(fListMap[NEW_STYLE_CARD_CONTROL]);
            }
            if ((style & NEW_STYLE_DEVICE_CONTROL) != 0)
            {
                list.AddRange(fListMap[NEW_STYLE_DEVICE_CONTROL]);
            }
            if ((style & NEW_STYLE_PATCH_CARD_CONTROL) != 0)
            {
                list.AddRange(fListMap[NEW_STYLE_PATCH_CARD_CONTROL]);
            }
            if ((style & NEW_STYLE_PATCH_DEVICE_CONTROL) != 0)
            {
                list.AddRange(fListMap[NEW_STYLE_PATCH_DEVICE_CONTROL]);
            }
            if ((style & NEW_STYLE_STORAGE) != 0)
            {
                list.AddRange(fListMap[NEW_STYLE_STORAGE]);
            }
            if ((style & NEW_STYLE_PTPD) != 0)
            {
                list.AddRange(fListMap[NEW_STYLE_PTPD]);
            }
            if ((style & NEW_STYLE_CPM) != 0)
            {
                list.AddRange(fListMap[NEW_STYLE_CPM]);
            }
            if ((style & NEW_STYLE_CLIENT_ITB) != 0)
            {
                list.AddRange(fListMap[NEW_STYLE_CLIENT_ITB]);
            }
            if ((style & NEW_STYLE_CLIENT_PSS) != 0)
            {
                list.AddRange(fListMap[NEW_STYLE_CLIENT_PSS]);
            }
            if ((style & NEW_STYLE_CLIENT_MATRIX) != 0)
            {
                list.AddRange(fListMap[NEW_STYLE_CLIENT_MATRIX]);
            }
            if ((style & NEW_STYLE_CLIENT_AUTOTEST) != 0)
            {
                list.AddRange(fListMap[NEW_STYLE_CLIENT_AUTOTEST]);
            }
            if (list == null || list.Count == 0)
            {
                return new com.hirain.avionics.healthmanager.dds.DDSData[0];
            }
            else
            {
                return list.ToArray();
            }
        }

        public static datarouter.EVENT_msgDataReader EventReader
        {
            get
            {
                return DDSEventControler.EventReader;
            }
        }
    }
   
}