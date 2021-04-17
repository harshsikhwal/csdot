using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes;

namespace csdot
{
	public class Subgraph : IDot, IElement
	{
		public string type { get; set; } = "subgraph";
		public Guid uid { get; }
		public string ID { get; set; }

		public SubgraphAttribute Attribute = new SubgraphAttribute();
		private Dictionary<Guid, IDot> m_elements = new Dictionary<Guid, IDot>();
		private Dictionary<string, IAttribute> attributeMap = new Dictionary<string, IAttribute>();

		public Subgraph(string i_id)
		{
			ID = i_id;
			uid = Guid.NewGuid();
			this.FillAttributeMap();
		}

		public Subgraph()
		{
			ID = "";
			uid = Guid.NewGuid();
			this.FillAttributeMap();
		}

		public Dictionary<string, IAttribute> attributes
		{
			get
			{
				return attributeMap;

			}
		}

		public void AddElement(IDot i_dot)
		{
			m_elements.Add(i_dot.uid, i_dot);
		}
		public void AddElements(params IDot[] i_dot)
		{
			foreach (var e in i_dot)
			{
				m_elements.Add(e.uid, e);
			}
		}

		public void DeleteElement(IDot i_dot)
		{
			m_elements.Remove(i_dot.uid);
		}

		public IDot GetElementByName(string i_name, string i_elementType = "node")
		{
			foreach (var element in m_elements)
			{
				if (element.Value.ID == i_name)
				{
					if (i_elementType == "node" && null != (element.Value as Node))
						return element.Value as Node;
					if (i_elementType == "edge" && null != (element.Value as Edge))
						return element.Value as Edge;
				}
			}

			// it means we did not find any element with the specific name 
			return null;
		}

		public IDot GetElement(Guid i_uid)
		{
			IDot dot = m_elements[i_uid];
			return dot;
		}

		private void FillAttributeMap()
		{
			this.attributeMap.Add("_background", Attribute._background);
			this.attributeMap.Add("bb", Attribute.bb);
			this.attributeMap.Add("bgcolor", Attribute.bgcolor);
			this.attributeMap.Add("center", Attribute.center);
			this.attributeMap.Add("charset", Attribute.charset);
			this.attributeMap.Add("_class", Attribute._class);
			this.attributeMap.Add("clusterrank", Attribute.clusterrank);
			this.attributeMap.Add("colorscheme", Attribute.colorscheme);
			this.attributeMap.Add("comment", Attribute.comment);
			this.attributeMap.Add("compound", Attribute.compound);
			this.attributeMap.Add("concentrate", Attribute.concentrate);
			this.attributeMap.Add("Damping", Attribute.Damping);
			this.attributeMap.Add("defaultdist", Attribute.defaultdist);
			this.attributeMap.Add("dim", Attribute.dim);
			this.attributeMap.Add("dimen", Attribute.dimen);
			this.attributeMap.Add("diredgeconstraints", Attribute.diredgeconstraints);
			this.attributeMap.Add("dpi", Attribute.dpi);
			this.attributeMap.Add("epsilon", Attribute.epsilon);
			this.attributeMap.Add("fontcolor", Attribute.fontcolor);
			this.attributeMap.Add("fontname", Attribute.fontname);
			this.attributeMap.Add("fontnames", Attribute.fontnames);
			this.attributeMap.Add("fontpath", Attribute.fontpath);
			this.attributeMap.Add("fontsize", Attribute.fontsize);
			this.attributeMap.Add("forcelabels", Attribute.forcelabels);
			this.attributeMap.Add("gradientangle", Attribute.gradientangle);
			this.attributeMap.Add("href", Attribute.href);
			this.attributeMap.Add("id", Attribute.id);
			this.attributeMap.Add("imagepath", Attribute.imagepath);
			this.attributeMap.Add("inputscale", Attribute.inputscale);
			this.attributeMap.Add("K", Attribute.K);
			this.attributeMap.Add("label", Attribute.label);
			this.attributeMap.Add("label_scheme", Attribute.label_scheme);
			this.attributeMap.Add("labeljust", Attribute.labeljust);
			this.attributeMap.Add("labelloc", Attribute.labelloc);
			this.attributeMap.Add("landscape", Attribute.landscape);
			this.attributeMap.Add("layerlistsep", Attribute.layerlistsep);
			this.attributeMap.Add("layersep", Attribute.layersep);
			this.attributeMap.Add("layout", Attribute.layout);
			this.attributeMap.Add("levels", Attribute.levels);
			this.attributeMap.Add("levelsgap", Attribute.levelsgap);
			this.attributeMap.Add("lheight", Attribute.lheight);
			this.attributeMap.Add("lp", Attribute.lp);
			this.attributeMap.Add("lwidth", Attribute.lwidth);
			this.attributeMap.Add("margin", Attribute.margin);
			this.attributeMap.Add("maxiter", Attribute.maxiter);
			this.attributeMap.Add("mclimit", Attribute.mclimit);
			this.attributeMap.Add("mindist", Attribute.mindist);
			this.attributeMap.Add("mode", Attribute.mode);
			this.attributeMap.Add("model", Attribute.model);
			this.attributeMap.Add("mosek", Attribute.mosek);
			this.attributeMap.Add("newrank", Attribute.newrank);
			this.attributeMap.Add("nodesep", Attribute.nodesep);
			this.attributeMap.Add("nojustify", Attribute.nojustify);
			this.attributeMap.Add("notranslate", Attribute.notranslate);
			this.attributeMap.Add("nslimit", Attribute.nslimit);
			this.attributeMap.Add("nslimit1", Attribute.nslimit1);
			this.attributeMap.Add("ordering", Attribute.ordering);
			this.attributeMap.Add("outputorder", Attribute.outputorder);
			this.attributeMap.Add("overlap", Attribute.overlap);
			this.attributeMap.Add("overlap_scaling", Attribute.overlap_scaling);
			this.attributeMap.Add("overlap_shrink", Attribute.overlap_shrink);
			this.attributeMap.Add("pack", Attribute.pack);
			this.attributeMap.Add("packmode", Attribute.packmode);
			this.attributeMap.Add("quantum", Attribute.quantum);
			this.attributeMap.Add("rank", Attribute.rank);
			this.attributeMap.Add("rankdir", Attribute.rankdir);
			this.attributeMap.Add("ranksep", Attribute.ranksep);
			this.attributeMap.Add("remincross", Attribute.remincross);
			this.attributeMap.Add("repulsiveforce", Attribute.repulsiveforce);
			this.attributeMap.Add("resolution", Attribute.resolution);
			this.attributeMap.Add("root", Attribute.root);
			this.attributeMap.Add("rotate", Attribute.rotate);
			this.attributeMap.Add("rotation", Attribute.rotation);
			this.attributeMap.Add("scale", Attribute.scale);
			this.attributeMap.Add("searchsize", Attribute.searchsize);
			this.attributeMap.Add("showboxes", Attribute.showboxes);
			this.attributeMap.Add("smoothing", Attribute.smoothing);
			this.attributeMap.Add("sortv", Attribute.sortv);
			this.attributeMap.Add("splines", Attribute.splines);
			this.attributeMap.Add("stylesheet", Attribute.stylesheet);
			this.attributeMap.Add("Target", Attribute.Target);
			this.attributeMap.Add("truecolor", Attribute.truecolor);
			this.attributeMap.Add("URL", Attribute.URL);
			this.attributeMap.Add("voro_margin", Attribute.voro_margin);
			this.attributeMap.Add("xdotversion", Attribute.xdotversion);
		}

		public string ElementToString()
		{
			string attrStr = Attribute.AttributesToString();
			string subgraphbuilder = type + " " + ID + "\n{\n";

			if (attrStr != "")
				subgraphbuilder = subgraphbuilder + attrStr +"\n";

			foreach (var dotElement in m_elements.Values)
			{
				subgraphbuilder = subgraphbuilder + dotElement.ElementToString() + "\n";
			}
			subgraphbuilder = subgraphbuilder + "}";

			return subgraphbuilder;
		}

		public string ElementToString(int i_spacing)
		{
			string spacing = "";
			string bspacing = "";
			if (i_spacing > 0)
			{
				spacing = new String('\t', i_spacing);
				bspacing = new String('\t', i_spacing - 1);
			}

			string attrStr = Attribute.AttributesToString();
			string subgraphbuilder = type + " " + ID + "\n" + bspacing + "{\n";

			if (attrStr != "")
				subgraphbuilder = subgraphbuilder + spacing + attrStr + "\n";

			foreach (var dotElement in m_elements.Values)
			{
				subgraphbuilder = subgraphbuilder + spacing + dotElement.ElementToString(i_spacing + 1) + "\n";
			}
			subgraphbuilder = subgraphbuilder + bspacing + "}";

			return subgraphbuilder;
		}
	}
}
