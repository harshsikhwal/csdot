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

		public override string ToString()
		{
			if(m_Z)
				return "\"" + X.ToString() + ", " + Y.ToString() + ", " + Z.ToString() + "\"";
			else
				return "\"" + X.ToString() + ", " + Y.ToString() + "\"";
		}

	}
}
