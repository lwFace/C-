using datarouter;
using DDS;
using System;
namespace com.hirain.avionics.dds
{
	/// <summary>
	/// @author jialun.liu </summary>
	/// <seealso cref= HILInc </seealso>
	public class AAMS_1553_Inc : AAMSBaseInterface
	{

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int, String) </seealso>
	  public AAMS_1553_Inc(int domainId, string partition) : base(domainId, partition)
	  {
	  }

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int) </seealso>
	  public AAMS_1553_Inc(int domainId) : base(domainId)
	  {
	  }

	  public AAMS_1553_Inc(int domainId, string[] partitions) : base(domainId, partitions)
	  {
	  }

	  private datarouter.AAMS_1553_msgDataReader fM_AAMS_1553Reader;

	  private datarouter.AAMS_1553_ChannelDataReader fC_AAMS_1553Reader;

	  private datarouter.AAMS_1553_msgDataWriter fM_AAMS_1553Writer;

	  private datarouter.AAMS_1553_ChannelDataWriter fC_AAMS_1553Writer;

	  private datarouter.AAMS_1553_msgTypeSupport fM_ts = new datarouter.AAMS_1553_msgTypeSupport();

	  private datarouter.AAMS_1553_ChannelTypeSupport fC_ts = new datarouter.AAMS_1553_ChannelTypeSupport();

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
            fM_AAMS_1553Writer = fMWriter as AAMS_1553_msgDataWriter;
		}
		if (fCWriter != null)
		{
            fC_AAMS_1553Writer = fCWriter as AAMS_1553_ChannelDataWriter;
		}

	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected void createReader() throws WrapperException
	  protected internal override void createReader()
	  {
		base.createReader();
		if (fMReader != null)
		{
            fM_AAMS_1553Reader = fMReader as AAMS_1553_msgDataReader;
		}
		if (fCReader != null)
		{
            fC_AAMS_1553Reader = fCReader as AAMS_1553_ChannelDataReader;
		}
	  }

	  /// <summary>
	  /// 将指�?AAMS_1553_msg数据发送到DDS�?
	  /// </summary>
	  /// <param name="msg">
	  ///          AAMS_1553_msg </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeAAMS_1553(datarouter.AAMS_1553_msg msg)
	  {
		if (fM_AAMS_1553Writer == null)
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
        return (int)fM_AAMS_1553Writer.Write(msg, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 将指定AAMS 1553 channel数据发送到DDS�?
	  /// </summary>
	  /// <param name="channel">
	  ///          AAMS channel </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeAAMS_1553_Channel(datarouter.AAMS_1553_Channel channel)
	  {
		if (fC_AAMS_1553Writer == null)
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
        return (int)fC_AAMS_1553Writer.Write(channel, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 获取AAMS 1553 msg Data Reader.
	  /// </summary>
	  /// <returns> AAMS 1553 msg Data Reader </returns>
	  public virtual datarouter.AAMS_1553_msgDataReader M_AAMS_1553Reader
	  {
		  get
		  {
			if (fM_AAMS_1553Reader == null)
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
			return fM_AAMS_1553Reader;
		  }
	  }

	  /// <summary>
	  /// 获取AAMS 1553 channel Data Reader.
	  /// </summary>
	  /// <returns> AAMS 1553 channel Data Reader </returns>
	  public virtual datarouter.AAMS_1553_ChannelDataReader C_AAMS_1553Reader
	  {
		  get
		  {
			if (fC_AAMS_1553Reader == null)
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
			return fC_AAMS_1553Reader;
		  }
	  }

	}

}