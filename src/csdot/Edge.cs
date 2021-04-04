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

		//public Dictionary<string, IAttribute> attributeMap = new Dictionary<string, IAttribute>();

		public List<Transition> Transition
		{
			get; set;
		}

		public Edge()
		{
			uid = Guid.NewGuid();
			//this.FillAttributeMap();
		}

		public Edge(List<Transition> i_transition)
		{
			Transition = i_transition;
			uid = Guid.NewGuid();
			//this.FillAttributeMap();
		}

		public void AddTransition(Transition i_transition)
		{
			Transition.Add(i_transition);
		}

		//private void FillAttributeMap()
		//{
		//	this.attributeMap.Add("arrowhead", Attribute.arrowhead);
		//	this.attributeMap.Add("arrowsize", Attribute.arrowsize);
		//	this.attributeMap.Add("arrowtail", Attribute.arrowtail);
		//	this.attributeMap.Add("_class", Attribute._class);
		//	this.attributeMap.Add("color", Attribute.color);
		//	this.attributeMap.Add("colorscheme", Attribute.colorscheme);
		//	this.attributeMap.Add("comment", Attribute.comment);
		//	this.attributeMap.Add("constraint", Attribute.constraint);
		//	this.attributeMap.Add("decorate", Attribute.decorate);
		//	this.attributeMap.Add("dir", Attribute.dir);
		//	this.attributeMap.Add("edgehref", Attribute.edgehref);
		//	this.attributeMap.Add("edgetarget", Attribute.edgetarget);
		//	this.attributeMap.Add("edgetooltip", Attribute.edgetooltip);
		//	this.attributeMap.Add("edgeURL", Attribute.edgeURL);
		//	this.attributeMap.Add("fillcolor", Attribute.fillcolor);
		//	this.attributeMap.Add("fontcolor", Attribute.fontcolor);
		//	this.attributeMap.Add("fontname", Attribute.fontname);
		//	this.attributeMap.Add("fontsize", Attribute.fontsize);
		//	this.attributeMap.Add("head_lp", Attribute.head_lp);
		//	this.attributeMap.Add("headclip", Attribute.headclip);
		//	this.attributeMap.Add("headhref", Attribute.headhref);
		//	this.attributeMap.Add("headlabel", Attribute.headlabel);
		//	this.attributeMap.Add("headtarget", Attribute.headtarget);
		//	this.attributeMap.Add("headtooltip", Attribute.headtooltip);
		//	this.attributeMap.Add("headURL", Attribute.headURL);
		//	this.attributeMap.Add("href", Attribute.href);
		//	this.attributeMap.Add("id", Attribute.id);
		//	this.attributeMap.Add("label", Attribute.label);
		//	this.attributeMap.Add("labelangle", Attribute.labelangle);
		//	this.attributeMap.Add("labeldistance", Attribute.labeldistance);
		//	this.attributeMap.Add("labelfloat", Attribute.labelfloat);
		//	this.attributeMap.Add("labelfontcolor", Attribute.labelfontcolor);
		//	this.attributeMap.Add("labelfontname", Attribute.labelfontname);
		//	this.attributeMap.Add("labelfontsize", Attribute.labelfontsize);
		//	this.attributeMap.Add("labelhref", Attribute.labelhref);
		//	this.attributeMap.Add("labeltarget", Attribute.labeltarget);
		//	this.attributeMap.Add("labeltooltip", Attribute.labeltooltip);
		//	this.attributeMap.Add("labelURL", Attribute.labelURL);
		//	this.attributeMap.Add("len", Attribute.len);
		//	this.attributeMap.Add("lhead", Attribute.lhead);
		//	this.attributeMap.Add("lp", Attribute.lp);
		//	this.attributeMap.Add("ltail", Attribute.ltail);
		//	this.attributeMap.Add("minlen", Attribute.minlen);
		//	this.attributeMap.Add("nojustify", Attribute.nojustify);
		//	this.attributeMap.Add("penwidth", Attribute.penwidth);
		//	this.attributeMap.Add("pos", Attribute.pos);
		//	this.attributeMap.Add("shape", Attribute.shape);
		//	this.attributeMap.Add("samehead", Attribute.samehead);
		//	this.attributeMap.Add("sametail", Attribute.sametail);
		//	this.attributeMap.Add("showboxes", Attribute.showboxes);
		//	this.attributeMap.Add("tail_lp", Attribute.tail_lp);
		//	this.attributeMap.Add("tailclip", Attribute.tailclip);
		//	this.attributeMap.Add("tailhref", Attribute.tailhref);
		//	this.attributeMap.Add("taillabel", Attribute.taillabel);
		//	this.attributeMap.Add("tailtarget", Attribute.tailtarget);
		//	this.attributeMap.Add("tailtooltip", Attribute.tailtooltip);
		//	this.attributeMap.Add("tailURL", Attribute.tailURL);
		//	this.attributeMap.Add("Target", Attribute.Target);
		//	this.attributeMap.Add("tooltip", Attribute.tooltip);
		//	this.attributeMap.Add("URL", Attribute.URL);
		//	this.attributeMap.Add("weight", Attribute.weight);
		//	this.attributeMap.Add("xlabel", Attribute.xlabel);
		//	this.attributeMap.Add("xlp", Attribute.xlp);
		//}

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
