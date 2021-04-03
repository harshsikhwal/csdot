using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.DataTypes;
using csdot;

namespace csdot
{
	class Test
	{
		public static void Main(string[] args)
		{
			
			Graph graph = new Graph("Test");
			Node node = new Node("node1");
			// Console.WriteLine("node1 key: " + node.uid.ToString());
			//graph.AddElement(node);
			//var h = graph.GetElement(node.uid);
			graph.Attribute.label.Value = "this";
			graph.Attribute.concentrate.Value = true;
			node.Attribute.color.Value = Color.X11.darkviolet;
			node.Attribute.label.Value = "new node";

			graph.AddElement(node);


			Node n1 = new Node("n1");
			// Console.WriteLine("node1 key: " + n1.uid.ToString());
			n1.Attribute.fontname.SetDefault();
			graph.AddElement(n1);



			Node node1 = new Node("123");
			node1.Attribute.shape.Value = ShapeTypes.circle;

			graph.AddElement(node1);

			var str = graph.ElementToString();

			Console.WriteLine(str);


			Node n = graph.GetElement(node1.uid) as Node;

			n.Attribute.shape.Set = false;

			str = graph.ElementToString();

			Console.WriteLine("New graph:\n");

			Console.WriteLine(str);


			// Creating edge
			// A -> B -- C
			// A -- Y

			Node a = new Node("A");
			Node b = new Node("B");
			Node c = new Node("C");

			Node y = new Node("Y");


			Edge edge = new Edge();



			List<Transition> ts = new List<Transition>()
			{
				new Transition(a, EdgeOp.directed),
				new Transition(b, EdgeOp.undirected),
				new Transition(b, EdgeOp.unspecified)
			};



			edge.Transition = ts;

			point _point = new point(3, 4);



			edge.Attribute.head_lp.Value = _point;

			edge.Attribute.head_lp.Value.X = 4;

			graph.AddElement(edge);
			str = graph.ElementToString();

			Console.WriteLine("Transition graph:\n");

			Console.WriteLine(str);

			//DotDocument docObj = new DotDocument();
			//Graph loadedGraph = docObj.LoadDigraph("..\\..\\..\\..\\..\\Resources\\test\\unknown\\dot.dot");
			//str = loadedGraph.ElementToString();
			//Console.WriteLine("Loaded graph:\n");
			//Console.WriteLine(str);
		}
	}

	public class _class
	{

	}

	public class A
	{
		public _class @class;
	}

	public class B
	{
		public void test()
		{
			A a = new A();
			a.@class = new _class();
		}
	}
}
