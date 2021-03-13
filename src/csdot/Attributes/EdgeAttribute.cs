using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
    public class EdgeAttribute : IDotAttribute
	{
        public ArrowHead arrowhead = new ArrowHead();
        public ArrowSize arrowsize = new ArrowSize();
        public ArrowTail arrowtail = new ArrowTail();
        public _Class _class = new _Class();
        public Color color = new Color();
        public ColorScheme colorscheme = new ColorScheme();
        public _Comment comment = new _Comment();
        public Constraint constraint = new Constraint();
        public Decorate decorate = new Decorate();
        public Dir dir = new Dir();
        public Edgehref edgehref = new Edgehref();
        public EdgeTarget edgetarget = new EdgeTarget();
        public EdgeToolTip edgetooltip = new EdgeToolTip();
        public EdgeURL edgeURL = new EdgeURL();
        public FillColor fillcolor = new FillColor();
        public FontColor fontcolor = new FontColor();
        public Fontname fontname = new Fontname();
        public Fontsize fontsize = new Fontsize();
        public HeadLP head_lp = new HeadLP();
        public HeadClip headclip = new HeadClip();
        public HeadHref headhref = new HeadHref();
        public HeadLabel headlabel = new HeadLabel();
        public HeadTarget headtarget = new HeadTarget();
        public HeadToolTip headtooltip = new HeadToolTip();
        public HeadURL headURL = new HeadURL();
        public Href href = new Href();
        public ID id = new ID();
        public Label label = new Label();
        public LabelAngle labelangle = new LabelAngle();
        public LabelDistance labeldistance = new LabelDistance();
        public LabelFloat labelfloat = new LabelFloat();
        public LabelFontColor labelfontcolor = new LabelFontColor();
        public LabelFontname labelfontname = new LabelFontname();
        public LabelFontsize labelfontsize = new LabelFontsize();
        public LabelHref labelhref = new LabelHref();
        public LabelTarget labeltarget = new LabelTarget();
        public LabelToolTip labeltooltip = new LabelToolTip();
        public LabelURL labelURL = new LabelURL();
        public Len len = new Len();
        public LHead lhead = new LHead();
        public LP lp = new LP();
        public LTail ltail = new LTail();
        public MinLen minlen = new MinLen();
        public NoJustify nojustify = new NoJustify();
        public PenWidth penwidth = new PenWidth();
        public Pos pos = new Pos();
        public SameHead samehead = new SameHead();
        public SameTail sametail = new SameTail();
        public ShowBoxes showboxes = new ShowBoxes();
        public TailLP tail_lp = new TailLP();
        public TailClip tailclip = new TailClip();
        public Tailhref tailhref = new Tailhref();
        public TailLabel taillabel = new TailLabel();
        public TailTarget tailtarget = new TailTarget();
        public TailToolTip tailtooltip = new TailToolTip();
        public TailURL tailURL = new TailURL();
        public Target Target = new Target();
        public ToolTip tooltip = new ToolTip();
        public url URL = new url();
        public Weight weight = new Weight();
        public XLabel xlabel = new XLabel();
        public XLP xlp = new XLP();

		public string AttributesToString()
		{
			string attribute = "";
            if (arrowhead.Set)
            {
                attribute = attribute + " " + arrowhead.TranslateToString();
            }
            if (arrowsize.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + arrowsize.TranslateToString() : attribute + ", " + arrowsize.TranslateToString();
            }
            if (arrowtail.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + arrowtail.TranslateToString() : attribute + ", " + arrowtail.TranslateToString();
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
            if (constraint.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + constraint.TranslateToString() : attribute + ", " + constraint.TranslateToString();
            }
            if (decorate.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + decorate.TranslateToString() : attribute + ", " + decorate.TranslateToString();
            }
            if (dir.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + dir.TranslateToString() : attribute + ", " + dir.TranslateToString();
            }
            if (edgehref.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + edgehref.TranslateToString() : attribute + ", " + edgehref.TranslateToString();
            }
            if (edgetarget.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + edgetarget.TranslateToString() : attribute + ", " + edgetarget.TranslateToString();
            }
            if (edgetooltip.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + edgetooltip.TranslateToString() : attribute + ", " + edgetooltip.TranslateToString();
            }
            if (edgeURL.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + edgeURL.TranslateToString() : attribute + ", " + edgeURL.TranslateToString();
            }
            if (fillcolor.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + fillcolor.TranslateToString() : attribute + ", " + fillcolor.TranslateToString();
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
            if (head_lp.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + head_lp.TranslateToString() : attribute + ", " + head_lp.TranslateToString();
            }
            if (headclip.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + headclip.TranslateToString() : attribute + ", " + headclip.TranslateToString();
            }
            if (headhref.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + headhref.TranslateToString() : attribute + ", " + headhref.TranslateToString();
            }
            if (headlabel.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + headlabel.TranslateToString() : attribute + ", " + headlabel.TranslateToString();
            }
            if (headtarget.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + headtarget.TranslateToString() : attribute + ", " + headtarget.TranslateToString();
            }
            if (headtooltip.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + headtooltip.TranslateToString() : attribute + ", " + headtooltip.TranslateToString();
            }
            if (headURL.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + headURL.TranslateToString() : attribute + ", " + headURL.TranslateToString();
            }
            if (href.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + href.TranslateToString() : attribute + ", " + href.TranslateToString();
            }
            if (id.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + id.TranslateToString() : attribute + ", " + id.TranslateToString();
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
            if (labelhref.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + labelhref.TranslateToString() : attribute + ", " + labelhref.TranslateToString();
            }
            if (labeltarget.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + labeltarget.TranslateToString() : attribute + ", " + labeltarget.TranslateToString();
            }
            if (labeltooltip.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + labeltooltip.TranslateToString() : attribute + ", " + labeltooltip.TranslateToString();
            }
            if (labelURL.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + labelURL.TranslateToString() : attribute + ", " + labelURL.TranslateToString();
            }
            if (len.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + len.TranslateToString() : attribute + ", " + len.TranslateToString();
            }
            if (lhead.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + lhead.TranslateToString() : attribute + ", " + lhead.TranslateToString();
            }
            if (lp.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + lp.TranslateToString() : attribute + ", " + lp.TranslateToString();
            }
            if (ltail.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + ltail.TranslateToString() : attribute + ", " + ltail.TranslateToString();
            }
            if (minlen.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + minlen.TranslateToString() : attribute + ", " + minlen.TranslateToString();
            }
            if (nojustify.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + nojustify.TranslateToString() : attribute + ", " + nojustify.TranslateToString();
            }
            if (penwidth.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + penwidth.TranslateToString() : attribute + ", " + penwidth.TranslateToString();
            }
            if (pos.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + pos.TranslateToString() : attribute + ", " + pos.TranslateToString();
            }
            if (samehead.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + samehead.TranslateToString() : attribute + ", " + samehead.TranslateToString();
            }
            if (sametail.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + sametail.TranslateToString() : attribute + ", " + sametail.TranslateToString();
            }
            if (showboxes.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + showboxes.TranslateToString() : attribute + ", " + showboxes.TranslateToString();
            }
            if (tail_lp.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + tail_lp.TranslateToString() : attribute + ", " + tail_lp.TranslateToString();
            }
            if (tailclip.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + tailclip.TranslateToString() : attribute + ", " + tailclip.TranslateToString();
            }
            if (tailhref.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + tailhref.TranslateToString() : attribute + ", " + tailhref.TranslateToString();
            }
            if (taillabel.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + taillabel.TranslateToString() : attribute + ", " + taillabel.TranslateToString();
            }
            if (tailtarget.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + tailtarget.TranslateToString() : attribute + ", " + tailtarget.TranslateToString();
            }
            if (tailtooltip.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + tailtooltip.TranslateToString() : attribute + ", " + tailtooltip.TranslateToString();
            }
            if (tailURL.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + tailURL.TranslateToString() : attribute + ", " + tailURL.TranslateToString();
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
            if (weight.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + weight.TranslateToString() : attribute + ", " + weight.TranslateToString();
            }
            if (xlabel.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + xlabel.TranslateToString() : attribute + ", " + xlabel.TranslateToString();
            }
            if (xlp.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + xlp.TranslateToString() : attribute + ", " + xlp.TranslateToString();
            }
			return attribute;
		}
	}
}