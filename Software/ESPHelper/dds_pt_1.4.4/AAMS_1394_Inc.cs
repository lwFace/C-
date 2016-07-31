using datarouter;
using DDS;
using System;
namespace com.hirain.avionics.dds
{

	/// <summary>
	/// @author jialun.liu </summary>
	/// <seealso cref= HILInc </seealso>
	public class AAMS_1394_Inc : AAMSBaseInterface
	{

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int, String) </seealso>
	  public AAMS_1394_Inc(int domainId, string partition) : base(domainId, partition)
	  {
	  }

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int) </seealso>
	  public AAMS_1394_Inc(int domainId) : base(domainId)
	  {
	  }

	  public AAMS_1394_Inc(int domainId, string[] partitions) : base(domainId, partitions)
	  {
	  }

	  private datarouter.AAMS_1394_msgDataReader fM_AAMS_1394Reader;

	  private datarouter.AAMS_1394_ChannelDataReader fC_AAMS_1394Reader;

	  private datarouter.AAMS_1394_msgDataWriter fM_AAMS_1394Writer;

	  private datarouter.AAMS_1394_ChannelDataWriter fC_AAMS_1394Writer;

	  private datarouter.AAMS_1394_msgTypeSupport fM_ts = new datarouter.AAMS_1394_msgTypeSupport();

	  private datarouter.AAMS_1394_ChannelTypeSupport fC_ts = new datarouter.AAMS_1394_ChannelTypeSupport();

	  protected internal override DDS.ITypeSupport MsgTypeSupport
	  {
		  get
		  {
			return fM_ts;
		  }
	  }

	  protected internal override DDS.ITypeSupport ChannelTypeSupport
	  {
		  get
		  {
			return fC_ts;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected void createWriter() throws WrapperException
	  protected internal override void createWriter()
	  {
		base.createWriter();
		if (fMWriter != null)
		{
            fM_AAMS_1394Writer = fMWriter as AAMS_1394_msgDataWriter;
		}
		if (fCWriter != null)
		{
            fC_AAMS_1394Writer = fCWriter as AAMS_1394_ChannelDataWriter;
		}

	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected void createReader() throws WrapperException
	  protected internal override void createReader()
	  {
		base.createReader();
		if (fMReader != null)
		{
            fM_AAMS_1394Reader = fMReader as AAMS_1394_msgDataReader;
		}
		if (fCReader != null)
		{
            fC_AAMS_1394Reader = fCReader as AAMS_1394_ChannelDataReader;
		}
	  }

	  /// <summary>
	  /// 将指�?AAMS_1394_msg数据发送到DDS�?
	  /// </summary>
	  /// <param name="msg">
	  ///          AAMS_1394_msg </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeAAMS_1394(datarouter.AAMS_1394_msg msg)
	  {
		if (fM_AAMS_1394Writer == null)
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
		return (int)fM_AAMS_1394Writer.Write(msg, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 将指定AAMS 1394 channel数据发送到DDS�?
	  /// </summary>
	  /// <param name="channel">
	  ///          AAMS channel </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeAAMS_1394_Channel(datarouter.AAMS_1394_Channel channel)
	  {
		if (fC_AAMS_1394Writer == null)
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
        return (int)fC_AAMS_1394Writer.Write(channel, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 获取AAMS 1394 msg Data Reader.
	  /// </summary>
	  /// <returns> AAMS 1394 msg Data Reader </returns>
	  public virtual datarouter.AAMS_1394_msgDataReader M_AAMS_1394Reader
	  {
		  get
		  {
			if (fM_AAMS_1394Reader == null)
			{
			  try
			  {
				createReader();
			  }
			  catch (WrapperException e)
			  {
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
			  }
			}
			return fM_AAMS_1394Reader;
		  }
	  }

	  /// <summary>
	  /// 获取AAMS 1394 channel Data Reader.
	  /// </summary>
	  /// <returns> AAMS 1394 channel Data Reader </returns>
	  public virtual datarouter.AAMS_1394_ChannelDataReader C_AAMS_1394Reader
	  {
		  get
		  {
			if (fC_AAMS_1394Reader == null)
			{
			  try
			  {
				createReader();
			  }
			  catch (WrapperException e)
			  {
				Console.WriteLine(e.ToString());
				Console.Write(e.StackTrace);
			  }
			}
			return fC_AAMS_1394Reader;
		  }
	  }

	}

}