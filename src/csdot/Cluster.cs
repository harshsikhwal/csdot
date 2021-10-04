using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes;

namespace csdot
{
	public class Cluster : IDot, IElement
	{
		public string type { get; set; } = "subgraph";
		public Guid uid { get; }
		public string ID { get; set; }

		private Dictionary<Guid, IDot> m_elements = new Dictionary<Guid, IDot>();
		public ClusterAttribute Attribute = new ClusterAttribute();
		private Dictionary<string, IAttribute> attributeMap = new Dictionary<string, IAttribute>();

		public Cluster(string i_id)
		{
			ID = i_id;
			uid = Guid.NewGuid();
			this.FillAttributeMap();
		}

		public Dictionary<string, IAttribute> attributes
		{
			get
			{
				return attributeMap;
			}
		}

		public void AddElement(IDot i_dot)
		{
			m_elements.Add(i_dot.uid, i_dot);
		}
		public void AddElements(params IDot[] i_dot)
		{
			foreach (var e in i_dot)
			{
				m_elements.Add(e.uid, e);
			}
		}

		public void DeleteElement(IDot i_dot)
		{
			m_elements.Remove(i_dot.uid);
		}

		public IDot GetElement(Guid i_uid)
		{
			IDot dot = m_elements[i_uid];
			return dot;
		}

		public IDot GetElementByName(string i_name, string i_elementType = "node")
		{
			foreach (var element in m_elements)
			{
				if (element.Value.ID == i_name)
				{
					if (i_elementType == "node" && null != (element.Value as Node))
						return element.Value as Node;
					if (i_elementType == "edge" && null != (element.Value as Edge))
						return element.Value as Edge;
				}
			}

			// it means we did not find any element with the specific name 
			return null;
		}

		private void FillAttributeMap()
		{
			this.attributeMap.Add("area", Attribute.area);
			this.attributeMap.Add("bgcolor", Attribute.bgcolor);
			this.attributeMap.Add("_class", Attribute._class);
			this.attributeMap.Add("color", Attribute.color);
			this.attributeMap.Add("colorscheme", Attribute.colorscheme);
			this.attributeMap.Add("fillcolor", Attribute.fillcolor);
			this.attributeMap.Add("fontcolor", Attribute.fontcolor);
			this.attributeMap.Add("fontname", Attribute.fontname);
			this.attributeMap.Add("fontsize", Attribute.fontsize);
			this.attributeMap.Add("gradientangle", Attribute.gradientangle);
			this.attributeMap.Add("href", Attribute.href);
			this.attributeMap.Add("id", Attribute.id);
			this.attributeMap.Add("K", Attribute.K);
			this.attributeMap.Add("label", Attribute.label);
			this.attributeMap.Add("labeljust", Attribute.labeljust);
			this.attributeMap.Add("labelloc", Attribute.labelloc);
			this.attributeMap.Add("lheight", Attribute.lheight);
			this.attributeMap.Add("lp", Attribute.lp);
			this.attributeMap.Add("lwidth", Attribute.lwidth);
			this.attributeMap.Add("margin", Attribute.margin);
			this.attributeMap.Add("nojustify", Attribute.nojustify);
			this.attributeMap.Add("pencolor", Attribute.pencolor);
			this.attributeMap.Add("penwidth", Attribute.penwidth);
			this.attributeMap.Add("peripheries", Attribute.peripheries);
			this.attributeMap.Add("sortv", Attribute.sortv);
			this.attributeMap.Add("Target", Attribute.Target);
			this.attributeMap.Add("tooltip", Attribute.tooltip);
			this.attributeMap.Add("URL", Attribute.URL);
		}

		public string ElementToString()
		{
			string attrStr = Attribute.AttributesToString();
			string clusterbuilder = type + " " + "cluster_" + ID + "\n{\n";

			if (attrStr != "")
				clusterbuilder = clusterbuilder + attrStr + "\n";

			foreach (var dotElement in m_elements.Values)
			{
				clusterbuilder = clusterbuilder + dotElement.ElementToString() + "\n";
			}
			clusterbuilder = clusterbuilder + "}";

			return clusterbuilder;
		}

		public string ElementToString(int i_spacing)
		{
			string spacing = "";
			string bspacing = "";
			if (i_spacing > 0)
			{
				spacing = new String('\t', i_spacing);
				bspacing = new String('\t', i_spacing - 1);
			}

			string attrStr = Attribute.AttributesToString();
			string clusterbuilder = type + " " + "cluster_" + ID + "\n" + bspacing + "{\n";

			if (attrStr != "")
				clusterbuilder = clusterbuilder + spacing + attrStr + "\n";

			foreach (var dotElement in m_elements.Values)
			{
				clusterbuilder = clusterbuilder + spacing + dotElement.ElementToString(i_spacing + 1) + "\n";
			}
			clusterbuilder = clusterbuilder + bspacing + "}";

			return clusterbuilder;
		}
	}
}
