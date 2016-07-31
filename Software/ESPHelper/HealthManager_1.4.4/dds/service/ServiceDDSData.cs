using System;
using System.Threading;

namespace com.hirain.avionics.healthmanager.dds.service
{



	public class ServiceDDSData : com.hirain.avionics.healthmanager.dds.DDSData
	{

	  private const string ATTR_FAULTDEVICE = "faultdevice";

	  private const string TAG_DEVICE = "DEV";

	  private const string TAG_SERVICE_INFO = "INFO";

	  protected internal DeviceDDSData[] devices = {};

	  protected internal int[] faultDevices = {};

	  public ServiceDDSData(int time, int id, string name, int type, string version, string[] configs, int status, string statusMsg, string ior) : base(time, id, name, type, version, configs, status, statusMsg, ior)
	  {
	  }

	  public ServiceDDSData(datarouter.EVENT_msg msg) : base(msg)
	  {
		datarouter.Node[] children = findChild(msg.info, TAG_SERVICE_INFO);
		if (children.Length == 1)
		{
		  parse(children[0]);
		}
	  }

	  public ServiceDDSData(ServiceDDSData data) : base(data)
	  {
	  }

	  public override datarouter.EVENT_msg toEventMsg()
	  {
		datarouter.EVENT_msg msg = base.toEventMsg();
		msg.type = TYPE_SERVICE;
		datarouter.Node info = msg.info;
		datarouter.Node serviceInfo = new datarouter.Node();
		serviceInfo.name = ServiceDDSData.TAG_SERVICE_INFO;
		setAttribute(serviceInfo, ServiceDDSData.ATTR_FAULTDEVICE, intarray2string(faultDevices));
		if (devices != null)
		{
		  for (int i = 0; i < devices.Length; i++)
		  {
			datarouter.Node device = new datarouter.Node();
			device.name = ServiceDDSData.TAG_DEVICE;
			devices[i].Attribute = device;
			appendChild(serviceInfo, device);
		  }
		}

		appendChild(info, serviceInfo);
		return msg;
	  }

	  public virtual void parse(datarouter.Node node)
	  {
		faultDevices = string2intarray(getAttribute(node, ATTR_FAULTDEVICE));
		datarouter.Node[] children = node.children;
		devices = new DeviceDDSData[children.Length];
		for (int i = 0; i < children.Length; i++)
		{
		  devices[i] = new DeviceDDSData(children[i]);
		}
	  }

	  public virtual DeviceDDSData[] Devices
	  {
		  get
		  {
			return devices;
		  }
		  set
		  {
			this.devices = value;
		  }
	  }


	  public virtual int[] FaultDevices
	  {
		  get
		  {
			return faultDevices;
		  }
		  set
		  {
			this.faultDevices = value;
		  }
	  }


	  public override void clone(com.hirain.avionics.healthmanager.dds.DDSData data)
	  {
		base.clone(data);
		this.devices = ((ServiceDDSData)data).devices;
		this.faultDevices = ((ServiceDDSData)data).faultDevices;
	  }

	  
	}

}