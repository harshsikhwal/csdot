using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class EdgeAttribute : IDotAttribute
	{
		public Area area = new Area();
		public ArrowSize arrowsize = new ArrowSize();
		public ArrowHead arrowHead = new ArrowHead();
		public ArrowTail arrowTail = new ArrowTail();
		public Color color = new Color();
		// ColorScheme colorscheme;
		public Fontname fontname = new Fontname();
		public Fontsize fontsize = new Fontsize();
		public Label label = new Label();
		public LabelAngle labelangle = new LabelAngle();
		public LabelDistance labeldistance = new LabelDistance();

		public string AttributesToString()
		{
			string attribute = "";
			if (area.Set)
			{
				attribute = attribute + " " + area.TranslateToString();
			}
			if (arrowsize.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + arrowsize.TranslateToString() : attribute + ", " + arrowsize.TranslateToString();
			}
			if (arrowHead.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + arrowHead.TranslateToString() : attribute + ", " + arrowHead.TranslateToString();
			}
			if (arrowTail.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + arrowTail.TranslateToString() : attribute + ", " + arrowTail.TranslateToString();
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
			if (labelangle.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + labelangle.TranslateToString() : attribute + ", " + labelangle.TranslateToString();
			}
			if (labeldistance.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + labeldistance.TranslateToString() : attribute + ", " + labeldistance.TranslateToString();
			}
			return attribute;
		}

	}
}
