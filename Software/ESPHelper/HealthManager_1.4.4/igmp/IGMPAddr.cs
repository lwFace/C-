namespace com.hirain.avionics.dds.igmp
{

	internal class IGMPAddr
	{

	  public string localAddr;

	  public string groupAddr;

	  public override bool Equals(object obj)
	  {
		if (obj is IGMPAddr)
		{
		  IGMPAddr an = (IGMPAddr)obj;
		  if (localAddr != null && groupAddr != null)
		  {
			return an.localAddr.Equals(localAddr) && an.groupAddr.Equals(groupAddr);
		  }
		}
		return false;
	  }
	}

}