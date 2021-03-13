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
		}

		[Test]
		public void full_diagraph()
		{
			graph = new Graph("");
			graph.type = "digraph";
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

		public void flowchart1()
		{
			graph = new Graph("G");
			graph.type = "digraph";
			List<Transition> transition = new List<Transition>()
			{
				new Transition("main", EdgeOp.directed),
				new Transition("parse", EdgeOp.directed),
				new Transition("execute", EdgeOp.unspecified)
			};
			Edge edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("main", EdgeOp.directed),
				new Transition("init", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("main", EdgeOp.directed),
				new Transition("cleanup", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("execute", EdgeOp.directed),
				new Transition("make_string", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("execute", EdgeOp.directed),
				new Transition("printf", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("init", EdgeOp.directed),
				new Transition("make_string", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("main", EdgeOp.directed),
				new Transition("printf", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("execute", EdgeOp.directed),
				new Transition("compare", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			DotDocument ddoc = new DotDocument();
			ddoc.SaveToFile(graph, "C:\\git\\csdot\\Resources\\test\\output\\flowchart1.dot");
			Assert.Pass();
		}

		// TODO: add flowchart2 from graphviz. Currently diagraph attribute ranksep and size not supported
		/*
		public void flowchart2()
		{
			graph = new Graph("asde91");
			graph.type = "digraph";
			List<Transition> transition = new List<Transition>()
			{
				new Transition("main", EdgeOp.directed),
				new Transition("parse", EdgeOp.directed),
				new Transition("execute", EdgeOp.unspecified)
			};
			Edge edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("main", EdgeOp.directed),
				new Transition("init", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("main", EdgeOp.directed),
				new Transition("cleanup", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("execute", EdgeOp.directed),
				new Transition("make_string", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("execute", EdgeOp.directed),
				new Transition("printf", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("init", EdgeOp.directed),
				new Transition("make_string", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("main", EdgeOp.directed),
				new Transition("printf", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			transition = new List<Transition>()
			{
				new Transition("execute", EdgeOp.directed),
				new Transition("compare", EdgeOp.unspecified)
			};
			edge = new Edge(transition);
			graph.AddElement(edge);

			DotDocument ddoc = new DotDocument();
			ddoc.SaveToFile(graph, "C:\\git\\csdot\\Resources\\test\\output\\flowchart1.dot");
			Assert.Pass();
		}
		*/

	}
}
