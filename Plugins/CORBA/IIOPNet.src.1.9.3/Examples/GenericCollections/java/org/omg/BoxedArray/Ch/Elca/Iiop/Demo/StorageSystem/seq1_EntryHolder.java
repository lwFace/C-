package org.omg.BoxedArray.Ch.Elca.Iiop.Demo.StorageSystem;

/**
* org/omg/BoxedArray/Ch/Elca/Iiop/Demo/StorageSystem/seq1_EntryHolder.java .
* 由IDL-to-Java 编译器 (可移植), 版本 "3.2"生成
* 从org/omg/BoxedArray/Ch/Elca/Iiop/Demo/StorageSystem/seq1_Entry.idl
* 2015年11月23日 星期一 下午04时43分02秒 CST
*/

public final class seq1_EntryHolder implements org.omg.CORBA.portable.Streamable
{
  public Ch.Elca.Iiop.Demo.StorageSystem.Entry[] value;

  public seq1_EntryHolder ()
  {
  }

  public seq1_EntryHolder (Ch.Elca.Iiop.Demo.StorageSystem.Entry[] initialValue)
  {
    value = initialValue;
  }

  public void _read (org.omg.CORBA.portable.InputStream i)
  {
    value = org.omg.BoxedArray.Ch.Elca.Iiop.Demo.StorageSystem.seq1_EntryHelper.read (i);
  }

  public void _write (org.omg.CORBA.portable.OutputStream o)
  {
    org.omg.BoxedArray.Ch.Elca.Iiop.Demo.StorageSystem.seq1_EntryHelper.write (o, value);
  }

  public org.omg.CORBA.TypeCode _type ()
  {
    return org.omg.BoxedArray.Ch.Elca.Iiop.Demo.StorageSystem.seq1_EntryHelper.type ();
  }

}
