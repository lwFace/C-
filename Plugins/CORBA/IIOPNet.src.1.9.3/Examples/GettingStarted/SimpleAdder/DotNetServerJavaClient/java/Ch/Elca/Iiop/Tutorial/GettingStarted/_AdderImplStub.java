package Ch.Elca.Iiop.Tutorial.GettingStarted;


/**
* Ch/Elca/Iiop/Tutorial/GettingStarted/_AdderImplStub.java .
* 由IDL-to-Java 编译器 (可移植), 版本 "3.2"生成
* 从Ch/Elca/Iiop/Tutorial/GettingStarted/AdderImpl.idl
* 2015年11月23日 星期一 下午04时43分07秒 CST
*/

public class _AdderImplStub extends org.omg.CORBA.portable.ObjectImpl implements Ch.Elca.Iiop.Tutorial.GettingStarted.AdderImpl
{

  public double add (double arg1, double arg2) throws Ch.Elca.Iiop.GenericUserException
  {
            org.omg.CORBA.portable.InputStream $in = null;
            try {
                org.omg.CORBA.portable.OutputStream $out = _request ("add", true);
                $out.write_double (arg1);
                $out.write_double (arg2);
                $in = _invoke ($out);
                double $result = $in.read_double ();
                return $result;
            } catch (org.omg.CORBA.portable.ApplicationException $ex) {
                $in = $ex.getInputStream ();
                String _id = $ex.getId ();
                if (_id.equals ("IDL:Ch/Elca/Iiop/GenericUserException:1.0"))
                    throw Ch.Elca.Iiop.GenericUserExceptionHelper.read ($in);
                else
                    throw new org.omg.CORBA.MARSHAL (_id);
            } catch (org.omg.CORBA.portable.RemarshalException $rm) {
                return add (arg1, arg2        );
            } finally {
                _releaseReply ($in);
            }
  } // add

  // Type-specific CORBA::Object operations
  private static String[] __ids = {
    "IDL:Ch/Elca/Iiop/Tutorial/GettingStarted/AdderImpl:1.0"};

  public String[] _ids ()
  {
    return (String[])__ids.clone ();
  }

  private void readObject (java.io.ObjectInputStream s) throws java.io.IOException
  {
     String str = s.readUTF ();
     String[] args = null;
     java.util.Properties props = null;
     org.omg.CORBA.ORB orb = org.omg.CORBA.ORB.init (args, props);
   try {
     org.omg.CORBA.Object obj = orb.string_to_object (str);
     org.omg.CORBA.portable.Delegate delegate = ((org.omg.CORBA.portable.ObjectImpl) obj)._get_delegate ();
     _set_delegate (delegate);
   } finally {
     orb.destroy() ;
   }
  }

  private void writeObject (java.io.ObjectOutputStream s) throws java.io.IOException
  {
     String[] args = null;
     java.util.Properties props = null;
     org.omg.CORBA.ORB orb = org.omg.CORBA.ORB.init (args, props);
   try {
     String str = orb.object_to_string (this);
     s.writeUTF (str);
   } finally {
     orb.destroy() ;
   }
  }
} // class _AdderImplStub
