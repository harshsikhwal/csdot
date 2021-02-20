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

		private EdgeAttribute m_attribute = new EdgeAttribute();

		public EdgeAttribute Attribute
		{
			get
			{
				return m_attribute;
			}
		}

		public Edge(string i_id)
		{
			ID = i_id;
			uid = new Guid();
		}

		public string ElementToString()
		{
			// TODO: ID TO ID code here
			return Attribute.AttributesToString();
		}
	}
}
