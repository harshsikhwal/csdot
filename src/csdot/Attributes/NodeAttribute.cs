using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class NodeAttribute : IDotAttribute
	{
		public Area area = new Area();
		public Color color = new Color();
		// public ColorScheme colorscheme = new ColorScheme();
		public FixedSize fixedSize = new FixedSize();
		public Fontname fontname = new Fontname();
		public Fontsize fontsize = new Fontsize();
		public Height height = new Height();
		public Label label = new Label();
		public Shape shape = new Shape();

		public string AttributesToString()
		{
			string attribute = "";
			if(area.Set)
			{
				attribute = attribute + " " + area.TranslateToString();
			}
			if (color.Set)
			{
				attribute = (null == attribute) ? attribute + " " + color.TranslateToString() : attribute + ", " + color.TranslateToString();
			}
			if (fixedSize.Set)
			{
				attribute = (null == attribute) ? attribute + " " + fixedSize.TranslateToString() : attribute + ", " + fixedSize.TranslateToString();
			}
			if (fontname.Set)
			{
				attribute = (null == attribute) ? attribute + " " + fontname.TranslateToString() : attribute + ", " + fontname.TranslateToString();
			}
			if (fontsize.Set)
			{
				attribute = (null == attribute) ? attribute + " " + fontsize.TranslateToString() : attribute + ", " + fontsize.TranslateToString();
			}
			if (height.Set)
			{
				attribute = (null == attribute) ? attribute + " " + height.TranslateToString() : attribute + ", " + height.TranslateToString();
			}
			if (label.Set)
			{
				attribute = (null == attribute) ? attribute + " " + label.TranslateToString() : attribute + ", " + label.TranslateToString();
			}
			if (shape.Set)
			{
				attribute = (null == attribute) ? attribute + " " + shape.TranslateToString() : attribute + ", " + shape.TranslateToString();
			}
			return attribute;
		}

	}
}
