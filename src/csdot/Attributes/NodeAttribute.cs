using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class NodeAttribute : IDotAttribute
	{
        public Dictionary<string, string> CustomAttribute = new Dictionary<string, string>();
        public Area area = new Area();
        public _Class _class = new _Class();
        public Color color = new Color();
        public ColorScheme colorscheme = new ColorScheme();
        public _Comment comment = new _Comment();
        public Distortion distortion = new Distortion();
        public FillColor fillcolor = new FillColor();
        public FixedSize fixedsize = new FixedSize();
        public FontColor fontcolor = new FontColor();
        public Fontname fontname = new Fontname();
        public Fontsize fontsize = new Fontsize();
        public GradientAngle gradientangle = new GradientAngle();
        public Group group = new Group();
        public Height height = new Height();
        public Href href = new Href();
        public ID id = new ID();
        public Image image = new Image();
        public ImagePos imagepos = new ImagePos();
        public ImageScale imagescale = new ImageScale();
        public Label label = new Label();
        public LabelLoc labelloc = new LabelLoc();
        public Margin margin = new Margin();
        public NoJustify nojustify = new NoJustify();
        public Ordering ordering = new Ordering();
        public PenWidth penwidth = new PenWidth();
        public Peripheries peripheries = new Peripheries();
        public Pin pin = new Pin();
        public Pos pos = new Pos();
        public Rects rects = new Rects();
        public Regular regular = new Regular();
        public Root root = new Root();
        public SamplePoints samplepoints = new SamplePoints();
        public Shape shape = new Shape();
        public ShapeFile shapefile = new ShapeFile();
        public ShowBoxes showboxes = new ShowBoxes();
        public Sides sides = new Sides();
        public Skew skew = new Skew();
        public Sortv sortv = new Sortv();
        public Target Target = new Target();
        public ToolTip tooltip = new ToolTip();
        public url URL = new url();
        public Width width = new Width();
        public XLabel xlabel = new XLabel();
        public XLP xlp = new XLP();
        public Z z = new Z();

		public string AttributesToString()
		{
			string attribute = "";
            if (area.Set)
            {
                attribute = attribute + " " + area.TranslateToString();
            }
            if (_class.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + _class.TranslateToString() : attribute + ", " + _class.TranslateToString();
            }
            if (color.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + color.TranslateToString() : attribute + ", " + color.TranslateToString();
            }
            if (colorscheme.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + colorscheme.TranslateToString() : attribute + ", " + colorscheme.TranslateToString();
            }
            if (comment.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + comment.TranslateToString() : attribute + ", " + comment.TranslateToString();
            }
            if (distortion.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + distortion.TranslateToString() : attribute + ", " + distortion.TranslateToString();
            }
            if (fillcolor.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + fillcolor.TranslateToString() : attribute + ", " + fillcolor.TranslateToString();
            }
            if (fixedsize.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + fixedsize.TranslateToString() : attribute + ", " + fixedsize.TranslateToString();
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
            if (group.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + group.TranslateToString() : attribute + ", " + group.TranslateToString();
            }
            if (height.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + height.TranslateToString() : attribute + ", " + height.TranslateToString();
            }
            if (href.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + href.TranslateToString() : attribute + ", " + href.TranslateToString();
            }
            if (id.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + id.TranslateToString() : attribute + ", " + id.TranslateToString();
            }
            if (image.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + image.TranslateToString() : attribute + ", " + image.TranslateToString();
            }
            if (imagepos.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + imagepos.TranslateToString() : attribute + ", " + imagepos.TranslateToString();
            }
            if (imagescale.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + imagescale.TranslateToString() : attribute + ", " + imagescale.TranslateToString();
            }
            if (label.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + label.TranslateToString() : attribute + ", " + label.TranslateToString();
            }
            if (labelloc.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + labelloc.TranslateToString() : attribute + ", " + labelloc.TranslateToString();
            }
            if (margin.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + margin.TranslateToString() : attribute + ", " + margin.TranslateToString();
            }
            if (nojustify.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + nojustify.TranslateToString() : attribute + ", " + nojustify.TranslateToString();
            }
            if (ordering.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + ordering.TranslateToString() : attribute + ", " + ordering.TranslateToString();
            }
            if (penwidth.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + penwidth.TranslateToString() : attribute + ", " + penwidth.TranslateToString();
            }
            if (peripheries.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + peripheries.TranslateToString() : attribute + ", " + peripheries.TranslateToString();
            }
            if (pin.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + pin.TranslateToString() : attribute + ", " + pin.TranslateToString();
            }
            if (pos.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + pos.TranslateToString() : attribute + ", " + pos.TranslateToString();
            }
            if (rects.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + rects.TranslateToString() : attribute + ", " + rects.TranslateToString();
            }
            if (regular.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + regular.TranslateToString() : attribute + ", " + regular.TranslateToString();
            }
            if (root.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + root.TranslateToString() : attribute + ", " + root.TranslateToString();
            }
            if (samplepoints.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + samplepoints.TranslateToString() : attribute + ", " + samplepoints.TranslateToString();
            }
            if (shape.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + shape.TranslateToString() : attribute + ", " + shape.TranslateToString();
            }
            if (shapefile.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + shapefile.TranslateToString() : attribute + ", " + shapefile.TranslateToString();
            }
            if (showboxes.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + showboxes.TranslateToString() : attribute + ", " + showboxes.TranslateToString();
            }
            if (sides.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + sides.TranslateToString() : attribute + ", " + sides.TranslateToString();
            }
            if (skew.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + skew.TranslateToString() : attribute + ", " + skew.TranslateToString();
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
            if (width.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + width.TranslateToString() : attribute + ", " + width.TranslateToString();
            }
            if (xlabel.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + xlabel.TranslateToString() : attribute + ", " + xlabel.TranslateToString();
            }
            if (xlp.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + xlp.TranslateToString() : attribute + ", " + xlp.TranslateToString();
            }
            if (z.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + z.TranslateToString() : attribute + ", " + z.TranslateToString();
            }
            if(CustomAttribute.Count > 0)
			{
                foreach (KeyValuePair<string, string> entry in CustomAttribute)
                {
                    var attr =  entry.Key + " = \"" + entry.Value + "\"";
                    attribute = ("" == attribute) ? attribute + " " + attr : attribute + ", " + attr;
                }
            }
			return attribute;
		}
	}
}