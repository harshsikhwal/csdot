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

		public Comment(string i_id)
		{
			ID = i_id;
		}

		public string ElementToString()
		{
			// TODO: check for multiline and add the same?
			return ID;
		}

		public string ElementToString(int i_spacing)
		{
			// TODO: how to know where is this present? Like on the same line or next line?
			return ID;
		}
	}
}
