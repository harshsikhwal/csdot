﻿using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes;

namespace csdot
{
	public class Subgraph : IDot
	{
		public string type { get; set; } = "subgraph";
		public Guid uid { get; }
		public string ID { get; set; }

		private SubgraphAttribute m_attribute = new SubgraphAttribute();
		private Dictionary<Guid, IDot> m_elements = new Dictionary<Guid, IDot>();

		public SubgraphAttribute Attribute
		{
			get
			{
				return m_attribute;
			}
		}

		public Subgraph(string i_id)
		{
			ID = i_id;
			uid = Guid.NewGuid();
		}

		public Subgraph()
		{
			ID = "";
			uid = Guid.NewGuid();
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

		public string ElementToString()
		{
			//TODO: Add code to translate the IDot dictionary list and call their corresponding attribute
			// return (strict) ? "strict" + type + " " + ID + "\n{\n" + Attribute.AttributesToString() + "\n}";
			string attrStr = Attribute.AttributesToString();
			string subgraphbuilder = type + " " + ID + "\n{\n";

			if (attrStr != "")
				subgraphbuilder = subgraphbuilder + attrStr +"\n";

			foreach (var dotElement in m_elements.Values)
			{
				subgraphbuilder = subgraphbuilder + dotElement.ElementToString() + "\n";
			}
			subgraphbuilder = subgraphbuilder + "}";

			return subgraphbuilder;
		}

		public string ElementToString(int i_spacing)
		{
			// TODO: Add code to translate the IDot dictionary list and call their corresponding attribute
			// return (strict) ? "strict" + type + " " + ID + "\n{\n" + Attribute.AttributesToString() + "\n}";
			string spacing = "";
			string bspacing = "";
			if (i_spacing > 0)
			{
				spacing = new String('\t', i_spacing);
				bspacing = new String('\t', i_spacing - 1);
			}

			string attrStr = Attribute.AttributesToString();
			string subgraphbuilder = type + " " + ID + "\n" + bspacing + "{\n";

			if (attrStr != "")
				subgraphbuilder = subgraphbuilder + spacing + attrStr + "\n";

			foreach (var dotElement in m_elements.Values)
			{
				subgraphbuilder = subgraphbuilder + spacing + dotElement.ElementToString(i_spacing + 1) + "\n";
			}
			subgraphbuilder = subgraphbuilder + bspacing + "}";

			return subgraphbuilder;
		}
	}
}
