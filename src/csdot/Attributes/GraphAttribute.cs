using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class GraphAttribute
	{
		Dictionary<string, IAttribute> AttributeMap = new Dictionary<string, IAttribute>();
		Background _background;
		BoundingBox bb;
		// BackgroundColor bgcolor;
		public ColorScheme colorscheme = new ColorScheme();
		// Charset charset;
		public Label label = new Label();
		// List<IA>

		public void RemoveAttribute()
		{

		}


	}
}
