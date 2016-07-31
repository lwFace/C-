using System;

namespace com.hirain.avionics.healthmanager.dds.service
{



	public class ServiceModuleDDSData : com.hirain.avionics.healthmanager.dds.DDSData
	{

	  private const string ATTR_HOST = "host";

	  protected internal int hostService;

	  public virtual int HostService
	  {
		  get
		  {
			return hostService;
		  }
		  set
		  {
			this.hostService = value;
		  }
	  }


	  public ServiceModuleDDSData(int time, int id, string name, int type, string version, string[] configs, int status, string statusMsg, string ior, int hostService) : base(time, id, name, type, version, configs, status, statusMsg, ior)
	  {
		this.hostService = hostService;
	  }

	  public ServiceModuleDDSData(datarouter.EVENT_msg msg) : base(msg)
	  {
		hostService = Convert.ToInt32(getAttribute(msg.info, ATTR_HOST));
	  }

	  public override datarouter.EVENT_msg toEventMsg()
	  {
		datarouter.EVENT_msg msg = base.toEventMsg();
		msg.type = TYPE_SERVICE_MODULE;
		setAttribute(msg.info, ServiceModuleDDSData.ATTR_HOST, "" + hostService);
		return msg;
	  }

	  public override void clone(com.hirain.avionics.healthmanager.dds.DDSData data)
	  {
		base.clone(data);
		this.hostService = ((ServiceModuleDDSData)data).hostService;
	  }

	}

}