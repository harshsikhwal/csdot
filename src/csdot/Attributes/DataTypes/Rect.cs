using System;
using System.Collections.Generic;
using System.Text;

namespace csdot.Attributes.DataTypes
{
	public class Rect
	{
		float llx, lly, urx, ury;
		Rect(float i_llx, float i_lly, float i_urx, float i_ury)
		{
			llx = i_llx;
			lly = i_lly;
			urx = i_urx;
			ury = i_ury;
		}
	}
}
