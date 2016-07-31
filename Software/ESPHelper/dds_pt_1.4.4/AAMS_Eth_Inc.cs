using datarouter;
using DDS;
using System;
namespace com.hirain.avionics.dds
{
    /// <summary>
	/// @author jialun.liu </summary>
	/// <seealso cref= HILInc </seealso>
	public class AAMS_Eth_Inc : AAMSBaseInterface
	{

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int, String) </seealso>
	  public AAMS_Eth_Inc(int domainId, string partition) : base(domainId, partition)
	  {
	  }

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int) </seealso>
	  public AAMS_Eth_Inc(int domainId) : base(domainId)
	  {
	  }

	  public AAMS_Eth_Inc(int domainId, string[] partitions) : base(domainId, partitions)
	  {
	  }

	  private datarouter.AAMS_Eth_msgDataReader fM_AAMS_EthReader;

	  private datarouter.AAMS_Eth_ChannelDataReader fC_AAMS_EthReader;

	  private datarouter.AAMS_Eth_msgDataWriter fM_AAMS_EthWriter;

	  private datarouter.AAMS_Eth_ChannelDataWriter fC_AAMS_EthWriter;

	  private datarouter.AAMS_Eth_msgTypeSupport fM_ts = new datarouter.AAMS_Eth_msgTypeSupport();

	  private datarouter.AAMS_Eth_ChannelTypeSupport fC_ts = new datarouter.AAMS_Eth_ChannelTypeSupport();

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
            fM_AAMS_EthWriter = fMWriter as AAMS_Eth_msgDataWriter;
		}
		if (fCWriter != null)
		{
            fC_AAMS_EthWriter = fCWriter as AAMS_Eth_ChannelDataWriter;
		}

	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected void createReader() throws WrapperException
	  protected internal override void createReader()
	  {
		base.createReader();
		if (fMReader != null)
		{
            fM_AAMS_EthReader = fMReader as AAMS_Eth_msgDataReader;
		}
		if (fCReader != null)
		{
            fC_AAMS_EthReader = fCReader as AAMS_Eth_ChannelDataReader; ;
		}
	  }

	  /// <summary>
	  /// 将指�?AAMS_Eth_msg数据发送到DDS�?
	  /// </summary>
	  /// <param name="msg">
	  ///          AAMS_Eth_msg </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeAAMS_Eth(datarouter.AAMS_Eth_msg msg)
	  {
		if (fM_AAMS_EthWriter == null)
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
        return (int)fM_AAMS_EthWriter.Write(msg, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 将指定AAMS Eth channel数据发送到DDS�?
	  /// </summary>
	  /// <param name="channel">
	  ///          AAMS channel </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeAAMS_Eth_Channel(datarouter.AAMS_Eth_Channel channel)
	  {
		if (fC_AAMS_EthWriter == null)
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
        return (int)fC_AAMS_EthWriter.Write(channel, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 获取AAMS Eth msg Data Reader.
	  /// </summary>
	  /// <returns> AAMS Eth msg Data Reader </returns>
	  public virtual datarouter.AAMS_Eth_msgDataReader M_AAMS_EthReader
	  {
		  get
		  {
			if (fM_AAMS_EthReader == null)
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
			return fM_AAMS_EthReader;
		  }
	  }

	  /// <summary>
	  /// 获取AAMS Eth channel Data Reader.
	  /// </summary>
	  /// <returns> AAMS Eth channel Data Reader </returns>
	  public virtual datarouter.AAMS_Eth_ChannelDataReader C_AAMS_EthReader
	  {
		  get
		  {
			if (fC_AAMS_EthReader == null)
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
			return fC_AAMS_EthReader;
		  }
	  }

	}

}