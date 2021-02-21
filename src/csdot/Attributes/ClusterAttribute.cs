
using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class ClusterAttribute : IDotAttribute
	{
        public Area area = new Area();
        public Color color = new Color();
        public ColorScheme colorscheme = new ColorScheme();
        public FontColor fontcolor = new FontColor();
        public Fontname fontname = new Fontname();
        public Fontsize fontsize = new Fontsize();
        public GradientAngle gradientangle = new GradientAngle();
        public Href href = new Href();
        public ID id = new ID();
        public k K = new k();
        public Label label = new Label();
        public LabelJust labeljust = new LabelJust();
        public LabelLoc labelloc = new LabelLoc();
        public LHeight lheight = new LHeight();
        public LWidth lwidth = new LWidth();
        public NoJustify nojustify = new NoJustify();
        public PenColor pencolor = new PenColor();
        public PenWidth penwidth = new PenWidth();
        public Peripheries peripheries = new Peripheries();
        public Sortv sortv = new Sortv();
        public Target Target = new Target();
        public ToolTip tooltip = new ToolTip();
        public url URL = new url();

		public string AttributesToString()
		{
			string attribute = "";
            if (area.Set)
            {
                attribute = attribute + " " + area.TranslateToString();
            }
            if (color.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + color.TranslateToString() : attribute + ", " + color.TranslateToString();
            }
            if (colorscheme.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + colorscheme.TranslateToString() : attribute + ", " + colorscheme.TranslateToString();
            }
            if (fontcolor.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + fontcolor.TranslateToString() : attribute + ", " + fontcolor.TranslateToString();
            }
            if (fontname.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + fontname.TranslateToString() : attribute + ", " + fontname.TranslateToString();
            }
            if (fontsize.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + fontsize.TranslateToString() : attribute + ", " + fontsize.TranslateToString();
            }
            if (gradientangle.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + gradientangle.TranslateToString() : attribute + ", " + gradientangle.TranslateToString();
            }
            if (href.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + href.TranslateToString() : attribute + ", " + href.TranslateToString();
            }
            if (id.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + id.TranslateToString() : attribute + ", " + id.TranslateToString();
            }
            if (K.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + K.TranslateToString() : attribute + ", " + K.TranslateToString();
            }
            if (label.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + label.TranslateToString() : attribute + ", " + label.TranslateToString();
            }
            if (labeljust.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + labeljust.TranslateToString() : attribute + ", " + labeljust.TranslateToString();
            }
            if (labelloc.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + labelloc.TranslateToString() : attribute + ", " + labelloc.TranslateToString();
            }
            if (lheight.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + lheight.TranslateToString() : attribute + ", " + lheight.TranslateToString();
            }
            if (lwidth.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + lwidth.TranslateToString() : attribute + ", " + lwidth.TranslateToString();
            }
            if (nojustify.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + nojustify.TranslateToString() : attribute + ", " + nojustify.TranslateToString();
            }
            if (pencolor.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + pencolor.TranslateToString() : attribute + ", " + pencolor.TranslateToString();
            }
            if (penwidth.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + penwidth.TranslateToString() : attribute + ", " + penwidth.TranslateToString();
            }
            if (peripheries.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + peripheries.TranslateToString() : attribute + ", " + peripheries.TranslateToString();
            }
            if (sortv.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + sortv.TranslateToString() : attribute + ", " + sortv.TranslateToString();
            }
            if (Target.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + Target.TranslateToString() : attribute + ", " + Target.TranslateToString();
            }
            if (tooltip.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + tooltip.TranslateToString() : attribute + ", " + tooltip.TranslateToString();
            }
            if (URL.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + URL.TranslateToString() : attribute + ", " + URL.TranslateToString();
            }
			return attribute;
		}
	}
}