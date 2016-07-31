package Ch.Elca.Iiop;

/**
* Ch/Elca/Iiop/GenericUserExceptionHolder.java .
* 由IDL-to-Java 编译器 (可移植), 版本 "3.2"生成
* 从Ch/Elca/Iiop/GenericUserException.idl
* 2015年11月23日 星期一 下午04时43分02秒 CST
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
