using System;
using System.Collections.Generic;
using System.Text;

namespace csdot.Attributes.DataTypes
{
	public class point
	{
		private bool m_Z = false;
		private float m_ZVal;
		public point(float i_x, float i_y)
		{
			X = i_x;
			Y = i_y;
		}

		public point(float i_x, float i_y, float i_z)
		{
			X = i_x;
			Y = i_y;
			Z = i_z;
		}
		public float X
		{
			get; set;
		}

		public float Y
		{
			get; set;
		}

		public float Z
		{
			get
			{
				return m_ZVal;
			}
			set
			{
				m_Z = true;
				m_ZVal = value;
			}
		}

		public static bool TryParse(string i_value, out point result)
        {
			string[] points = i_value.Split();
			result = null;
			if (points.Length < 1 || points.Length > 3)
				return false;
			else if (points.Length == 2)
            {
				bool x = float.TryParse(points[0], out float o_x);
				bool y = float.TryParse(points[1], out float o_y);
				if (x && y)
					result = new point(o_x, o_y);
				else
					return false;
            }
            else
            {
				bool x = float.TryParse(points[0], out float o_x);
				bool y = float.TryParse(points[1], out float o_y);
				bool z = float.TryParse(points[1], out float o_z);
				if (x && y && z)
					result = new point(o_x, o_y, o_z);
				else
					return false;
			}
			return true;
        }


		public override string ToString()
		{
			if(m_Z)
				return "\"" + X.ToString() + ", " + Y.ToString() + ", " + Z.ToString() + "\"";
			else
				return "\"" + X.ToString() + ", " + Y.ToString() + "\"";
		}

	}
}
