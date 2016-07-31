package Ch.Elca.Iiop.Tutorial.GettingStarted;


/**
* Ch/Elca/Iiop/Tutorial/GettingStarted/AdderImplHelper.java .
* ��IDL-to-Java ������ (����ֲ), �汾 "3.2"����
* ��Ch/Elca/Iiop/Tutorial/GettingStarted/AdderImpl.idl
* 2015��11��23�� ����һ ����04ʱ43��07�� CST
*/

abstract public class AdderImplHelper
{
  private static String  _id = "IDL:Ch/Elca/Iiop/Tutorial/GettingStarted/AdderImpl:1.0";

  public static void insert (org.omg.CORBA.Any a, Ch.Elca.Iiop.Tutorial.GettingStarted.AdderImpl that)
  {
    org.omg.CORBA.portable.OutputStream out = a.create_output_stream ();
    a.type (type ());
    write (out, that);
    a.read_value (out.create_input_stream (), type ());
  }

  public static Ch.Elca.Iiop.Tutorial.GettingStarted.AdderImpl extract (org.omg.CORBA.Any a)
  {
    return read (a.create_input_stream ());
  }

  private static org.omg.CORBA.TypeCode __typeCode = null;
  synchronized public static org.omg.CORBA.TypeCode type ()
  {
    if (__typeCode == null)
    {
      __typeCode = org.omg.CORBA.ORB.init ().create_interface_tc (Ch.Elca.Iiop.Tutorial.GettingStarted.AdderImplHelper.id (), "AdderImpl");
    }
    return __typeCode;
  }

  public static String id ()
  {
    return _id;
  }

  public static Ch.Elca.Iiop.Tutorial.GettingStarted.AdderImpl read (org.omg.CORBA.portable.InputStream istream)
  {
    return narrow (istream.read_Object (_AdderImplStub.class));
  }

  public static void write (org.omg.CORBA.portable.OutputStream ostream, Ch.Elca.Iiop.Tutorial.GettingStarted.AdderImpl value)
  {
    ostream.write_Object ((org.omg.CORBA.Object) value);
  }

  public static Ch.Elca.Iiop.Tutorial.GettingStarted.AdderImpl narrow (org.omg.CORBA.Object obj)
  {
    if (obj == null)
      return null;
    else if (obj instanceof Ch.Elca.Iiop.Tutorial.GettingStarted.AdderImpl)
      return (Ch.Elca.Iiop.Tutorial.GettingStarted.AdderImpl)obj;
    else if (!obj._is_a (id ()))
      throw new org.omg.CORBA.BAD_PARAM ();
    else
    {
      org.omg.CORBA.portable.Delegate delegate = ((org.omg.CORBA.portable.ObjectImpl)obj)._get_delegate ();
      Ch.Elca.Iiop.Tutorial.GettingStarted._AdderImplStub stub = new Ch.Elca.Iiop.Tutorial.GettingStarted._AdderImplStub ();
      stub._set_delegate(delegate);
      return stub;
    }
  }

  public static Ch.Elca.Iiop.Tutorial.GettingStarted.AdderImpl unchecked_narrow (org.omg.CORBA.Object obj)
  {
    if (obj == null)
      return null;
    else if (obj instanceof Ch.Elca.Iiop.Tutorial.GettingStarted.AdderImpl)
      return (Ch.Elca.Iiop.Tutorial.GettingStarted.AdderImpl)obj;
    else
    {
      org.omg.CORBA.portable.Delegate delegate = ((org.omg.CORBA.portable.ObjectImpl)obj)._get_delegate ();
      Ch.Elca.Iiop.Tutorial.GettingStarted._AdderImplStub stub = new Ch.Elca.Iiop.Tutorial.GettingStarted._AdderImplStub ();
      stub._set_delegate(delegate);
      return stub;
    }
  }

}
