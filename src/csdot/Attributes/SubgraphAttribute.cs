
using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class SubgraphAttribute : IDotAttribute
	{
        public Rank rank = new Rank();

		public string AttributesToString()
		{
			string attribute = "";
            if (rank.Set)
            {
                attribute = attribute + " " + rank.TranslateToString();
            }
			return attribute;
		}
	}
}