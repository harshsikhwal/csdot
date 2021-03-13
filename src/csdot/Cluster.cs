using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes;

namespace csdot
{
	public class Cluster : IDot
	{
		public string type { get; set; } = "subgraph";
		public Guid uid { get; }
		public string ID { get; set; }

		private Dictionary<Guid, IDot> m_elements = new Dictionary<Guid, IDot>();
		public ClusterAttribute Attribute = new ClusterAttribute();

		public Cluster(string i_id)
		{
			ID = i_id;
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
			string attrStr = Attribute.AttributesToString();
			string clusterbuilder = type + " " + ID + "\n{\n";

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
			string clusterbuilder = type + " " + ID + "\n" + bspacing + "{\n";

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
