﻿using NUnit.Framework;
using csdot;
using csdot.Attributes.DataTypes;

namespace UnitTest
{
	public class AttributeTest
	{
		Graph graph;
		[SetUp]
		public void Setup()
		{
			graph = new Graph("test");
		}

		[Test]
		public void set_and_unset()
		{
			Node ethernet = new Node("ethernet");
			ethernet.Attribute.shape.Value = ShapeTypes.circle;
			ethernet.Attribute.color.Value = Color.X11.red;
			ethernet.Attribute.label.Value = "ethernet";

			graph.AddElement(ethernet);

			Node ipv4 = new Node("ipv4");
			ipv4.Attribute.shape.Value = ShapeTypes.square;
			ipv4.Attribute.color.Value = Color.X11.blue;
			ipv4.Attribute.label.Value = "ipv4";

			graph.AddElement(ipv4);

			DotDocument ddoc = new DotDocument();
			ddoc.SaveToFile(graph, "C:\\git\\csdot\\Resources\\test\\output\\set_and_unset1.dot");

			Node element = graph.GetElement(ipv4.uid) as Node;
			element.Attribute.color.Set = false;

			ddoc.SaveToFile(graph, "C:\\git\\csdot\\Resources\\test\\output\\set_and_unset2.dot");

			Assert.Pass();
		}
	}
}
