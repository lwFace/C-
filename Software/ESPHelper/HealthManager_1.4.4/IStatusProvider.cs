namespace com.hirain.avionics.healthmanager
{


	public interface IStatusProvider
	{
	  /// <summary>
	  /// ����һ��ServerNode�������ڹ㲥״̬��Ϣ����������Ϣ�ı�ʱ���ڴ˷����з���ֵ��
	  /// <p>
	  /// ServerNode getNode() { <code><p>
	  /// ServerNode newNode = new ServerNode(HealthManager.TYPE_CLIENT_MATRIX, "Matrix",
	  /// "matrix-1", "1.0", ServerNode.STATUS_ONLINE, "free",
	  /// "http://10.0.0.30/svn/Matrix", "12345", new String[]{"afdx_matrix","matrix-429","matrix-dio1", "matrix-dio2"});
	  /// <p>
	  /// return newNode;
	  /// <p></code>
	  /// </summary>
	  /// <seealso cref= ServerNode </seealso>
	  /// <returns> ServerNode </returns>
	  com.hirain.avionics.healthmanager.dds.IDDSData Node {get;}

	}

}