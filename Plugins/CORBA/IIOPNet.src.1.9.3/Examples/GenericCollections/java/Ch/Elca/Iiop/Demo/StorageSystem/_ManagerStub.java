package Ch.Elca.Iiop.Demo.StorageSystem;


/**
* Ch/Elca/Iiop/Demo/StorageSystem/_ManagerStub.java .
* 由IDL-to-Java 编译器 (可移植), 版本 "3.2"生成
* 从Ch/Elca/Iiop/Demo/StorageSystem/Manager.idl
* 2015年11月23日 星期一 下午04时43分01秒 CST
*/

public class _ManagerStub extends org.omg.CORBA.portable.ObjectImpl implements Ch.Elca.Iiop.Demo.StorageSystem.Manager
{

  public Ch.Elca.Iiop.Demo.StorageSystem.Container CreateContainer () throws Ch.Elca.Iiop.GenericUserException
  {
            org.omg.CORBA.portable.InputStream $in = null;
            try {
                org.omg.CORBA.portable.OutputStream $out = _request ("CreateContainer", true);
                $in = _invoke ($out);
                Ch.Elca.Iiop.Demo.StorageSystem.Container $result = Ch.Elca.Iiop.Demo.StorageSystem.ContainerHelper.read ($in);
                return $result;
            } catch (org.omg.CORBA.portable.ApplicationException $ex) {
                $in = $ex.getInputStream ();
                String _id = $ex.getId ();
                if (_id.equals ("IDL:Ch/Elca/Iiop/GenericUserException:1.0"))
                    throw Ch.Elca.Iiop.GenericUserExceptionHelper.read ($in);
                else
                    throw new org.omg.CORBA.MARSHAL (_id);
            } catch (org.omg.CORBA.portable.RemarshalException $rm) {
                return CreateContainer (        );
            } finally {
                _releaseReply ($in);
            }
  } // CreateContainer

  public Ch.Elca.Iiop.Demo.StorageSystem.Container[] FilterContainers (Ch.Elca.Iiop.Demo.StorageSystem.Entry[] filter) throws Ch.Elca.Iiop.GenericUserException
  {
            org.omg.CORBA.portable.InputStream $in = null;
            try {
                org.omg.CORBA.portable.OutputStream $out = _request ("FilterContainers", true);
                org.omg.BoxedArray.Ch.Elca.Iiop.Demo.StorageSystem.seq1_EntryHelper.write ($out, filter);
                $in = _invoke ($out);
                Ch.Elca.Iiop.Demo.StorageSystem.Container[] $result = org.omg.BoxedArray.Ch.Elca.Iiop.Demo.StorageSystem.seq1_ContainerHelper.read ($in);
                return $result;
            } catch (org.omg.CORBA.portable.ApplicationException $ex) {
                $in = $ex.getInputStream ();
                String _id = $ex.getId ();
                if (_id.equals ("IDL:Ch/Elca/Iiop/GenericUserException:1.0"))
                    throw Ch.Elca.Iiop.GenericUserExceptionHelper.read ($in);
                else
                    throw new org.omg.CORBA.MARSHAL (_id);
            } catch (org.omg.CORBA.portable.RemarshalException $rm) {
                return FilterContainers (filter        );
            } finally {
                _releaseReply ($in);
            }
  } // FilterContainers

  // Type-specific CORBA::Object operations
  private static String[] __ids = {
    "IDL:Ch/Elca/Iiop/Demo/StorageSystem/Manager:1.0"};

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
} // class _ManagerStub
