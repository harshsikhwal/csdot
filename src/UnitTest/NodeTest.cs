using NUnit.Framework;
using csdot;
using csdot.Attributes.DataTypes;

namespace UnitTest
{
	public class Tests
	{
		Graph graph;
		[SetUp]
		public void Setup()
		{
			graph = new Graph("test");
		}

		[Test]
		public void Test1()
		{
			Node ethernet = new Node("ethernet");
			ethernet.Attribute.shape.Value = ShapeTypes.circle;
			ethernet.Attribute.color.Value = Color.X11.red;
			ethernet.Attribute.label.Value = "ethernet";
			graph.AddElement(ethernet);
			Assert.Pass();
		}
	}
}