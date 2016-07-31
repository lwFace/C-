using datarouter;
using DDS;
using System;
namespace com.hirain.avionics.dds
{


	/// <summary>
	/// @author jialun.liu </summary>
	/// <seealso cref= HILInc </seealso>
	public class AAMS_RFM_Inc : AAMSBaseInterface
	{

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int, String) </seealso>
	  public AAMS_RFM_Inc(int domainId, string partition) : base(domainId, partition)
	  {
	  }

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int) </seealso>
	  public AAMS_RFM_Inc(int domainId) : base(domainId)
	  {
	  }

	  public AAMS_RFM_Inc(int domainId, string[] partitions) : base(domainId, partitions)
	  {
	  }

	  private datarouter.AAMS_RFM_msgDataReader fM_AAMS_RFMReader;

	  private datarouter.AAMS_RFM_ChannelDataReader fC_AAMS_RFMReader;

	  private datarouter.AAMS_RFM_msgDataWriter fM_AAMS_RFMWriter;

	  private datarouter.AAMS_RFM_ChannelDataWriter fC_AAMS_RFMWriter;

	  private datarouter.AAMS_RFM_msgTypeSupport fM_ts = new datarouter.AAMS_RFM_msgTypeSupport();

	  private datarouter.AAMS_RFM_ChannelTypeSupport fC_ts = new datarouter.AAMS_RFM_ChannelTypeSupport();

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
            fM_AAMS_RFMWriter = fMWriter as AAMS_RFM_msgDataWriter;
		}
		if (fCWriter != null)
		{
            fC_AAMS_RFMWriter = fCWriter as AAMS_RFM_ChannelDataWriter;
		}

	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected void createReader() throws WrapperException
	  protected internal override void createReader()
	  {
		base.createReader();
		if (fMReader != null)
		{
            fM_AAMS_RFMReader = fMReader as AAMS_RFM_msgDataReader;
		}
		if (fCReader != null)
		{
            fC_AAMS_RFMReader = fCReader as AAMS_RFM_ChannelDataReader;
		}
	  }

	  /// <summary>
	  /// 灏嗘寚瀹�AAMS_RFM_msg鏁版嵁鍙戦�鍒癉DS銆�
	  /// </summary>
	  /// <param name="msg">
	  ///          AAMS_RFM_msg </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeAAMS_RFM(datarouter.AAMS_RFM_msg msg)
	  {
		if (fM_AAMS_RFMWriter == null)
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
        return (int)fM_AAMS_RFMWriter.Write(msg, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 灏嗘寚瀹欰AMS RFM channel鏁版嵁鍙戦�鍒癉DS銆�
	  /// </summary>
	  /// <param name="channel">
	  ///          AAMS channel </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeAAMS_RFM_Channel(datarouter.AAMS_RFM_Channel channel)
	  {
		if (fC_AAMS_RFMWriter == null)
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
        return (int)fC_AAMS_RFMWriter.Write(channel, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 鑾峰彇AAMS RFM msg Data Reader.
	  /// </summary>
	  /// <returns> AAMS RFM msg Data Reader </returns>
	  public virtual datarouter.AAMS_RFM_msgDataReader M_AAMS_RFMReader
	  {
		  get
		  {
			if (fM_AAMS_RFMReader == null)
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
			return fM_AAMS_RFMReader;
		  }
	  }

	  /// <summary>
	  /// 鑾峰彇AAMS RFM channel Data Reader.
	  /// </summary>
	  /// <returns> AAMS RFM channel Data Reader </returns>
	  public virtual datarouter.AAMS_RFM_ChannelDataReader C_AAMS_RFMReader
	  {
		  get
		  {
			if (fC_AAMS_RFMReader == null)
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
			return fC_AAMS_RFMReader;
		  }
	  }

	}

}