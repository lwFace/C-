package Ch.Elca.Iiop;


/**
* Ch/Elca/Iiop/GenericUserExceptionHelper.java .
* 由IDL-to-Java 编译器 (可移植), 版本 "3.2"生成
* 从Ch/Elca/Iiop/GenericUserException.idl
* 2015年11月23日 星期一 下午04时43分07秒 CST
*/

abstract public class GenericUserExceptionHelper
{
  private static String  _id = "IDL:Ch/Elca/Iiop/GenericUserException:1.0";

  public static void insert (org.omg.CORBA.Any a, Ch.Elca.Iiop.GenericUserException that)
  {
    org.omg.CORBA.portable.OutputStream out = a.create_output_stream ();
    a.type (type ());
    write (out, that);
    a.read_value (out.create_input_stream (), type ());
  }

  public static Ch.Elca.Iiop.GenericUserException extract (org.omg.CORBA.Any a)
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
          org.omg.CORBA.StructMember[] _members0 = new org.omg.CORBA.StructMember [3];
          org.omg.CORBA.TypeCode _tcOf_members0 = null;
          _tcOf_members0 = org.omg.CORBA.ORB.init ().create_wstring_tc (0);
          _members0[0] = new org.omg.CORBA.StructMember (
            "name",
            _tcOf_members0,
            null);
          _tcOf_members0 = org.omg.CORBA.ORB.init ().create_wstring_tc (0);
          _members0[1] = new org.omg.CORBA.StructMember (
            "message",
            _tcOf_members0,
            null);
          _tcOf_members0 = org.omg.CORBA.ORB.init ().create_wstring_tc (0);
          _members0[2] = new org.omg.CORBA.StructMember (
            "throwingMethod",
            _tcOf_members0,
            null);
          __typeCode = org.omg.CORBA.ORB.init ().create_exception_tc (Ch.Elca.Iiop.GenericUserExceptionHelper.id (), "GenericUserException", _members0);
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

  public static Ch.Elca.Iiop.GenericUserException read (org.omg.CORBA.portable.InputStream istream)
  {
    Ch.Elca.Iiop.GenericUserException value = new Ch.Elca.Iiop.GenericUserException ();
    // read and discard the repository ID
    istream.read_string ();
    value.name = istream.read_wstring ();
    value.message = istream.read_wstring ();
    value.throwingMethod = istream.read_wstring ();
    return value;
  }

  public static void write (org.omg.CORBA.portable.OutputStream ostream, Ch.Elca.Iiop.GenericUserException value)
  {
    // write the repository ID
    ostream.write_string (id ());
    ostream.write_wstring (value.name);
    ostream.write_wstring (value.message);
    ostream.write_wstring (value.throwingMethod);
  }

}
