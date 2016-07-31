using datarouter;
using DDS;
using System;
namespace com.hirain.avionics.dds
{


	/// <summary>
	/// @author jialun.liu </summary>
	/// <seealso cref= HILInc </seealso>
	public class AAMS_FC_AE_ASM_Inc : AAMSBaseInterface
	{

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int, String) </seealso>
	  public AAMS_FC_AE_ASM_Inc(int domainId, string partition) : base(domainId, partition)
	  {
	  }

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int) </seealso>
	  public AAMS_FC_AE_ASM_Inc(int domainId) : base(domainId)
	  {
	  }

	  public AAMS_FC_AE_ASM_Inc(int domainId, string[] partitions) : base(domainId, partitions)
	  {
	  }

	  private datarouter.AAMS_FC_AE_ASM_msgDataReader fM_AAMS_FC_AE_ASMReader;

	  private datarouter.AAMS_FC_AE_ASM_ChannelDataReader fC_AAMS_FC_AE_ASMReader;

	  private datarouter.AAMS_FC_AE_ASM_msgDataWriter fM_AAMS_FC_AE_ASMWriter;

	  private datarouter.AAMS_FC_AE_ASM_ChannelDataWriter fC_AAMS_FC_AE_ASMWriter;

	  private datarouter.AAMS_FC_AE_ASM_msgTypeSupport fM_ts = new datarouter.AAMS_FC_AE_ASM_msgTypeSupport();

	  private datarouter.AAMS_FC_AE_ASM_ChannelTypeSupport fC_ts = new datarouter.AAMS_FC_AE_ASM_ChannelTypeSupport();

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
            fM_AAMS_FC_AE_ASMWriter = fMWriter as AAMS_FC_AE_ASM_msgDataWriter;
		}
		if (fCWriter != null)
		{
            fC_AAMS_FC_AE_ASMWriter = fCWriter as AAMS_FC_AE_ASM_ChannelDataWriter;
		}

	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected void createReader() throws WrapperException
	  protected internal override void createReader()
	  {
		base.createReader();
		if (fMReader != null)
		{
            fM_AAMS_FC_AE_ASMReader = fMReader as AAMS_FC_AE_ASM_msgDataReader;
		}
		if (fCReader != null)
		{
            fC_AAMS_FC_AE_ASMReader = fCReader as AAMS_FC_AE_ASM_ChannelDataReader;
		}
	  }

	  /// <summary>
	  /// 将指�?AAMS_FC_AE_ASM_msg数据发�?到DDS�?
	  /// </summary>
	  /// <param name="msg">
	  ///          AAMS_FC_AE_ASM_msg </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeAAMS_FC_AE_ASM(datarouter.AAMS_FC_AE_ASM_msg msg)
	  {
		if (fM_AAMS_FC_AE_ASMWriter == null)
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
        return (int)fM_AAMS_FC_AE_ASMWriter.Write(msg, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 将指定AAMS FC_AE_ASM channel数据发�?到DDS�?
	  /// </summary>
	  /// <param name="channel">
	  ///          AAMS channel </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeAAMS_FC_AE_ASM_Channel(datarouter.AAMS_FC_AE_ASM_Channel channel)
	  {
		if (fC_AAMS_FC_AE_ASMWriter == null)
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
        return (int)fC_AAMS_FC_AE_ASMWriter.Write(channel, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 获取AAMS FC_AE_ASM msg Data Reader.
	  /// </summary>
	  /// <returns> AAMS FC_AE_ASM msg Data Reader </returns>
	  public virtual datarouter.AAMS_FC_AE_ASM_msgDataReader M_AAMS_FC_AE_ASMReader
	  {
		  get
		  {
			if (fM_AAMS_FC_AE_ASMReader == null)
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
			return fM_AAMS_FC_AE_ASMReader;
		  }
	  }

	  /// <summary>
	  /// 获取AAMS FC_AE_ASM channel Data Reader.
	  /// </summary>
	  /// <returns> AAMS FC_AE_ASM channel Data Reader </returns>
	  public virtual datarouter.AAMS_FC_AE_ASM_ChannelDataReader C_AAMS_FC_AE_ASMReader
	  {
		  get
		  {
			if (fC_AAMS_FC_AE_ASMReader == null)
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
			return fC_AAMS_FC_AE_ASMReader;
		  }
	  }

	}

}