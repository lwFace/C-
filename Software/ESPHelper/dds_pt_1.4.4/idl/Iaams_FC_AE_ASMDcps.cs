using DDS;
using DDS.OpenSplice;

namespace datarouter
{
    #region IAAMS_FC_AE_ASM_msgDataReader
    public interface IAAMS_FC_AE_ASM_msgDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_FC_AE_ASM_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_FC_AE_ASM_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_FC_AE_ASM_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_FC_AE_ASM_msg key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_FC_AE_ASM_msg instance);
    }
    #endregion

    #region IAAMS_FC_AE_ASM_msgDataWriter
    public interface IAAMS_FC_AE_ASM_msgDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_FC_AE_ASM_msg instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_FC_AE_ASM_msg instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_FC_AE_ASM_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_FC_AE_ASM_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_FC_AE_ASM_msg instanceData);

        ReturnCode Write(
            AAMS_FC_AE_ASM_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_FC_AE_ASM_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_FC_AE_ASM_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_FC_AE_ASM_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_FC_AE_ASM_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_FC_AE_ASM_msg instanceData);

        ReturnCode WriteDispose(
            AAMS_FC_AE_ASM_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_FC_AE_ASM_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_FC_AE_ASM_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_FC_AE_ASM_msg key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_FC_AE_ASM_msg instanceData);
    }
    #endregion

    #region IAAMS_FC_AE_ASM_ChannelDataReader
    public interface IAAMS_FC_AE_ASM_ChannelDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_FC_AE_ASM_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_FC_AE_ASM_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_FC_AE_ASM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_FC_AE_ASM_Channel key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_FC_AE_ASM_Channel instance);
    }
    #endregion

    #region IAAMS_FC_AE_ASM_ChannelDataWriter
    public interface IAAMS_FC_AE_ASM_ChannelDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_FC_AE_ASM_Channel instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_FC_AE_ASM_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_FC_AE_ASM_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_FC_AE_ASM_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_FC_AE_ASM_Channel instanceData);

        ReturnCode Write(
            AAMS_FC_AE_ASM_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_FC_AE_ASM_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_FC_AE_ASM_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_FC_AE_ASM_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_FC_AE_ASM_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_FC_AE_ASM_Channel instanceData);

        ReturnCode WriteDispose(
            AAMS_FC_AE_ASM_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_FC_AE_ASM_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_FC_AE_ASM_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_FC_AE_ASM_Channel key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_FC_AE_ASM_Channel instanceData);
    }
    #endregion

}

