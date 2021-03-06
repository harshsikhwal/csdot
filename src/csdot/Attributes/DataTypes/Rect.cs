using System;
using System.Collections.Generic;
using System.Text;

namespace csdot.Attributes.DataTypes
{
	public class Rect
	{ 
		public Rect(float i_llx, float i_lly, float i_urx, float i_ury)
		{
			LLX = i_llx;
			LLY = i_lly;
			URX = i_urx;
			URY = i_ury;
		}


		public float LLX
		{
			get; set;
		}

		public float LLY
		{
			get; set;
		}

		public float URX
		{
			get; set;
		}

		public float URY
		{
			get; set;
		}


		public override string ToString()
		{
			return "\"" + LLX.ToString() + ", " + LLY.ToString() + ", " + URX.ToString() + ", " + URY.ToString() + "\"";
		}
	}
}
