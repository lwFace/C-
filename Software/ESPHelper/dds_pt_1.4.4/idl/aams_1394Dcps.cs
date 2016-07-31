using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DDS;
using DDS.OpenSplice;
using DDS.OpenSplice.CustomMarshalers;

namespace datarouter
{
    #region AAMS_1394_msgDataReader
    public class AAMS_1394_msgDataReader : DDS.OpenSplice.DataReader, IAAMS_1394_msgDataReader
    {
        private AAMS_1394_msgTypeSupport typeSupport;

        public AAMS_1394_msgDataReader(AAMS_1394_msgTypeSupport ts, IntPtr gapiPtr)
            : base(gapiPtr)
        {
            typeSupport = ts;
        }

        public ReturnCode Read(
            ref AAMS_1394_msg[] dataValues,
            ref SampleInfo[] sampleInfos)
        {
            return Read(ref dataValues, ref sampleInfos, Length.Unlimited);
        }

        public ReturnCode Read(
            ref AAMS_1394_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples)
        {
            return Read(ref dataValues, ref sampleInfos, maxSamples, SampleStateKind.Any,
                ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode Read(
            ref AAMS_1394_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates)
        {
            return Read(ref dataValues, ref sampleInfos, Length.Unlimited, sampleStates,
                viewStates, instanceStates);
        }

        public ReturnCode Read(
                ref AAMS_1394_msg[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                SampleStateKind sampleStates,
                ViewStateKind viewStates,
                InstanceStateKind instanceStates)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.Read(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        sampleStates,
                        viewStates,
                        instanceStates);
            dataValues = (AAMS_1394_msg[])objectValues;
            return result;
        }

        public ReturnCode Take(
            ref AAMS_1394_msg[] dataValues,
            ref SampleInfo[] sampleInfos)
        {
            return Take(ref dataValues, ref sampleInfos, Length.Unlimited);
        }

        public ReturnCode Take(
            ref AAMS_1394_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples)
        {
            return Take(ref dataValues, ref sampleInfos, maxSamples, SampleStateKind.Any,
                ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode Take(
            ref AAMS_1394_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates)
        {
            return Take(ref dataValues, ref sampleInfos, Length.Unlimited, sampleStates,
                viewStates, instanceStates);
        }

        public ReturnCode Take(
                ref AAMS_1394_msg[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                SampleStateKind sampleStates,
                ViewStateKind viewStates,
                InstanceStateKind instanceStates)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.Take(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        sampleStates,
                        viewStates,
                        instanceStates);
            dataValues = (AAMS_1394_msg[])objectValues;
            return result;
        }

        public ReturnCode ReadWithCondition(
            ref AAMS_1394_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition)
        {
            return ReadWithCondition(ref dataValues, ref sampleInfos,
                Length.Unlimited, readCondition);
        }

        public ReturnCode ReadWithCondition(
                ref AAMS_1394_msg[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                IReadCondition readCondition)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.ReadWithCondition(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        readCondition);
            dataValues = (AAMS_1394_msg[])objectValues;
            return result;
        }

        public ReturnCode TakeWithCondition(
            ref AAMS_1394_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition)
        {
            return TakeWithCondition(ref dataValues, ref sampleInfos,
                Length.Unlimited, readCondition);
        }

        public ReturnCode TakeWithCondition(
                ref AAMS_1394_msg[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                IReadCondition readCondition)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.TakeWithCondition(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        readCondition);
            dataValues = (AAMS_1394_msg[])objectValues;
            return result;
        }

        public ReturnCode ReadNextSample(
                AAMS_1394_msg dataValue,
                SampleInfo sampleInfo)
        {
            object objectValues = dataValue;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.ReadNextSample(
                        this,
                        ref objectValues,
                        ref sampleInfo);
            dataValue = (AAMS_1394_msg)objectValues;
            return result;
        }

        public ReturnCode TakeNextSample(
                AAMS_1394_msg dataValue,
                SampleInfo sampleInfo)
        {
            object objectValues = dataValue;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.TakeNextSample(
                        this,
                        ref objectValues,
                        ref sampleInfo);
            dataValue = (AAMS_1394_msg)objectValues;
            return result;
        }

        public ReturnCode ReadInstance(
            ref AAMS_1394_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return ReadInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode ReadInstance(
            ref AAMS_1394_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return ReadInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode ReadInstance(
                ref AAMS_1394_msg[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                InstanceHandle instanceHandle,
                SampleStateKind sampleStates,
                ViewStateKind viewStates,
                InstanceStateKind instanceStates)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.ReadInstance(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        instanceHandle,
                        sampleStates,
                        viewStates,
                        instanceStates);
            dataValues = (AAMS_1394_msg[])objectValues;
            return result;
        }

        public ReturnCode TakeInstance(
            ref AAMS_1394_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return TakeInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode TakeInstance(
            ref AAMS_1394_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return TakeInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode TakeInstance(
                ref AAMS_1394_msg[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                InstanceHandle instanceHandle,
                SampleStateKind sampleStates,
                ViewStateKind viewStates,
                InstanceStateKind instanceStates)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.TakeInstance(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        instanceHandle,
                        sampleStates,
                        viewStates,
                        instanceStates);
            dataValues = (AAMS_1394_msg[])objectValues;
            return result;
        }

        public ReturnCode ReadNextInstance(
            ref AAMS_1394_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return ReadNextInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode ReadNextInstance(
            ref AAMS_1394_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return ReadNextInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode ReadNextInstance(
                ref AAMS_1394_msg[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                InstanceHandle instanceHandle,
                SampleStateKind sampleStates,
                ViewStateKind viewStates,
                InstanceStateKind instanceStates)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.ReadNextInstance(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        instanceHandle,
                        sampleStates,
                        viewStates,
                        instanceStates);
            dataValues = (AAMS_1394_msg[])objectValues;
            return result;
        }

        public ReturnCode TakeNextInstance(
            ref AAMS_1394_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return TakeNextInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode TakeNextInstance(
            ref AAMS_1394_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return TakeNextInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode TakeNextInstance(
                ref AAMS_1394_msg[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                InstanceHandle instanceHandle,
                SampleStateKind sampleStates,
                ViewStateKind viewStates,
                InstanceStateKind instanceStates)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.TakeNextInstance(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        instanceHandle,
                        sampleStates,
                        viewStates,
                        instanceStates);
            dataValues = (AAMS_1394_msg[])objectValues;
            return result;
        }

        public ReturnCode ReadNextInstanceWithCondition(
                ref AAMS_1394_msg[] dataValues,
                ref SampleInfo[] sampleInfos,
                InstanceHandle instanceHandle,
                IReadCondition readCondition)
        {
            return ReadNextInstanceWithCondition(
                ref dataValues,
                ref sampleInfos,
                Length.Unlimited,
                instanceHandle,
                readCondition);
        }

        public ReturnCode ReadNextInstanceWithCondition(
                ref AAMS_1394_msg[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                InstanceHandle instanceHandle,
                IReadCondition readCondition)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.ReadNextInstanceWithCondition(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        instanceHandle,
                        readCondition);
            dataValues = (AAMS_1394_msg[])objectValues;
            return result;
        }

        public ReturnCode TakeNextInstanceWithCondition(
                ref AAMS_1394_msg[] dataValues,
                ref SampleInfo[] sampleInfos,
                InstanceHandle instanceHandle,
                IReadCondition readCondition)
        {
            return TakeNextInstanceWithCondition(
                ref dataValues,
                ref sampleInfos,
                Length.Unlimited,
                instanceHandle,
                readCondition);
        }

        public ReturnCode TakeNextInstanceWithCondition(
                ref AAMS_1394_msg[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                InstanceHandle instanceHandle,
                IReadCondition readCondition)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.TakeNextInstanceWithCondition(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        instanceHandle,
                        readCondition);

            dataValues = (AAMS_1394_msg[])objectValues;
            return result;
        }

        public ReturnCode ReturnLoan(
                ref AAMS_1394_msg[] dataValues,
                ref SampleInfo[] sampleInfos)
        {
            ReturnCode result;

            if (dataValues != null && sampleInfos != null)
            {
                if (dataValues != null && sampleInfos != null)
                {
                    if (dataValues.Length == sampleInfos.Length)
                    {
                        dataValues = null;
                        sampleInfos = null;
                        result = ReturnCode.Ok;
                    }
                    else
                    {
                        result = ReturnCode.PreconditionNotMet;
                    }
                }
                else
                {
                    if ((dataValues == null) && (sampleInfos == null))
                    {
                        result = ReturnCode.Ok;
                    }
                    else
                    {
                        result = ReturnCode.PreconditionNotMet;
                    }
                }
            }
            else
            {
                result = ReturnCode.BadParameter;
            }

            return result;
        }

        public ReturnCode GetKeyValue(
                ref AAMS_1394_msg key,
                InstanceHandle handle)
        {
            object keyObj = key;
            ReturnCode result = DDS.OpenSplice.FooDataReader.GetKeyValue(
                        this,
                        ref keyObj,
                        handle);
            if (keyObj != key) key = keyObj as AAMS_1394_msg;
            return result;
        }

        public InstanceHandle LookupInstance(
                AAMS_1394_msg instance)
        {
            return
                DDS.OpenSplice.FooDataReader.LookupInstance(
                        this,
                        instance);
        }

    }
    #endregion
    
    #region AAMS_1394_msgDataWriter
    public class AAMS_1394_msgDataWriter : DDS.OpenSplice.DataWriter, IAAMS_1394_msgDataWriter
    {
        private AAMS_1394_msgTypeSupport typeSupport;

        public AAMS_1394_msgDataWriter(AAMS_1394_msgTypeSupport ts, IntPtr gapiPtr)
            : base(gapiPtr)
        {
            typeSupport = ts;
        }

        public InstanceHandle RegisterInstance(
                AAMS_1394_msg instanceData)
        {
            return DDS.OpenSplice.FooDataWriter.RegisterInstance(
                        this,
                        instanceData);
        }

        public InstanceHandle RegisterInstanceWithTimestamp(
                AAMS_1394_msg instanceData,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.RegisterInstanceWithTimestamp(
                        this,
                        instanceData,
                        sourceTimestamp);
        }

        public ReturnCode UnregisterInstance(
                AAMS_1394_msg instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.UnregisterInstance(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode UnregisterInstanceWithTimestamp(
                AAMS_1394_msg instanceData,
                InstanceHandle instanceHandle,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.UnregisterInstanceWithTimestamp(
                        this,
                        instanceData,
                        instanceHandle,
                        sourceTimestamp);
        }

        public ReturnCode Write(AAMS_1394_msg instanceData)
        {
            return Write(instanceData, InstanceHandle.Nil);
        }

        public ReturnCode Write(
                AAMS_1394_msg instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.Write(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode WriteWithTimestamp(
                AAMS_1394_msg instanceData,
                Time sourceTimestamp)
        {
            return WriteWithTimestamp(instanceData, InstanceHandle.Nil, sourceTimestamp);
        }

        public ReturnCode WriteWithTimestamp(
                AAMS_1394_msg instanceData,
                InstanceHandle instanceHandle,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.WriteWithTimestamp(
                        this,
                        instanceData,
                        instanceHandle,
                        sourceTimestamp);
        }

        public ReturnCode Dispose(
                AAMS_1394_msg instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.Dispose(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode DisposeWithTimestamp(
                AAMS_1394_msg instanceData,
                InstanceHandle instanceHandle,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.DisposeWithTimestamp(
                        this,
                        instanceData,
                        instanceHandle,
                        sourceTimestamp);
        }

        public ReturnCode WriteDispose(
                AAMS_1394_msg instanceData)
        {
            return WriteDispose(instanceData, InstanceHandle.Nil);
        }

        public ReturnCode WriteDispose(
                AAMS_1394_msg instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.WriteDispose(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode WriteDisposeWithTimestamp(
                AAMS_1394_msg instanceData,
                Time sourceTimestamp)
        {
            return WriteDisposeWithTimestamp(instanceData, InstanceHandle.Nil, sourceTimestamp);
        }

        public ReturnCode WriteDisposeWithTimestamp(
                AAMS_1394_msg instanceData,
                InstanceHandle instanceHandle,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.WriteDisposeWithTimestamp(
                        this,
                        instanceData,
                        instanceHandle,
                        sourceTimestamp);
        }

        public ReturnCode GetKeyValue(
                ref AAMS_1394_msg key,
                InstanceHandle instanceHandle)
        {
            object keyObj = key;
            ReturnCode result = DDS.OpenSplice.FooDataWriter.GetKeyValue(
                                    this,
                                    ref keyObj,
                                    instanceHandle);
            if (keyObj != key) key = keyObj as AAMS_1394_msg;
            return result;
        }

        public InstanceHandle LookupInstance(
            AAMS_1394_msg instanceData)
        {
            InstanceHandle result = DDS.OpenSplice.FooDataWriter.LookupInstance(
                                        this,
                                        instanceData);
            return result;
        }
    }
    #endregion

    #region AAMS_1394_msgTypeSupport
    public class AAMS_1394_msgTypeSupport : DDS.OpenSplice.TypeSupport
    {
        private const string typeName = "datarouter::AAMS_1394_msg";
        private const string keyList = "id";
        private const string metaDescriptor = "<MetaData version=\"1.0.0\"><Module name=\"datarouter\"><Struct name=\"Payload\"><Member name=\"value\"><Octet/></Member></Struct><TypeDef name=\"PayloadTypeAAMS1394\"><Sequence><Type name=\"datarouter::Payload\"/></Sequence></TypeDef><Struct name=\"AAMS_1394_msg\"><Member name=\"id\"><ULong/></Member><Member name=\"channel\"><ULong/></Member><Member name=\"msgId\"><ULong/></Member><Member name=\"nodeId\"><ULong/></Member><Member name=\"healthStatus\"><ULong/></Member><Member name=\"healthBeat\"><ULong/></Member><Member name=\"vpcData\"><ULong/></Member><Member name=\"vpcError\"><Boolean/></Member><Member name=\"headerCRC\"><ULong/></Member><Member name=\"dataCRC\"><ULong/></Member><Member name=\"payloadLen\"><ULong/></Member><Member name=\"src\"><ULong/></Member><Member name=\"sec\"><ULong/></Member><Member name=\"usec\"><ULong/></Member><Member name=\"payload\"><Type name=\"datarouter::PayloadTypeAAMS1394\"/></Member></Struct></Module></MetaData>";

        public AAMS_1394_msgTypeSupport()
            : base(typeof(AAMS_1394_msg))
        { }

        public override string TypeName
        {
            get
            {
                return typeName;
            }
        }

        public override string Description
        {
            get
            {
                return metaDescriptor;
            }
        }

        public override string KeyList
        {
            get
            {
                return keyList;
            }
        }

        public override ReturnCode RegisterType(IDomainParticipant participant, string typeName)
        {
            return RegisterType(participant, typeName, new AAMS_1394_msgMarshaler());
        }

        public override DDS.OpenSplice.DataWriter CreateDataWriter(IntPtr gapiPtr)
        {
            return new AAMS_1394_msgDataWriter(this, gapiPtr);
        }

        public override DDS.OpenSplice.DataReader CreateDataReader(IntPtr gapiPtr)
        {
            return new AAMS_1394_msgDataReader(this, gapiPtr);
        }
    }
    #endregion
    #region AAMS_1394_ChannelDataReader
    public class AAMS_1394_ChannelDataReader : DDS.OpenSplice.DataReader, IAAMS_1394_ChannelDataReader
    {
        private AAMS_1394_ChannelTypeSupport typeSupport;

        public AAMS_1394_ChannelDataReader(AAMS_1394_ChannelTypeSupport ts, IntPtr gapiPtr)
            : base(gapiPtr)
        {
            typeSupport = ts;
        }

        public ReturnCode Read(
            ref AAMS_1394_Channel[] dataValues,
            ref SampleInfo[] sampleInfos)
        {
            return Read(ref dataValues, ref sampleInfos, Length.Unlimited);
        }

        public ReturnCode Read(
            ref AAMS_1394_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples)
        {
            return Read(ref dataValues, ref sampleInfos, maxSamples, SampleStateKind.Any,
                ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode Read(
            ref AAMS_1394_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates)
        {
            return Read(ref dataValues, ref sampleInfos, Length.Unlimited, sampleStates,
                viewStates, instanceStates);
        }

        public ReturnCode Read(
                ref AAMS_1394_Channel[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                SampleStateKind sampleStates,
                ViewStateKind viewStates,
                InstanceStateKind instanceStates)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.Read(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        sampleStates,
                        viewStates,
                        instanceStates);
            dataValues = (AAMS_1394_Channel[])objectValues;
            return result;
        }

        public ReturnCode Take(
            ref AAMS_1394_Channel[] dataValues,
            ref SampleInfo[] sampleInfos)
        {
            return Take(ref dataValues, ref sampleInfos, Length.Unlimited);
        }

        public ReturnCode Take(
            ref AAMS_1394_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples)
        {
            return Take(ref dataValues, ref sampleInfos, maxSamples, SampleStateKind.Any,
                ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode Take(
            ref AAMS_1394_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates)
        {
            return Take(ref dataValues, ref sampleInfos, Length.Unlimited, sampleStates,
                viewStates, instanceStates);
        }

        public ReturnCode Take(
                ref AAMS_1394_Channel[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                SampleStateKind sampleStates,
                ViewStateKind viewStates,
                InstanceStateKind instanceStates)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.Take(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        sampleStates,
                        viewStates,
                        instanceStates);
            dataValues = (AAMS_1394_Channel[])objectValues;
            return result;
        }

        public ReturnCode ReadWithCondition(
            ref AAMS_1394_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition)
        {
            return ReadWithCondition(ref dataValues, ref sampleInfos,
                Length.Unlimited, readCondition);
        }

        public ReturnCode ReadWithCondition(
                ref AAMS_1394_Channel[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                IReadCondition readCondition)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.ReadWithCondition(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        readCondition);
            dataValues = (AAMS_1394_Channel[])objectValues;
            return result;
        }

        public ReturnCode TakeWithCondition(
            ref AAMS_1394_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition)
        {
            return TakeWithCondition(ref dataValues, ref sampleInfos,
                Length.Unlimited, readCondition);
        }

        public ReturnCode TakeWithCondition(
                ref AAMS_1394_Channel[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                IReadCondition readCondition)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.TakeWithCondition(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        readCondition);
            dataValues = (AAMS_1394_Channel[])objectValues;
            return result;
        }

        public ReturnCode ReadNextSample(
                AAMS_1394_Channel dataValue,
                SampleInfo sampleInfo)
        {
            object objectValues = dataValue;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.ReadNextSample(
                        this,
                        ref objectValues,
                        ref sampleInfo);
            dataValue = (AAMS_1394_Channel)objectValues;
            return result;
        }

        public ReturnCode TakeNextSample(
                AAMS_1394_Channel dataValue,
                SampleInfo sampleInfo)
        {
            object objectValues = dataValue;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.TakeNextSample(
                        this,
                        ref objectValues,
                        ref sampleInfo);
            dataValue = (AAMS_1394_Channel)objectValues;
            return result;
        }

        public ReturnCode ReadInstance(
            ref AAMS_1394_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return ReadInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode ReadInstance(
            ref AAMS_1394_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return ReadInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode ReadInstance(
                ref AAMS_1394_Channel[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                InstanceHandle instanceHandle,
                SampleStateKind sampleStates,
                ViewStateKind viewStates,
                InstanceStateKind instanceStates)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.ReadInstance(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        instanceHandle,
                        sampleStates,
                        viewStates,
                        instanceStates);
            dataValues = (AAMS_1394_Channel[])objectValues;
            return result;
        }

        public ReturnCode TakeInstance(
            ref AAMS_1394_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return TakeInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode TakeInstance(
            ref AAMS_1394_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return TakeInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode TakeInstance(
                ref AAMS_1394_Channel[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                InstanceHandle instanceHandle,
                SampleStateKind sampleStates,
                ViewStateKind viewStates,
                InstanceStateKind instanceStates)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.TakeInstance(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        instanceHandle,
                        sampleStates,
                        viewStates,
                        instanceStates);
            dataValues = (AAMS_1394_Channel[])objectValues;
            return result;
        }

        public ReturnCode ReadNextInstance(
            ref AAMS_1394_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return ReadNextInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode ReadNextInstance(
            ref AAMS_1394_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return ReadNextInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode ReadNextInstance(
                ref AAMS_1394_Channel[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                InstanceHandle instanceHandle,
                SampleStateKind sampleStates,
                ViewStateKind viewStates,
                InstanceStateKind instanceStates)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.ReadNextInstance(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        instanceHandle,
                        sampleStates,
                        viewStates,
                        instanceStates);
            dataValues = (AAMS_1394_Channel[])objectValues;
            return result;
        }

        public ReturnCode TakeNextInstance(
            ref AAMS_1394_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return TakeNextInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode TakeNextInstance(
            ref AAMS_1394_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return TakeNextInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode TakeNextInstance(
                ref AAMS_1394_Channel[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                InstanceHandle instanceHandle,
                SampleStateKind sampleStates,
                ViewStateKind viewStates,
                InstanceStateKind instanceStates)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.TakeNextInstance(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        instanceHandle,
                        sampleStates,
                        viewStates,
                        instanceStates);
            dataValues = (AAMS_1394_Channel[])objectValues;
            return result;
        }

        public ReturnCode ReadNextInstanceWithCondition(
                ref AAMS_1394_Channel[] dataValues,
                ref SampleInfo[] sampleInfos,
                InstanceHandle instanceHandle,
                IReadCondition readCondition)
        {
            return ReadNextInstanceWithCondition(
                ref dataValues,
                ref sampleInfos,
                Length.Unlimited,
                instanceHandle,
                readCondition);
        }

        public ReturnCode ReadNextInstanceWithCondition(
                ref AAMS_1394_Channel[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                InstanceHandle instanceHandle,
                IReadCondition readCondition)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.ReadNextInstanceWithCondition(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        instanceHandle,
                        readCondition);
            dataValues = (AAMS_1394_Channel[])objectValues;
            return result;
        }

        public ReturnCode TakeNextInstanceWithCondition(
                ref AAMS_1394_Channel[] dataValues,
                ref SampleInfo[] sampleInfos,
                InstanceHandle instanceHandle,
                IReadCondition readCondition)
        {
            return TakeNextInstanceWithCondition(
                ref dataValues,
                ref sampleInfos,
                Length.Unlimited,
                instanceHandle,
                readCondition);
        }

        public ReturnCode TakeNextInstanceWithCondition(
                ref AAMS_1394_Channel[] dataValues,
                ref SampleInfo[] sampleInfos,
                int maxSamples,
                InstanceHandle instanceHandle,
                IReadCondition readCondition)
        {
            object[] objectValues = dataValues;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.TakeNextInstanceWithCondition(
                        this,
                        ref objectValues,
                        ref sampleInfos,
                        maxSamples,
                        instanceHandle,
                        readCondition);

            dataValues = (AAMS_1394_Channel[])objectValues;
            return result;
        }

        public ReturnCode ReturnLoan(
                ref AAMS_1394_Channel[] dataValues,
                ref SampleInfo[] sampleInfos)
        {
            ReturnCode result;

            if (dataValues != null && sampleInfos != null)
            {
                if (dataValues != null && sampleInfos != null)
                {
                    if (dataValues.Length == sampleInfos.Length)
                    {
                        dataValues = null;
                        sampleInfos = null;
                        result = ReturnCode.Ok;
                    }
                    else
                    {
                        result = ReturnCode.PreconditionNotMet;
                    }
                }
                else
                {
                    if ((dataValues == null) && (sampleInfos == null))
                    {
                        result = ReturnCode.Ok;
                    }
                    else
                    {
                        result = ReturnCode.PreconditionNotMet;
                    }
                }
            }
            else
            {
                result = ReturnCode.BadParameter;
            }

            return result;
        }

        public ReturnCode GetKeyValue(
                ref AAMS_1394_Channel key,
                InstanceHandle handle)
        {
            object keyObj = key;
            ReturnCode result = DDS.OpenSplice.FooDataReader.GetKeyValue(
                        this,
                        ref keyObj,
                        handle);
            if (keyObj != key) key = keyObj as AAMS_1394_Channel;
            return result;
        }

        public InstanceHandle LookupInstance(
                AAMS_1394_Channel instance)
        {
            return
                DDS.OpenSplice.FooDataReader.LookupInstance(
                        this,
                        instance);
        }

    }
    #endregion
    
    #region AAMS_1394_ChannelDataWriter
    public class AAMS_1394_ChannelDataWriter : DDS.OpenSplice.DataWriter, IAAMS_1394_ChannelDataWriter
    {
        private AAMS_1394_ChannelTypeSupport typeSupport;

        public AAMS_1394_ChannelDataWriter(AAMS_1394_ChannelTypeSupport ts, IntPtr gapiPtr)
            : base(gapiPtr)
        {
            typeSupport = ts;
        }

        public InstanceHandle RegisterInstance(
                AAMS_1394_Channel instanceData)
        {
            return DDS.OpenSplice.FooDataWriter.RegisterInstance(
                        this,
                        instanceData);
        }

        public InstanceHandle RegisterInstanceWithTimestamp(
                AAMS_1394_Channel instanceData,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.RegisterInstanceWithTimestamp(
                        this,
                        instanceData,
                        sourceTimestamp);
        }

        public ReturnCode UnregisterInstance(
                AAMS_1394_Channel instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.UnregisterInstance(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode UnregisterInstanceWithTimestamp(
                AAMS_1394_Channel instanceData,
                InstanceHandle instanceHandle,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.UnregisterInstanceWithTimestamp(
                        this,
                        instanceData,
                        instanceHandle,
                        sourceTimestamp);
        }

        public ReturnCode Write(AAMS_1394_Channel instanceData)
        {
            return Write(instanceData, InstanceHandle.Nil);
        }

        public ReturnCode Write(
                AAMS_1394_Channel instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.Write(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode WriteWithTimestamp(
                AAMS_1394_Channel instanceData,
                Time sourceTimestamp)
        {
            return WriteWithTimestamp(instanceData, InstanceHandle.Nil, sourceTimestamp);
        }

        public ReturnCode WriteWithTimestamp(
                AAMS_1394_Channel instanceData,
                InstanceHandle instanceHandle,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.WriteWithTimestamp(
                        this,
                        instanceData,
                        instanceHandle,
                        sourceTimestamp);
        }

        public ReturnCode Dispose(
                AAMS_1394_Channel instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.Dispose(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode DisposeWithTimestamp(
                AAMS_1394_Channel instanceData,
                InstanceHandle instanceHandle,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.DisposeWithTimestamp(
                        this,
                        instanceData,
                        instanceHandle,
                        sourceTimestamp);
        }

        public ReturnCode WriteDispose(
                AAMS_1394_Channel instanceData)
        {
            return WriteDispose(instanceData, InstanceHandle.Nil);
        }

        public ReturnCode WriteDispose(
                AAMS_1394_Channel instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.WriteDispose(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode WriteDisposeWithTimestamp(
                AAMS_1394_Channel instanceData,
                Time sourceTimestamp)
        {
            return WriteDisposeWithTimestamp(instanceData, InstanceHandle.Nil, sourceTimestamp);
        }

        public ReturnCode WriteDisposeWithTimestamp(
                AAMS_1394_Channel instanceData,
                InstanceHandle instanceHandle,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.WriteDisposeWithTimestamp(
                        this,
                        instanceData,
                        instanceHandle,
                        sourceTimestamp);
        }

        public ReturnCode GetKeyValue(
                ref AAMS_1394_Channel key,
                InstanceHandle instanceHandle)
        {
            object keyObj = key;
            ReturnCode result = DDS.OpenSplice.FooDataWriter.GetKeyValue(
                                    this,
                                    ref keyObj,
                                    instanceHandle);
            if (keyObj != key) key = keyObj as AAMS_1394_Channel;
            return result;
        }

        public InstanceHandle LookupInstance(
            AAMS_1394_Channel instanceData)
        {
            InstanceHandle result = DDS.OpenSplice.FooDataWriter.LookupInstance(
                                        this,
                                        instanceData);
            return result;
        }
    }
    #endregion

    #region AAMS_1394_ChannelTypeSupport
    public class AAMS_1394_ChannelTypeSupport : DDS.OpenSplice.TypeSupport
    {
        private const string typeName = "datarouter::AAMS_1394_Channel";
        private const string keyList = "id";
        private const string metaDescriptor = "<MetaData version=\"1.0.0\"><Module name=\"datarouter\"><Struct name=\"Payload\"><Member name=\"value\"><Octet/></Member></Struct><TypeDef name=\"PayloadTypeAAMS1394\"><Sequence><Type name=\"datarouter::Payload\"/></Sequence></TypeDef><Struct name=\"AAMS_1394_msg\"><Member name=\"id\"><ULong/></Member><Member name=\"channel\"><ULong/></Member><Member name=\"msgId\"><ULong/></Member><Member name=\"nodeId\"><ULong/></Member><Member name=\"healthStatus\"><ULong/></Member><Member name=\"healthBeat\"><ULong/></Member><Member name=\"vpcData\"><ULong/></Member><Member name=\"vpcError\"><Boolean/></Member><Member name=\"headerCRC\"><ULong/></Member><Member name=\"dataCRC\"><ULong/></Member><Member name=\"payloadLen\"><ULong/></Member><Member name=\"src\"><ULong/></Member><Member name=\"sec\"><ULong/></Member><Member name=\"usec\"><ULong/></Member><Member name=\"payload\"><Type name=\"datarouter::PayloadTypeAAMS1394\"/></Member></Struct><Struct name=\"AAMS_1394_Channel\"><Member name=\"id\"><ULong/></Member><Member name=\"msgs\"><Sequence><Type name=\"datarouter::AAMS_1394_msg\"/></Sequence></Member></Struct></Module></MetaData>";

        public AAMS_1394_ChannelTypeSupport()
            : base(typeof(AAMS_1394_Channel))
        { }

        public override string TypeName
        {
            get
            {
                return typeName;
            }
        }

        public override string Description
        {
            get
            {
                return metaDescriptor;
            }
        }

        public override string KeyList
        {
            get
            {
                return keyList;
            }
        }

        public override ReturnCode RegisterType(IDomainParticipant participant, string typeName)
        {
            return RegisterType(participant, typeName, new AAMS_1394_ChannelMarshaler());
        }

        public override DDS.OpenSplice.DataWriter CreateDataWriter(IntPtr gapiPtr)
        {
            return new AAMS_1394_ChannelDataWriter(this, gapiPtr);
        }

        public override DDS.OpenSplice.DataReader CreateDataReader(IntPtr gapiPtr)
        {
            return new AAMS_1394_ChannelDataReader(this, gapiPtr);
        }
    }
    #endregion
}

