using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class GraphAttribute : IDotAttribute
	{

		public Background _background = new Background();
		public BoundingBox bb = new BoundingBox();
		public BgColor bgcolor = new BgColor();
		public Center center = new Center();
		public Compound compound = new Compound();
		public Concentrate concentrate = new Concentrate();
		public Constraint constraint = new Constraint();
		public Epsilon epsilon = new Epsilon();
		public Fontname fontname = new Fontname();
		public Fontsize fontsize = new Fontsize();
		public Forcelabels forcelabels = new Forcelabels();
		public ImagePath imagepath = new ImagePath();
		public InputScale inputscale = new InputScale(); 
		public Label label = new Label();
		public LabelScheme label_scheme = new LabelScheme();
		public Landscape landscape = new Landscape();
		public Levels levels = new Levels();
		public ShowBoxes showboxes = new ShowBoxes();
		public Rotate rotate = new Rotate();
		public Rotation rotation = new Rotation();
		public string AttributesToString()
		{
			string attribute = "";
			if (_background.Set)
			{
				attribute = attribute + " " + _background.TranslateToString();
			}
			if (bb.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + bb.TranslateToString() : attribute + ", " + bb.TranslateToString();
			}
			if (bgcolor.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + bgcolor.TranslateToString() : attribute + ", " + bgcolor.TranslateToString();
			}
			if (compound.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + compound.TranslateToString() : attribute + ", " + compound.TranslateToString();
			}
			if (concentrate.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + concentrate.TranslateToString() : attribute + ", " + concentrate.TranslateToString();
			}
			if (constraint.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + constraint.TranslateToString() : attribute + ", " + constraint.TranslateToString();
			}
			if (epsilon.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + epsilon.TranslateToString() : attribute + ", " + epsilon.TranslateToString();
			}
			if (fontname.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + fontname.TranslateToString() : attribute + ", " + fontname.TranslateToString();
			}
			if (fontsize.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + fontsize.TranslateToString() : attribute + ", " + fontsize.TranslateToString();
			}
			if (forcelabels.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + forcelabels.TranslateToString() : attribute + ", " + forcelabels.TranslateToString();
			}
			if (imagepath.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + imagepath.TranslateToString() : attribute + ", " + imagepath.TranslateToString();
			}
			if (inputscale.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + inputscale.TranslateToString() : attribute + ", " + inputscale.TranslateToString();
			}
			if (label.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + label.TranslateToString() : attribute + ", " + label.TranslateToString();
			}
			if (label_scheme.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + label_scheme.TranslateToString() : attribute + ", " + label_scheme.TranslateToString();
			}
			if (landscape.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + landscape.TranslateToString() : attribute + ", " + landscape.TranslateToString();
			}
			if (levels.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + levels.TranslateToString() : attribute + ", " + levels.TranslateToString();
			}
			if (showboxes.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + showboxes.TranslateToString() : attribute + ", " + showboxes.TranslateToString();
			}
			if (rotate.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + rotate.TranslateToString() : attribute + ", " + rotate.TranslateToString();
			}
			if (rotation.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + rotation.TranslateToString() : attribute + ", " + rotation.TranslateToString();
			}
			return attribute;
		}
	}
}
