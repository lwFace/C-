package Ch.Elca.Iiop.Demo.StorageSystem;


/**
* Ch/Elca/Iiop/Demo/StorageSystem/EntryHelper.java .
* 由IDL-to-Java 编译器 (可移植), 版本 "3.2"生成
* 从Ch/Elca/Iiop/Demo/StorageSystem/Entry.idl
* 2015年11月23日 星期一 下午04时43分01秒 CST
*/

abstract public class EntryHelper
{
  private static String  _id = "IDL:Ch/Elca/Iiop/Demo/StorageSystem/Entry:1.0";


  public static void insert (org.omg.CORBA.Any a, Ch.Elca.Iiop.Demo.StorageSystem.Entry that)
  {
    org.omg.CORBA.portable.OutputStream out = a.create_output_stream ();
    a.type (type ());
    write (out, that);
    a.read_value (out.create_input_stream (), type ());
  }

  public static Ch.Elca.Iiop.Demo.StorageSystem.Entry extract (org.omg.CORBA.Any a)
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
          org.omg.CORBA.ValueMember[] _members0 = new org.omg.CORBA.ValueMember[2];
          org.omg.CORBA.TypeCode _tcOf_members0 = null;
          // ValueMember instance for key
          _tcOf_members0 = org.omg.CORBA.WStringValueHelper.type ();
          _members0[0] = new org.omg.CORBA.ValueMember ("key", 
              org.omg.CORBA.WStringValueHelper.id (), 
              _id, 
              "", 
              _tcOf_members0, 
              null, 
              org.omg.CORBA.PUBLIC_MEMBER.value);
          // ValueMember instance for value
          _tcOf_members0 = org.omg.CORBA.WStringValueHelper.type ();
          _members0[1] = new org.omg.CORBA.ValueMember ("value", 
              org.omg.CORBA.WStringValueHelper.id (), 
              _id, 
              "", 
              _tcOf_members0, 
              null, 
              org.omg.CORBA.PUBLIC_MEMBER.value);
          __typeCode = org.omg.CORBA.ORB.init ().create_value_tc (_id, "Entry", org.omg.CORBA.VM_NONE.value, null, _members0);
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

  public static Ch.Elca.Iiop.Demo.StorageSystem.Entry read (org.omg.CORBA.portable.InputStream istream)
  {
    return (Ch.Elca.Iiop.Demo.StorageSystem.Entry)((org.omg.CORBA_2_3.portable.InputStream) istream).read_value (id ());
  }

  public static void write (org.omg.CORBA.portable.OutputStream ostream, Ch.Elca.Iiop.Demo.StorageSystem.Entry value)
  {
    ((org.omg.CORBA_2_3.portable.OutputStream) ostream).write_value (value, id ());
  }


}
