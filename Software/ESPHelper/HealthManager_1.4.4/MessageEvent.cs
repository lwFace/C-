namespace com.hirain.avionics.healthmanager
{

	public class MessageEvent
	{

	  private int type;

	  private int time;

	  private string subType;

	  private string node;

	  private string[] description;

	  internal MessageEvent(int type, string eventType, int time, string node, string[] desc) : base()
	  {
		this.type = type;
		this.subType = eventType;
		this.time = time;
		this.node = node;
		this.description = desc;
	  }

	  public virtual int Type
	  {
		  get
		  {
			return type;
		  }
	  }

	  public virtual string EventType
	  {
		  get
		  {
			return subType;
		  }
	  }

	  public virtual int Time
	  {
		  get
		  {
			return time;
		  }
	  }

	  public virtual string Node
	  {
		  get
		  {
			return node;
		  }
	  }

	  public virtual string[] Description
	  {
		  get
		  {
			return description;
		  }
	  }

	}

}