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
			graph = new Graph("test");
		}

		[Test]
		public void Test1()
		{
			Assert.Pass();
		}
	}
}
