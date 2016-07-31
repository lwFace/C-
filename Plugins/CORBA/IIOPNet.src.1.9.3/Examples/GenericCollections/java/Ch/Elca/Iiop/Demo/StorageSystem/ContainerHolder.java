package Ch.Elca.Iiop.Demo.StorageSystem;

/**
* Ch/Elca/Iiop/Demo/StorageSystem/ContainerHolder.java .
* 由IDL-to-Java 编译器 (可移植), 版本 "3.2"生成
* 从Ch/Elca/Iiop/Demo/StorageSystem/Container.idl
* 2015年11月23日 星期一 下午04时43分01秒 CST
*/

public final class ContainerHolder implements org.omg.CORBA.portable.Streamable
{
  public Ch.Elca.Iiop.Demo.StorageSystem.Container value = null;

  public ContainerHolder ()
  {
  }

  public ContainerHolder (Ch.Elca.Iiop.Demo.StorageSystem.Container initialValue)
  {
    value = initialValue;
  }

  public void _read (org.omg.CORBA.portable.InputStream i)
  {
    value = Ch.Elca.Iiop.Demo.StorageSystem.ContainerHelper.read (i);
  }

  public void _write (org.omg.CORBA.portable.OutputStream o)
  {
    Ch.Elca.Iiop.Demo.StorageSystem.ContainerHelper.write (o, value);
  }

  public org.omg.CORBA.TypeCode _type ()
  {
    return Ch.Elca.Iiop.Demo.StorageSystem.ContainerHelper.type ();
  }

}
