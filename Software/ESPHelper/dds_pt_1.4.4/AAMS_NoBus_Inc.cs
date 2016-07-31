using datarouter;
using DDS;
using System;
namespace com.hirain.avionics.dds
{


	/// <summary>
	/// @author jialun.liu </summary>
	/// <seealso cref= HILInc </seealso>
	public class AAMS_NoBus_Inc : AAMSBaseInterface
	{

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int, String) </seealso>
	  public AAMS_NoBus_Inc(int domainId, string partition) : base(domainId, partition)
	  {
	  }

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int) </seealso>
	  public AAMS_NoBus_Inc(int domainId) : base(domainId)
	  {
	  }

	  public AAMS_NoBus_Inc(int domainId, string[] partitions) : base(domainId, partitions)
	  {
	  }

	  private datarouter.AAMS_NoBus_msgDataReader fM_AAMS_NoBusReader;

	  private datarouter.AAMS_NoBus_ChannelDataReader fC_AAMS_NoBusReader;

	  private datarouter.AAMS_NoBus_msgDataWriter fM_AAMS_NoBusWriter;

	  private datarouter.AAMS_NoBus_ChannelDataWriter fC_AAMS_NoBusWriter;

	  private datarouter.AAMS_NoBus_msgTypeSupport fM_ts = new datarouter.AAMS_NoBus_msgTypeSupport();

	  private datarouter.AAMS_NoBus_ChannelTypeSupport fC_ts = new datarouter.AAMS_NoBus_ChannelTypeSupport();

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
            fM_AAMS_NoBusWriter = fMWriter as AAMS_NoBus_msgDataWriter;
		}
		if (fCWriter != null)
		{
            fC_AAMS_NoBusWriter = fCWriter as AAMS_NoBus_ChannelDataWriter;
		}

	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected void createReader() throws WrapperException
	  protected internal override void createReader()
	  {
		base.createReader();
		if (fMReader != null)
		{
            fM_AAMS_NoBusReader = fMReader as AAMS_NoBus_msgDataReader; 
		}
		if (fCReader != null)
		{
            fC_AAMS_NoBusReader = fCReader as AAMS_NoBus_ChannelDataReader;
		}
	  }

	  /// <summary>
	  /// 灏嗘寚瀹�AAMS_NoBus_msg鏁版嵁鍙戦�鍒癉DS銆�
	  /// </summary>
	  /// <param name="msg">
	  ///          AAMS_NoBus_msg </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeAAMS_NoBus(datarouter.AAMS_NoBus_msg msg)
	  {
		if (fM_AAMS_NoBusWriter == null)
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
        return (int)fM_AAMS_NoBusWriter.Write(msg, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 灏嗘寚瀹欰AMS NoBus channel鏁版嵁鍙戦�鍒癉DS銆�
	  /// </summary>
	  /// <param name="channel">
	  ///          AAMS channel </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeAAMS_NoBus_Channel(datarouter.AAMS_NoBus_Channel channel)
	  {
		if (fC_AAMS_NoBusWriter == null)
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
        return (int)fC_AAMS_NoBusWriter.Write(channel, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 鑾峰彇AAMS NoBus msg Data Reader.
	  /// </summary>
	  /// <returns> AAMS NoBus msg Data Reader </returns>
	  public virtual datarouter.AAMS_NoBus_msgDataReader M_AAMS_NoBusReader
	  {
		  get
		  {
			if (fM_AAMS_NoBusReader == null)
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
			return fM_AAMS_NoBusReader;
		  }
	  }

	  /// <summary>
	  /// 鑾峰彇AAMS NoBus channel Data Reader.
	  /// </summary>
	  /// <returns> AAMS NoBus channel Data Reader </returns>
	  public virtual datarouter.AAMS_NoBus_ChannelDataReader C_AAMS_NoBusReader
	  {
		  get
		  {
			if (fC_AAMS_NoBusReader == null)
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
			return fC_AAMS_NoBusReader;
		  }
	  }

	}

}