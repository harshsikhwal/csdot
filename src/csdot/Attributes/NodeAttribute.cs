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
		public FixedSize fixedSize = new FixedSize();
		public Fontname fontname = new Fontname();
		public Fontsize fontsize = new Fontsize();
		public Group group = new Group();
		public Height height = new Height();
		public Image image = new Image();
		public ImagePos imagepos = new ImagePos();
		public Label label = new Label();
		public Shape shape = new Shape();
		public ShowBoxes showboxes = new ShowBoxes();
		public Sides sides = new Sides();
		public string AttributesToString()
		{
			string attribute = "";
			if(area.Set)
			{
				attribute = attribute + " " + area.TranslateToString();
			}
			if (color.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + color.TranslateToString() : attribute + ", " + color.TranslateToString();
			}
			if (fixedSize.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + fixedSize.TranslateToString() : attribute + ", " + fixedSize.TranslateToString();
			}
			if (fontname.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + fontname.TranslateToString() : attribute + ", " + fontname.TranslateToString();
			}
			if (fontsize.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + fontsize.TranslateToString() : attribute + ", " + fontsize.TranslateToString();
			}
			if (group.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + group.TranslateToString() : attribute + ", " + group.TranslateToString();
			}
			if (height.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + height.TranslateToString() : attribute + ", " + height.TranslateToString();
			}
			if (image.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + image.TranslateToString() : attribute + ", " + image.TranslateToString();
			}
			if (imagepos.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + imagepos.TranslateToString() : attribute + ", " + imagepos.TranslateToString();
			}
			if (label.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + label.TranslateToString() : attribute + ", " + label.TranslateToString();
			}
			if (shape.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + shape.TranslateToString() : attribute + ", " + shape.TranslateToString();
			}
			if (showboxes.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + showboxes.TranslateToString() : attribute + ", " + showboxes.TranslateToString();
			}
			if (sides.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + sides.TranslateToString() : attribute + ", " + sides.TranslateToString();
			}
			return attribute;
		}

	}
}
