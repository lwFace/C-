package Ch.Elca.Iiop;


/**
* Ch/Elca/Iiop/GenericUserException.java .
* 由IDL-to-Java 编译器 (可移植), 版本 "3.2"生成
* 从Ch/Elca/Iiop/GenericUserException.idl
* 2015年11月23日 星期一 下午04时43分07秒 CST
*/

public final class GenericUserException extends org.omg.CORBA.UserException
{
  public String name = null;
  public String message = null;
  public String throwingMethod = null;

  public GenericUserException ()
  {
    super(GenericUserExceptionHelper.id());
  } // ctor

  public GenericUserException (String _name, String _message, String _throwingMethod)
  {
    super(GenericUserExceptionHelper.id());
    name = _name;
    message = _message;
    throwingMethod = _throwingMethod;
  } // ctor


  public GenericUserException (String $reason, String _name, String _message, String _throwingMethod)
  {
    super(GenericUserExceptionHelper.id() + "  " + $reason);
    name = _name;
    message = _message;
    throwingMethod = _throwingMethod;
  } // ctor

} // class GenericUserException
