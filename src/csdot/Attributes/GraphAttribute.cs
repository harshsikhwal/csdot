using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class GraphAttribute : IDotAttribute
	{
        public Dictionary<string, string> CustomAttribute = new Dictionary<string, string>();
        public _Background _background = new _Background();
        public BB bb = new BB();
        public BGColor bgcolor = new BGColor();
        public Center center = new Center();
        public Charset charset = new Charset();
        public _Class _class = new _Class();
        public ClusterRank clusterrank = new ClusterRank();
        public ColorScheme colorscheme = new ColorScheme();
        public _Comment comment = new _Comment();
        public Compound compound = new Compound();
        public Concentrate concentrate = new Concentrate();
        public damping Damping = new damping();
        public DefaultDist defaultdist = new DefaultDist();
        public Dim dim = new Dim();
        public Dimen dimen = new Dimen();
        public DirEdgeConstraints diredgeconstraints = new DirEdgeConstraints();
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
        public LP lp = new LP();
        public LWidth lwidth = new LWidth();
        public Margin margin = new Margin();
        public Maxiter maxiter = new Maxiter();
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
        public OutputOrder outputorder = new OutputOrder();
        public Overlap overlap = new Overlap();
        public OverlapScaling overlap_scaling = new OverlapScaling();
        public OverlapShrink overlap_shrink = new OverlapShrink();
        public Pack pack = new Pack();
        public PackMode packmode = new PackMode();
        public Quantum quantum = new Quantum();
        public RankDir rankdir = new RankDir();
        public RankSep ranksep = new RankSep();
        public Remincross remincross = new Remincross();
        public RepulsiveForce repulsiveforce = new RepulsiveForce();
        public Resolution resolution = new Resolution();
        public Root root = new Root();
        public Rotate rotate = new Rotate();
        public Rotation rotation = new Rotation();
        public Scale scale = new Scale();
        public SearchSize searchsize = new SearchSize();
        public ShowBoxes showboxes = new ShowBoxes();
        public Smoothing smoothing = new Smoothing();
        public Sortv sortv = new Sortv();
        public SPLines splines = new SPLines();
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
                attribute = attribute + _background.TranslateToString();
            }
            if (bb.Set)
            {
                attribute = ("" == attribute) ? attribute + bb.TranslateToString() : attribute + "\n" + bb.TranslateToString();
            }
            if (bgcolor.Set)
            {
                attribute = ("" == attribute) ? attribute + bgcolor.TranslateToString() : attribute + "\n" + bgcolor.TranslateToString();
            }
            if (center.Set)
            {
                attribute = ("" == attribute) ? attribute + center.TranslateToString() : attribute + "\n" + center.TranslateToString();
            }
            if (charset.Set)
            {
                attribute = ("" == attribute) ? attribute + charset.TranslateToString() : attribute + "\n" + charset.TranslateToString();
            }
            if (_class.Set)
            {
                attribute = ("" == attribute) ? attribute + _class.TranslateToString() : attribute + "\n" + _class.TranslateToString();
            }
            if (clusterrank.Set)
            {
                attribute = ("" == attribute) ? attribute + clusterrank.TranslateToString() : attribute + "\n" + clusterrank.TranslateToString();
            }
            if (colorscheme.Set)
            {
                attribute = ("" == attribute) ? attribute + colorscheme.TranslateToString() : attribute + "\n" + colorscheme.TranslateToString();
            }
            if (comment.Set)
            {
                attribute = ("" == attribute) ? attribute + comment.TranslateToString() : attribute + "\n" + comment.TranslateToString();
            }
            if (compound.Set)
            {
                attribute = ("" == attribute) ? attribute + compound.TranslateToString() : attribute + "\n" + compound.TranslateToString();
            }
            if (concentrate.Set)
            {
                attribute = ("" == attribute) ? attribute + concentrate.TranslateToString() : attribute + "\n" + concentrate.TranslateToString();
            }
            if (Damping.Set)
            {
                attribute = ("" == attribute) ? attribute + Damping.TranslateToString() : attribute + "\n" + Damping.TranslateToString();
            }
            if (defaultdist.Set)
            {
                attribute = ("" == attribute) ? attribute + defaultdist.TranslateToString() : attribute + "\n" + defaultdist.TranslateToString();
            }
            if (dim.Set)
            {
                attribute = ("" == attribute) ? attribute + dim.TranslateToString() : attribute + "\n" + dim.TranslateToString();
            }
            if (dimen.Set)
            {
                attribute = ("" == attribute) ? attribute + dimen.TranslateToString() : attribute + "\n" + dimen.TranslateToString();
            }
            if (diredgeconstraints.Set)
            {
                attribute = ("" == attribute) ? attribute + diredgeconstraints.TranslateToString() : attribute + "\n" + diredgeconstraints.TranslateToString();
            }
            if (dpi.Set)
            {
                attribute = ("" == attribute) ? attribute + dpi.TranslateToString() : attribute + "\n" + dpi.TranslateToString();
            }
            if (epsilon.Set)
            {
                attribute = ("" == attribute) ? attribute + epsilon.TranslateToString() : attribute + "\n" + epsilon.TranslateToString();
            }
            if (fontcolor.Set)
            {
                attribute = ("" == attribute) ? attribute + fontcolor.TranslateToString() : attribute + "\n" + fontcolor.TranslateToString();
            }
            if (fontname.Set)
            {
                attribute = ("" == attribute) ? attribute + fontname.TranslateToString() : attribute + "\n" + fontname.TranslateToString();
            }
            if (fontnames.Set)
            {
                attribute = ("" == attribute) ? attribute + fontnames.TranslateToString() : attribute + "\n" + fontnames.TranslateToString();
            }
            if (fontpath.Set)
            {
                attribute = ("" == attribute) ? attribute + fontpath.TranslateToString() : attribute + "\n" + fontpath.TranslateToString();
            }
            if (fontsize.Set)
            {
                attribute = ("" == attribute) ? attribute + fontsize.TranslateToString() : attribute + "\n" + fontsize.TranslateToString();
            }
            if (forcelabels.Set)
            {
                attribute = ("" == attribute) ? attribute + forcelabels.TranslateToString() : attribute + "\n" + forcelabels.TranslateToString();
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
            if (imagepath.Set)
            {
                attribute = ("" == attribute) ? attribute + imagepath.TranslateToString() : attribute + "\n" + imagepath.TranslateToString();
            }
            if (inputscale.Set)
            {
                attribute = ("" == attribute) ? attribute + inputscale.TranslateToString() : attribute + "\n" + inputscale.TranslateToString();
            }
            if (K.Set)
            {
                attribute = ("" == attribute) ? attribute + K.TranslateToString() : attribute + "\n" + K.TranslateToString();
            }
            if (label.Set)
            {
                attribute = ("" == attribute) ? attribute + label.TranslateToString() : attribute + "\n" + label.TranslateToString();
            }
            if (label_scheme.Set)
            {
                attribute = ("" == attribute) ? attribute + label_scheme.TranslateToString() : attribute + "\n" + label_scheme.TranslateToString();
            }
            if (labeljust.Set)
            {
                attribute = ("" == attribute) ? attribute + labeljust.TranslateToString() : attribute + "\n" + labeljust.TranslateToString();
            }
            if (labelloc.Set)
            {
                attribute = ("" == attribute) ? attribute + labelloc.TranslateToString() : attribute + "\n" + labelloc.TranslateToString();
            }
            if (landscape.Set)
            {
                attribute = ("" == attribute) ? attribute + landscape.TranslateToString() : attribute + "\n" + landscape.TranslateToString();
            }
            if (layerlistsep.Set)
            {
                attribute = ("" == attribute) ? attribute + layerlistsep.TranslateToString() : attribute + "\n" + layerlistsep.TranslateToString();
            }
            if (layersep.Set)
            {
                attribute = ("" == attribute) ? attribute + layersep.TranslateToString() : attribute + "\n" + layersep.TranslateToString();
            }
            if (layout.Set)
            {
                attribute = ("" == attribute) ? attribute + layout.TranslateToString() : attribute + "\n" + layout.TranslateToString();
            }
            if (levels.Set)
            {
                attribute = ("" == attribute) ? attribute + levels.TranslateToString() : attribute + "\n" + levels.TranslateToString();
            }
            if (levelsgap.Set)
            {
                attribute = ("" == attribute) ? attribute + levelsgap.TranslateToString() : attribute + "\n" + levelsgap.TranslateToString();
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
            if (maxiter.Set)
            {
                attribute = ("" == attribute) ? attribute + maxiter.TranslateToString() : attribute + "\n" + maxiter.TranslateToString();
            }
            if (mclimit.Set)
            {
                attribute = ("" == attribute) ? attribute + mclimit.TranslateToString() : attribute + "\n" + mclimit.TranslateToString();
            }
            if (mindist.Set)
            {
                attribute = ("" == attribute) ? attribute + mindist.TranslateToString() : attribute + "\n" + mindist.TranslateToString();
            }
            if (mode.Set)
            {
                attribute = ("" == attribute) ? attribute + mode.TranslateToString() : attribute + "\n" + mode.TranslateToString();
            }
            if (model.Set)
            {
                attribute = ("" == attribute) ? attribute + model.TranslateToString() : attribute + "\n" + model.TranslateToString();
            }
            if (mosek.Set)
            {
                attribute = ("" == attribute) ? attribute + mosek.TranslateToString() : attribute + "\n" + mosek.TranslateToString();
            }
            if (newrank.Set)
            {
                attribute = ("" == attribute) ? attribute + newrank.TranslateToString() : attribute + "\n" + newrank.TranslateToString();
            }
            if (nodesep.Set)
            {
                attribute = ("" == attribute) ? attribute + nodesep.TranslateToString() : attribute + "\n" + nodesep.TranslateToString();
            }
            if (nojustify.Set)
            {
                attribute = ("" == attribute) ? attribute + nojustify.TranslateToString() : attribute + "\n" + nojustify.TranslateToString();
            }
            if (notranslate.Set)
            {
                attribute = ("" == attribute) ? attribute + notranslate.TranslateToString() : attribute + "\n" + notranslate.TranslateToString();
            }
            if (nslimit.Set)
            {
                attribute = ("" == attribute) ? attribute + nslimit.TranslateToString() : attribute + "\n" + nslimit.TranslateToString();
            }
            if (nslimit1.Set)
            {
                attribute = ("" == attribute) ? attribute + nslimit1.TranslateToString() : attribute + "\n" + nslimit1.TranslateToString();
            }
            if (ordering.Set)
            {
                attribute = ("" == attribute) ? attribute + ordering.TranslateToString() : attribute + "\n" + ordering.TranslateToString();
            }
            if (outputorder.Set)
            {
                attribute = ("" == attribute) ? attribute + outputorder.TranslateToString() : attribute + "\n" + outputorder.TranslateToString();
            }
            if (overlap.Set)
            {
                attribute = ("" == attribute) ? attribute + overlap.TranslateToString() : attribute + "\n" + overlap.TranslateToString();
            }
            if (overlap_scaling.Set)
            {
                attribute = ("" == attribute) ? attribute + overlap_scaling.TranslateToString() : attribute + "\n" + overlap_scaling.TranslateToString();
            }
            if (overlap_shrink.Set)
            {
                attribute = ("" == attribute) ? attribute + overlap_shrink.TranslateToString() : attribute + "\n" + overlap_shrink.TranslateToString();
            }
            if (pack.Set)
            {
                attribute = ("" == attribute) ? attribute + pack.TranslateToString() : attribute + "\n" + pack.TranslateToString();
            }
            if (packmode.Set)
            {
                attribute = ("" == attribute) ? attribute + packmode.TranslateToString() : attribute + "\n" + packmode.TranslateToString();
            }
            if (quantum.Set)
            {
                attribute = ("" == attribute) ? attribute + quantum.TranslateToString() : attribute + "\n" + quantum.TranslateToString();
            }
            if (rankdir.Set)
            {
                attribute = ("" == attribute) ? attribute + rankdir.TranslateToString() : attribute + "\n" + rankdir.TranslateToString();
            }
            if (ranksep.Set)
            {
                attribute = ("" == attribute) ? attribute + ranksep.TranslateToString() : attribute + "\n" + ranksep.TranslateToString();
            }
            if (remincross.Set)
            {
                attribute = ("" == attribute) ? attribute + remincross.TranslateToString() : attribute + "\n" + remincross.TranslateToString();
            }
            if (repulsiveforce.Set)
            {
                attribute = ("" == attribute) ? attribute + repulsiveforce.TranslateToString() : attribute + "\n" + repulsiveforce.TranslateToString();
            }
            if (resolution.Set)
            {
                attribute = ("" == attribute) ? attribute + resolution.TranslateToString() : attribute + "\n" + resolution.TranslateToString();
            }
            if (root.Set)
            {
                attribute = ("" == attribute) ? attribute + root.TranslateToString() : attribute + "\n" + root.TranslateToString();
            }
            if (rotate.Set)
            {
                attribute = ("" == attribute) ? attribute + rotate.TranslateToString() : attribute + "\n" + rotate.TranslateToString();
            }
            if (rotation.Set)
            {
                attribute = ("" == attribute) ? attribute + rotation.TranslateToString() : attribute + "\n" + rotation.TranslateToString();
            }
            if (scale.Set)
            {
                attribute = ("" == attribute) ? attribute + scale.TranslateToString() : attribute + "\n" + scale.TranslateToString();
            }
            if (searchsize.Set)
            {
                attribute = ("" == attribute) ? attribute + searchsize.TranslateToString() : attribute + "\n" + searchsize.TranslateToString();
            }
            if (showboxes.Set)
            {
                attribute = ("" == attribute) ? attribute + showboxes.TranslateToString() : attribute + "\n" + showboxes.TranslateToString();
            }
            if (smoothing.Set)
            {
                attribute = ("" == attribute) ? attribute + smoothing.TranslateToString() : attribute + "\n" + smoothing.TranslateToString();
            }
            if (sortv.Set)
            {
                attribute = ("" == attribute) ? attribute + sortv.TranslateToString() : attribute + "\n" + sortv.TranslateToString();
            }
            if (splines.Set)
            {
                attribute = ("" == attribute) ? attribute + splines.TranslateToString() : attribute + "\n" + splines.TranslateToString();
            }
            if (stylesheet.Set)
            {
                attribute = ("" == attribute) ? attribute + stylesheet.TranslateToString() : attribute + "\n" + stylesheet.TranslateToString();
            }
            if (Target.Set)
            {
                attribute = ("" == attribute) ? attribute + Target.TranslateToString() : attribute + "\n" + Target.TranslateToString();
            }
            if (truecolor.Set)
            {
                attribute = ("" == attribute) ? attribute + truecolor.TranslateToString() : attribute + "\n" + truecolor.TranslateToString();
            }
            if (URL.Set)
            {
                attribute = ("" == attribute) ? attribute + URL.TranslateToString() : attribute + "\n" + URL.TranslateToString();
            }
            if (voro_margin.Set)
            {
                attribute = ("" == attribute) ? attribute + voro_margin.TranslateToString() : attribute + "\n" + voro_margin.TranslateToString();
            }
            if (xdotversion.Set)
            {
                attribute = ("" == attribute) ? attribute + xdotversion.TranslateToString() : attribute + "\n" + xdotversion.TranslateToString();
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