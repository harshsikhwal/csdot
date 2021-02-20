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
				attribute = (null == attribute) ? attribute + " " + arrowsize.TranslateToString() : attribute + ", " + arrowsize.TranslateToString();
			}
			return attribute;
		}

	}
}
