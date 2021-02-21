using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class EdgeAttribute : IDotAttribute
	{
		public Area area = new Area();
		public ArrowHead arrowhead = new ArrowHead();
		public ArrowSize arrowsize = new ArrowSize();
		public ArrowTail arrowtail = new ArrowTail();
		public Color color = new Color();
		public Fontname fontname = new Fontname();
		public Fontsize fontsize = new Fontsize();
		public HeadClip headclip = new HeadClip();
		public Label label = new Label();
		public LabelAngle labelangle = new LabelAngle();
		public LabelDistance labeldistance = new LabelDistance();
		public LabelFloat labelfloat = new LabelFloat();
		public LabelFontColor labelfontcolor = new LabelFontColor();
		public LabelFontName labelfontname = new LabelFontName();
		public LabelFontSize labelfontsize = new LabelFontSize();
		public ShowBoxes showboxes = new ShowBoxes();
		public TailClip tailclip = new TailClip();

		public string AttributesToString()
		{
			string attribute = "";
			if (area.Set)
			{
				attribute = attribute + " " + area.TranslateToString();
			}
			if (arrowhead.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + arrowhead.TranslateToString() : attribute + ", " + arrowhead.TranslateToString();
			}
			if (arrowsize.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + arrowsize.TranslateToString() : attribute + ", " + arrowsize.TranslateToString();
			}
			if (arrowtail.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + arrowtail.TranslateToString() : attribute + ", " + arrowtail.TranslateToString();
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
			if (headclip.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + headclip.TranslateToString() : attribute + ", " + headclip.TranslateToString();
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
			if (labelfloat.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + labelfloat.TranslateToString() : attribute + ", " + labelfloat.TranslateToString();
			}
			if (labelfontcolor.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + labelfontcolor.TranslateToString() : attribute + ", " + labelfontcolor.TranslateToString();
			}
			if (labelfontname.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + labelfontname.TranslateToString() : attribute + ", " + labelfontname.TranslateToString();
			}
			if (labelfontsize.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + labelfontsize.TranslateToString() : attribute + ", " + labelfontsize.TranslateToString();
			}
			if (showboxes.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + showboxes.TranslateToString() : attribute + ", " + showboxes.TranslateToString();
			}
			if (tailclip.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + tailclip.TranslateToString() : attribute + ", " + tailclip.TranslateToString();
			}
			return attribute;
		}

	}
}
