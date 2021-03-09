using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using csdot;
using csdot.Attributes.DataTypes;


namespace UnitTest
{
	public class DiagraphTest
	{
		Graph graph;
		[SetUp]
		public void Setup()
		{
			graph = new Graph("");
			graph.type = "digraph";
		}

		[Test]
		public void full_diagraph()
		{
			List<Transition> transition = new List<Transition>()
			{
				new Transition("a", EdgeOp.directed),
				new Transition("b", EdgeOp.unspecified)
			};
			Edge edge = new Edge(transition);
			edge.Attribute.label.Value = "0.2";
			edge.Attribute.weight.Value = 0.2;
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("a", EdgeOp.directed),
				new Transition("c", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			edge.Attribute.label.Value = "0.4";
			edge.Attribute.weight.Value = 0.4;
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("c", EdgeOp.directed),
				new Transition("b", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			edge.Attribute.label.Value = "0.6";
			edge.Attribute.weight.Value = 0.6;
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("c", EdgeOp.directed),
				new Transition("e", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			edge.Attribute.label.Value = "0.6";
			edge.Attribute.weight.Value = 0.6;
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("e", EdgeOp.directed),
				new Transition("e", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			edge.Attribute.label.Value = "0.1";
			edge.Attribute.weight.Value = 0.1;
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("e", EdgeOp.directed),
				new Transition("b", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			edge.Attribute.label.Value = "0.7";
			edge.Attribute.weight.Value = 0.7;
			graph.AddElement(edge);

			DotDocument ddoc = new DotDocument();
			ddoc.SaveToFile(graph, "C:\\git\\csdot\\Resources\\test\\output\\full_digraph.dot");
			Assert.Pass();

		}
	}
}
