using datarouter;
using DDS;
using System;
namespace com.hirain.avionics.dds
{
	public class HILInc : DDSBaseInterface
	{

	  /// <seealso cref= com.hirain.avionics.dds.DDSBaseInterface#DDSBaseInterface(int, String) </seealso>
	  public HILInc(int domainId, string partition) : base(domainId, partition)
	  {
	  }

	  /// <seealso cref= com.hirain.avionics.dds.DDSBaseInterface#DDSBaseInterface(int) </seealso>
	  public HILInc(int domainId) : base(domainId)
	  {
	  }

	  public HILInc(int domainId, string[] partitions) : base(domainId, partitions)
	  {
	  }

	  private datarouter.HIL_msgDataReader fM_HILReader;

	  private datarouter.HIL_ChannelDataReader fC_HILReader;

	  private datarouter.HIL_msgDataWriter fM_HILWriter;

	  private datarouter.HIL_msgDataWriter fM_Sti_HILWriter;

	  private datarouter.HIL_ChannelDataWriter fC_HILWriter;

	  private datarouter.HIL_msgTypeSupport msgTS = new datarouter.HIL_msgTypeSupport();

	  private datarouter.HIL_ChannelTypeSupport channelTS = new datarouter.HIL_ChannelTypeSupport();
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
            fM_HILWriter = fMWriter as HIL_msgDataWriter;
		}
		if (fCWriter != null)
		{
		  fC_HILWriter = fCWriter as HIL_ChannelDataWriter;
		}

		if (fM_Sti_HILWriter == null)
		{
            TopicQos topicQos = null;
            DataWriterQos RQosH = null;
            fMTopic.GetQos(ref topicQos);
            fPublisher.CopyFromTopicQos(ref RQosH, topicQos);
            DDS.IDataWriter writer = fPublisher.CreateDataWriter(fMTopic, RQosH, null, StatusKind.Any);
		  if (writer == null)
		  {
			throw new WrapperException("DDS_Base_Interface::createWriter()");
		  }
          fM_Sti_HILWriter = writer as HIL_msgDataWriter; 
		}
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected void createReader() throws WrapperException
	  protected internal override void createReader()
	  {
		base.createReader();
		if (fMReader != null)
		{
            fM_HILReader = fMReader as HIL_msgDataReader;
		}
		if (fCReader != null)
		{
            fC_HILReader = fCReader as HIL_ChannelDataReader; 
		}
	  }

	  protected internal override void fillQos(DDS.TopicQos qos)
	  {
		base.fillQos(qos);
		qos.History.Depth = 1;
	  }

	  /// <summary>
	  /// 鐏忓棙瀵氱�娆籌L msg閸欐垿锟介崚鐧塂S閵嗭�?
	  /// </summary>
	  /// <param name="msg">
	  ///          HIL msg to be write in DDS. </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeHIL(datarouter.HIL_msg msg)
	  {
		if (fM_HILWriter == null)
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
		return (int)fM_HILWriter.Write(msg, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 鐏忓棙瀵氱�娆籌L msg娴ｈ法鏁ゅ┑锟藉С閺傜懓绱￠崣鎴︼拷閸掔檳DS閵嗭�?
	  /// </summary>
	  /// @deprecated 娴ｈ法鏁ゅ┑锟藉СPartition娴狅絾娴涢張顒佸复閸欙拷 
	  /// <param name="msg">
	  ///          HIL msg to be write in DDS. </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeHIL_sti(datarouter.HIL_msg msg)
	  {
		if (fM_Sti_HILWriter == null)
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
		return (int)fM_Sti_HILWriter.Write(msg, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 鐏忓棙瀵氱�娆籌L channel閸欐垿锟介崚鐧塂S閵嗭�?
	  /// </summary>
	  /// <param name="channel">
	  ///          data to be write in DDS </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeHIL_Channel(datarouter.HIL_Channel channel)
	  {
		if (fC_HILWriter == null)
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
		return (int)fC_HILWriter.Write(channel, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 閼惧嘲褰嘓IL msg Data Reader閿涘瞼鏁ゆ禍搴ゎ嚢閸欐湆DS閺佺増宓侀妴锟�?*
	  /// </summary>
	  /// <returns> HIL msg Topic data reader </returns>
	  public virtual datarouter.HIL_msgDataReader M_HILReader
	  {
		  get
		  {
			if (fM_HILReader == null)
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
			return fM_HILReader;
		  }
	  }

	  /// <summary>
	  /// 閼惧嘲褰嘓IL channel Data Reader閿涘瞼鏁ゆ禍搴ゎ嚢閸欐湆DS閺佺増宓侀妴锟�?*
	  /// </summary>
	  /// <returns> HIL Channel Topic data reader </returns>
	  public virtual datarouter.HIL_ChannelDataReader C_HILReader
	  {
		  get
		  {
			if (fC_HILReader == null)
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
			return fC_HILReader;
		  }
	  }

	}

}