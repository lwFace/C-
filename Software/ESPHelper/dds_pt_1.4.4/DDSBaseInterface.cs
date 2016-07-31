using System.Text;
using DDS;

namespace com.hirain.avionics.dds
{


    /// <seealso cref= HILInc
    /// @author jialun.liu
    /// @version 1.4.1 </seealso>
    public abstract class DDSBaseInterface
    {

        private const string DDS_VERSION = "1.4.4";

        private static readonly string[] DEFAULT_PARTITION = { "SIMULATION" };

        protected internal DDS.DomainParticipantFactory fParticipantFactory;

        protected internal DDS.IDomainParticipant fParticipant;

        protected internal int fDomainId;

        protected internal string[] fPartitions;

        protected internal DDS.ITopic fMTopic;

        protected internal DDS.ITopic fCTopic;

        protected internal DDS.IPublisher fPublisher;

        protected internal DDS.ISubscriber fSubscriber;

        protected internal DDS.IDataWriter fMWriter;

        protected internal DDS.IDataWriter fCWriter;

        protected internal DDS.IDataReader fMReader;

        protected internal DDS.IDataReader fCReader;

        protected internal DDS.DataReaderListener fReaderListener;

        
        /// <summary>
        /// 使用给定DomainID构造对象，PartitionName默认为SIMULATION,读写深度默认�?�?
        /// </summary>
        /// <param name="domainId">
        ///          DDS Domain ID </param>
        public DDSBaseInterface(int domainId)
            : base()
        {
            this.fDomainId = domainId;
            this.fPartitions = DEFAULT_PARTITION;
        }

        /// <summary>
        /// 使用给定DomainID，Partiton构造对象。读写深度默认为1�?
        /// </summary>
        /// <param name="domainId">
        ///          DDS Domain ID </param>
        /// <param name="partition">
        ///          Partition name </param>
        public DDSBaseInterface(int domainId, string partition)
            : base()
        {
            this.fDomainId = domainId;
            this.fPartitions = new string[] { partition };
        }

        /// <summary>
        /// 使用给定DomainID，Partitons构造对象�?
        /// </summary>
        /// <param name="domainId">
        ///          DDS Domain ID </param>
        /// <param name="partitions">
        ///          Partition names </param>
        public DDSBaseInterface(int domainId, string[] partitions)
            : base()
        {
            this.fDomainId = domainId;
            this.fPartitions = partitions;
        }

        /// <summary>
        /// 初始化DDS，构造全部所需要的DDS资源�?
        /// </summary>
        /// <exception cref="WrapperException">
        ///           - if initial failed. </exception>
        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
        //ORIGINAL LINE: public void start() throws WrapperException
        public virtual void start()
        {
            createParticipant();
            createTopic();
        }

        /// <summary>
        /// 停止DDS，释放所有DDS资源�?
        /// </summary>
        /// <exception cref="WrapperException">
        ///           - if dispose failed. </exception>
        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
        //ORIGINAL LINE: public void stop() throws WrapperException
        public virtual void stop()
        {
            StringBuilder excStr = new StringBuilder("");

            try
            {
                deletePariticipant();
            }
            catch (WrapperException e)
            {
                excStr.Append(e.Message);
            }

            fParticipant = null;
            fPublisher = null;
            fSubscriber = null;
            fMTopic = null;
            fCTopic = null;
            fMReader = null;
            fCReader = null;
            fMWriter = null;
            fCWriter = null;
            fReaderListener = null;

            if (!excStr.ToString().Equals(""))
            {
                throw new WrapperException(excStr.ToString());
            }
        }

        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
        //ORIGINAL LINE: protected void init() throws WrapperException
        protected internal virtual void init()
        {

        }

        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
        //ORIGINAL LINE: protected final void createParticipant() throws WrapperException
        protected internal void createParticipant()
        {
            fParticipantFactory = DDS.DomainParticipantFactory.Instance;

            if (fParticipant == null)
            {
                // fParticipant = fParticipantFactory.lookup_participant(fDomainId);
                if (fParticipant == null)
                {
                    DDS.DomainParticipantQos pqos = new DDS.DomainParticipantQos();
                    fParticipantFactory.GetDefaultParticipantQos(ref pqos);
                    fillQos(pqos);
                    fParticipantFactory.SetDefaultParticipantQos(pqos);

                    fParticipant = fParticipantFactory.CreateParticipant(fDomainId, pqos, null, StatusKind.Any);
                }
                if (fParticipant == null)
                {
                    throw new WrapperException("DDS_Base_Interface::createParticipant(DDS::DomainId_t domain)");
                }
            }
        }

        private DDS.ITopic createTopic(DDS.IDomainParticipant participant, DDS.ITypeSupport ts)
        {
            string typeName = ts.TypeName;
            string topicName = typeName.Substring(typeName.IndexOf("::") + 2);
            ts.RegisterType(participant, typeName);
            DDS.ITopic topic = participant.FindTopic(typeName, new DDS.Duration(0, 50));
            if (topic != null)
            {
                return topic;
            }
            else
            {
                DDS.TopicQos tqos = new DDS.TopicQos();
                participant.GetDefaultTopicQos(ref tqos);
                fillQos(tqos);
                participant.SetDefaultTopicQos(tqos);
                topic = participant.CreateTopic(topicName, typeName, tqos, null, StatusKind.Any);
                return topic;
            }
        }

        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
        //ORIGINAL LINE: protected final void createTopic() throws WrapperException
        protected internal void createTopic()
        {
            DDS.ITypeSupport msgTS = MsgTypeSupport;
            if (msgTS != null)
            {
                fMTopic = createTopic(fParticipant, msgTS);
                if (fMTopic == null)
                {
                    throw new WrapperException(msgTS.TypeName + "::createTopic()");
                }
            }

            DDS.ITypeSupport channelTS = ChannelTypeSupport;
            if (channelTS != null)
            {
                fCTopic = createTopic(fParticipant, channelTS);
                if (fCTopic == null)
                {
                    throw new WrapperException(channelTS.TypeName + ":createTopic()");
                }
            }
        }

        protected internal abstract DDS.ITypeSupport MsgTypeSupport { get; }

        protected internal abstract DDS.ITypeSupport ChannelTypeSupport { get; }

        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
        //ORIGINAL LINE: protected final void createPublisher() throws WrapperException
        protected internal void createPublisher()
        {
            if (fPublisher == null)
            {
                DDS.PublisherQos pqos = new DDS.PublisherQos();
                fParticipant.GetDefaultPublisherQos(ref pqos);
                fillQos(pqos);
                fParticipant.SetDefaultPublisherQos(pqos);

                fPublisher = fParticipant.CreatePublisher(pqos, null, StatusKind.Any);
                if (fPublisher == null)
                {
                    throw new WrapperException("DDS_Base_Interface::createPublisher()");
                }
            }
        }

        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
        //ORIGINAL LINE: protected final void createSubcriber() throws WrapperException
        protected internal void createSubcriber()
        {
            if (fSubscriber == null)
            {
                DDS.SubscriberQos sqos = new DDS.SubscriberQos();
                fParticipant.GetDefaultSubscriberQos(ref sqos);
                fillQos(sqos);
                fParticipant.SetDefaultSubscriberQos(sqos);

                fSubscriber = fParticipant.CreateSubscriber(sqos, null, StatusKind.Any);
                if (fSubscriber == null)
                {
                    throw new WrapperException("DDS_Base_Interface::createSubscriber()");
                }
            }
        }

        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
        //ORIGINAL LINE: protected void createWriter() throws WrapperException
        protected internal virtual void createWriter()
        {
            if (fPublisher == null)
            {
                createPublisher();
            }
            TopicQos topicQos = null;
            DataWriterQos RQosH = null;
            if (fCWriter == null && fCTopic != null)
            {
                fCTopic.GetQos(ref topicQos);
                fPublisher.CopyFromTopicQos(ref RQosH, topicQos);
                fCWriter = fPublisher.CreateDataWriter(fCTopic, RQosH, null, StatusKind.Any);
                if (fCWriter == null)
                {
                    throw new WrapperException("DDS_Base_Interface::createWriter()");
                }
            }
            if (fMWriter == null && fMTopic != null)
            {
                fMTopic.GetQos(ref topicQos);
                fPublisher.CopyFromTopicQos(ref RQosH, topicQos);
                fMWriter = fPublisher.CreateDataWriter(fMTopic, RQosH, null, StatusKind.Any);
                if (fMWriter == null)
                {
                    throw new WrapperException("DDS_Base_Interface::createWriter()");
                }
            }
        }

        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
        //ORIGINAL LINE: protected void createReader() throws WrapperException
        protected internal virtual void createReader()
        {
            DataReaderQos RQosH = null;
            TopicQos topicQos = null;
            if (fSubscriber == null)
            {
                createSubcriber();
            }

            if (fMReader == null && fMTopic != null)
            {
                fMTopic.GetQos(ref topicQos);
                fSubscriber.CopyFromTopicQos(ref RQosH, topicQos);

                fMReader = fSubscriber.CreateDataReader(fMTopic, RQosH, null, StatusKind.Any);//


                if (fMReader == null)
                {
                    throw new WrapperException("DDS_Base_Interface::createReader()");
                }
            }
            if (fCReader == null && fCTopic != null)
            {
                fCTopic.GetQos(ref topicQos);
                fSubscriber.CopyFromTopicQos(ref RQosH, topicQos);
                fCReader = fSubscriber.CreateDataReader(fCTopic, RQosH, null, StatusKind.Any);
                if (fCReader == null)
                {
                    throw new WrapperException("DDS_Base_Interface::createReader()");
                }
            }

            if (fReaderListener != null)
            {
                if (fMReader != null)
                {
                    DDS.ReturnCode rtcode = fMReader.SetListener(fReaderListener, StatusKind.DataAvailable);
                    if (rtcode != DDS.ReturnCode.Ok)
                    {
                        throw new WrapperException("DDS_Base_Interface::setReaderListener()");
                    }
                }
                if (fCReader != null)
                {
                    DDS.ReturnCode rtcode = fCReader.SetListener(fReaderListener, StatusKind.DataAvailable);
                    if (rtcode != DDS.ReturnCode.Ok)
                    {
                        throw new WrapperException("DDS_Base_Interface::setReaderListener()");
                    }
                }
            }
        }

        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
        //ORIGINAL LINE: protected final void deletePariticipant() throws WrapperException
        protected internal void deletePariticipant()
        {
            if (fParticipant != null)
            {
                DDS.ReturnCode live = fParticipant.AssertLiveliness();
                if (live == DDS.ReturnCode.Ok)
                {
                    DDS.ReturnCode rtcode = fParticipant.DeleteContainedEntities();
                    if (rtcode != DDS.ReturnCode.Ok)
                    {
                        throw new WrapperException("DDS_Base_Interface::deletePariticipant()");
                    }

                    rtcode = fParticipantFactory.DeleteParticipant(fParticipant);
                    if (rtcode != DDS.ReturnCode.Ok)
                    {
                        throw new WrapperException("DDS_Base_Interface::deletePariticipant()");
                    }
                }
                fParticipant = null;
            }
        }

        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
        //ORIGINAL LINE: protected final void deleteTopic() throws WrapperException
        protected internal void deleteTopic()
        {
            if (fMTopic != null)
            {
                DDS.ReturnCode rtcode = fParticipant.DeleteTopic(fMTopic);
                if (rtcode != DDS.ReturnCode.Ok)
                {
                    throw new WrapperException("DDS_Base_Interface::deleteTopic()");
                }
                fMTopic = null;
            }
            if (fCTopic != null)
            {
                DDS.ReturnCode rtcode = fParticipant.DeleteTopic(fCTopic);
                if (rtcode != DDS.ReturnCode.Ok)
                {
                    throw new WrapperException("DDS_Base_Interface::deleteTopic()");
                }
                fCTopic = null;
            }
        }

        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
        //ORIGINAL LINE: protected final void deletePublisher() throws WrapperException
        protected internal void deletePublisher()
        {
            if (fPublisher != null)
            {
                DDS.ReturnCode rtcode = fPublisher.DeleteContainedEntities();
                if (rtcode != DDS.ReturnCode.Ok)
                {
                    throw new WrapperException("DDS_Base_Interface::deletePublisher()");
                }
                rtcode = fParticipant.DeletePublisher(fPublisher);
                if (rtcode != DDS.ReturnCode.Ok)
                {
                    throw new WrapperException("DDS_Base_Interface::deletePublisher()");
                }
                fPublisher = null;
            }
        }

        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
        //ORIGINAL LINE: protected final void deleteSubscriber() throws WrapperException
        protected internal void deleteSubscriber()
        {
            if (fSubscriber != null)
            {
                DDS.ReturnCode rtcode = fSubscriber.DeleteContainedEntities();
                if (rtcode != DDS.ReturnCode.Ok)
                {
                    throw new WrapperException("DDS_Base_Interface::deleteSubscriber()");
                }
                rtcode = fParticipant.DeleteSubscriber(fSubscriber);
                if (rtcode != DDS.ReturnCode.Ok)
                {
                    throw new WrapperException("DDS_Base_Interface::deleteSubscriber()");
                }
                fSubscriber = null;
            }
        }

        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
        //ORIGINAL LINE: protected void deleteWriter() throws WrapperException
        protected internal virtual void deleteWriter()
        {
            if (fMWriter != null)
            {
                DDS.ReturnCode rtcode = fPublisher.DeleteDataWriter(fMWriter);
                if (rtcode != DDS.ReturnCode.Ok)
                {
                    throw new WrapperException("DDS_Base_Interface::deleteWriter()");
                }
                fMWriter = null;
            }
            if (fCWriter != null)
            {
                DDS.ReturnCode rtcode = fPublisher.DeleteDataWriter(fCWriter);
                if (rtcode != DDS.ReturnCode.Ok)
                {
                    throw new WrapperException("DDS_Base_Interface::deleteWriter()");
                }
                fCWriter = null;
            }
        }

        protected internal virtual void deleteReader()
        {
            if (fMReader != null)
            {
                fMReader.SetListener(null, 0);
                DDS.ReturnCode rtcode = fSubscriber.DeleteDataReader(fMReader);
                if (rtcode != DDS.ReturnCode.Ok)
                {
                    throw new WrapperException("DDS_Base_Interface::deleteReader()");
                }
                fMReader = null;
            }

            if (fCReader != null)
            {
                fCReader.SetListener(null, 0);
                DDS.ReturnCode rtcode = fSubscriber.DeleteDataReader(fCReader);
                if (rtcode != DDS.ReturnCode.Ok)
                {
                    throw new WrapperException("DDS_Base_Interface::deleteReader()");
                }
                fCReader = null;
            }

        }

        protected internal virtual void fillQos(DDS.DomainParticipantQos qos)
        {
            qos.EntityFactory.AutoenableCreatedEntities = true;
        }

        protected internal virtual void fillQos(DDS.TopicQos qos)
        {

            qos.Durability.Kind = DDS.DurabilityQosPolicyKind.VolatileDurabilityQos;

            qos.Reliability.Kind = DDS.ReliabilityQosPolicyKind.ReliableReliabilityQos;

            qos.LatencyBudget.Duration.Sec = 0;
            qos.LatencyBudget.Duration.NanoSec = 500000;

            qos.History.Kind = DDS.HistoryQosPolicyKind.KeepLastHistoryQos;
            qos.History.Depth = 1;

            qos.DestinationOrder.Kind = DDS.DestinationOrderQosPolicyKind.BySourceTimestampDestinationorderQos;

            qos.Ownership.Kind = DDS.OwnershipQosPolicyKind.SharedOwnershipQos;

            qos.ResourceLimits.MaxInstances = 1000;
            qos.ResourceLimits.MaxSamples = 1000;
            qos.ResourceLimits.MaxSamplesPerInstance = 1000;

        }

        protected internal virtual void fillQos(DDS.PublisherQos qos)
        {
            qos.Presentation.AccessScope = DDS.PresentationQosPolicyAccessScopeKind.InstancePresentationQos;
            qos.Presentation.CoherentAccess = false;
            qos.Presentation.OrderedAccess = false;

            qos.EntityFactory.AutoenableCreatedEntities = true;

            qos.Partition.Name = fPartitions;
        }

        protected internal virtual void fillQos(DDS.SubscriberQos qos)
        {
            qos.Presentation.AccessScope = DDS.PresentationQosPolicyAccessScopeKind.InstancePresentationQos;
            qos.Presentation.CoherentAccess = false;
            qos.Presentation.OrderedAccess = false;

            qos.EntityFactory.AutoenableCreatedEntities = true;

            qos.Partition.Name = fPartitions;
        }

        /// <summary>
        /// 设置Reader监听器，用于监听Reader状态变化�?
        /// </summary>
        /// <param name="readerListener"> </param>
        /// <exception cref="WrapperException"> </exception>
        public void setReaderListener(DDS.DataReaderListener readerListener)
        {
            this.fReaderListener = readerListener;

            if (fMReader == null)
            {
                createReader();
            }
            if (fMReader != null)
            {
                DDS.ReturnCode rtcode = fMReader.SetListener(fReaderListener, StatusKind.DataAvailable);
                if (rtcode != DDS.ReturnCode.Ok)
                {
                    throw new WrapperException("DDS_Base_Interface::setReaderListener()");
                }
            }
            if (fCReader == null)
            {
                createReader();
            }
            if (fCReader != null)
            {
                DDS.ReturnCode rtcode = fCReader.SetListener(fReaderListener, StatusKind.DataAvailable);
                if (rtcode != DDS.ReturnCode.Ok)
                {
                    throw new WrapperException("DDS_Base_Interface::setReaderListener()");
                }
            }

        }

        /// <summary>
        /// 设置Participant监听器，用于监听所有Participant状态变化�?
        /// </summary>
        /// <param name="listener"> </param>
        /// <exception cref="WrapperException"> </exception>
        public virtual DDS.DomainParticipantListener Participant
        {
            set
            {
                if (fParticipant != null)
                {
                    DDS.ReturnCode rtcode = fParticipant.SetListener(value, StatusKind.Any);
                    if (rtcode != DDS.ReturnCode.Ok)
                    {
                        throw new WrapperException("DDS_Base_Interface::setReaderListener()");
                    }
                }
            }
        }

        /// <summary>
        /// 获取DDS时间�?
        /// </summary>
        /// <param name="time">
        ///          timer holder for return time of DDS. </param>
        /// <exception cref="WrapperException">
        ///           - if get time of DDS failed. </exception>
        //JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
        //ORIGINAL LINE: public void getCurrentTime(DDS.Time_tHolder time) throws WrapperException
        public virtual void getCurrentTime(DDS.Time time)
        {
            if (fParticipant != null)
            {
                DDS.ReturnCode rtcode = fParticipant.GetCurrentTime(out time);
                if (rtcode != DDS.ReturnCode.Ok)
                {
                    throw new WrapperException("DDSBaseInterface::getCurrentTime()");
                }
            }
        }

        /// <summary>
        /// 获取当前DDS Domain ID�?
        /// </summary>
        /// <returns> DDS Domain ID </returns>
        public virtual int DomainId
        {
            get
            {
                return fDomainId;
            }
        }

        /// <returns> version of DDS module </returns>
        public static string Version
        {
            get
            {
                return DDS_VERSION;
            }
        }
    }

}