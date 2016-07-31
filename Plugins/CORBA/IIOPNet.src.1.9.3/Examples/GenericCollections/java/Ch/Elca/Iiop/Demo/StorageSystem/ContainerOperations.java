package Ch.Elca.Iiop.Demo.StorageSystem;


/**
* Ch/Elca/Iiop/Demo/StorageSystem/ContainerOperations.java .
* ��IDL-to-Java ������ (����ֲ), �汾 "3.2"����
* ��Ch/Elca/Iiop/Demo/StorageSystem/Container.idl
* 2015��11��23�� ����һ ����04ʱ43��01�� CST
*/

public interface ContainerOperations 
{
  Ch.Elca.Iiop.Demo.StorageSystem.Entry[] Enumerate () throws Ch.Elca.Iiop.GenericUserException;
  void SetValue (String key, String value) throws Ch.Elca.Iiop.GenericUserException;
  void SetEntry (Ch.Elca.Iiop.Demo.StorageSystem.Entry e) throws Ch.Elca.Iiop.GenericUserException;
  String GetValue (String key) throws Ch.Elca.Iiop.GenericUserException;
} // interface ContainerOperations
