using System;

namespace com.hirain.avionics.dds
{

	public class WrapperException : Exception
	{

	  /// 
	  private const long serialVersionUID = 2271793522031896126L;

	  public WrapperException() : base()
	  {
	  }

	  public WrapperException(string arg0, Exception arg1) : base(arg0, arg1)
	  {
	  }

	  public WrapperException(string arg0) : base(arg0)
	  {
	  }


	}

}