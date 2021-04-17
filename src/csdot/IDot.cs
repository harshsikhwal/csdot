using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes;

namespace csdot
{
	public interface IDot
	{
		public string type { get; set; }
		public Guid uid { get; }

		public string ID
		{
			get;
			set;
		}
		
		public Dictionary<string, IAttribute> attributes { get; }

		public string ElementToString();

		public string ElementToString(int i_spacing);
	}
}
