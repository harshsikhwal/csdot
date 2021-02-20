using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class ClusterAttribute : IDotAttribute
	{
		public BgColor bgcolor = new BgColor();
		public Color color = new Color();
		
		// ColorScheme colorscheme = new ColorScheme();
		public Fontname fontname = new Fontname();
		public Fontsize fontsize = new Fontsize();
		public Label label = new Label();

		public string AttributesToString()
		{
			string attribute = "";
			if (bgcolor.Set)
			{
				attribute = attribute + " " + bgcolor.TranslateToString();
			}
			if (color.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + color.TranslateToString() : attribute + ", " + color.TranslateToString();
			}
			if (fontname.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + fontname.TranslateToString() : attribute + ", " + fontname.TranslateToString();
			}
			if (fontsize.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + fontsize.TranslateToString() : attribute + ", " + fontsize.TranslateToString();
			}
			if (label.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + label.TranslateToString() : attribute + ", " + label.TranslateToString();
			}
			return attribute;
		}
	}
}
