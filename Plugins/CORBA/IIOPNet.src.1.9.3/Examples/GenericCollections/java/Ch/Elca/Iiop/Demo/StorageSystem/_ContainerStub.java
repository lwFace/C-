package Ch.Elca.Iiop.Demo.StorageSystem;


/**
* Ch/Elca/Iiop/Demo/StorageSystem/_ContainerStub.java .
* 由IDL-to-Java 编译器 (可移植), 版本 "3.2"生成
* 从Ch/Elca/Iiop/Demo/StorageSystem/Container.idl
* 2015年11月23日 星期一 下午04时43分01秒 CST
*/

public class _ContainerStub extends org.omg.CORBA.portable.ObjectImpl implements Ch.Elca.Iiop.Demo.StorageSystem.Container
{

  public Ch.Elca.Iiop.Demo.StorageSystem.Entry[] Enumerate () throws Ch.Elca.Iiop.GenericUserException
  {
            org.omg.CORBA.portable.InputStream $in = null;
            try {
                org.omg.CORBA.portable.OutputStream $out = _request ("Enumerate", true);
                $in = _invoke ($out);
                Ch.Elca.Iiop.Demo.StorageSystem.Entry[] $result = org.omg.BoxedArray.Ch.Elca.Iiop.Demo.StorageSystem.seq1_EntryHelper.read ($in);
                return $result;
            } catch (org.omg.CORBA.portable.ApplicationException $ex) {
                $in = $ex.getInputStream ();
                String _id = $ex.getId ();
                if (_id.equals ("IDL:Ch/Elca/Iiop/GenericUserException:1.0"))
                    throw Ch.Elca.Iiop.GenericUserExceptionHelper.read ($in);
                else
                    throw new org.omg.CORBA.MARSHAL (_id);
            } catch (org.omg.CORBA.portable.RemarshalException $rm) {
                return Enumerate (        );
            } finally {
                _releaseReply ($in);
            }
  } // Enumerate

  public void SetValue (String key, String value) throws Ch.Elca.Iiop.GenericUserException
  {
            org.omg.CORBA.portable.InputStream $in = null;
            try {
                org.omg.CORBA.portable.OutputStream $out = _request ("SetValue", true);
                org.omg.CORBA.WStringValueHelper.write ($out, key);
                org.omg.CORBA.WStringValueHelper.write ($out, value);
                $in = _invoke ($out);
                return;
            } catch (org.omg.CORBA.portable.ApplicationException $ex) {
                $in = $ex.getInputStream ();
                String _id = $ex.getId ();
                if (_id.equals ("IDL:Ch/Elca/Iiop/GenericUserException:1.0"))
                    throw Ch.Elca.Iiop.GenericUserExceptionHelper.read ($in);
                else
                    throw new org.omg.CORBA.MARSHAL (_id);
            } catch (org.omg.CORBA.portable.RemarshalException $rm) {
                SetValue (key, value        );
            } finally {
                _releaseReply ($in);
            }
  } // SetValue

  public void SetEntry (Ch.Elca.Iiop.Demo.StorageSystem.Entry e) throws Ch.Elca.Iiop.GenericUserException
  {
            org.omg.CORBA.portable.InputStream $in = null;
            try {
                org.omg.CORBA.portable.OutputStream $out = _request ("SetEntry", true);
                Ch.Elca.Iiop.Demo.StorageSystem.EntryHelper.write ($out, e);
                $in = _invoke ($out);
                return;
            } catch (org.omg.CORBA.portable.ApplicationException $ex) {
                $in = $ex.getInputStream ();
                String _id = $ex.getId ();
                if (_id.equals ("IDL:Ch/Elca/Iiop/GenericUserException:1.0"))
                    throw Ch.Elca.Iiop.GenericUserExceptionHelper.read ($in);
                else
                    throw new org.omg.CORBA.MARSHAL (_id);
            } catch (org.omg.CORBA.portable.RemarshalException $rm) {
                SetEntry (e        );
            } finally {
                _releaseReply ($in);
            }
  } // SetEntry

  public String GetValue (String key) throws Ch.Elca.Iiop.GenericUserException
  {
            org.omg.CORBA.portable.InputStream $in = null;
            try {
                org.omg.CORBA.portable.OutputStream $out = _request ("GetValue", true);
                org.omg.CORBA.WStringValueHelper.write ($out, key);
                $in = _invoke ($out);
                String $result = org.omg.CORBA.WStringValueHelper.read ($in);
                return $result;
            } catch (org.omg.CORBA.portable.ApplicationException $ex) {
                $in = $ex.getInputStream ();
                String _id = $ex.getId ();
                if (_id.equals ("IDL:Ch/Elca/Iiop/GenericUserException:1.0"))
                    throw Ch.Elca.Iiop.GenericUserExceptionHelper.read ($in);
                else
                    throw new org.omg.CORBA.MARSHAL (_id);
            } catch (org.omg.CORBA.portable.RemarshalException $rm) {
                return GetValue (key        );
            } finally {
                _releaseReply ($in);
            }
  } // GetValue

  // Type-specific CORBA::Object operations
  private static String[] __ids = {
    "IDL:Ch/Elca/Iiop/Demo/StorageSystem/Container:1.0"};

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
} // class _ContainerStub
