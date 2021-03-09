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

		// better if we have a list?
		private bool subIDSet { get; set; } = false;

		private string m_subID = "";

		public string subID
		{
			get
			{
				return m_subID;
			}
			set
			{
				subIDSet = true;
				m_subID = value;
			}

		}
		public string compassPoint { get; set; } = "";

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
			string attributestr = Attribute.AttributesToString();
			if(attributestr != "")
			{
				attributestr = " [" + attributestr + " ]";
			}
			if (subIDSet)
			{
				if(compassPoint == "")
					return ID + ":" + m_subID + attributestr;
				else
					return ID + ":" + m_subID + ":" + compassPoint + attributestr;
			}
			if(compassPoint != "")
				return ID + ":" + compassPoint + attributestr;
			
			else
				return ID + attributestr;
		}

		public string ElementToString(int i_spacing)
		{
			string attributestr = Attribute.AttributesToString();
			if (attributestr != "")
				attributestr = " [" + attributestr + " ]";
			else
				attributestr = ";";
			if (subIDSet)
			{
				if (compassPoint == "")
					return ID + ":" + m_subID + attributestr;
				else
					return ID + ":" + m_subID + ":" + compassPoint + attributestr;
			}
			if (compassPoint != "")
				return ID + ":" + compassPoint + attributestr;

			else
				return ID + attributestr;
		}
	}
}
