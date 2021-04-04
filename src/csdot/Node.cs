using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes;

namespace csdot
{
	public class Node : IDot
	{
		public string type { get; set; } = "node";
		public Guid uid { get;  }
		public string ID { get; set; }

		//public Dictionary<string, IAttribute> attributeMap = new Dictionary<string, IAttribute>();

		// better if we have a list?
		private bool subIDSet { get; set; } = false;

		private string m_subID = "";

		public string subID
		{
			get
			{
				return m_subID;
			}
			set
			{
				subIDSet = true;
				m_subID = value;
			}

		}
		public string compassPoint { get; set; } = "";

		private NodeAttribute m_attribute = new NodeAttribute();

		public NodeAttribute Attribute
		{
			get
			{
				return m_attribute;
			}
		}

		public Node(string i_id)
		{
			ID = i_id;
			uid = Guid.NewGuid();
			//this.FillAttributeMap();
		}

        //private void FillAttributeMap()
        //{
        //    this.attributeMap.Add("area", m_attribute.area);
        //    this.attributeMap.Add("_class", m_attribute._class);
        //    this.attributeMap.Add("color", m_attribute.color);
        //    this.attributeMap.Add("colorscheme", m_attribute.colorscheme);
        //    this.attributeMap.Add("comment", m_attribute.comment);
        //    this.attributeMap.Add("distortion", m_attribute.distortion);
        //    this.attributeMap.Add("fillcolor", m_attribute.fillcolor);
        //    this.attributeMap.Add("fixedsize", m_attribute.fixedsize);
        //    this.attributeMap.Add("fontcolor", m_attribute.fontcolor);
        //    this.attributeMap.Add("fontname", m_attribute.fontname);
        //    this.attributeMap.Add("fontsize", m_attribute.fontsize);
        //    this.attributeMap.Add("gradientangle", m_attribute.gradientangle);
        //    this.attributeMap.Add("height", m_attribute.height);
        //    this.attributeMap.Add("href", m_attribute.href);
        //    this.attributeMap.Add("id", m_attribute.id);
        //    this.attributeMap.Add("image", m_attribute.image);
        //    this.attributeMap.Add("imagepos", m_attribute.imagepos);
        //    this.attributeMap.Add("imagescale", m_attribute.imagescale);
        //    this.attributeMap.Add("label", m_attribute.label);
        //    this.attributeMap.Add("labelloc", m_attribute.labelloc);
        //    this.attributeMap.Add("margin", m_attribute.margin);
        //    this.attributeMap.Add("nojustify", m_attribute.nojustify);
        //    this.attributeMap.Add("ordering", m_attribute.ordering);
        //    this.attributeMap.Add("penwidth", m_attribute.penwidth);
        //    this.attributeMap.Add("peripheries", m_attribute.peripheries);
        //    this.attributeMap.Add("pin", m_attribute.pin);
        //    this.attributeMap.Add("pos", m_attribute.pos);
        //    this.attributeMap.Add("rects", m_attribute.rects);
        //    this.attributeMap.Add("regular", m_attribute.regular);
        //    this.attributeMap.Add("root", m_attribute.root);
        //    this.attributeMap.Add("samplepoints", m_attribute.samplepoints);
        //    this.attributeMap.Add("shape", m_attribute.shape);
        //    this.attributeMap.Add("shapefile", m_attribute.shapefile);
        //    this.attributeMap.Add("showboxes", m_attribute.showboxes);
        //    this.attributeMap.Add("sides", m_attribute.sides);
        //    this.attributeMap.Add("skew", m_attribute.skew);
        //    this.attributeMap.Add("sortv", m_attribute.sortv);
        //    this.attributeMap.Add("Target", m_attribute.Target);
        //    this.attributeMap.Add("tooltip", m_attribute.tooltip);
        //    this.attributeMap.Add("URL", m_attribute.URL);
        //    this.attributeMap.Add("width", m_attribute.width);
        //    this.attributeMap.Add("xlabel", m_attribute.xlabel);
        //    this.attributeMap.Add("xlp", m_attribute.xlp);
        //    this.attributeMap.Add("z", m_attribute.z);
        //}

        public string ElementToString()
		{
			string attributestr = Attribute.AttributesToString();
			if(attributestr != "")
			{
				attributestr = " [" + attributestr + " ]";
			}
			if (subIDSet)
			{
				if(compassPoint == "")
					return ID + ":" + m_subID + attributestr;
				else
					return ID + ":" + m_subID + ":" + compassPoint + attributestr;
			}
			if(compassPoint != "")
				return ID + ":" + compassPoint + attributestr;
			
			else
				return ID + attributestr;
		}

		public string ElementToString(int i_spacing)
		{
			string attributestr = Attribute.AttributesToString();
			if (attributestr != "")
				attributestr = " [" + attributestr + " ]";
			else
				attributestr = ";";
			if (subIDSet)
			{
				if (compassPoint == "")
					return ID + ":" + m_subID + attributestr;
				else
					return ID + ":" + m_subID + ":" + compassPoint + attributestr;
			}
			if (compassPoint != "")
				return ID + ":" + compassPoint + attributestr;

			else
				return ID + attributestr;
		}
	}
}
