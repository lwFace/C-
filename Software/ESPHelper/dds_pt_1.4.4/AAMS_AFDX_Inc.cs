using datarouter;
using DDS;
using System;
namespace com.hirain.avionics.dds
{


	/// <summary>
	/// @author jialun.liu </summary>
	/// <seealso cref= HILInc </seealso>
	public class AAMS_AFDX_Inc : AAMSBaseInterface
	{

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int, String) </seealso>
	  public AAMS_AFDX_Inc(int domainId, string partition) : base(domainId, partition)
	  {
	  }

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int) </seealso>
	  public AAMS_AFDX_Inc(int domainId) : base(domainId)
	  {
	  }

	  public AAMS_AFDX_Inc(int domainId, string[] partitions) : base(domainId, partitions)
	  {
	  }

	  private datarouter.AAMS_AFDX_msgDataReader fM_AAMS_AFDXReader;

	  private datarouter.AAMS_AFDX_ChannelDataReader fC_AAMS_AFDXReader;

	  private datarouter.AAMS_AFDX_msgDataWriter fM_AAMS_AFDXWriter;

	  private datarouter.AAMS_AFDX_ChannelDataWriter fC_AAMS_AFDXWriter;

	  private datarouter.AAMS_AFDX_msgTypeSupport fM_ts = new datarouter.AAMS_AFDX_msgTypeSupport();

	  private datarouter.AAMS_AFDX_ChannelTypeSupport fC_ts = new datarouter.AAMS_AFDX_ChannelTypeSupport();

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
            fM_AAMS_AFDXWriter = fMWriter as AAMS_AFDX_msgDataWriter;
		}
		if (fCWriter != null)
		{
            fC_AAMS_AFDXWriter = fCWriter as AAMS_AFDX_ChannelDataWriter;
		}

	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected void createReader() throws WrapperException
	  protected internal override void createReader()
	  {
		base.createReader();
		if (fMReader != null)
		{
            fM_AAMS_AFDXReader = fMReader as AAMS_AFDX_msgDataReader;
		}
		if (fCReader != null)
		{
            fC_AAMS_AFDXReader = fCReader as AAMS_AFDX_ChannelDataReader;
		}
	  }

	  /// <summary>
	  /// 将指�?AAMS_AFDX_msg数据发送到DDS�?
	  /// </summary>
	  /// <param name="msg">
	  ///          AAMS_AFDX_msg </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeAAMS_AFDX(datarouter.AAMS_AFDX_msg msg)
	  {
		if (fM_AAMS_AFDXWriter == null)
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
        return (int)fM_AAMS_AFDXWriter.Write(msg, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 将指定AAMS AFDX channel数据发送到DDS�?
	  /// </summary>
	  /// <param name="channel">
	  ///          AAMS channel </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeAAMS_AFDX_Channel(datarouter.AAMS_AFDX_Channel channel)
	  {
		if (fC_AAMS_AFDXWriter == null)
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
        return (int)fC_AAMS_AFDXWriter.Write(channel, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 获取AAMS AFDX msg Data Reader.
	  /// </summary>
	  /// <returns> AAMS AFDX msg Data Reader </returns>
	  public virtual datarouter.AAMS_AFDX_msgDataReader M_AAMS_AFDXReader
	  {
		  get
		  {
			if (fM_AAMS_AFDXReader == null)
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
			return fM_AAMS_AFDXReader;
		  }
	  }

	  /// <summary>
	  /// 获取AAMS AFDX channel Data Reader.
	  /// </summary>
	  /// <returns> AAMS AFDX channel Data Reader </returns>
	  public virtual datarouter.AAMS_AFDX_ChannelDataReader C_AAMS_AFDXReader
	  {
		  get
		  {
			if (fC_AAMS_AFDXReader == null)
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
			return fC_AAMS_AFDXReader;
		  }
	  }

	}

}