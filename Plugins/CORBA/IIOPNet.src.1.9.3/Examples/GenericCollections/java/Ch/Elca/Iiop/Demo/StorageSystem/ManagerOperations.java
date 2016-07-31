package Ch.Elca.Iiop.Demo.StorageSystem;


/**
* Ch/Elca/Iiop/Demo/StorageSystem/ManagerOperations.java .
* ��IDL-to-Java ������ (����ֲ), �汾 "3.2"����
* ��Ch/Elca/Iiop/Demo/StorageSystem/Manager.idl
* 2015��11��23�� ����һ ����04ʱ43��01�� CST
*/

public interface ManagerOperations 
{
  Ch.Elca.Iiop.Demo.StorageSystem.Container CreateContainer () throws Ch.Elca.Iiop.GenericUserException;
  Ch.Elca.Iiop.Demo.StorageSystem.Container[] FilterContainers (Ch.Elca.Iiop.Demo.StorageSystem.Entry[] filter) throws Ch.Elca.Iiop.GenericUserException;
} // interface ManagerOperations
