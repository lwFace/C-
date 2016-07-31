package Ch.Elca.Iiop;


/**
* Ch/Elca/Iiop/GenericUserException.java .
* ��IDL-to-Java ������ (����ֲ), �汾 "3.2"����
* ��Ch/Elca/Iiop/GenericUserException.idl
* 2015��11��23�� ����һ ����04ʱ43��07�� CST
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
