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
			Console.WriteLine("node1 key: " + node.uid.ToString());
			//graph.AddElement(node);
			//var h = graph.GetElement(node.uid);
			graph.Attribute.label.Value = "this";
			node.Attribute.color.Value = Color.X11.darkviolet;
			node.Attribute.label.Value = "new node";
			graph.AddElement(node);


			Node n1 = new Node("n1");
			Console.WriteLine("node1 key: " + n1.uid.ToString());
			n1.Attribute.fontname.SetDefault();
			graph.AddElement(n1);
			var str = graph.ElementToString();

			Console.WriteLine(str);



		}
	}
}
