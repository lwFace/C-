using datarouter;
using DDS;
using System;
namespace com.hirain.avionics.dds
{


	/// <summary>
	/// @author jialun.liu </summary>
	/// <seealso cref= HILInc </seealso>
	public class AAMS_CAN_Inc : AAMSBaseInterface
	{

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int, String) </seealso>
	  public AAMS_CAN_Inc(int domainId, string partition) : base(domainId, partition)
	  {
	  }

	  /// <seealso cref= DDSBaseInterface#DDSBaseInterface(int) </seealso>
	  public AAMS_CAN_Inc(int domainId) : base(domainId)
	  {
	  }

	  public AAMS_CAN_Inc(int domainId, string[] partitions) : base(domainId, partitions)
	  {
	  }

	  private datarouter.AAMS_CAN_msgDataReader fM_AAMS_CANReader;

	  private datarouter.AAMS_CAN_ChannelDataReader fC_AAMS_CANReader;

	  private datarouter.AAMS_CAN_msgDataWriter fM_AAMS_CANWriter;

	  private datarouter.AAMS_CAN_ChannelDataWriter fC_AAMS_CANWriter;

	  private datarouter.AAMS_CAN_msgTypeSupport fM_ts = new datarouter.AAMS_CAN_msgTypeSupport();

	  private datarouter.AAMS_CAN_ChannelTypeSupport fC_ts = new datarouter.AAMS_CAN_ChannelTypeSupport();

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
            fM_AAMS_CANWriter = fMWriter as AAMS_CAN_msgDataWriter;
		}
		if (fCWriter != null)
		{
            fC_AAMS_CANWriter = fCWriter as AAMS_CAN_ChannelDataWriter;
		}

	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected void createReader() throws WrapperException
	  protected internal override void createReader()
	  {
		base.createReader();
		if (fMReader != null)
		{
            fM_AAMS_CANReader = fMReader as AAMS_CAN_msgDataReader;
		}
		if (fCReader != null)
		{
            fC_AAMS_CANReader = fCReader as AAMS_CAN_ChannelDataReader;
		}
	  }

	  /// <summary>
	  /// 将指�?AAMS_CAN_msg数据发送到DDS�?
	  /// </summary>
	  /// <param name="msg">
	  ///          AAMS_CAN_msg </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeAAMS_CAN(datarouter.AAMS_CAN_msg msg)
	  {
		if (fM_AAMS_CANWriter == null)
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
        return (int)fM_AAMS_CANWriter.Write(msg, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 将指定AAMS CAN channel数据发送到DDS�?
	  /// </summary>
	  /// <param name="channel">
	  ///          AAMS channel </param>
	  /// <returns> 0 means success, others means exception. </returns>
	  /// <seealso cref= DDS.RETCODE_OK </seealso>
	  /// <seealso cref= DDS.RETCODE_ERROR </seealso>
	  /// <seealso cref= DDS.RETCODE_... </seealso>
	  public virtual int writeAAMS_CAN_Channel(datarouter.AAMS_CAN_Channel channel)
	  {
		if (fC_AAMS_CANWriter == null)
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
        return (int)fC_AAMS_CANWriter.Write(channel, InstanceHandle.Nil);
	  }

	  /// <summary>
	  /// 获取AAMS CAN msg Data Reader.
	  /// </summary>
	  /// <returns> AAMS CAN msg Data Reader </returns>
	  public virtual datarouter.AAMS_CAN_msgDataReader M_AAMS_CANReader
	  {
		  get
		  {
			if (fM_AAMS_CANReader == null)
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
			return fM_AAMS_CANReader;
		  }
	  }

	  /// <summary>
	  /// 获取AAMS CAN channel Data Reader.
	  /// </summary>
	  /// <returns> AAMS CAN channel Data Reader </returns>
	  public virtual datarouter.AAMS_CAN_ChannelDataReader C_AAMS_CANReader
	  {
		  get
		  {
			if (fC_AAMS_CANReader == null)
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
			return fC_AAMS_CANReader;
		  }
	  }

	}

}