
using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class GraphAttribute : IDotAttribute
	{
        public _Background _background = new _Background();
        public Center center = new Center();
        public ColorScheme colorscheme = new ColorScheme();
        public Compound compound = new Compound();
        public Concentrate concentrate = new Concentrate();
        public damping Damping = new damping();
        public DefaultDist defaultdist = new DefaultDist();
        public Dim dim = new Dim();
        public Dimen dimen = new Dimen();
        public Dpi dpi = new Dpi();
        public Epsilon epsilon = new Epsilon();
        public FontColor fontcolor = new FontColor();
        public Fontname fontname = new Fontname();
        public Fontnames fontnames = new Fontnames();
        public FontPath fontpath = new FontPath();
        public Fontsize fontsize = new Fontsize();
        public ForceLabels forcelabels = new ForceLabels();
        public GradientAngle gradientangle = new GradientAngle();
        public Href href = new Href();
        public ID id = new ID();
        public ImagePath imagepath = new ImagePath();
        public InputScale inputscale = new InputScale();
        public k K = new k();
        public Label label = new Label();
        public LabelScheme label_scheme = new LabelScheme();
        public LabelJust labeljust = new LabelJust();
        public LabelLoc labelloc = new LabelLoc();
        public Landscape landscape = new Landscape();
        public LayerListSep layerlistsep = new LayerListSep();
        public LayerSep layersep = new LayerSep();
        public Layout layout = new Layout();
        public Levels levels = new Levels();
        public LevelsGap levelsgap = new LevelsGap();
        public LHeight lheight = new LHeight();
        public LWidth lwidth = new LWidth();
        public MClimit mclimit = new MClimit();
        public Mindist mindist = new Mindist();
        public Mode mode = new Mode();
        public Model model = new Model();
        public Mosek mosek = new Mosek();
        public NewRank newrank = new NewRank();
        public NodeSep nodesep = new NodeSep();
        public NoJustify nojustify = new NoJustify();
        public NoTranslate notranslate = new NoTranslate();
        public NSLimit nslimit = new NSLimit();
        public NSLimit1 nslimit1 = new NSLimit1();
        public Ordering ordering = new Ordering();
        public OverlapScaling overlap_scaling = new OverlapScaling();
        public OverlapShrink overlap_shrink = new OverlapShrink();
        public Quantum quantum = new Quantum();
        public Remincross remincross = new Remincross();
        public RepulsiveForce repulsiveforce = new RepulsiveForce();
        public Resolution resolution = new Resolution();
        public Rotate rotate = new Rotate();
        public Rotation rotation = new Rotation();
        public SearchSize searchsize = new SearchSize();
        public ShowBoxes showboxes = new ShowBoxes();
        public Sortv sortv = new Sortv();
        public StyleSheet stylesheet = new StyleSheet();
        public Target Target = new Target();
        public TrueColor truecolor = new TrueColor();
        public url URL = new url();
        public VoroMargin voro_margin = new VoroMargin();
        public XDotVersion xdotversion = new XDotVersion();

		public string AttributesToString()
		{
			string attribute = "";
            if (_background.Set)
            {
                attribute = attribute + " " + _background.TranslateToString();
            }
            if (center.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + center.TranslateToString() : attribute + ", " + center.TranslateToString();
            }
            if (colorscheme.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + colorscheme.TranslateToString() : attribute + ", " + colorscheme.TranslateToString();
            }
            if (compound.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + compound.TranslateToString() : attribute + ", " + compound.TranslateToString();
            }
            if (concentrate.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + concentrate.TranslateToString() : attribute + ", " + concentrate.TranslateToString();
            }
            if (Damping.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + Damping.TranslateToString() : attribute + ", " + Damping.TranslateToString();
            }
            if (defaultdist.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + defaultdist.TranslateToString() : attribute + ", " + defaultdist.TranslateToString();
            }
            if (dim.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + dim.TranslateToString() : attribute + ", " + dim.TranslateToString();
            }
            if (dimen.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + dimen.TranslateToString() : attribute + ", " + dimen.TranslateToString();
            }
            if (dpi.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + dpi.TranslateToString() : attribute + ", " + dpi.TranslateToString();
            }
            if (epsilon.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + epsilon.TranslateToString() : attribute + ", " + epsilon.TranslateToString();
            }
            if (fontcolor.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + fontcolor.TranslateToString() : attribute + ", " + fontcolor.TranslateToString();
            }
            if (fontname.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + fontname.TranslateToString() : attribute + ", " + fontname.TranslateToString();
            }
            if (fontnames.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + fontnames.TranslateToString() : attribute + ", " + fontnames.TranslateToString();
            }
            if (fontpath.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + fontpath.TranslateToString() : attribute + ", " + fontpath.TranslateToString();
            }
            if (fontsize.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + fontsize.TranslateToString() : attribute + ", " + fontsize.TranslateToString();
            }
            if (forcelabels.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + forcelabels.TranslateToString() : attribute + ", " + forcelabels.TranslateToString();
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
            if (imagepath.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + imagepath.TranslateToString() : attribute + ", " + imagepath.TranslateToString();
            }
            if (inputscale.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + inputscale.TranslateToString() : attribute + ", " + inputscale.TranslateToString();
            }
            if (K.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + K.TranslateToString() : attribute + ", " + K.TranslateToString();
            }
            if (label.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + label.TranslateToString() : attribute + ", " + label.TranslateToString();
            }
            if (label_scheme.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + label_scheme.TranslateToString() : attribute + ", " + label_scheme.TranslateToString();
            }
            if (labeljust.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + labeljust.TranslateToString() : attribute + ", " + labeljust.TranslateToString();
            }
            if (labelloc.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + labelloc.TranslateToString() : attribute + ", " + labelloc.TranslateToString();
            }
            if (landscape.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + landscape.TranslateToString() : attribute + ", " + landscape.TranslateToString();
            }
            if (layerlistsep.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + layerlistsep.TranslateToString() : attribute + ", " + layerlistsep.TranslateToString();
            }
            if (layersep.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + layersep.TranslateToString() : attribute + ", " + layersep.TranslateToString();
            }
            if (layout.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + layout.TranslateToString() : attribute + ", " + layout.TranslateToString();
            }
            if (levels.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + levels.TranslateToString() : attribute + ", " + levels.TranslateToString();
            }
            if (levelsgap.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + levelsgap.TranslateToString() : attribute + ", " + levelsgap.TranslateToString();
            }
            if (lheight.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + lheight.TranslateToString() : attribute + ", " + lheight.TranslateToString();
            }
            if (lwidth.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + lwidth.TranslateToString() : attribute + ", " + lwidth.TranslateToString();
            }
            if (mclimit.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + mclimit.TranslateToString() : attribute + ", " + mclimit.TranslateToString();
            }
            if (mindist.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + mindist.TranslateToString() : attribute + ", " + mindist.TranslateToString();
            }
            if (mode.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + mode.TranslateToString() : attribute + ", " + mode.TranslateToString();
            }
            if (model.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + model.TranslateToString() : attribute + ", " + model.TranslateToString();
            }
            if (mosek.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + mosek.TranslateToString() : attribute + ", " + mosek.TranslateToString();
            }
            if (newrank.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + newrank.TranslateToString() : attribute + ", " + newrank.TranslateToString();
            }
            if (nodesep.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + nodesep.TranslateToString() : attribute + ", " + nodesep.TranslateToString();
            }
            if (nojustify.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + nojustify.TranslateToString() : attribute + ", " + nojustify.TranslateToString();
            }
            if (notranslate.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + notranslate.TranslateToString() : attribute + ", " + notranslate.TranslateToString();
            }
            if (nslimit.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + nslimit.TranslateToString() : attribute + ", " + nslimit.TranslateToString();
            }
            if (nslimit1.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + nslimit1.TranslateToString() : attribute + ", " + nslimit1.TranslateToString();
            }
            if (ordering.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + ordering.TranslateToString() : attribute + ", " + ordering.TranslateToString();
            }
            if (overlap_scaling.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + overlap_scaling.TranslateToString() : attribute + ", " + overlap_scaling.TranslateToString();
            }
            if (overlap_shrink.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + overlap_shrink.TranslateToString() : attribute + ", " + overlap_shrink.TranslateToString();
            }
            if (quantum.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + quantum.TranslateToString() : attribute + ", " + quantum.TranslateToString();
            }
            if (remincross.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + remincross.TranslateToString() : attribute + ", " + remincross.TranslateToString();
            }
            if (repulsiveforce.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + repulsiveforce.TranslateToString() : attribute + ", " + repulsiveforce.TranslateToString();
            }
            if (resolution.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + resolution.TranslateToString() : attribute + ", " + resolution.TranslateToString();
            }
            if (rotate.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + rotate.TranslateToString() : attribute + ", " + rotate.TranslateToString();
            }
            if (rotation.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + rotation.TranslateToString() : attribute + ", " + rotation.TranslateToString();
            }
            if (searchsize.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + searchsize.TranslateToString() : attribute + ", " + searchsize.TranslateToString();
            }
            if (showboxes.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + showboxes.TranslateToString() : attribute + ", " + showboxes.TranslateToString();
            }
            if (sortv.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + sortv.TranslateToString() : attribute + ", " + sortv.TranslateToString();
            }
            if (stylesheet.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + stylesheet.TranslateToString() : attribute + ", " + stylesheet.TranslateToString();
            }
            if (Target.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + Target.TranslateToString() : attribute + ", " + Target.TranslateToString();
            }
            if (truecolor.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + truecolor.TranslateToString() : attribute + ", " + truecolor.TranslateToString();
            }
            if (URL.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + URL.TranslateToString() : attribute + ", " + URL.TranslateToString();
            }
            if (voro_margin.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + voro_margin.TranslateToString() : attribute + ", " + voro_margin.TranslateToString();
            }
            if (xdotversion.Set)
            {
                attribute = ("" == attribute) ? attribute + " " + xdotversion.TranslateToString() : attribute + ", " + xdotversion.TranslateToString();
            }
			return attribute;
		}
	}
}