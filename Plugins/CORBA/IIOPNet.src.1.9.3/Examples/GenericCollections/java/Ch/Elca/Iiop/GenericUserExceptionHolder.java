package Ch.Elca.Iiop;

/**
* Ch/Elca/Iiop/GenericUserExceptionHolder.java .
* ��IDL-to-Java ������ (����ֲ), �汾 "3.2"����
* ��Ch/Elca/Iiop/GenericUserException.idl
* 2015��11��23�� ����һ ����04ʱ43��02�� CST
*/

public final class GenericUserExceptionHolder implements org.omg.CORBA.portable.Streamable
{
  public Ch.Elca.Iiop.GenericUserException value = null;

  public GenericUserExceptionHolder ()
  {
  }

  public GenericUserExceptionHolder (Ch.Elca.Iiop.GenericUserException initialValue)
  {
    value = initialValue;
  }

  public void _read (org.omg.CORBA.portable.InputStream i)
  {
    value = Ch.Elca.Iiop.GenericUserExceptionHelper.read (i);
  }

  public void _write (org.omg.CORBA.portable.OutputStream o)
  {
    Ch.Elca.Iiop.GenericUserExceptionHelper.write (o, value);
  }

  public org.omg.CORBA.TypeCode _type ()
  {
    return Ch.Elca.Iiop.GenericUserExceptionHelper.type ();
  }

}
