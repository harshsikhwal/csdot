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

		public static bool TryParse(string i_value, out Rect result)
		{
			string[] points = i_value.Split();
			result = null;
			if (points.Length != 4)
				return false;
			else
			{
				bool llx = float.TryParse(points[0], out float o_llx);
				bool lly = float.TryParse(points[1], out float o_lly);
				bool urx = float.TryParse(points[2], out float o_urx);
				bool ury = float.TryParse(points[3], out float o_ury);
				if (llx && lly && urx && ury)
					result = new Rect(o_llx, o_lly, o_urx, o_ury);
				else
					return false;
			}
			return true;
		}
	}
}
