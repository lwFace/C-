package org.omg.BoxedArray.Ch.Elca.Iiop.Demo.StorageSystem;

/**
* org/omg/BoxedArray/Ch/Elca/Iiop/Demo/StorageSystem/seq1_EntryHolder.java .
* ��IDL-to-Java ������ (����ֲ), �汾 "3.2"����
* ��org/omg/BoxedArray/Ch/Elca/Iiop/Demo/StorageSystem/seq1_Entry.idl
* 2015��11��23�� ����һ ����04ʱ43��02�� CST
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
