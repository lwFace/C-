using System;
using System.Collections.Generic;
using System.Text;

namespace com.hirain.avionics.healthmanager.dds
{



	public abstract class AbstractDDSData : IDDSData
	{
			public abstract datarouter.EVENT_msg toEventMsg();

	  public static void setAttribute(datarouter.Node node, string name, string value)
	  {
		datarouter.Node[] attributes = node.attributes;
		foreach (datarouter.Node attr in attributes)
		{
		  if (attr.name.Equals(name))
		  {
			attr._value = value;
			return;
		  }
		}
		datarouter.Node[] newAttributes = new datarouter.Node[attributes.Length + 1];
		Array.Copy(attributes, 0, newAttributes, 0, attributes.Length);
		datarouter.Node newAttr = new datarouter.Node();
		newAttr.name = name;
		newAttr._value = value;
		newAttributes[attributes.Length] = newAttr;
		node.attributes = newAttributes;
	  }

	  public static string getAttribute(datarouter.Node node, string name)
	  {
		datarouter.Node[] attributes = node.attributes;
		foreach (datarouter.Node attr in attributes)
		{
		  if (attr.name.Equals(name))
		  {
			return attr._value;
		  }
		}
		return null;
	  }

	  public static void appendChild(datarouter.Node parent, datarouter.Node child)
	  {
		datarouter.Node[] children = parent.children;
		datarouter.Node[] newChildren = new datarouter.Node[children.Length + 1];
		Array.Copy(children, 0, newChildren, 0, children.Length);
		newChildren[children.Length] = child;
		parent.children = newChildren;
	  }

	  public static datarouter.Node[] findChild(datarouter.Node parent, string name)
	  {
		List<datarouter.Node> list = new List<datarouter.Node>();
		foreach (datarouter.Node node in parent.children)
		{
		  if (node.name.Equals(name))
		  {
			list.Add(node);
		  }
		}
		return list.ToArray();
	  }

	  public static string intarray2string(int[] array)
	  {
		StringBuilder sb = new StringBuilder();
		if (array != null)
		{
		  foreach (int id in array)
		  {
              sb.Append(Convert.ToString(id, 16));
			sb.Append(';');
		  }
		}
		return sb.ToString();
	  }

	  public static int[] string2intarray(string str)
	  {
		if (str == null || str.Equals(""))
		{
		  return new int[0];
		}
		string[] arrays = StringHelperClass.StringSplit(str, ";", true);
		int[] array = new int[arrays.Length];
		for (int i = 0; i < arrays.Length; i++)
		{
		  array[i] = Convert.ToInt32(arrays[i], 16);
		}
		return array;
	  }

	  public AbstractDDSData() : base()
	  {
	  }

	}

}