package Ch.Elca.Iiop.Demo.StorageSystem;

/**
* Ch/Elca/Iiop/Demo/StorageSystem/ManagerHolder.java .
* 由IDL-to-Java 编译器 (可移植), 版本 "3.2"生成
* 从Ch/Elca/Iiop/Demo/StorageSystem/Manager.idl
* 2015年11月23日 星期一 下午04时43分01秒 CST
*/

public final class ManagerHolder implements org.omg.CORBA.portable.Streamable
{
  public Ch.Elca.Iiop.Demo.StorageSystem.Manager value = null;

  public ManagerHolder ()
  {
  }

  public ManagerHolder (Ch.Elca.Iiop.Demo.StorageSystem.Manager initialValue)
  {
    value = initialValue;
  }

  public void _read (org.omg.CORBA.portable.InputStream i)
  {
    value = Ch.Elca.Iiop.Demo.StorageSystem.ManagerHelper.read (i);
  }

  public void _write (org.omg.CORBA.portable.OutputStream o)
  {
    Ch.Elca.Iiop.Demo.StorageSystem.ManagerHelper.write (o, value);
  }

  public org.omg.CORBA.TypeCode _type ()
  {
    return Ch.Elca.Iiop.Demo.StorageSystem.ManagerHelper.type ();
  }

}
