using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using csdot;
using csdot.Attributes.DataTypes;


namespace UnitTest
{
	public class GraphTest
	{
		Graph graph;
		[SetUp]
		public void Setup()
		{
			graph = new Graph("");
		}

		[Test]
		public void showing_a_path()
		{
			List<Transition> transition = new List<Transition>()
			{
				new Transition("a", EdgeOp.undirected),
				new Transition("b", EdgeOp.unspecified)
			};
			Edge edge = new Edge(transition);
			edge.Attribute.color.Value = Color.X11.red;
			edge.Attribute.penwidth.Value = 3.0;
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("b", EdgeOp.undirected),
				new Transition("c", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("c", EdgeOp.undirected),
				new Transition("d", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			edge.Attribute.color.Value = Color.X11.red;
			edge.Attribute.penwidth.Value = 3.0;
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("d", EdgeOp.undirected),
				new Transition("e", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("e", EdgeOp.undirected),
				new Transition("f", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("a", EdgeOp.undirected),
				new Transition("d", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("b", EdgeOp.undirected),
				new Transition("d", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			edge.Attribute.color.Value = Color.X11.red;
			edge.Attribute.penwidth.Value = 3.0;
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("c", EdgeOp.undirected),
				new Transition("f", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			edge.Attribute.color.Value = Color.X11.red;
			edge.Attribute.penwidth.Value = 3.0;
			graph.AddElement(edge);

			DotDocument ddoc = new DotDocument();
			ddoc.SaveToFile(graph, "C:\\git\\csdot\\Resources\\test\\output\\showing_a_path.dot");
			Assert.Pass();

			Assert.Pass();
		}
	}
}
