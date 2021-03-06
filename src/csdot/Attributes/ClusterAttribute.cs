using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class ClusterAttribute : IDotAttribute
	{
        public Dictionary<string, string> CustomAttribute = new Dictionary<string, string>();
        public Area area = new Area();
        public BGColor bgcolor = new BGColor();
        public _Class _class = new _Class();
        public Color color = new Color();
        public ColorScheme colorscheme = new ColorScheme();
        public FillColor fillcolor = new FillColor();
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
        public LP lp = new LP();
        public LWidth lwidth = new LWidth();
        public Margin margin = new Margin();
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
                attribute = attribute + area.TranslateToString();
            }
            if (bgcolor.Set)
            {
                attribute = ("" == attribute) ? attribute + bgcolor.TranslateToString() : attribute + "\n" + bgcolor.TranslateToString();
            }
            if (_class.Set)
            {
                attribute = ("" == attribute) ? attribute + _class.TranslateToString() : attribute + "\n" + _class.TranslateToString();
            }
            if (color.Set)
            {
                attribute = ("" == attribute) ? attribute + color.TranslateToString() : attribute + "\n" + color.TranslateToString();
            }
            if (colorscheme.Set)
            {
                attribute = ("" == attribute) ? attribute + colorscheme.TranslateToString() : attribute + "\n" + colorscheme.TranslateToString();
            }
            if (fillcolor.Set)
            {
                attribute = ("" == attribute) ? attribute + fillcolor.TranslateToString() : attribute + "\n" + fillcolor.TranslateToString();
            }
            if (fontcolor.Set)
            {
                attribute = ("" == attribute) ? attribute + fontcolor.TranslateToString() : attribute + "\n" + fontcolor.TranslateToString();
            }
            if (fontname.Set)
            {
                attribute = ("" == attribute) ? attribute + fontname.TranslateToString() : attribute + "\n" + fontname.TranslateToString();
            }
            if (fontsize.Set)
            {
                attribute = ("" == attribute) ? attribute + fontsize.TranslateToString() : attribute + "\n" + fontsize.TranslateToString();
            }
            if (gradientangle.Set)
            {
                attribute = ("" == attribute) ? attribute + gradientangle.TranslateToString() : attribute + "\n" + gradientangle.TranslateToString();
            }
            if (href.Set)
            {
                attribute = ("" == attribute) ? attribute + href.TranslateToString() : attribute + "\n" + href.TranslateToString();
            }
            if (id.Set)
            {
                attribute = ("" == attribute) ? attribute + id.TranslateToString() : attribute + "\n" + id.TranslateToString();
            }
            if (K.Set)
            {
                attribute = ("" == attribute) ? attribute + K.TranslateToString() : attribute + "\n" + K.TranslateToString();
            }
            if (label.Set)
            {
                attribute = ("" == attribute) ? attribute + label.TranslateToString() : attribute + "\n" + label.TranslateToString();
            }
            if (labeljust.Set)
            {
                attribute = ("" == attribute) ? attribute + labeljust.TranslateToString() : attribute + "\n" + labeljust.TranslateToString();
            }
            if (labelloc.Set)
            {
                attribute = ("" == attribute) ? attribute + labelloc.TranslateToString() : attribute + "\n" + labelloc.TranslateToString();
            }
            if (lheight.Set)
            {
                attribute = ("" == attribute) ? attribute + lheight.TranslateToString() : attribute + "\n" + lheight.TranslateToString();
            }
            if (lp.Set)
            {
                attribute = ("" == attribute) ? attribute + lp.TranslateToString() : attribute + "\n" + lp.TranslateToString();
            }
            if (lwidth.Set)
            {
                attribute = ("" == attribute) ? attribute + lwidth.TranslateToString() : attribute + "\n" + lwidth.TranslateToString();
            }
            if (margin.Set)
            {
                attribute = ("" == attribute) ? attribute + margin.TranslateToString() : attribute + "\n" + margin.TranslateToString();
            }
            if (nojustify.Set)
            {
                attribute = ("" == attribute) ? attribute + nojustify.TranslateToString() : attribute + "\n" + nojustify.TranslateToString();
            }
            if (pencolor.Set)
            {
                attribute = ("" == attribute) ? attribute + pencolor.TranslateToString() : attribute + "\n" + pencolor.TranslateToString();
            }
            if (penwidth.Set)
            {
                attribute = ("" == attribute) ? attribute + penwidth.TranslateToString() : attribute + "\n" + penwidth.TranslateToString();
            }
            if (peripheries.Set)
            {
                attribute = ("" == attribute) ? attribute + peripheries.TranslateToString() : attribute + "\n" + peripheries.TranslateToString();
            }
            if (sortv.Set)
            {
                attribute = ("" == attribute) ? attribute + sortv.TranslateToString() : attribute + "\n" + sortv.TranslateToString();
            }
            if (Target.Set)
            {
                attribute = ("" == attribute) ? attribute + Target.TranslateToString() : attribute + "\n" + Target.TranslateToString();
            }
            if (tooltip.Set)
            {
                attribute = ("" == attribute) ? attribute + tooltip.TranslateToString() : attribute + "\n" + tooltip.TranslateToString();
            }
            if (URL.Set)
            {
                attribute = ("" == attribute) ? attribute + URL.TranslateToString() : attribute + "\n" + URL.TranslateToString();
            }
            if(CustomAttribute.Count > 0)
			{
                foreach (KeyValuePair<string, string> entry in CustomAttribute)
                {
                    var attr =  entry.Key + " = \"" + entry.Value + "\""; 
                    attribute = ("" == attribute) ? attribute + attr : attribute + "\n" + attr;
                }
            }
			return attribute;
		}
	}
}