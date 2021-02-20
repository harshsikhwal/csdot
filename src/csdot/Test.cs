using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.DataTypes;

namespace csdot
{
	class Test
	{
		public static void Main(string[] args)
		{
			
			Graph graph = new Graph("Test");
			Node node = new Node("node1");
			//graph.AddElement(node);
			//var h = graph.GetElement(node.uid);
			graph.Attribute.label.Value = "this";
			node.Attribute.color.Value = Color.X11.darkviolet;

		}
	}
}
