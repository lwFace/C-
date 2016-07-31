namespace com.hirain.avionics.healthmanager
{


	public class StatusChangeEvent
	{

	  private int oldStatus;

	  private int newStatus;

	  private com.hirain.avionics.healthmanager.dds.DDSData node;

	  internal StatusChangeEvent(int oldStatus, int newStatus, com.hirain.avionics.healthmanager.dds.DDSData node) : base()
	  {
		this.oldStatus = oldStatus;
		this.newStatus = newStatus;
		this.node = node;
	  }

	  public virtual int OldStatus
	  {
		  get
		  {
			return oldStatus;
		  }
	  }

	  public virtual int NewStatus
	  {
		  get
		  {
			return newStatus;
		  }
	  }

	  public virtual com.hirain.avionics.healthmanager.dds.DDSData Node
	  {
		  get
		  {
			return node;
		  }
	  }

	}

}