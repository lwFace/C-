namespace com.hirain.avionics.dds.util
{

	public class ChannelSNConvert
	{

	  public static int IO_TYPE_AFDX_SIM = 1;

	  public static int IO_TYPE_AFDX_COLLECTOR = 2;

	  public static int IO_TYPE_AFDX_PATCH = 3;

	  public static int IO_TYPE_AFDX_INJECT = 4;

	  public static int IO_TYPE_AFDX_SWITCH = 5;

	  public static int IO_TYPE_RDC_429 = 6;

	  public static int IO_TYPE_RDC_CAN = 7;

	  public static int IO_TYPE_DIO_PATCH = 8;

	  public static int IO_TYPE_429_PATCH = 9;

	  public static int IO_TYPE_COMMON_IO = 10;

	  public static int IO_TYPE_RDC_422 = 11;

	  public static int IO_TYPE_RDC_DIO = 12;

	  public static int IO_TYPE_RDC_HDLC = 13;

	  public static int IO_TYPE_RDC_ETH = 14;

	  public class ChannelInfo
	  {
		private int type;

		private int devId;

		private int cardId;

		private int channelId;

		public ChannelInfo(int type, int devId, int cardId, int channelId) : base()
		{
		  this.type = type;
		  this.devId = devId;
		  this.cardId = cardId;
		  this.channelId = channelId;
		}

		public virtual int Type
		{
			get
			{
			  return type;
			}
		}

		public virtual int DevId
		{
			get
			{
			  return devId;
			}
		}

		public virtual int CardId
		{
			get
			{
			  return cardId;
			}
		}

		public virtual int ChannelId
		{
			get
			{
			  return channelId;
			}
		}

	  }

	  public static int Channel2SN(ChannelInfo cId)
	  {
		int id = 0;
        id |= (cId.Type & 0x7f) << 25; // 7bit
		id |= (cId.DevId & 0xff) << 17; // 8bit
		id |= (0 << 16); // 1bit
		id |= (cId.CardId & 0x3f) << 10; // 6bit
		id |= (0 << 8); // 2bit
		id |= cId.ChannelId & 0xff; // 8bit
		return id;
	  }

	  public static ChannelInfo SN2Channel(int id)
	  {
		ChannelInfo cId = new ChannelInfo(id >> 25 & 0x7f, id >> 17 & 0xff, id >> 10 & 0x3f, id & 0xff);
		return cId;
	  }
	}

}