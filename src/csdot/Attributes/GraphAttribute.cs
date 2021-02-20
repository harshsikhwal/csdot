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
				attribute = (null == attribute) ? attribute + " " + bb.TranslateToString() : attribute + ", " + bb.TranslateToString();
			}
			return attribute;
		}
	}
}
