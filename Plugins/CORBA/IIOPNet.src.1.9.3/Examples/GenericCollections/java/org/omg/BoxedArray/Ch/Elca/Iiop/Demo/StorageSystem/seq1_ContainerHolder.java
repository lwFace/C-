package org.omg.BoxedArray.Ch.Elca.Iiop.Demo.StorageSystem;

/**
* org/omg/BoxedArray/Ch/Elca/Iiop/Demo/StorageSystem/seq1_ContainerHolder.java .
* ��IDL-to-Java ������ (����ֲ), �汾 "3.2"����
* ��org/omg/BoxedArray/Ch/Elca/Iiop/Demo/StorageSystem/seq1_Container.idl
* 2015��11��23�� ����һ ����04ʱ43��02�� CST
*/

public final class seq1_ContainerHolder implements org.omg.CORBA.portable.Streamable
{
  public Ch.Elca.Iiop.Demo.StorageSystem.Container[] value;

  public seq1_ContainerHolder ()
  {
  }

  public seq1_ContainerHolder (Ch.Elca.Iiop.Demo.StorageSystem.Container[] initialValue)
  {
    value = initialValue;
  }

  public void _read (org.omg.CORBA.portable.InputStream i)
  {
    value = org.omg.BoxedArray.Ch.Elca.Iiop.Demo.StorageSystem.seq1_ContainerHelper.read (i);
  }

  public void _write (org.omg.CORBA.portable.OutputStream o)
  {
    org.omg.BoxedArray.Ch.Elca.Iiop.Demo.StorageSystem.seq1_ContainerHelper.write (o, value);
  }

  public org.omg.CORBA.TypeCode _type ()
  {
    return org.omg.BoxedArray.Ch.Elca.Iiop.Demo.StorageSystem.seq1_ContainerHelper.type ();
  }

}
