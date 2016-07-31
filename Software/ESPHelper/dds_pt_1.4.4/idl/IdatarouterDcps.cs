using DDS;
using DDS.OpenSplice;

namespace datarouter
{

    #region IEVENT_msgDataReader
    public interface IEVENT_msgDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            EVENT_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            EVENT_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref EVENT_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref EVENT_msg key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            EVENT_msg instance);
    }
    #endregion

    #region IEVENT_msgDataWriter
    public interface IEVENT_msgDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            EVENT_msg instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            EVENT_msg instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            EVENT_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            EVENT_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            EVENT_msg instanceData);

        ReturnCode Write(
            EVENT_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            EVENT_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            EVENT_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            EVENT_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            EVENT_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            EVENT_msg instanceData);

        ReturnCode WriteDispose(
            EVENT_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            EVENT_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            EVENT_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref EVENT_msg key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            EVENT_msg instanceData);
    }
    #endregion

    #region ICONTROL_msgDataReader
    public interface ICONTROL_msgDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            CONTROL_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            CONTROL_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref CONTROL_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref CONTROL_msg key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            CONTROL_msg instance);
    }
    #endregion

    #region ICONTROL_msgDataWriter
    public interface ICONTROL_msgDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            CONTROL_msg instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            CONTROL_msg instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            CONTROL_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            CONTROL_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            CONTROL_msg instanceData);

        ReturnCode Write(
            CONTROL_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            CONTROL_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            CONTROL_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            CONTROL_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            CONTROL_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            CONTROL_msg instanceData);

        ReturnCode WriteDispose(
            CONTROL_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            CONTROL_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            CONTROL_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref CONTROL_msg key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            CONTROL_msg instanceData);
    }
    #endregion

    #region ICONTROL_STATUS_msgDataReader
    public interface ICONTROL_STATUS_msgDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            CONTROL_STATUS_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            CONTROL_STATUS_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref CONTROL_STATUS_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref CONTROL_STATUS_msg key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            CONTROL_STATUS_msg instance);
    }
    #endregion

    #region ICONTROL_STATUS_msgDataWriter
    public interface ICONTROL_STATUS_msgDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            CONTROL_STATUS_msg instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            CONTROL_STATUS_msg instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            CONTROL_STATUS_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            CONTROL_STATUS_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            CONTROL_STATUS_msg instanceData);

        ReturnCode Write(
            CONTROL_STATUS_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            CONTROL_STATUS_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            CONTROL_STATUS_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            CONTROL_STATUS_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            CONTROL_STATUS_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            CONTROL_STATUS_msg instanceData);

        ReturnCode WriteDispose(
            CONTROL_STATUS_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            CONTROL_STATUS_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            CONTROL_STATUS_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref CONTROL_STATUS_msg key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            CONTROL_STATUS_msg instanceData);
    }
    #endregion

    #region IAAMS_429_msgDataReader
    public interface IAAMS_429_msgDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_429_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_429_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_429_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_429_msg key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_429_msg instance);
    }
    #endregion

    #region IAAMS_429_msgDataWriter
    public interface IAAMS_429_msgDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_429_msg instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_429_msg instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_429_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_429_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_429_msg instanceData);

        ReturnCode Write(
            AAMS_429_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_429_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_429_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_429_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_429_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_429_msg instanceData);

        ReturnCode WriteDispose(
            AAMS_429_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_429_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_429_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_429_msg key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_429_msg instanceData);
    }
    #endregion

    #region IAAMS_429_ChannelDataReader
    public interface IAAMS_429_ChannelDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_429_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_429_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_429_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_429_Channel key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_429_Channel instance);
    }
    #endregion

    #region IAAMS_429_ChannelDataWriter
    public interface IAAMS_429_ChannelDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_429_Channel instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_429_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_429_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_429_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_429_Channel instanceData);

        ReturnCode Write(
            AAMS_429_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_429_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_429_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_429_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_429_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_429_Channel instanceData);

        ReturnCode WriteDispose(
            AAMS_429_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_429_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_429_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_429_Channel key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_429_Channel instanceData);
    }
    #endregion

    #region IAAMS_NoBus_msgDataReader
    public interface IAAMS_NoBus_msgDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_NoBus_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_NoBus_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_NoBus_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_NoBus_msg key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_NoBus_msg instance);
    }
    #endregion

    #region IAAMS_NoBus_msgDataWriter
    public interface IAAMS_NoBus_msgDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_NoBus_msg instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_NoBus_msg instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_NoBus_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_NoBus_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_NoBus_msg instanceData);

        ReturnCode Write(
            AAMS_NoBus_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_NoBus_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_NoBus_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_NoBus_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_NoBus_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_NoBus_msg instanceData);

        ReturnCode WriteDispose(
            AAMS_NoBus_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_NoBus_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_NoBus_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_NoBus_msg key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_NoBus_msg instanceData);
    }
    #endregion

    #region IAAMS_NoBus_ChannelDataReader
    public interface IAAMS_NoBus_ChannelDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_NoBus_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_NoBus_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_NoBus_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_NoBus_Channel key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_NoBus_Channel instance);
    }
    #endregion

    #region IAAMS_NoBus_ChannelDataWriter
    public interface IAAMS_NoBus_ChannelDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_NoBus_Channel instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_NoBus_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_NoBus_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_NoBus_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_NoBus_Channel instanceData);

        ReturnCode Write(
            AAMS_NoBus_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_NoBus_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_NoBus_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_NoBus_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_NoBus_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_NoBus_Channel instanceData);

        ReturnCode WriteDispose(
            AAMS_NoBus_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_NoBus_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_NoBus_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_NoBus_Channel key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_NoBus_Channel instanceData);
    }
    #endregion

    #region IAAMS_1553_msgDataReader
    public interface IAAMS_1553_msgDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_1553_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_1553_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_1553_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_1553_msg key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_1553_msg instance);
    }
    #endregion

    #region IAAMS_1553_msgDataWriter
    public interface IAAMS_1553_msgDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_1553_msg instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_1553_msg instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_1553_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_1553_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_1553_msg instanceData);

        ReturnCode Write(
            AAMS_1553_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_1553_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_1553_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_1553_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_1553_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_1553_msg instanceData);

        ReturnCode WriteDispose(
            AAMS_1553_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_1553_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_1553_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_1553_msg key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_1553_msg instanceData);
    }
    #endregion

    #region IAAMS_1553_ChannelDataReader
    public interface IAAMS_1553_ChannelDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_1553_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_1553_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_1553_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_1553_Channel key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_1553_Channel instance);
    }
    #endregion

    #region IAAMS_1553_ChannelDataWriter
    public interface IAAMS_1553_ChannelDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_1553_Channel instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_1553_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_1553_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_1553_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_1553_Channel instanceData);

        ReturnCode Write(
            AAMS_1553_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_1553_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_1553_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_1553_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_1553_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_1553_Channel instanceData);

        ReturnCode WriteDispose(
            AAMS_1553_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_1553_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_1553_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_1553_Channel key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_1553_Channel instanceData);
    }
    #endregion

    #region IAAMS_422_msgDataReader
    public interface IAAMS_422_msgDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_422_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_422_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_422_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_422_msg key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_422_msg instance);
    }
    #endregion

    #region IAAMS_422_msgDataWriter
    public interface IAAMS_422_msgDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_422_msg instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_422_msg instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_422_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_422_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_422_msg instanceData);

        ReturnCode Write(
            AAMS_422_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_422_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_422_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_422_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_422_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_422_msg instanceData);

        ReturnCode WriteDispose(
            AAMS_422_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_422_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_422_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_422_msg key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_422_msg instanceData);
    }
    #endregion

    #region IAAMS_422_ChannelDataReader
    public interface IAAMS_422_ChannelDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_422_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_422_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_422_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_422_Channel key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_422_Channel instance);
    }
    #endregion

    #region IAAMS_422_ChannelDataWriter
    public interface IAAMS_422_ChannelDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_422_Channel instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_422_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_422_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_422_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_422_Channel instanceData);

        ReturnCode Write(
            AAMS_422_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_422_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_422_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_422_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_422_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_422_Channel instanceData);

        ReturnCode WriteDispose(
            AAMS_422_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_422_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_422_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_422_Channel key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_422_Channel instanceData);
    }
    #endregion

    #region IAAMS_CAN_msgDataReader
    public interface IAAMS_CAN_msgDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_CAN_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_CAN_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_CAN_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_CAN_msg key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_CAN_msg instance);
    }
    #endregion

    #region IAAMS_CAN_msgDataWriter
    public interface IAAMS_CAN_msgDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_CAN_msg instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_CAN_msg instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_CAN_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_CAN_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_CAN_msg instanceData);

        ReturnCode Write(
            AAMS_CAN_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_CAN_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_CAN_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_CAN_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_CAN_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_CAN_msg instanceData);

        ReturnCode WriteDispose(
            AAMS_CAN_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_CAN_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_CAN_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_CAN_msg key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_CAN_msg instanceData);
    }
    #endregion

    #region IAAMS_CAN_ChannelDataReader
    public interface IAAMS_CAN_ChannelDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_CAN_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_CAN_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_CAN_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_CAN_Channel key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_CAN_Channel instance);
    }
    #endregion

    #region IAAMS_CAN_ChannelDataWriter
    public interface IAAMS_CAN_ChannelDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_CAN_Channel instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_CAN_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_CAN_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_CAN_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_CAN_Channel instanceData);

        ReturnCode Write(
            AAMS_CAN_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_CAN_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_CAN_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_CAN_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_CAN_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_CAN_Channel instanceData);

        ReturnCode WriteDispose(
            AAMS_CAN_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_CAN_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_CAN_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_CAN_Channel key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_CAN_Channel instanceData);
    }
    #endregion

    #region IAAMS_RFM_msgDataReader
    public interface IAAMS_RFM_msgDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_RFM_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_RFM_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_RFM_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_RFM_msg key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_RFM_msg instance);
    }
    #endregion

    #region IAAMS_RFM_msgDataWriter
    public interface IAAMS_RFM_msgDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_RFM_msg instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_RFM_msg instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_RFM_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_RFM_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_RFM_msg instanceData);

        ReturnCode Write(
            AAMS_RFM_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_RFM_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_RFM_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_RFM_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_RFM_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_RFM_msg instanceData);

        ReturnCode WriteDispose(
            AAMS_RFM_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_RFM_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_RFM_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_RFM_msg key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_RFM_msg instanceData);
    }
    #endregion

    #region IAAMS_RFM_ChannelDataReader
    public interface IAAMS_RFM_ChannelDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_RFM_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_RFM_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_RFM_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_RFM_Channel key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_RFM_Channel instance);
    }
    #endregion

    #region IAAMS_RFM_ChannelDataWriter
    public interface IAAMS_RFM_ChannelDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_RFM_Channel instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_RFM_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_RFM_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_RFM_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_RFM_Channel instanceData);

        ReturnCode Write(
            AAMS_RFM_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_RFM_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_RFM_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_RFM_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_RFM_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_RFM_Channel instanceData);

        ReturnCode WriteDispose(
            AAMS_RFM_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_RFM_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_RFM_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_RFM_Channel key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_RFM_Channel instanceData);
    }
    #endregion

    #region IAAMS_HDLC_msgDataReader
    public interface IAAMS_HDLC_msgDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_HDLC_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_HDLC_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_HDLC_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_HDLC_msg key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_HDLC_msg instance);
    }
    #endregion

    #region IAAMS_HDLC_msgDataWriter
    public interface IAAMS_HDLC_msgDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_HDLC_msg instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_HDLC_msg instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_HDLC_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_HDLC_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_HDLC_msg instanceData);

        ReturnCode Write(
            AAMS_HDLC_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_HDLC_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_HDLC_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_HDLC_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_HDLC_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_HDLC_msg instanceData);

        ReturnCode WriteDispose(
            AAMS_HDLC_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_HDLC_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_HDLC_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_HDLC_msg key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_HDLC_msg instanceData);
    }
    #endregion

    #region IAAMS_HDLC_ChannelDataReader
    public interface IAAMS_HDLC_ChannelDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_HDLC_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_HDLC_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_HDLC_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_HDLC_Channel key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_HDLC_Channel instance);
    }
    #endregion

    #region IAAMS_HDLC_ChannelDataWriter
    public interface IAAMS_HDLC_ChannelDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_HDLC_Channel instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_HDLC_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_HDLC_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_HDLC_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_HDLC_Channel instanceData);

        ReturnCode Write(
            AAMS_HDLC_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_HDLC_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_HDLC_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_HDLC_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_HDLC_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_HDLC_Channel instanceData);

        ReturnCode WriteDispose(
            AAMS_HDLC_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_HDLC_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_HDLC_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_HDLC_Channel key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_HDLC_Channel instanceData);
    }
    #endregion

    #region IAAMS_Eth_msgDataReader
    public interface IAAMS_Eth_msgDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_Eth_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_Eth_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_Eth_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_Eth_msg key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_Eth_msg instance);
    }
    #endregion

    #region IAAMS_Eth_msgDataWriter
    public interface IAAMS_Eth_msgDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_Eth_msg instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_Eth_msg instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_Eth_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_Eth_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_Eth_msg instanceData);

        ReturnCode Write(
            AAMS_Eth_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_Eth_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_Eth_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_Eth_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_Eth_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_Eth_msg instanceData);

        ReturnCode WriteDispose(
            AAMS_Eth_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_Eth_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_Eth_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_Eth_msg key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_Eth_msg instanceData);
    }
    #endregion

    #region IAAMS_Eth_ChannelDataReader
    public interface IAAMS_Eth_ChannelDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_Eth_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_Eth_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_Eth_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_Eth_Channel key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_Eth_Channel instance);
    }
    #endregion

    #region IAAMS_Eth_ChannelDataWriter
    public interface IAAMS_Eth_ChannelDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_Eth_Channel instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_Eth_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_Eth_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_Eth_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_Eth_Channel instanceData);

        ReturnCode Write(
            AAMS_Eth_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_Eth_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_Eth_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_Eth_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_Eth_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_Eth_Channel instanceData);

        ReturnCode WriteDispose(
            AAMS_Eth_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_Eth_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_Eth_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_Eth_Channel key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_Eth_Channel instanceData);
    }
    #endregion

    #region IAAMS_IMBADB_msgDataReader
    public interface IAAMS_IMBADB_msgDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_IMBADB_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_IMBADB_msg dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_IMBADB_msg[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_IMBADB_msg key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_IMBADB_msg instance);
    }
    #endregion

    #region IAAMS_IMBADB_msgDataWriter
    public interface IAAMS_IMBADB_msgDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_IMBADB_msg instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_IMBADB_msg instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_IMBADB_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_IMBADB_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_IMBADB_msg instanceData);

        ReturnCode Write(
            AAMS_IMBADB_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_IMBADB_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_IMBADB_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_IMBADB_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_IMBADB_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_IMBADB_msg instanceData);

        ReturnCode WriteDispose(
            AAMS_IMBADB_msg instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_IMBADB_msg instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_IMBADB_msg instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_IMBADB_msg key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_IMBADB_msg instanceData);
    }
    #endregion

    #region IAAMS_IMBADB_ChannelDataReader
    public interface IAAMS_IMBADB_ChannelDataReader : DDS.IDataReader
    {
        ReturnCode Read(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Read(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Read(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Read(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode Take(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples);

        ReturnCode Take(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode Take(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadWithCondition(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode ReadWithCondition(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            IReadCondition readCondition);

        ReturnCode TakeWithCondition(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            IReadCondition readCondition);

        ReturnCode ReadNextSample(
            AAMS_IMBADB_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode TakeNextSample(
            AAMS_IMBADB_Channel dataValue,
            SampleInfo sampleInfo);

        ReturnCode ReadInstance(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadInstance(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeInstance(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeInstance(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstance(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode ReadNextInstance(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode TakeNextInstance(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle);

        ReturnCode TakeNextInstance(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            SampleStateKind sampleStates,
            ViewStateKind viewStates,
            InstanceStateKind instanceStates);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReadNextInstanceWithCondition(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode TakeNextInstanceWithCondition(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos,
            int maxSamples,
            InstanceHandle instanceHandle,
            IReadCondition readCondition);

        ReturnCode ReturnLoan(
            ref AAMS_IMBADB_Channel[] dataValues,
            ref SampleInfo[] sampleInfos);

        ReturnCode GetKeyValue(
            ref AAMS_IMBADB_Channel key,
            InstanceHandle handle);

        InstanceHandle LookupInstance(
            AAMS_IMBADB_Channel instance);
    }
    #endregion

    #region IAAMS_IMBADB_ChannelDataWriter
    public interface IAAMS_IMBADB_ChannelDataWriter : DDS.IDataWriter
    {
        InstanceHandle RegisterInstance(
            AAMS_IMBADB_Channel instanceData);

        InstanceHandle RegisterInstanceWithTimestamp(
            AAMS_IMBADB_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode UnregisterInstance(
            AAMS_IMBADB_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode UnregisterInstanceWithTimestamp(
            AAMS_IMBADB_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Write(
            AAMS_IMBADB_Channel instanceData);

        ReturnCode Write(
            AAMS_IMBADB_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteWithTimestamp(
            AAMS_IMBADB_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteWithTimestamp(
            AAMS_IMBADB_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode Dispose(
            AAMS_IMBADB_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode DisposeWithTimestamp(
            AAMS_IMBADB_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode WriteDispose(
            AAMS_IMBADB_Channel instanceData);

        ReturnCode WriteDispose(
            AAMS_IMBADB_Channel instanceData,
            InstanceHandle instanceHandle);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_IMBADB_Channel instanceData,
            Time sourceTimestamp);

        ReturnCode WriteDisposeWithTimestamp(
            AAMS_IMBADB_Channel instanceData,
            InstanceHandle instanceHandle,
            Time sourceTimestamp);

        ReturnCode GetKeyValue(
            ref AAMS_IMBADB_Channel key,
            InstanceHandle instanceHandle);

        InstanceHandle LookupInstance(
            AAMS_IMBADB_Channel instanceData);
    }
    #endregion

}

