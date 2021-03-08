using System;
using System.Collections.Generic;
using System.Text;
using csdot;
using NUnit.Framework;
using csdot.Attributes.DataTypes;

namespace UnitTest
{
	public class SubgraphTest
	{
		Graph graph;
		[SetUp]
		public void Setup()
		{
			graph = new Graph("");
			graph.type = "digraph";
		}

		[Test]
		public void Subgraphs()
		{
			Subgraph cluster_0 = new Subgraph("cluster_0");
			cluster_0.Attribute.label.Value = "Subgraph A";

			List<Transition> transition = new List<Transition>()
			{
				new Transition("a", EdgeOp.directed),
				new Transition("b", EdgeOp.unspecified)
			};
			Edge edge = new Edge(transition);
			cluster_0.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("b", EdgeOp.directed),
				new Transition("c", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			cluster_0.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("c", EdgeOp.directed),
				new Transition("d", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			cluster_0.AddElement(edge);

			graph.AddElement(cluster_0);

			Subgraph cluster_1 = new Subgraph("cluster_1");
			cluster_1.Attribute.label.Value = "Subgraph B";

			transition = new List<Transition>()
			{
				new Transition("a", EdgeOp.directed),
				new Transition("f", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			cluster_1.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("f", EdgeOp.directed),
				new Transition("c", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			cluster_1.AddElement(edge);
			graph.AddElement(cluster_1);

			DotDocument ddoc = new DotDocument();
			ddoc.SaveToFile(graph, "C:\\git\\csdot\\Resources\\test\\output\\subgraphs.dot");
			Assert.Pass();
		}

		[Test]
		public void Subgraphs2()
		{
			graph = new Graph("");
			graph.Attribute.splines.Value = true;
			Subgraph cluster_0 = new Subgraph("cluster_0");
			cluster_0.Attribute.label.Value = "Subgraph A";
			Node a = new Node("a");
			Node b = new Node("b");
			Node c = new Node("c");
			cluster_0.AddElements(a, b, c);

			Subgraph cluster_1 = new Subgraph("cluster_1");
			cluster_1.Attribute.label.Value = "Subgraph B";
			Node d = new Node("d");
			Node e = new Node("e");
			cluster_1.AddElements(d, e);

			graph.AddElements(cluster_0, cluster_1);

			List<Transition> transition = new List<Transition>()
			{
				new Transition(a, EdgeOp.undirected),
				new Transition(e, EdgeOp.unspecified)
			};

			Edge edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition(a, EdgeOp.undirected),
				new Transition(d, EdgeOp.unspecified)
			};

			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition(b, EdgeOp.undirected),
				new Transition(d, EdgeOp.unspecified)
			};

			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition(b, EdgeOp.undirected),
				new Transition(e, EdgeOp.unspecified)
			};

			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition(c, EdgeOp.undirected),
				new Transition(d, EdgeOp.unspecified)
			};

			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition(c, EdgeOp.undirected),
				new Transition(e, EdgeOp.unspecified)
			};

			edge = new Edge(transition);
			graph.AddElement(edge);

			DotDocument ddoc = new DotDocument();
			ddoc.SaveToFile(graph, "C:\\git\\csdot\\Resources\\test\\output\\subgraphs2.dot");
			Assert.Pass();
		}
	}
}
