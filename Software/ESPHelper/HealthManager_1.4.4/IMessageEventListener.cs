namespace com.hirain.avionics.healthmanager
{


	public interface IMessageEventListener
	{

	  void handleSpecialEvent(datarouter.EVENT_msg msg);

	}

}