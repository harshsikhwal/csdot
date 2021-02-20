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
		// public ColorScheme colorscheme = new ColorScheme();
		// Charset charset;
		public Epsilon epsilon = new Epsilon();
		public Fontname fontname = new Fontname();
		public Fontsize fontsize = new Fontsize();
		public Forcelabels forcelabels = new Forcelabels();
		public InputScale inputscale = new InputScale(); 
		public Label label = new Label();

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
			if (inputscale.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + inputscale.TranslateToString() : attribute + ", " + inputscale.TranslateToString();
			}
			if (label.Set)
			{
				attribute = ("" == attribute) ? attribute + " " + label.TranslateToString() : attribute + ", " + label.TranslateToString();
			}
			return attribute;
		}
	}
}
