package Ch.Elca.Iiop.Tutorial.GettingStarted;

/**
* Ch/Elca/Iiop/Tutorial/GettingStarted/AdderImplHolder.java .
* 由IDL-to-Java 编译器 (可移植), 版本 "3.2"生成
* 从Ch/Elca/Iiop/Tutorial/GettingStarted/AdderImpl.idl
* 2015年11月23日 星期一 下午04时43分07秒 CST
*/

public final class AdderImplHolder implements org.omg.CORBA.portable.Streamable
{
  public Ch.Elca.Iiop.Tutorial.GettingStarted.AdderImpl value = null;

  public AdderImplHolder ()
  {
  }

  public AdderImplHolder (Ch.Elca.Iiop.Tutorial.GettingStarted.AdderImpl initialValue)
  {
    value = initialValue;
  }

  public void _read (org.omg.CORBA.portable.InputStream i)
  {
    value = Ch.Elca.Iiop.Tutorial.GettingStarted.AdderImplHelper.read (i);
  }

  public void _write (org.omg.CORBA.portable.OutputStream o)
  {
    Ch.Elca.Iiop.Tutorial.GettingStarted.AdderImplHelper.write (o, value);
  }

  public org.omg.CORBA.TypeCode _type ()
  {
    return Ch.Elca.Iiop.Tutorial.GettingStarted.AdderImplHelper.type ();
  }

}
