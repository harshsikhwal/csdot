using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class ClusterAttribute : IDotAttribute
	{
		public Area area = new Area();
		public BgColor bgcolor = new BgColor();
		public Color color = new Color();
		public Fontname fontname = new Fontname();
		public Fontsize fontsize = new Fontsize();
		public Label label = new Label();

		public string AttributesToString()
		{
			string attribute = "";
			if (area.Set)
			{
				attribute = attribute + " " + area.TranslateToString();
			}
			if (bgcolor.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + bgcolor.TranslateToString() : attribute + ", " + bgcolor.TranslateToString();
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
