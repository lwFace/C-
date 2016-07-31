using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DDS;
using DDS.OpenSplice;
using DDS.OpenSplice.CustomMarshalers;

namespace datarouter
{
    #region AAMS_FC_AE_ASM_msgDataReader
    public class AAMS_FC_AE_ASM_msgDataReader : DDS.OpenSplice.DataReader, IAAMS_FC_AE_ASM_msgDataReader
    {
        private AAMS_FC_AE_ASM_msgTypeSupport typeSupport;

        public AAMS_FC_AE_ASM_msgDataReader(AAMS_FC_AE_ASM_msgTypeSupport ts, IntPtr gapiPtr)
            : base(gapiPtr)
        {
            typeSupport = ts;
        }

        public ReturnCode Read(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos)
        {
            return Read(ref dataValues, ref sampleInfos, Length.Unlimited);
        }

        public ReturnCode Read(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples)
        {
            return Read(ref dataValues, ref sampleInfos, maxSamples, SampleStateKind.Any,
                ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode Read(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates)
        {
            return Read(ref dataValues, ref sampleInfos, Length.Unlimited, sampleStates,
                viewStates, instanceStates);
        }

        public ReturnCode Read(
                ref AAMS_FC_AE_ASM_msg[] dataValues,
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
            dataValues = (AAMS_FC_AE_ASM_msg[])objectValues;
            return result;
        }

        public ReturnCode Take(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos)
        {
            return Take(ref dataValues, ref sampleInfos, Length.Unlimited);
        }

        public ReturnCode Take(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples)
        {
            return Take(ref dataValues, ref sampleInfos, maxSamples, SampleStateKind.Any,
                ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode Take(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates)
        {
            return Take(ref dataValues, ref sampleInfos, Length.Unlimited, sampleStates,
                viewStates, instanceStates);
        }

        public ReturnCode Take(
                ref AAMS_FC_AE_ASM_msg[] dataValues,
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
            dataValues = (AAMS_FC_AE_ASM_msg[])objectValues;
            return result;
        }

        public ReturnCode ReadWithCondition(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition)
        {
            return ReadWithCondition(ref dataValues, ref sampleInfos,
                Length.Unlimited, readCondition);
        }

        public ReturnCode ReadWithCondition(
                ref AAMS_FC_AE_ASM_msg[] dataValues,
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
            dataValues = (AAMS_FC_AE_ASM_msg[])objectValues;
            return result;
        }

        public ReturnCode TakeWithCondition(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition)
        {
            return TakeWithCondition(ref dataValues, ref sampleInfos,
                Length.Unlimited, readCondition);
        }

        public ReturnCode TakeWithCondition(
                ref AAMS_FC_AE_ASM_msg[] dataValues,
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
            dataValues = (AAMS_FC_AE_ASM_msg[])objectValues;
            return result;
        }

        public ReturnCode ReadNextSample(
                AAMS_FC_AE_ASM_msg dataValue,
                SampleInfo sampleInfo)
        {
            object objectValues = dataValue;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.ReadNextSample(
                        this,
                        ref objectValues,
                        ref sampleInfo);
            dataValue = (AAMS_FC_AE_ASM_msg)objectValues;
            return result;
        }

        public ReturnCode TakeNextSample(
                AAMS_FC_AE_ASM_msg dataValue,
                SampleInfo sampleInfo)
        {
            object objectValues = dataValue;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.TakeNextSample(
                        this,
                        ref objectValues,
                        ref sampleInfo);
            dataValue = (AAMS_FC_AE_ASM_msg)objectValues;
            return result;
        }

        public ReturnCode ReadInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return ReadInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode ReadInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return ReadInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode ReadInstance(
                ref AAMS_FC_AE_ASM_msg[] dataValues,
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
            dataValues = (AAMS_FC_AE_ASM_msg[])objectValues;
            return result;
        }

        public ReturnCode TakeInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return TakeInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode TakeInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return TakeInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode TakeInstance(
                ref AAMS_FC_AE_ASM_msg[] dataValues,
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
            dataValues = (AAMS_FC_AE_ASM_msg[])objectValues;
            return result;
        }

        public ReturnCode ReadNextInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return ReadNextInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode ReadNextInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return ReadNextInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode ReadNextInstance(
                ref AAMS_FC_AE_ASM_msg[] dataValues,
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
            dataValues = (AAMS_FC_AE_ASM_msg[])objectValues;
            return result;
        }

        public ReturnCode TakeNextInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return TakeNextInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode TakeNextInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return TakeNextInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode TakeNextInstance(
                ref AAMS_FC_AE_ASM_msg[] dataValues,
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
            dataValues = (AAMS_FC_AE_ASM_msg[])objectValues;
            return result;
        }

        public ReturnCode ReadNextInstanceWithCondition(
                ref AAMS_FC_AE_ASM_msg[] dataValues,
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
                ref AAMS_FC_AE_ASM_msg[] dataValues,
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
            dataValues = (AAMS_FC_AE_ASM_msg[])objectValues;
            return result;
        }

        public ReturnCode TakeNextInstanceWithCondition(
                ref AAMS_FC_AE_ASM_msg[] dataValues,
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
                ref AAMS_FC_AE_ASM_msg[] dataValues,
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

            dataValues = (AAMS_FC_AE_ASM_msg[])objectValues;
            return result;
        }

        public ReturnCode ReturnLoan(
                ref AAMS_FC_AE_ASM_msg[] dataValues,
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
                ref AAMS_FC_AE_ASM_msg key,
                InstanceHandle handle)
        {
            object keyObj = key;
            ReturnCode result = DDS.OpenSplice.FooDataReader.GetKeyValue(
                        this,
                        ref keyObj,
                        handle);
            if (keyObj != key) key = keyObj as AAMS_FC_AE_ASM_msg;
            return result;
        }

        public InstanceHandle LookupInstance(
                AAMS_FC_AE_ASM_msg instance)
        {
            return
                DDS.OpenSplice.FooDataReader.LookupInstance(
                        this,
                        instance);
        }

    }
    #endregion
    
    #region AAMS_FC_AE_ASM_msgDataWriter
    public class AAMS_FC_AE_ASM_msgDataWriter : DDS.OpenSplice.DataWriter, IAAMS_FC_AE_ASM_msgDataWriter
    {
        private AAMS_FC_AE_ASM_msgTypeSupport typeSupport;

        public AAMS_FC_AE_ASM_msgDataWriter(AAMS_FC_AE_ASM_msgTypeSupport ts, IntPtr gapiPtr)
            : base(gapiPtr)
        {
            typeSupport = ts;
        }

        public InstanceHandle RegisterInstance(
                AAMS_FC_AE_ASM_msg instanceData)
        {
            return DDS.OpenSplice.FooDataWriter.RegisterInstance(
                        this,
                        instanceData);
        }

        public InstanceHandle RegisterInstanceWithTimestamp(
                AAMS_FC_AE_ASM_msg instanceData,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.RegisterInstanceWithTimestamp(
                        this,
                        instanceData,
                        sourceTimestamp);
        }

        public ReturnCode UnregisterInstance(
                AAMS_FC_AE_ASM_msg instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.UnregisterInstance(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode UnregisterInstanceWithTimestamp(
                AAMS_FC_AE_ASM_msg instanceData,
                InstanceHandle instanceHandle,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.UnregisterInstanceWithTimestamp(
                        this,
                        instanceData,
                        instanceHandle,
                        sourceTimestamp);
        }

        public ReturnCode Write(AAMS_FC_AE_ASM_msg instanceData)
        {
            return Write(instanceData, InstanceHandle.Nil);
        }

        public ReturnCode Write(
                AAMS_FC_AE_ASM_msg instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.Write(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode WriteWithTimestamp(
                AAMS_FC_AE_ASM_msg instanceData,
                Time sourceTimestamp)
        {
            return WriteWithTimestamp(instanceData, InstanceHandle.Nil, sourceTimestamp);
        }

        public ReturnCode WriteWithTimestamp(
                AAMS_FC_AE_ASM_msg instanceData,
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
                AAMS_FC_AE_ASM_msg instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.Dispose(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode DisposeWithTimestamp(
                AAMS_FC_AE_ASM_msg instanceData,
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
                AAMS_FC_AE_ASM_msg instanceData)
        {
            return WriteDispose(instanceData, InstanceHandle.Nil);
        }

        public ReturnCode WriteDispose(
                AAMS_FC_AE_ASM_msg instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.WriteDispose(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode WriteDisposeWithTimestamp(
                AAMS_FC_AE_ASM_msg instanceData,
                Time sourceTimestamp)
        {
            return WriteDisposeWithTimestamp(instanceData, InstanceHandle.Nil, sourceTimestamp);
        }

        public ReturnCode WriteDisposeWithTimestamp(
                AAMS_FC_AE_ASM_msg instanceData,
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
                ref AAMS_FC_AE_ASM_msg key,
                InstanceHandle instanceHandle)
        {
            object keyObj = key;
            ReturnCode result = DDS.OpenSplice.FooDataWriter.GetKeyValue(
                                    this,
                                    ref keyObj,
                                    instanceHandle);
            if (keyObj != key) key = keyObj as AAMS_FC_AE_ASM_msg;
            return result;
        }

        public InstanceHandle LookupInstance(
            AAMS_FC_AE_ASM_msg instanceData)
        {
            InstanceHandle result = DDS.OpenSplice.FooDataWriter.LookupInstance(
                                        this,
                                        instanceData);
            return result;
        }
    }
    #endregion

    #region AAMS_FC_AE_ASM_msgTypeSupport
    public class AAMS_FC_AE_ASM_msgTypeSupport : DDS.OpenSplice.TypeSupport
    {
        private const string typeName = "datarouter::AAMS_FC_AE_ASM_msg";
        private const string keyList = "id";
        private const string metaDescriptor = "<MetaData version=\"1.0.0\"><Module name=\"datarouter\"><Struct name=\"Payload\"><Member name=\"value\"><Octet/></Member></Struct><TypeDef name=\"PayloadTypeAAMS_FC_AE_ASM\"><Sequence><Type name=\"datarouter::Payload\"/></Sequence></TypeDef><Struct name=\"AAMS_FC_AE_ASM_msg\"><Member name=\"id\"><ULong/></Member><Member name=\"msgId\"><ULong/></Member><Member name=\"vendorSpecificSecurity\"><ULong/></Member><Member name=\"reserved\"><ULong/></Member><Member name=\"priority\"><ULong/></Member><Member name=\"msgLength\"><ULong/></Member><Member name=\"lByte\"><ULong/></Member><Member name=\"sec\"><ULong/></Member><Member name=\"usec\"><ULong/></Member><Member name=\"payload\"><Type name=\"datarouter::PayloadTypeAAMS_FC_AE_ASM\"/></Member></Struct></Module></MetaData>";

        public AAMS_FC_AE_ASM_msgTypeSupport()
            : base(typeof(AAMS_FC_AE_ASM_msg))
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
            return RegisterType(participant, typeName, new AAMS_FC_AE_ASM_msgMarshaler());
        }

        public override DDS.OpenSplice.DataWriter CreateDataWriter(IntPtr gapiPtr)
        {
            return new AAMS_FC_AE_ASM_msgDataWriter(this, gapiPtr);
        }

        public override DDS.OpenSplice.DataReader CreateDataReader(IntPtr gapiPtr)
        {
            return new AAMS_FC_AE_ASM_msgDataReader(this, gapiPtr);
        }
    }
    #endregion
    #region AAMS_FC_AE_ASM_ChannelDataReader
    public class AAMS_FC_AE_ASM_ChannelDataReader : DDS.OpenSplice.DataReader, IAAMS_FC_AE_ASM_ChannelDataReader
    {
        private AAMS_FC_AE_ASM_ChannelTypeSupport typeSupport;

        public AAMS_FC_AE_ASM_ChannelDataReader(AAMS_FC_AE_ASM_ChannelTypeSupport ts, IntPtr gapiPtr)
            : base(gapiPtr)
        {
            typeSupport = ts;
        }

        public ReturnCode Read(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos)
        {
            return Read(ref dataValues, ref sampleInfos, Length.Unlimited);
        }

        public ReturnCode Read(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples)
        {
            return Read(ref dataValues, ref sampleInfos, maxSamples, SampleStateKind.Any,
                ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode Read(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates)
        {
            return Read(ref dataValues, ref sampleInfos, Length.Unlimited, sampleStates,
                viewStates, instanceStates);
        }

        public ReturnCode Read(
                ref AAMS_FC_AE_ASM_Channel[] dataValues,
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
            dataValues = (AAMS_FC_AE_ASM_Channel[])objectValues;
            return result;
        }

        public ReturnCode Take(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos)
        {
            return Take(ref dataValues, ref sampleInfos, Length.Unlimited);
        }

        public ReturnCode Take(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples)
        {
            return Take(ref dataValues, ref sampleInfos, maxSamples, SampleStateKind.Any,
                ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode Take(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates)
        {
            return Take(ref dataValues, ref sampleInfos, Length.Unlimited, sampleStates,
                viewStates, instanceStates);
        }

        public ReturnCode Take(
                ref AAMS_FC_AE_ASM_Channel[] dataValues,
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
            dataValues = (AAMS_FC_AE_ASM_Channel[])objectValues;
            return result;
        }

        public ReturnCode ReadWithCondition(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition)
        {
            return ReadWithCondition(ref dataValues, ref sampleInfos,
                Length.Unlimited, readCondition);
        }

        public ReturnCode ReadWithCondition(
                ref AAMS_FC_AE_ASM_Channel[] dataValues,
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
            dataValues = (AAMS_FC_AE_ASM_Channel[])objectValues;
            return result;
        }

        public ReturnCode TakeWithCondition(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition)
        {
            return TakeWithCondition(ref dataValues, ref sampleInfos,
                Length.Unlimited, readCondition);
        }

        public ReturnCode TakeWithCondition(
                ref AAMS_FC_AE_ASM_Channel[] dataValues,
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
            dataValues = (AAMS_FC_AE_ASM_Channel[])objectValues;
            return result;
        }

        public ReturnCode ReadNextSample(
                AAMS_FC_AE_ASM_Channel dataValue,
                SampleInfo sampleInfo)
        {
            object objectValues = dataValue;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.ReadNextSample(
                        this,
                        ref objectValues,
                        ref sampleInfo);
            dataValue = (AAMS_FC_AE_ASM_Channel)objectValues;
            return result;
        }

        public ReturnCode TakeNextSample(
                AAMS_FC_AE_ASM_Channel dataValue,
                SampleInfo sampleInfo)
        {
            object objectValues = dataValue;
            ReturnCode result =
                DDS.OpenSplice.FooDataReader.TakeNextSample(
                        this,
                        ref objectValues,
                        ref sampleInfo);
            dataValue = (AAMS_FC_AE_ASM_Channel)objectValues;
            return result;
        }

        public ReturnCode ReadInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return ReadInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode ReadInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return ReadInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode ReadInstance(
                ref AAMS_FC_AE_ASM_Channel[] dataValues,
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
            dataValues = (AAMS_FC_AE_ASM_Channel[])objectValues;
            return result;
        }

        public ReturnCode TakeInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return TakeInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode TakeInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return TakeInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode TakeInstance(
                ref AAMS_FC_AE_ASM_Channel[] dataValues,
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
            dataValues = (AAMS_FC_AE_ASM_Channel[])objectValues;
            return result;
        }

        public ReturnCode ReadNextInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return ReadNextInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode ReadNextInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return ReadNextInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode ReadNextInstance(
                ref AAMS_FC_AE_ASM_Channel[] dataValues,
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
            dataValues = (AAMS_FC_AE_ASM_Channel[])objectValues;
            return result;
        }

        public ReturnCode TakeNextInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle)
        {
            return TakeNextInstance(ref dataValues, ref sampleInfos, Length.Unlimited, instanceHandle);
        }

        public ReturnCode TakeNextInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle)
        {
            return TakeNextInstance(ref dataValues, ref sampleInfos, maxSamples, instanceHandle,
                SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
        }

        public ReturnCode TakeNextInstance(
                ref AAMS_FC_AE_ASM_Channel[] dataValues,
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
            dataValues = (AAMS_FC_AE_ASM_Channel[])objectValues;
            return result;
        }

        public ReturnCode ReadNextInstanceWithCondition(
                ref AAMS_FC_AE_ASM_Channel[] dataValues,
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
                ref AAMS_FC_AE_ASM_Channel[] dataValues,
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
            dataValues = (AAMS_FC_AE_ASM_Channel[])objectValues;
            return result;
        }

        public ReturnCode TakeNextInstanceWithCondition(
                ref AAMS_FC_AE_ASM_Channel[] dataValues,
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
                ref AAMS_FC_AE_ASM_Channel[] dataValues,
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

            dataValues = (AAMS_FC_AE_ASM_Channel[])objectValues;
            return result;
        }

        public ReturnCode ReturnLoan(
                ref AAMS_FC_AE_ASM_Channel[] dataValues,
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
                ref AAMS_FC_AE_ASM_Channel key,
                InstanceHandle handle)
        {
            object keyObj = key;
            ReturnCode result = DDS.OpenSplice.FooDataReader.GetKeyValue(
                        this,
                        ref keyObj,
                        handle);
            if (keyObj != key) key = keyObj as AAMS_FC_AE_ASM_Channel;
            return result;
        }

        public InstanceHandle LookupInstance(
                AAMS_FC_AE_ASM_Channel instance)
        {
            return
                DDS.OpenSplice.FooDataReader.LookupInstance(
                        this,
                        instance);
        }

    }
    #endregion
    
    #region AAMS_FC_AE_ASM_ChannelDataWriter
    public class AAMS_FC_AE_ASM_ChannelDataWriter : DDS.OpenSplice.DataWriter, IAAMS_FC_AE_ASM_ChannelDataWriter
    {
        private AAMS_FC_AE_ASM_ChannelTypeSupport typeSupport;

        public AAMS_FC_AE_ASM_ChannelDataWriter(AAMS_FC_AE_ASM_ChannelTypeSupport ts, IntPtr gapiPtr)
            : base(gapiPtr)
        {
            typeSupport = ts;
        }

        public InstanceHandle RegisterInstance(
                AAMS_FC_AE_ASM_Channel instanceData)
        {
            return DDS.OpenSplice.FooDataWriter.RegisterInstance(
                        this,
                        instanceData);
        }

        public InstanceHandle RegisterInstanceWithTimestamp(
                AAMS_FC_AE_ASM_Channel instanceData,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.RegisterInstanceWithTimestamp(
                        this,
                        instanceData,
                        sourceTimestamp);
        }

        public ReturnCode UnregisterInstance(
                AAMS_FC_AE_ASM_Channel instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.UnregisterInstance(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode UnregisterInstanceWithTimestamp(
                AAMS_FC_AE_ASM_Channel instanceData,
                InstanceHandle instanceHandle,
                Time sourceTimestamp)
        {
            return DDS.OpenSplice.FooDataWriter.UnregisterInstanceWithTimestamp(
                        this,
                        instanceData,
                        instanceHandle,
                        sourceTimestamp);
        }

        public ReturnCode Write(AAMS_FC_AE_ASM_Channel instanceData)
        {
            return Write(instanceData, InstanceHandle.Nil);
        }

        public ReturnCode Write(
                AAMS_FC_AE_ASM_Channel instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.Write(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode WriteWithTimestamp(
                AAMS_FC_AE_ASM_Channel instanceData,
                Time sourceTimestamp)
        {
            return WriteWithTimestamp(instanceData, InstanceHandle.Nil, sourceTimestamp);
        }

        public ReturnCode WriteWithTimestamp(
                AAMS_FC_AE_ASM_Channel instanceData,
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
                AAMS_FC_AE_ASM_Channel instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.Dispose(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode DisposeWithTimestamp(
                AAMS_FC_AE_ASM_Channel instanceData,
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
                AAMS_FC_AE_ASM_Channel instanceData)
        {
            return WriteDispose(instanceData, InstanceHandle.Nil);
        }

        public ReturnCode WriteDispose(
                AAMS_FC_AE_ASM_Channel instanceData,
                InstanceHandle instanceHandle)
        {
            return DDS.OpenSplice.FooDataWriter.WriteDispose(
                        this,
                        instanceData,
                        instanceHandle);
        }

        public ReturnCode WriteDisposeWithTimestamp(
                AAMS_FC_AE_ASM_Channel instanceData,
                Time sourceTimestamp)
        {
            return WriteDisposeWithTimestamp(instanceData, InstanceHandle.Nil, sourceTimestamp);
        }

        public ReturnCode WriteDisposeWithTimestamp(
                AAMS_FC_AE_ASM_Channel instanceData,
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
                ref AAMS_FC_AE_ASM_Channel key,
                InstanceHandle instanceHandle)
        {
            object keyObj = key;
            ReturnCode result = DDS.OpenSplice.FooDataWriter.GetKeyValue(
                                    this,
                                    ref keyObj,
                                    instanceHandle);
            if (keyObj != key) key = keyObj as AAMS_FC_AE_ASM_Channel;
            return result;
        }

        public InstanceHandle LookupInstance(
            AAMS_FC_AE_ASM_Channel instanceData)
        {
            InstanceHandle result = DDS.OpenSplice.FooDataWriter.LookupInstance(
                                        this,
                                        instanceData);
            return result;
        }
    }
    #endregion

    #region AAMS_FC_AE_ASM_ChannelTypeSupport
    public class AAMS_FC_AE_ASM_ChannelTypeSupport : DDS.OpenSplice.TypeSupport
    {
        private const string typeName = "datarouter::AAMS_FC_AE_ASM_Channel";
        private const string keyList = "id";
        private const string metaDescriptor = "<MetaData version=\"1.0.0\"><Module name=\"datarouter\"><Struct name=\"Payload\"><Member name=\"value\"><Octet/></Member></Struct><TypeDef name=\"PayloadTypeAAMS_FC_AE_ASM\"><Sequence><Type name=\"datarouter::Payload\"/></Sequence></TypeDef><Struct name=\"AAMS_FC_AE_ASM_msg\"><Member name=\"id\"><ULong/></Member><Member name=\"msgId\"><ULong/></Member><Member name=\"vendorSpecificSecurity\"><ULong/></Member><Member name=\"reserved\"><ULong/></Member><Member name=\"priority\"><ULong/></Member><Member name=\"msgLength\"><ULong/></Member><Member name=\"lByte\"><ULong/></Member><Member name=\"sec\"><ULong/></Member><Member name=\"usec\"><ULong/></Member><Member name=\"payload\"><Type name=\"datarouter::PayloadTypeAAMS_FC_AE_ASM\"/></Member></Struct><Struct name=\"AAMS_FC_AE_ASM_Channel\"><Member name=\"id\"><ULong/></Member><Member name=\"msgs\"><Sequence><Type name=\"datarouter::AAMS_FC_AE_ASM_msg\"/></Sequence></Member></Struct></Module></MetaData>";

        public AAMS_FC_AE_ASM_ChannelTypeSupport()
            : base(typeof(AAMS_FC_AE_ASM_Channel))
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
            return RegisterType(participant, typeName, new AAMS_FC_AE_ASM_ChannelMarshaler());
        }

        public override DDS.OpenSplice.DataWriter CreateDataWriter(IntPtr gapiPtr)
        {
            return new AAMS_FC_AE_ASM_ChannelDataWriter(this, gapiPtr);
        }

        public override DDS.OpenSplice.DataReader CreateDataReader(IntPtr gapiPtr)
        {
            return new AAMS_FC_AE_ASM_ChannelDataReader(this, gapiPtr);
        }
    }
    #endregion
}

