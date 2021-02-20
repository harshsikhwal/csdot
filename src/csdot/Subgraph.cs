using System;
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

		public void AddElement(IDot i_dot)
		{
			m_elements.Add(i_dot.uid, i_dot);
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
			string subgraphbuilder = type + " " + ID + Attribute.AttributesToString() + "{\n";
			foreach (var dotElement in m_elements.Values)
			{
				subgraphbuilder = subgraphbuilder + dotElement.ElementToString() + "\n";
			}
			subgraphbuilder = "}";

			return subgraphbuilder;
		}

	}
}
