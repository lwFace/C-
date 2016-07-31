using datarouter;
using DDS;
using System;
namespace com.hirain.avionics.dds
{
	/// <summary>
	/// @author jialun.liu
	/// </summary>
	public class EventInc : DDSBaseInterface
	{
	  /// <summary>
	  /// 榛樿Writer/Reader娣卞�?00.
	  /// </summary>
	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int, String) </seealso>
	  public EventInc(int domainId, string partition) : base(domainId, partition)
	  {
	  }

	  /// <summary>
	  /// 榛樿Writer/Reader娣卞�?00.
	  /// </summary>
	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int) </seealso>
	  public EventInc(int domainId) : base(domainId, "Event")
	  {
	  }

	  public EventInc(int domainId, string[] partitions) : base(domainId, partitions)
	  {
	  }

	  private datarouter.EVENT_msgDataReader fM_EventReader;

	  private datarouter.EVENT_msgDataWriter fM_EventWriter;

	  private datarouter.EVENT_msgTypeSupport fmsgTS = new datarouter.EVENT_msgTypeSupport();

	  protected internal override DDS.ITypeSupport MsgTypeSupport
	  {
		  get
		  {
			return fmsgTS;
		  }
	  }

	  protected internal override DDS.ITypeSupport ChannelTypeSupport
	  {
		  get
		  {
			return null;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected void createWriter() throws WrapperException
	  protected internal override void createWriter()
	  {
		base.createWriter();
		if (fMWriter != null)
		{
            fM_EventWriter = fMWriter as EVENT_msgDataWriter;
		}
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected void createReader() throws WrapperException
	  protected internal override void createReader()
	  {
		base.createReader();
		if (fMReader != null)
		{
		  fM_EventReader = fMReader as EVENT_msgDataReader;
		}
	  }

      protected internal override void fillQos(DDS.TopicQos qos)
	  {
		base.fillQos(qos);
        qos.DestinationOrder.Kind = DDS.DestinationOrderQosPolicyKind.ByReceptionTimestampDestinationorderQos;
		qos.Durability.Kind = DDS.DurabilityQosPolicyKind.TransientDurabilityQos;
		qos.History.Depth = 100;
	  }

	  /// <summary>
	  /// 灏嗘寚瀹欵VENT msg鏁版嵁鍐欏叆DDS銆�
	  /// </summary>
	  /// <param name="msg">
	  ///          鎸囧畾EVENT msg </param>
	  /// <returns> 姝ｇ‘杩斿洖0锛岄敊璇繑鍥炲叾浠栧�銆� </returns>
	  public virtual int writeEvent(datarouter.EVENT_msg msg)
	  {
		if (fM_EventWriter == null)
		{
		  try
		  {
			createWriter();
		  }
		  catch (WrapperException e)
		  {
			Console.WriteLine(e.ToString());
			Console.Write(e.StackTrace);
			return -1;
		  }
		}
        return (int)fM_EventWriter.Write(msg, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 鑾峰彇EVENT msg Data Reader銆�
	  /// </summary>
	  /// <returns> EVENT msg Data Reader </returns>
	  public virtual datarouter.EVENT_msgDataReader M_EventReader
	  {
		  get
		  {
			if (fM_EventReader == null)
			{
			  try
			  {
				createReader();
			  }
			  catch (WrapperException e)
			  {
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
				return null;
			  }
			}
			return fM_EventReader;
		  }
	  }

	  /// <summary>
	  /// 鑾峰彇EVENT msg Data Reader銆�
	  /// </summary>
	  /// @deprecated 浣跨敤getM_EventReader()浠ｆ浛銆�? 
	  /// <returns> EVENT msg Data Reader </returns>
	  public virtual datarouter.EVENT_msgDataReader M_EventReader4aams
	  {
		  get
		  {
			if (fM_EventReader == null)
			{
			  try
			  {
				createReader();
			  }
			  catch (WrapperException e)
			  {
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
				return null;
			  }
			}
			return fM_EventReader;
		  }
	  }
	}
}