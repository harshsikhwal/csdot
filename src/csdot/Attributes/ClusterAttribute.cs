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
				attribute = (null == attribute) ? attribute + " " + color.TranslateToString() : attribute + ", " + color.TranslateToString();
			}
			return attribute;
		}
	}
}
