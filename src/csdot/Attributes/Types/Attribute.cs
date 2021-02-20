using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.DataTypes;

namespace csdot.Attributes.Types
{
	public class Area : IAttribute
	{
		#region Properties

		public bool Set { get; set; } = false;

		private double m_value;

		public double Value
		{
			get
			{
				return m_value;
			}
			set
			{
				Set = true;
				m_value = value;
			}
		}
		#endregion

		#region Member Functions

		public double GetDefault()
		{
			return 1;
		}

		public void SetDefault()
		{
			Set = true;
			Value = 1;
		}

		public void SetMinimum()
		{
			Set = true;
			Value = 1;
		}

		public string TranslateToString()
		{
			return "area = " + Value.ToString();
		}

		#endregion
	}

	public class ArrowHead : IAttribute
	{
		public bool Set { get; set; } = false;

		private string m_value;

		public string Value
		{
			get
			{
				return m_value;
			}
			set
			{
				Set = true;
				m_value = value;
			}
		}

		public string GetDefault()
		{
			return ArrowType.normal;
		}

		public void SetDefault()
		{
			Set = true;
			Value = ArrowType.normal;
		}
		public string TranslateToString()
		{
			return "arrowhead = \"" + Value + "\"";
		}
	}

	public class ArrowSize : IAttribute
	{
		public bool Set { get; set; } = false;

		private double m_value;

		public double Value
		{
			get
			{
				return m_value;
			}
			set
			{
				Set = true;
				m_value = value;
			}
		}

		public double GetDefault()
		{
			return 1.0;
		}

		public void SetDefault()
		{
			Set = true;
			Value = 1.0;
		}

		public double GetMinimum()
		{
			return 0.0;
		}

		public void SetMinimum()
		{
			Set = true;
			Value = 0.0;
		}

		public string TranslateToString()
		{
			return "arrowsize = " + Value.ToString();
		}

	}

	public class ArrowTail : IAttribute
	{
		public bool Set { get; set; } = false;

		private string m_value;

		public string Value
		{
			get
			{
				return m_value;
			}
			set
			{
				Set = true;
				m_value = value;
			}
		}

		public string GetDefault()
		{
			return ArrowType.normal;
		}

		public void SetDefault()
		{
			Set = true;
			Value = ArrowType.normal;
		}

		public string TranslateToString()
		{
			return "arrowtail = \"" + Value + "\"";
		}

	}

	public class Background : IAttribute
	{
		public bool Set { get; set; } = false;

		private string m_value;

		public string Value
		{
			get
			{
				return m_value;
			}
			set
			{
				Set = true;
				m_value = value;
			}
		}

		public string TranslateToString()
		{
			return "_background = " + Value;
		}
	}
	
	public class BgColor : IAttribute
	{
		public bool Set { get; set; } = false;

		private string m_value;

		public string Value
		{
			get
			{
				return m_value;
			}
			set
			{
				Set = true;
				m_value = value;
			}
		}

		public string TranslateToString()
		{
			return "bgcolor = " + Value;
		}
	}

	public class BoundingBox : IAttribute
	{
		public bool Set { get; set; } = false;

		private Rect m_value;

		public Rect Value
		{
			get
			{
				return m_value;
			}
			set
			{
				Set = true;
				m_value = value;
			}
		}

		public string TranslateToString()
		{
			return "";
		}
	}
	
	public class Center : IAttribute
	{
		public bool Set { get; set; } = false;

		private bool m_value = false;

		public bool Value
		{
			get
			{
				return m_value;

			}

			set
			{
				Set = true;
				m_value = value;
			}
		}

		public bool GetDefault()
		{
			return false;
		}

		public void SetDefault()
		{
			Set = true;
			Value = false;
		}

		public string TranslateToString()
		{
			return "center = " + Value.ToString();
		}
	}

	public class Color : IAttribute
	{
		public bool Set { get; set; } = false;

		private string m_value = "black";

		public string Value
		{
			get
			{
				return m_value;
			}
			set
			{
				Set = true;
				m_value = value;
			}
		}

		public string GetDefault()
		{
			return "black";
		}

		public void SetDefault()
		{
			Set = true;
			Value = "black";
		}

		public string TranslateToString()
		{
			return "color = " + Value;
		}
	}

	public class Epsilon : IAttribute
	{
		public bool Set { get; set; } = false;

		private double m_value;

		public double Value
		{
			get
			{
				return m_value;

			}

			set
			{
				Set = true;
				m_value = value;
			}
		}

		public double GetDefault()
		{
			return 0.001;
		}

		public void SetDefault()
		{
			Set = true;
			Value = 0.001;
		}

		public string TranslateToString()
		{
			return "epsilon = " + Value.ToString();
		}


	}

	public class FixedSize : IAttribute
	{
		public bool Set { get; set; } = false;

		private bool m_value;

		public bool Value
		{
			get
			{
				return m_value;

			}

			set
			{
				Set = true;
				m_value = value;
			}
		}

		public bool GetDefault()
		{
			return false;
		}

		public void SetDefault()
		{
			Set = true;
			Value = false;
		}

		public string TranslateToString()
		{
			return "fixedsize = " + Value.ToString();
		}
	}

	public class Fontname : IAttribute
	{
		public bool Set { get; set; } = false;

		private string m_value;

		public string Value
		{
			get
			{
				return m_value;
			}
			set
			{
				Set = true;
				m_value = value;
			}
		}

		public string GetDefault()
		{
			return "Times-Roman";
		}

		public void SetDefault()
		{
			Set = true;
			Value = "Times-Roman";
		}

		public string TranslateToString()
		{
			return "fontname = \"" + Value + "\"";
		}
	}

	public class Fontsize : IAttribute
	{
		public bool Set { get; set; } = false;

		private double m_value;

		public double Value
		{
			get
			{
				return m_value;

			}

			set
			{
				Set = true;
				m_value = value;
			}
		}

		public double GetDefault()
		{
			return 14.0;
		}

		public void SetDefault()
		{
			Set = true;
			Value = 14.0;
		}

		public double GetMinimum()
		{
			return 1.0;
		}

		public void SetMinimum()
		{
			Set = true;
			Value = 1.0;
		}

		public string TranslateToString()
		{
			return "fontsize = " + Value.ToString();
		}
	}

	public class Forcelabels : IAttribute
	{
		public bool Set { get; set; } = false;

		private bool m_value = true;

		public bool Value
		{
			get
			{
				return m_value;

			}

			set
			{
				Set = true;
				m_value = value;
			}
		}

		public bool GetDefault()
		{
			return true;
		}

		public void SetDefault()
		{
			Set = true;
			Value = true;
		}

		public string TranslateToString()
		{
			return "forcelabels = " + Value.ToString();
		}


	}

	public class Height : IAttribute
	{
		public bool Set { get; set; } = false;

		private double m_value;

		public double Value
		{
			get
			{
				return m_value;

			}

			set
			{
				Set = true;
				m_value = value;
			}
		}

		public double GetDefault()
		{
			return 0.5;
		}

		public void SetDefault()
		{
			Set = true;
			Value = 0.5;
		}

		public double GetMinimum()
		{
			return 0.02;
		}

		public void SetMinimum()
		{
			Set = true;
			Value = 0.02;
		}

		public string TranslateToString()
		{
			return "height = " + Value.ToString();
		}


	}

	public class InputScale : IAttribute
	{
		public bool Set { get; set; } = false;

		private double m_value;

		public double Value
		{
			get
			{
				return m_value;

			}

			set
			{
				Set = true;
				m_value = value;
			}
		}

		public string TranslateToString()
		{
			return "inputscale = " + Value.ToString();
		}


	}

	public class Label : IAttribute
	{
		public bool Set { get; set; } = false;

		private string m_value;

		public string Value
		{
			get
			{
				return m_value;
			}
			set
			{
				Set = true;
				m_value = value;
			}
		}

		public string GetDefault()
		{
			return "";
		}

		public string TranslateToString()
		{
			return "label = \"" + Value + "\"";
		}
	}

	public class LabelAngle : IAttribute
	{
		public bool Set { get; set; } = false;

		private double m_value;

		public double Value
		{
			get
			{
				return m_value;

			}

			set
			{
				Set = true;
				m_value = value;
			}
		}

		public double GetDefault()
		{
			return -25.0;
		}

		public void SetDefault()
		{
			Set = true;
			Value = -25.0;
		}

		public double GetMinimum()
		{
			return -180.0;
		}

		public void SetMinimum()
		{
			Set = true;
			Value = -180.0;
		}

		public string TranslateToString()
		{
			return "labelangle = " + Value.ToString();
		}


	}

	public class LabelDistance : IAttribute
	{
		public bool Set { get; set; } = false;

		private double m_value;

		public double Value
		{
			get
			{
				return m_value;

			}

			set
			{
				Set = true;
				m_value = value;
			}
		}

		public double GetDefault()
		{
			return 1;
		}

		public void SetDefault()
		{
			Set = true;
			Value = 1;
		}

		public double GetMinimum()
		{
			return 0.0;
		}

		public void SetMinimum()
		{
			Set = true;
			Value = 0.0;
		}

		public string TranslateToString()
		{
			return "labeldistance = " + Value.ToString();
		}
	}

	public class Shape : IAttribute
	{
		public bool Set { get; set; } = false;

		private string m_value;

		public string Value
		{
			get
			{
				return m_value;
			}
			set
			{
				Set = true;
				m_value = value;
			}
		}

		public string GetDefault()
		{
			return ShapeTypes.ellipse;
		}

		public void SetDefault()
		{
			Set = true;
			Value = ShapeTypes.ellipse;
		}

		public string TranslateToString()
		{
			return "shape = " + Value;
		}
	}
}
