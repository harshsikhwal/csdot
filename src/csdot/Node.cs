using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes;

namespace csdot
{
	public class Node : IDot
	{
		private NodeAttribute m_attribute = new NodeAttribute();

		public NodeAttribute Attribute
		{
			get
			{
				return m_attribute;
			}
		}



	}
}
