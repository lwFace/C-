using System;
using System.Text;

namespace com.hirain.avionics.healthmanager.dds.service
{



	public class DeviceDDSData
	{

	  private const string TAG_PORT = "P";

	  private const string ATTR_STATUSMSG = "statusmsg";

	  private const string ATTR_STATUS = "status";

	  private const string ATTR_TYPE = "type";

	  private const string ATTR_ID = "id";

	  public const int TYPE_AFDX_COLLECTOR = 1;

	  public const int TYPE_A429_COLLECTOR = 2;

	  public const int TYPE_AFDX_MATRIX = 3;

	  public const int TYPE_AFDX_SIMULATOR = 4;

	  public const int TYPE_NOBUS_COLLECTOR = 5;

	  public const int TYPE_NOBUS_SIMULATOR = 6;

	  public const int TYPE_A422_COLLECTOR = 7;

	  public const int TYPE_A422_SIMULATOR = 8;

	  public const int TYPE_HDLC_COLLECTOR = 9;

	  public const int TYPE_HDLC_SIMULATOR = 10;

	  public const int TYPE_CAN_COLLECTOR = 11;

	  public const int TYPE_CAN_SIMULATOR = 12;

	  public const int TYPE_429_SIMULATOR = 13;

	  public const int TYPE_A485_COLLECTOR = 14;

	  public const int TYPE_A485_SIMULATOR = 15;

	  protected internal int id;

	  protected internal int type;

	  protected internal int status;

	  protected internal string statusMsg;

	  protected internal object[] ports = new object[0];

	  public virtual int Id
	  {
		  get
		  {
			return id;
		  }
		  set
		  {
			this.id = value;
		  }
	  }


	  public virtual int Type
	  {
		  get
		  {
			return type;
		  }
		  set
		  {
			this.type = value;
		  }
	  }


	  public virtual int Status
	  {
		  get
		  {
			return status;
		  }
		  set
		  {
			this.status = value;
		  }
	  }


	  public virtual string StatusMsg
	  {
		  get
		  {
			return statusMsg;
		  }
		  set
		  {
			this.statusMsg = value;
		  }
	  }


	  public virtual object[] Ports
	  {
		  get
		  {
			return ports;
		  }
		  set
		  {
			this.ports = value;
		  }
	  }


	  public class PortInfo_AFDXCollector
	  {
		  private readonly DeviceDDSData outerInstance;

		internal int id;

		internal bool connect;

		internal bool onoff;

		internal int count;

		public PortInfo_AFDXCollector(DeviceDDSData outerInstance, int id, bool connect, bool onoff, int count) : base()
		{
				this.outerInstance = outerInstance;
		  this.id = id;
		  this.connect = connect;
		  this.onoff = onoff;
		  this.count = count;
		}

		public virtual int Id
		{
			get
			{
			  return id;
			}
		}

		public virtual bool Connect
		{
			get
			{
			  return connect;
			}
		}

		public virtual bool Onoff
		{
			get
			{
			  return onoff;
			}
		}

		public virtual int Count
		{
			get
			{
			  return count;
			}
		}

		public PortInfo_AFDXCollector(DeviceDDSData outerInstance, string value)
		{
				this.outerInstance = outerInstance;
		  string[] values = StringHelperClass.StringSplit(value, ";", true);
		  if (values.Length == 4)
		  {
			id = Convert.ToInt32(values[0], 16);
			connect = values[1].Equals("1");
			onoff = values[2].Equals("1");
			count = Convert.ToInt32(values[3], 16);
		  }
		}

		public override string ToString()
		{
		  // assert (false);
		  StringBuilder sb = new StringBuilder();
		  sb.Append(Convert.ToString(id, 16));
		  sb.Append(";");
		  sb.Append(connect ? "1" : "0");
		  sb.Append(";");
		  sb.Append(onoff ? "1" : "0");
		  sb.Append(";");
		  sb.Append(Convert.ToString(count, 16));
		  // sb.append(";");
		  return sb.ToString();
		}
	  }

	  public class PortInfo_AFDXSimulator
	  {
		  private readonly DeviceDDSData outerInstance;

		internal int id;

		internal bool connect;

		internal bool onoff;

		internal int incount;

		internal int outcount;

		public PortInfo_AFDXSimulator(DeviceDDSData outerInstance, int id, bool connect, bool onoff, int incount, int outcount) : base()
		{
				this.outerInstance = outerInstance;
		  this.id = id;
		  this.connect = connect;
		  this.onoff = onoff;
		  this.incount = incount;
		  this.outcount = outcount;
		}

		public virtual int Id
		{
			get
			{
			  return id;
			}
		}

		public virtual bool Connect
		{
			get
			{
			  return connect;
			}
		}

		public virtual bool Onoff
		{
			get
			{
			  return onoff;
			}
		}

		public virtual int Incount
		{
			get
			{
			  return incount;
			}
		}

		public virtual int Outcount
		{
			get
			{
			  return outcount;
			}
		}

		public PortInfo_AFDXSimulator(DeviceDDSData outerInstance, string value)
		{
				this.outerInstance = outerInstance;
		  string[] values = StringHelperClass.StringSplit(value, ";", true);
		  if (values.Length == 5)
		  {
			id = Convert.ToInt32(values[0], 16);
			connect = values[1].Equals("1");
			onoff = values[2].Equals("1");
			incount = Convert.ToInt32(values[3], 16);
			outcount = Convert.ToInt32(values[4], 16);
		  }
		}

		public override string ToString()
		{
		  // assert (false);
		  StringBuilder sb = new StringBuilder();
		  sb.Append(Convert.ToString(id, 16));
		  sb.Append(";");
		  sb.Append(connect ? "1" : "0");
		  sb.Append(";");
		  sb.Append(onoff ? "1" : "0");
		  sb.Append(";");
		  sb.Append(Convert.ToString(incount, 16));
		  sb.Append(";");
		  sb.Append(Convert.ToString(outcount, 16));
		  // sb.append(";");
		  return sb.ToString();
		}
	  }

	  public class PortInfo_A429Collector
	  {
		  private readonly DeviceDDSData outerInstance;

		internal int id;

		internal bool onoff;

		internal int count;

		internal bool aams;

		internal bool sil;

		public PortInfo_A429Collector(DeviceDDSData outerInstance, int id, bool onoff, int count, bool aams, bool sil) : base()
		{
				this.outerInstance = outerInstance;
		  this.id = id;
		  this.onoff = onoff;
		  this.count = count;
		  this.aams = aams;
		  this.sil = sil;
		}

		public virtual int Id
		{
			get
			{
			  return id;
			}
		}

		public virtual bool Onoff
		{
			get
			{
			  return onoff;
			}
		}

		public virtual int Count
		{
			get
			{
			  return count;
			}
		}

		public virtual bool Aams
		{
			get
			{
			  return aams;
			}
		}

		public virtual bool Sil
		{
			get
			{
			  return sil;
			}
		}

		public PortInfo_A429Collector(DeviceDDSData outerInstance, string value)
		{
				this.outerInstance = outerInstance;
		  string[] values = StringHelperClass.StringSplit(value, ";", true);
		  if (values.Length == 5)
		  {
			try
			{
			  id = Convert.ToInt32(values[0], 16);
			  onoff = values[1].Equals("1");
			  count = Convert.ToInt32(values[2], 16);
			  aams = values[3].Equals("1");
			  sil = values[4].Equals("1");
			}
			catch (Exception e)
			{
			  Console.WriteLine(e.ToString());
			  Console.Write(e.StackTrace);
			}
		  }
		}

		public override string ToString()
		{
		  // assert (false);
		  StringBuilder sb = new StringBuilder();
		  sb.Append(Convert.ToString(id, 16));
		  sb.Append(";");
		  sb.Append(onoff ? "1" : "0");
		  sb.Append(";");
		  sb.Append(Convert.ToString(count, 16));
		  sb.Append(";");
		  sb.Append(aams ? "1" : "0");
		  sb.Append(";");
		  sb.Append(sil ? "1" : "0");
		  // sb.append(";");
		  return sb.ToString();
		}
	  }

	  public virtual datarouter.Node Attribute
	  {
		  set
		  {
			com.hirain.avionics.healthmanager.dds.DDSData.setAttribute(value, DeviceDDSData.ATTR_ID, "" + id);
			com.hirain.avionics.healthmanager.dds.DDSData.setAttribute(value, DeviceDDSData.ATTR_TYPE, "" + type);
			com.hirain.avionics.healthmanager.dds.DDSData.setAttribute(value, DeviceDDSData.ATTR_STATUS, "" + status);
			com.hirain.avionics.healthmanager.dds.DDSData.setAttribute(value, DeviceDDSData.ATTR_STATUSMSG, statusMsg);
			for (int i = 0; i < ports.Length; i++)
			{
			  datarouter.Node port = new datarouter.Node();
			  port.name = DeviceDDSData.TAG_PORT;
			  port._value = ports[i].ToString();
			  com.hirain.avionics.healthmanager.dds.DDSData.appendChild(value, port);
			}
		  }
	  }

	  public DeviceDDSData(int id, int type, int status, string statusMsg) : base()
	  {
		this.id = id;
		this.type = type;
		this.status = status;
		this.statusMsg = statusMsg;
	  }

	  public DeviceDDSData(datarouter.Node device)
	  {
		id = Convert.ToInt32(com.hirain.avionics.healthmanager.dds.DDSData.getAttribute(device, DeviceDDSData.ATTR_ID));
		type = Convert.ToInt32(com.hirain.avionics.healthmanager.dds.DDSData.getAttribute(device, ATTR_TYPE));
		status = Convert.ToInt32(com.hirain.avionics.healthmanager.dds.DDSData.getAttribute(device, ATTR_STATUS));
		statusMsg = com.hirain.avionics.healthmanager.dds.DDSData.getAttribute(device, ATTR_STATUSMSG);

		datarouter.Node[] portNodes = device.children;
		ports = new object[portNodes.Length];
		for (int i = 0; i < ports.Length; i++)
		{
		  switch (type)
		  {
		  case TYPE_AFDX_COLLECTOR:
			ports[i] = new PortInfo_AFDXCollector(this, portNodes[i]._value);
			break;
		  case TYPE_AFDX_SIMULATOR:
			ports[i] = new PortInfo_AFDXSimulator(this, portNodes[i]._value);
			break;
		  case TYPE_A429_COLLECTOR:
			ports[i] = new PortInfo_A429Collector(this, portNodes[i]._value);
			break;
		  }
		}
	  }
	}

}