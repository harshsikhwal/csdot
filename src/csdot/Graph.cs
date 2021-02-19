using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes;

namespace csdot
{
	public class Graph : IDot
	{
		public List<Node> m_nodes = new List<Node>();
		public List<Edge> m_edges = new List<Edge>();
		public GraphAttribute Attribute = new GraphAttribute();
		public List<IDot> m_dot = new List<IDot>();

	}
}
