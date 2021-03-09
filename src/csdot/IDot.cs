using System;
using System.Collections.Generic;
using System.Text;

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

		public string ElementToString();

		public string ElementToString(int i_spacing);
	}
}
