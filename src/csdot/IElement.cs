using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes;

namespace csdot
{
	public interface IElement: IDot
	{
		public void AddElement(IDot i_dot);

		public IDot GetElementByName(string i_name, string i_elementType = "node");
	}
}
