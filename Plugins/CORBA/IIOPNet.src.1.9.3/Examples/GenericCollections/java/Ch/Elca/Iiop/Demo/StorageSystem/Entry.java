package Ch.Elca.Iiop.Demo.StorageSystem;


/**
* Ch/Elca/Iiop/Demo/StorageSystem/Entry.java .
* 由IDL-to-Java 编译器 (可移植), 版本 "3.2"生成
* 从Ch/Elca/Iiop/Demo/StorageSystem/Entry.idl
* 2015年11月23日 星期一 下午04时43分01秒 CST
*/

public abstract class Entry implements org.omg.CORBA.portable.StreamableValue
{
  public String key = null;
  public String value = null;

  private static String[] _truncatable_ids = {
    Ch.Elca.Iiop.Demo.StorageSystem.EntryHelper.id ()
  };

  public String[] _truncatable_ids() {
    return _truncatable_ids;
  }

  public void _read (org.omg.CORBA.portable.InputStream istream)
  {
    this.key = org.omg.CORBA.WStringValueHelper.read (istream);
    this.value = org.omg.CORBA.WStringValueHelper.read (istream);
  }

  public void _write (org.omg.CORBA.portable.OutputStream ostream)
  {
    org.omg.CORBA.WStringValueHelper.write (ostream, this.key);
    org.omg.CORBA.WStringValueHelper.write (ostream, this.value);
  }

  public org.omg.CORBA.TypeCode _type ()
  {
    return Ch.Elca.Iiop.Demo.StorageSystem.EntryHelper.type ();
  }
} // class Entry
