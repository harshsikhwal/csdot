using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes;

namespace csdot
{
	public class Cluster : IDot
	{
		public string type { get; set; } = "cluster";
		public Guid uid { get; }
		public string ID { get; set; }

		private ClusterAttribute m_attribute = new ClusterAttribute();

		public ClusterAttribute Attribute
		{
			get
			{
				return m_attribute;
			}
		}

		public Cluster(string i_id)
		{
			ID = i_id;
			uid = Guid.NewGuid();
		}

		public string ElementToString()
		{
			// Add code for cluster
			return "";
		}
	}
}
