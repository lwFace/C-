using datarouter;
using DDS;
using System;
namespace com.hirain.avionics.dds
{


	/// <summary>
	/// @author jialun.liu </summary>
	/// <seealso cref= HILInc </seealso>
	public class AAMS_FlexRay_Inc : AAMSBaseInterface
	{

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int, String) </seealso>
	  public AAMS_FlexRay_Inc(int domainId, string partition) : base(domainId, partition)
	  {
	  }

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int) </seealso>
	  public AAMS_FlexRay_Inc(int domainId) : base(domainId)
	  {
	  }

	  public AAMS_FlexRay_Inc(int domainId, string[] partitions) : base(domainId, partitions)
	  {
	  }

	  private datarouter.AAMS_FlexRay_msgDataReader fM_AAMS_FlexRayReader;

	  private datarouter.AAMS_FlexRay_ChannelDataReader fC_AAMS_FlexRayReader;

	  private datarouter.AAMS_FlexRay_msgDataWriter fM_AAMS_FlexRayWriter;

	  private datarouter.AAMS_FlexRay_ChannelDataWriter fC_AAMS_FlexRayWriter;

	  private datarouter.AAMS_FlexRay_msgTypeSupport fM_ts = new datarouter.AAMS_FlexRay_msgTypeSupport();

	  private datarouter.AAMS_FlexRay_ChannelTypeSupport fC_ts = new datarouter.AAMS_FlexRay_ChannelTypeSupport();

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
            fM_AAMS_FlexRayWriter = fMWriter as AAMS_FlexRay_msgDataWriter;
		}
		if (fCWriter != null)
		{
            fC_AAMS_FlexRayWriter = fCWriter as AAMS_FlexRay_ChannelDataWriter;
		}

	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected void createReader() throws WrapperException
	  protected internal override void createReader()
	  {
		base.createReader();
		if (fMReader != null)
		{
            fM_AAMS_FlexRayReader = fMReader as AAMS_FlexRay_msgDataReader;
		}
		if (fCReader != null)
		{
            fC_AAMS_FlexRayReader = fCReader as AAMS_FlexRay_ChannelDataReader;
		}
	  }

	  /// <summary>
	  /// 将指�?AAMS_FlexRay_msg数据发�?到DDS�?
	  /// </summary>
	  /// <param name="msg">
	  ///          AAMS_FlexRay_msg </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeAAMS_FlexRay(datarouter.AAMS_FlexRay_msg msg)
	  {
		if (fM_AAMS_FlexRayWriter == null)
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
        return (int)fM_AAMS_FlexRayWriter.Write(msg, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 将指定AAMS FlexRay channel数据发�?到DDS�?
	  /// </summary>
	  /// <param name="channel">
	  ///          AAMS channel </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeAAMS_FlexRay_Channel(datarouter.AAMS_FlexRay_Channel channel)
	  {
		if (fC_AAMS_FlexRayWriter == null)
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
        return (int)fC_AAMS_FlexRayWriter.Write(channel, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 获取AAMS FlexRay msg Data Reader.
	  /// </summary>
	  /// <returns> AAMS FlexRay msg Data Reader </returns>
	  public virtual datarouter.AAMS_FlexRay_msgDataReader M_AAMS_FlexRayReader
	  {
		  get
		  {
			if (fM_AAMS_FlexRayReader == null)
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
			return fM_AAMS_FlexRayReader;
		  }
	  }

	  /// <summary>
	  /// 获取AAMS FlexRay channel Data Reader.
	  /// </summary>
	  /// <returns> AAMS FlexRay channel Data Reader </returns>
	  public virtual datarouter.AAMS_FlexRay_ChannelDataReader C_AAMS_FlexRayReader
	  {
		  get
		  {
			if (fC_AAMS_FlexRayReader == null)
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
			return fC_AAMS_FlexRayReader;
		  }
	  }

	}

}