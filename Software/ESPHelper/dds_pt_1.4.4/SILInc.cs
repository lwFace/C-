using datarouter;
using DDS;
using System;
namespace com.hirain.avionics.dds
{

	/// <summary>
	/// @author jialun.liu </summary>
	/// <seealso cref= HILInc </seealso>
	public class SILInc : DDSBaseInterface
	{
	  /// <seealso cref= com.hirain.avionics.dds.DDSBaseInterface#DDSBaseInterface(int, String) </seealso>
	  public SILInc(int domainId, string partition) : base(domainId, partition)
	  {
	  }

	  /// <seealso cref= com.hirain.avionics.dds.DDSBaseInterface#DDSBaseInterface(int) </seealso>
	  public SILInc(int domainId) : base(domainId)
	  {
	  }

	  public SILInc(int domainId, string[] partitions) : base(domainId, partitions)
	  {
	  }

	  private datarouter.SIL_msgDataReader fM_SILReader;

	  private datarouter.SIL_ChannelDataReader fC_SILReader;

	  private datarouter.SIL_msgDataWriter fM_SILWriter;

	  private datarouter.SIL_ChannelDataWriter fC_SILWriter;

	  private datarouter.SIL_msgTypeSupport msgTS = new datarouter.SIL_msgTypeSupport();

	  private datarouter.SIL_ChannelTypeSupport channelTS = new datarouter.SIL_ChannelTypeSupport();

	  protected internal override DDS.ITypeSupport MsgTypeSupport
	  {
		  get
		  {
			return msgTS;
		  }
	  }

	  protected internal override DDS.ITypeSupport ChannelTypeSupport
	  {
		  get
		  {
			return channelTS;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected void createWriter() throws WrapperException
	  protected internal override void createWriter()
	  {
		base.createWriter();
		if (fMWriter != null)
		{
            fM_SILWriter = fMWriter as SIL_msgDataWriter;
		}
		if (fCWriter != null)
		{
            fC_SILWriter = fCWriter as SIL_ChannelDataWriter;
		}

	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected void createReader() throws WrapperException
	  protected internal override void createReader()
	  {
		base.createReader();
		if (fMReader != null)
		{
            fM_SILReader = fMReader as SIL_msgDataReader;
		}
		if (fCReader != null)
		{
            fC_SILReader = fCReader as SIL_ChannelDataReader;
		}
	  }

	  /// <summary>
	  /// 鐏忓棙瀵氱�姝婭L msg閸欐垿锟介崚鐧塂S閵嗭�?
	  /// </summary>
	  /// <param name="msg">
	  ///          SIL msg to be write in DDS. </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeSIL(datarouter.SIL_msg msg)
	  {
		if (fM_SILWriter == null)
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
		return (int)fM_SILWriter.Write(msg, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 鐏忓棙瀵氱�姝婭L channel閸欐垿锟介崚鐧塂S閵嗭�?
	  /// </summary>
	  /// <param name="channel">
	  ///          data to be write in DDS </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeSIL_Channel(datarouter.SIL_Channel channel)
	  {
		if (fC_SILWriter == null)
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
        return (int)fC_SILWriter.Write(channel, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 閼惧嘲褰嘢IL msg Data Reader閿涘瞼鏁ゆ禍搴ゎ嚢閸欐湆DS閺佺増宓侀妴锟�?*
	  /// </summary>
	  /// <returns> SIL msg Topic data reader </returns>
	  public virtual datarouter.SIL_msgDataReader M_SILReader
	  {
		  get
		  {
			if (fM_SILReader == null)
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
			return fM_SILReader;
		  }
	  }

	  /// <summary>
	  /// 閼惧嘲褰嘢IL channel Data Reader閿涘瞼鏁ゆ禍搴ゎ嚢閸欐湆DS閺佺増宓侀妴锟�?*
	  /// </summary>
	  /// <returns> SIL Channel Topic data reader </returns>
	  public virtual datarouter.SIL_ChannelDataReader C_SILReader
	  {
		  get
		  {
			if (fC_SILReader == null)
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
			return fC_SILReader;
		  }
	  }

	  protected internal override void fillQos(DDS.TopicQos qos)
	  {
		base.fillQos(qos);
		qos.History.Depth = 1;
	  }

	}

}