using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using csdot;
using csdot.Attributes.DataTypes;

namespace UnitTest
{
	public class EdgeTest
	{
		Graph graph;
		[SetUp]
		public void Setup()
		{
			graph = new Graph("");
		}

		// [Test]
		public void edge_subgraph()
		{
			graph.Attribute.rankdir.Value = Rankdir.LR;

			Node a = new Node("a");
			Node b = new Node("b");
			Node c = new Node("c");
			Node d = new Node("d");
			Node e = new Node("e");
			Node f = new Node("f");
			Node g = new Node("g");
			Node h = new Node("h");
			Node i = new Node("i");
			Node j = new Node("j");

			Subgraph subgraph = new Subgraph();
			subgraph.AddElements(b, c, d);

			List<Transition> transition = new List<Transition>()
			{
				new Transition(a, EdgeOp.undirected),
				new Transition(subgraph, EdgeOp.unspecified)
			};
			Edge edge = new Edge(transition);
			graph.AddElement(edge);

			subgraph = new Subgraph();
			subgraph.AddElements(c, e);

			transition = new List<Transition>()
			{
				new Transition(b, EdgeOp.undirected),
				new Transition(subgraph, EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			subgraph = new Subgraph();
			subgraph.AddElements(e, f);

			transition = new List<Transition>()
			{
				new Transition(c, EdgeOp.undirected),
				new Transition(subgraph, EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			subgraph = new Subgraph();
			subgraph.AddElements(f, g);

			transition = new List<Transition>()
			{
				new Transition(d, EdgeOp.undirected),
				new Transition(subgraph, EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition(e, EdgeOp.undirected),
				new Transition(h, EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			subgraph = new Subgraph();
			subgraph.AddElements(h, i, j, g);

			transition = new List<Transition>()
			{
				new Transition(f, EdgeOp.undirected),
				new Transition(subgraph, EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			DotDocument ddoc = new DotDocument();
			ddoc.SaveToFile(graph, "..\\..\\..\\..\\..\\Resources\\test\\output\\edge_subgraph.dot");
			Assert.Pass();
		}
	}
}
