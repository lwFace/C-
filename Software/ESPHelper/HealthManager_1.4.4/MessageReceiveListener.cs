namespace com.hirain.avionics.healthmanager
{


	public abstract class MessageReceiveListener
	{

	  public abstract int eventID();

	  public abstract void handleMessage(datarouter.EVENT_msg[] msg);

	  public override bool Equals(object obj)
	  {
		if (obj is MessageReceiveListener)
		{
		  return ((MessageReceiveListener)obj).eventID() == eventID();
		}
		return base.Equals(obj);
	  }

	}

}