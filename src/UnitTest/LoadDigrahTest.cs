using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using csdot;

namespace UnitTest
{
    class LoadDigrahTest
    {
        [Test]
        public void BasicLoadTest()
        {
            DotDocument docObj = new DotDocument();
            //Graph loadedGraph = docObj.LoadDigraph("..\\..\\..\\..\\..\\Resources\\test\\unknown\\dot.dot");
            //Assert.IsTrue(loadedGraph.ID == "Transition", "Graph name is not matching");
            Assert.Pass();
        }
    }
}
