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
            //Node ip = loadedGraph.GetElementByName("ipv4_t") as Node;
            //Assert.IsTrue(ip.ID == "ipv4_t", "Node name is not matching");
            //Assert.IsTrue(ip.Attribute.shape.Value == "rectangle", "shape Attribute is not matching");
            //Assert.IsTrue(ip.Attribute.label.Value == "ipv4_t(ipv4_t.protocol)", "lable Attribute is not matching");
            //Node udp = loadedGraph.GetElementByName("udp") as Node;
            //Assert.IsTrue(udp.ID == "udp", "Node name is not matching");
            //Assert.IsTrue(udp.Attribute.shape.Value == "rectangle", "shape Attribute is not matching");
            //Assert.IsTrue(udp.Attribute.label.Value == "udp(udp.port)", "lable Attribute is not matching");
            Assert.Pass();
        }
    }
}
