package Ch.Elca.Iiop.Demo.StorageSystem;

/**
* Ch/Elca/Iiop/Demo/StorageSystem/ContainerHolder.java .
* ��IDL-to-Java ������ (����ֲ), �汾 "3.2"����
* ��Ch/Elca/Iiop/Demo/StorageSystem/Container.idl
* 2015��11��23�� ����һ ����04ʱ43��01�� CST
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
