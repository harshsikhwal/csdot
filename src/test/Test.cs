using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.DataTypes;
using csdot;

namespace csdot
{
	class Test
	{
		public static void LoadTest()
		{
			DotDocument doc = new DotDocument();
			Graph loadedGraph = doc.LoadDigraph("..\\..\\..\\..\\..\\Resources\\test\\unknown\\attr_widgets.dot");
			var str = loadedGraph.ElementToString(1);
			Console.WriteLine("Loaded graph: showing_a_path.dot\n");
			Console.WriteLine(str);
			doc.SaveToFile(loadedGraph, "..\\..\\..\\..\\..\\Resources\\test\\dot_files\\test.dot");
		}

		public static void CustomAttribute()
		{
			Graph graph = new Graph("new_graph");

			// Add node
			Node node = new Node("A");
			node.Attribute.area.Value = 36;
			node.Attribute.color.Value = "black";
			graph.AddElement(node);

			node = new Node("custom_attribute");
			node.Attribute.color.Value = "white";
			node.Attribute.CustomAttribute.Add("NodeFileName", "C:\\Values");
			graph.AddElement(node);

			

			// Add edge

			// Add subgraph

			Subgraph subgraph = new Subgraph("test");
			node = new Node("subgraph_node_A");
			node.Attribute.area.Value = 3;
			node.Attribute.CustomAttribute.Add("Test", "Val");
			subgraph.AddElement(node);
			graph.AddElement(subgraph);
			// Add cluster

			DotDocument doc = new DotDocument();
			doc.SaveToFile(graph, "C:\\git\\csdot\\Resources\\test\\dot_files\\test.dot");
		}


		public static void SaveTest()
		{

		}

		public static void Main(string[] args)
		{
            CustomAttribute();
            /*
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
			
            string str;
            DotDocument docObj1 = new DotDocument();
            Graph loadedGraph1 = docObj1.LoadDigraph("..\\..\\..\\..\\..\\Resources\\test\\unknown\\dot.dot");
            str = loadedGraph1.ElementToString(1);
            Console.WriteLine("\nLoaded graph: 1\n");
            Console.WriteLine(str);

            DotDocument docObj3 = new DotDocument();
            Graph loadedGraph3 = docObj3.LoadDigraph("..\\..\\..\\..\\..\\Resources\\test\\dot_files\\cluster1.dot");
            str = loadedGraph3.ElementToString(1);
            Console.WriteLine("\nLoaded graph: 2\n");
            Console.WriteLine(str);

            DotDocument docObj4 = new DotDocument();
            Graph loadedGraph4 = docObj4.LoadDigraph("..\\..\\..\\..\\..\\Resources\\test\\dot_files\\full_digraph.dot");
            str = loadedGraph4.ElementToString(1);
            Console.WriteLine("\nLoaded graph: 3\n");
            Console.WriteLine(str);

            DotDocument docObj5 = new DotDocument();
            Graph loadedGraph5 = docObj5.LoadDigraph("..\\..\\..\\..\\..\\Resources\\test\\dot_files\\rank.dot");
            str = loadedGraph5.ElementToString(1);
            Console.WriteLine("\nLoaded graph: 4\n");
            Console.WriteLine(str);

            DotDocument docObj6 = new DotDocument();
            Graph loadedGraph6 = docObj6.LoadDigraph("..\\..\\..\\..\\..\\Resources\\test\\dot_files\\cluster2.dot");
            str = loadedGraph6.ElementToString(1);
            Console.WriteLine("\nLoaded graph: 5\n");
            Console.WriteLine(str);

            DotDocument docObj7 = new DotDocument();
            Graph loadedGraph7 = docObj7.LoadDigraph("..\\..\\..\\..\\..\\Resources\\test\\dot_files\\ne2.dot");
            str = loadedGraph7.ElementToString(1);
            Console.WriteLine("\nLoaded graph: 6\n");
            Console.WriteLine(str);

            DotDocument docObj8 = new DotDocument();
            Graph loadedGraph8 = docObj8.LoadDigraph("..\\..\\..\\..\\..\\Resources\\test\\dot_files\\edge_subgraph.dot");
            str = loadedGraph8.ElementToString(1);
            Console.WriteLine("\nLoaded graph: 7\n");
            Console.WriteLine(str);

            DotDocument docObj9 = new DotDocument();
            Graph loadedGraph9 = docObj9.LoadDigraph("..\\..\\..\\..\\..\\Resources\\test\\dot_files\\large_graphs1.dot");
            str = loadedGraph9.ElementToString(1);
            Console.WriteLine("\nLoaded graph: 8\n");
            Console.WriteLine(str);

            DotDocument docObj10 = new DotDocument();
            Graph loadedGraph10 = docObj10.LoadDigraph("..\\..\\..\\..\\..\\Resources\\test\\dot_files\\large_graphs2.dot");
            str = loadedGraph10.ElementToString(1);
            Console.WriteLine("\nLoaded graph: 9\n");
            Console.WriteLine(str);

            DotDocument docObj11 = new DotDocument();
            Graph loadedGraph11 = docObj11.LoadDigraph("..\\..\\..\\..\\..\\Resources\\test\\dot_files\\nested_cluster.dot");
            str = loadedGraph11.ElementToString(1);
            Console.WriteLine("\nLoaded graph: 10\n");
            Console.WriteLine(str);

            DotDocument docObj12 = new DotDocument();
            Graph loadedGraph12 = docObj12.LoadDigraph("..\\..\\..\\..\\..\\Resources\\test\\dot_files\\subgraph_cluster.dot");
            str = loadedGraph12.ElementToString(1);
            Console.WriteLine("\nLoaded graph: 11\n");
            Console.WriteLine(str);

            DotDocument docObj13 = new DotDocument();
            Graph loadedGraph13 = docObj13.LoadDigraph("..\\..\\..\\..\\..\\Resources\\test\\Issues\\[Load Digraph] Node present as string is tokenized to different nodes\\flowchart2.dot");
            str = loadedGraph13.ElementToString(1);
            Console.WriteLine("\nLoaded graph: 12\n");
            Console.WriteLine(str);

            DotDocument docObj14 = new DotDocument();
            Graph loadedGraph14 = docObj14.LoadDigraph("..\\..\\..\\..\\..\\Resources\\test\\dot_files\\test.dot");
            str = loadedGraph14.ElementToString(1);
            Console.WriteLine("\nLoaded graph: 13\n");
            Console.WriteLine(str);
			*/
            //LoadTest();
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
