package org.omg.BoxedArray.Ch.Elca.Iiop.Demo.StorageSystem;

/**
* org/omg/BoxedArray/Ch/Elca/Iiop/Demo/StorageSystem/seq1_ContainerHolder.java .
* 由IDL-to-Java 编译器 (可移植), 版本 "3.2"生成
* 从org/omg/BoxedArray/Ch/Elca/Iiop/Demo/StorageSystem/seq1_Container.idl
* 2015年11月23日 星期一 下午04时43分02秒 CST
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
