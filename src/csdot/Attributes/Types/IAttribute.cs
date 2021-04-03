using System;
using System.Collections.Generic;
using System.Text;

namespace csdot.Attributes
{
	public interface IAttribute
	{
		public bool Set { get; set; }
		public string TranslateToString();

		public void TranslateToValue(string i_value);
	}
}
