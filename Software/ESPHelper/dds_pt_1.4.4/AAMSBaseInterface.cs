using DDS;
namespace com.hirain.avionics.dds
{

	/// <summary>
	/// 鎵�湁AAMS_* Topic閫氱敤鎺ュ彛锛岃缃鍙栨繁搴︿负100銆�
	/// 
	/// @author jialun.liu </summary>
	/// <seealso cref= HILInc </seealso>
	public abstract class AAMSBaseInterface : DDSBaseInterface
	{

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int, String) </seealso>
	  public AAMSBaseInterface(int domainId, string partition) : base(domainId, partition)
	  {
	  }

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int) </seealso>
	  public AAMSBaseInterface(int domainId) : base(domainId)
	  {
	  }

	  public AAMSBaseInterface(int domainId, string[] partitions) : base(domainId, partitions)
	  {
	  }

	  protected internal override void fillQos(DDS.TopicQos qos)
	  {
		base.fillQos(qos);
		qos.History.Depth = 100;
		qos.ResourceLimits.MaxInstances = 1000;
		qos.ResourceLimits.MaxSamples = -1;
		qos.ResourceLimits.MaxSamplesPerInstance = 1000;
	  }

	}

}