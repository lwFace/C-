package org.omg.BoxedArray.Ch.Elca.Iiop.Demo.StorageSystem;


/**
* org/omg/BoxedArray/Ch/Elca/Iiop/Demo/StorageSystem/seq1_ContainerHelper.java .
* 由IDL-to-Java 编译器 (可移植), 版本 "3.2"生成
* 从org/omg/BoxedArray/Ch/Elca/Iiop/Demo/StorageSystem/seq1_Container.idl
* 2015年11月23日 星期一 下午04时43分02秒 CST
*/

public final class seq1_ContainerHelper implements org.omg.CORBA.portable.BoxedValueHelper
{
  private static String  _id = "IDL:org/omg/BoxedArray/Ch/Elca/Iiop/Demo/StorageSystem/seq1_Container:1.0";

  private static seq1_ContainerHelper _instance = new seq1_ContainerHelper ();


  public seq1_ContainerHelper()
  {
  }

  public static void insert (org.omg.CORBA.Any a, Ch.Elca.Iiop.Demo.StorageSystem.Container[] that)
  {
    org.omg.CORBA.portable.OutputStream out = a.create_output_stream ();
    a.type (type ());
    write (out, that);
    a.read_value (out.create_input_stream (), type ());
  }

  public static Ch.Elca.Iiop.Demo.StorageSystem.Container[] extract (org.omg.CORBA.Any a)
  {
    return read (a.create_input_stream ());
  }

  private static org.omg.CORBA.TypeCode __typeCode = null;
  private static boolean __active = false;
  synchronized public static org.omg.CORBA.TypeCode type ()
  {
    if (__typeCode == null)
    {
      synchronized (org.omg.CORBA.TypeCode.class)
      {
        if (__typeCode == null)
        {
          if (__active)
          {
            return org.omg.CORBA.ORB.init().create_recursive_tc ( _id );
          }
          __active = true;
          __typeCode = Ch.Elca.Iiop.Demo.StorageSystem.ContainerHelper.type ();
          __typeCode = org.omg.CORBA.ORB.init ().create_sequence_tc (0, __typeCode);
          __typeCode = org.omg.CORBA.ORB.init ().create_value_box_tc (_id, "seq1_Container", __typeCode);
          __active = false;
        }
      }
    }
    return __typeCode;
  }

  public static String id ()
  {
    return _id;
  }

  public static Ch.Elca.Iiop.Demo.StorageSystem.Container[] read (org.omg.CORBA.portable.InputStream istream)
  {
    if (!(istream instanceof org.omg.CORBA_2_3.portable.InputStream)) {
      throw new org.omg.CORBA.BAD_PARAM(); }
    return (Ch.Elca.Iiop.Demo.StorageSystem.Container[]) ((org.omg.CORBA_2_3.portable.InputStream) istream).read_value (_instance);
  }

  public java.io.Serializable read_value (org.omg.CORBA.portable.InputStream istream)
  {
    Ch.Elca.Iiop.Demo.StorageSystem.Container[] tmp;
    int _len0 = istream.read_long ();
    tmp = new Ch.Elca.Iiop.Demo.StorageSystem.Container[_len0];
    for (int _o1 = 0;_o1 < tmp.length; ++_o1)
      tmp[_o1] = Ch.Elca.Iiop.Demo.StorageSystem.ContainerHelper.read (istream);
    return (java.io.Serializable) tmp;
  }

  public static void write (org.omg.CORBA.portable.OutputStream ostream, Ch.Elca.Iiop.Demo.StorageSystem.Container[] value)
  {
    if (!(ostream instanceof org.omg.CORBA_2_3.portable.OutputStream)) {
      throw new org.omg.CORBA.BAD_PARAM(); }
    ((org.omg.CORBA_2_3.portable.OutputStream) ostream).write_value (value, _instance);
  }

  public void write_value (org.omg.CORBA.portable.OutputStream ostream, java.io.Serializable value)
  {
    if (!(value instanceof Ch.Elca.Iiop.Demo.StorageSystem.Container[])) {
      throw new org.omg.CORBA.MARSHAL(); }
    Ch.Elca.Iiop.Demo.StorageSystem.Container[] valueType = (Ch.Elca.Iiop.Demo.StorageSystem.Container[]) value;
    ostream.write_long (valueType.length);
    for (int _i0 = 0;_i0 < valueType.length; ++_i0)
      Ch.Elca.Iiop.Demo.StorageSystem.ContainerHelper.write (ostream, valueType[_i0]);
  }

  public String get_id ()
  {
    return _id;
  }

}
