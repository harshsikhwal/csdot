using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.DataTypes;

namespace csdot.Attributes.Types
{
	public class Area : IAttribute
	{
		#region Properties

		public double Value
		{
			get; set;
		}
		#endregion

		#region Member Functions

		public double GetDefault()
		{
			return 1;
		}

		public void SetDefault()
		{
			Value = 1;
		}

		public void SetMinimum()
		{
			Value = 1;
		}

		#endregion
	}

	public class ArrowHead : IAttribute
	{
		public string Value
		{
			get;
			set;
		}

		public string GetDefault()
		{
			return ArrowType.normal;
		}

		public void SetDefault()
		{
			Value = ArrowType.normal;
		}

	}

	public class ArrowSize : IAttribute
	{
		public double Value
		{
			get; set;
		}

		public double GetDefault()
		{
			return 1.0;
		}

		public void SetDefault()
		{
			Value = 1.0;
		}

		public double GetMinimum()
		{
			return 0.0;
		}

		public void SetMinimum()
		{
			Value = 0.0;
		}


	}

	public class ArrowTail : IAttribute
	{
		public string Value
		{
			get;
			set;
		}

		public string GetDefault()
		{
			return ArrowType.normal;
		}

		public void SetDefault()
		{
			Value = ArrowType.normal;
		}

	}

	public class Background : IAttribute
	{
		public string Value
		{
			get; set;
		}
	}

	public class BoundingBox : IAttribute
	{
		public Rect Value
		{
			get;
			set;
		}
	}

	public class Label : IAttribute
	{
		public string Value
		{
			get; set;
		}

		public string GetDefault()
		{
			return "";
		}
	}
}
