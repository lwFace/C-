using System;
using System.Collections.Generic;

namespace com.hirain.avionics.healthmanager.dds
{

	public abstract class DDSData : AbstractDDSData
	{

	  private const string ATTR_IOR = "IOR";

	  private const string ATTR_VERSION = "version";

	  private const string ATTR_STATUS = "status";

	  private const string ATTR_STATUSMSG = "statusmsg";

	  private const string TAG_INFO = "INFO";

	  private const string TAG_CONFIG = "CONF";

	  public const string TYPE_SERVICE = "service";

	  public const string TYPE_CLIENT = "client";

	  public const string TYPE_SERVICE_MODULE = "servicemdule";

	  public const int STATUS_ONLINE = 1;

	  public const int STATUS_OFFLINE = 2;

	  public const int STATUS_RUNNING = 3;

	  public const int STATUS_EXCEPTION = -1;

	  protected internal int time;

	  protected internal int id;

	  protected internal string name;

	  protected internal int type;

	  protected internal string version;

	  protected internal string[] configs;

	  protected internal int status;

	  protected internal string statusMsg;

	  protected internal string ior;

	  public long daemonTime = 0;

	  public DDSData(int time, int id, string name, int type, string version, string[] configs, int status, string statusMsg, string ior) : base()
	  {
		this.time = time;
		this.id = id;
		this.name = name;
		this.type = type;
		this.version = version;
		this.configs = configs;
		this.status = status;
		this.statusMsg = statusMsg;
		this.ior = ior;
	  }

	  public DDSData(datarouter.EVENT_msg msg) : base()
	  {
          type = (int)msg.event_id & (~(int)HealthManager.STATUS_MASK);
		time = (int)msg.time;
        id = (int)msg.nodeId;
		name = msg.name;

		datarouter.Node info = msg.info;
		version = getAttribute(info, ATTR_VERSION);
		status = Convert.ToInt32(getAttribute(info, ATTR_STATUS));
		statusMsg = getAttribute(info, ATTR_STATUSMSG);
		ior = getAttribute(info, ATTR_IOR);
		datarouter.Node[] children = info.children;
		// configs = new String[children.length];
		List<string> conflist = new List<string>();
		for (int i = 0; i < children.Length; i++)
		{
		  if (children[i].name.Equals(TAG_CONFIG))
			// configs[i] = children[i].value;
		  {
			conflist.Add(children[i]._value);
		  }
		}
        configs = conflist.ToArray();

	  }

	  public DDSData(DDSData data)
	  {
		this.id = data.id;
		this.name = data.name;
		this.type = data.type;
		clone(data);
	  }

	  public static DDSData newInstance(datarouter.EVENT_msg msg)
	  {
		if (msg.type.Equals(TYPE_CLIENT))
		{
		  return new com.hirain.avionics.healthmanager.dds.client.ClientDDSData(msg);
		}
		else if (msg.type.Equals(TYPE_SERVICE))
		{
		  return new com.hirain.avionics.healthmanager.dds.service.ServiceDDSData(msg);
		}
		else if (msg.type.Equals(TYPE_SERVICE_MODULE))
		{
		  return new com.hirain.avionics.healthmanager.dds.service.ServiceModuleDDSData(msg);
		}
		Console.Error.WriteLine("Event message type error!" + msg.event_id);
		return null;
	  }
      public override int GetHashCode()
      {
          return base.GetHashCode();
      }
	  public override datarouter.EVENT_msg toEventMsg()
	  {
		datarouter.EVENT_msg msg = new datarouter.EVENT_msg();
        msg.event_id = (uint)type | (uint)HealthManager.STATUS_MASK;
		msg.time = (uint)time;
        msg.nodeId = (uint)id;
		msg.name = name;
		datarouter.Node info = new datarouter.Node();
		info.name = DDSData.TAG_INFO;
		setAttribute(info, ATTR_VERSION, version);
		setAttribute(info, ATTR_STATUS, status + "");
		setAttribute(info, ATTR_STATUSMSG, statusMsg);
		setAttribute(info, ATTR_IOR, ior);
		for (int i = 0; i < configs.Length; i++)
		{
		  datarouter.Node config = new datarouter.Node();
		  config.name = TAG_CONFIG;
		  config._value = configs[i];
		  appendChild(info, config);
		}
		msg.info = info;
		return msg;
	  }

	  public virtual void clone(DDSData data)
	  {
		this.time = data.time;
		this.status = data.status;
		this.statusMsg = data.statusMsg;
		this.configs = data.configs;
		this.ior = data.ior;
		this.version = data.version;
	  }

	  public override bool Equals(object obj)
	  {
		if (obj is DDSData)
		{
		  return ((DDSData)obj).id == this.id && ((DDSData)obj).name.Equals(this.name) && ((DDSData)obj).type == this.type;
		}
		return false;
	  }

	  /// <summary>
	  /// get service type
	  /// 
	  /// @return
	  /// </summary>
	  public virtual int Time
	  {
		  get
		  {
			return time;
		  }
		  set
		  {
			this.time = value;
		  }
	  }

	  /// <summary>
	  /// get id
	  /// 
	  /// @return
	  /// </summary>
	  public virtual int Id
	  {
		  get
		  {
			return id;
		  }
	  }

	  /// <summary>
	  /// get name
	  /// 
	  /// @return
	  /// </summary>
	  public virtual string Name
	  {
		  get
		  {
			return name;
		  }
	  }

	  /// <summary>
	  /// get type
	  /// 
	  /// @return
	  /// </summary>
	  public virtual int Type
	  {
		  get
		  {
			return type;
		  }
	  }

	  /// <summary>
	  /// get version
	  /// 
	  /// @return
	  /// </summary>
	  public virtual string Version
	  {
		  get
		  {
			return version;
		  }
	  }

	  /// <summary>
	  /// get configs
	  /// 
	  /// @return
	  /// </summary>
	  public virtual string[] Configs
	  {
		  get
		  {
			return configs;
		  }
		  set
		  {
			this.configs = value;
		  }
	  }

	  /// <summary>
	  /// get status
	  /// 
	  /// @return
	  /// </summary>
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


	  /// <summary>
	  /// get status message
	  /// 
	  /// @return
	  /// </summary>
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


	  /// <summary>
	  /// get ior
	  /// 
	  /// @return
	  /// </summary>
	  public virtual string Ior
	  {
		  get
		  {
			return ior;
		  }
	  }



	}

}