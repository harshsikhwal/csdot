using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class NodeAttribute
	{
		public Area area;
		public ColorScheme colorscheme = new ColorScheme();
		public Label label;


		// Add Attribute

		public bool AddAttribute()
		{
			return true;
		}

		// Delete Attribute

		public bool DeleteAttribute()
		{
			return true;
		}


	}
}
