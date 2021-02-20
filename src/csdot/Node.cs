using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes;

namespace csdot
{
	public class Node : IDot
	{
		public string type { get; set; } = "node";
		public Guid uid { get;  }
		public string ID { get; set; }

		private NodeAttribute m_attribute = new NodeAttribute();

		public NodeAttribute Attribute
		{
			get
			{
				return m_attribute;
			}
		}

		public Node(string i_id)
		{
			ID = i_id;
			uid = Guid.NewGuid();
		}

		public string ElementToString()
		{
			return ID + " [" + Attribute.AttributesToString() + "]";
		}
	}
}
