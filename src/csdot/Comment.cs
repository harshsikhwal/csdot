using System;
using System.Collections.Generic;
using System.Text;

namespace csdot
{
	public class Comment : IDot
	{
		public string type { get; set; } = "comment";
		public Guid uid { get; }
		public string ID { get; set; }

		public string ElementToString()
		{
			return "";
		}

		public string ElementToString(int i_spacing)
		{
			return "";
		}
	}
}
