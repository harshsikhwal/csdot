using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes;
namespace csdot
{
	public class Edge : IDot
	{
		public string type { get; set; } = "edge";
		public Guid uid { get; }
		public string ID { get; set; }

		public EdgeAttribute Attribute = new EdgeAttribute();

		public List<Transition> Transition
		{
			get; set;
		}

		public Edge()
		{
			uid = Guid.NewGuid();
		}

		public Edge(List<Transition> i_transition)
		{
			Transition = i_transition;
			uid = Guid.NewGuid();
		}

		public void AddTransition(Transition i_transition)
		{
			Transition.Add(i_transition);
		}

		public string ElementToString()
		{
			string transitionBuilder = "";
			foreach(var t in Transition)
			{
				if(t.type == "subgraph")
				{
					transitionBuilder = transitionBuilder + t.dot.ElementToString();
				}
				else 
				{
					transitionBuilder = transitionBuilder + t.ID;
				}
				if(t.edgeop == "")
					transitionBuilder = transitionBuilder + " ";
				else
					transitionBuilder = transitionBuilder + " " + t.edgeop + " ";
			}
			string attributestr = Attribute.AttributesToString();
			if(attributestr != "")
			{
				transitionBuilder = transitionBuilder + "[" +  Attribute.AttributesToString() + " ]";
			}
			return transitionBuilder;
		}

		public string ElementToString(int i_spacing)
		{
			string spacing = "";
			if (i_spacing > 0)
				spacing = new String('\t', i_spacing);
			string transitionBuilder = "";
			foreach (var t in Transition)
			{
				if (t.type == "subgraph")
				{
					transitionBuilder = transitionBuilder + t.dot.ElementToString(i_spacing);
				}
				else
				{
					transitionBuilder = transitionBuilder + t.ID;
				}
				if (t.edgeop == "")
					transitionBuilder = transitionBuilder + " ";
				else
					transitionBuilder = transitionBuilder + " " + t.edgeop + " ";
			}
			string attributestr = Attribute.AttributesToString();
			if (attributestr != "")
			{
				transitionBuilder = transitionBuilder + "[" + Attribute.AttributesToString() + " ]";
			}
			return transitionBuilder;
		}
	}

	public class Transition
	{
		public Guid uid;
		public string ID;
		public string edgeop;
		public string type;
		public IDot dot;

		public Transition(string i_id, string m_op)
		{
			ID = i_id;
			uid = Guid.NewGuid();
			edgeop = m_op;
			type = "node";
		}

		public Transition(IDot i_dot, string m_op)
		{
			uid = i_dot.uid;
			ID = i_dot.ID;
			edgeop = m_op;
			type = i_dot.type;
			dot = i_dot;
		}
	}

}
