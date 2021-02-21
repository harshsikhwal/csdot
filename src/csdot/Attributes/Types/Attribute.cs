
using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.DataTypes;

namespace csdot.Attributes.Types
{
    public class _Background : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value;
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string TranslateToString()
        {
            return "_background = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class Area : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 1.0;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 1.0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 1.0;
        }
        
        public string TranslateToString()
        {
            return "area = " + Value.ToString();
        }
        #endregion
    }
            
    public class ArrowHead : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "ArrowType.normal";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "ArrowType.normal";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "ArrowType.normal";
        }
        
        public string TranslateToString()
        {
            return "arrowhead = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class ArrowSize : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 1.0;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 1.0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 1.0;
        }
        
        public double GetMinimum()
        {
            return 0.0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0.0;
        }
        
        public string TranslateToString()
        {
            return "arrowsize = " + Value.ToString();
        }
        #endregion
    }
            
    public class ArrowTail : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "ArrowType.normal";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "ArrowType.normal";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "ArrowType.normal";
        }
        
        public string TranslateToString()
        {
            return "arrowtail = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class Center : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = false;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return false;
        }

        public void SetDefault()
        {
            Set = true;
            Value = false;
        }
        
        public string TranslateToString()
        {
            return "center = " + Value.ToString();
        }
        #endregion
    }
            
    public class Color : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "DataTypes.Color.X11.black";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "DataTypes.Color.X11.black";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "DataTypes.Color.X11.black";
        }
        
        public string TranslateToString()
        {
            return "color = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class ColorScheme : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "colorscheme = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class Compound : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = false;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return false;
        }

        public void SetDefault()
        {
            Set = true;
            Value = false;
        }
        
        public string TranslateToString()
        {
            return "compound = " + Value.ToString();
        }
        #endregion
    }
            
    public class Concentrate : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = false;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return false;
        }

        public void SetDefault()
        {
            Set = true;
            Value = false;
        }
        
        public string TranslateToString()
        {
            return "concentrate = " + Value.ToString();
        }
        #endregion
    }
            
    public class Constraint : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = true;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return true;
        }

        public void SetDefault()
        {
            Set = true;
            Value = true;
        }
        
        public string TranslateToString()
        {
            return "constraint = " + Value.ToString();
        }
        #endregion
    }
            
    public class damping : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 0.99;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 0.99;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 0.99;
        }
        
        public double GetMinimum()
        {
            return 0.0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0.0;
        }
        
        public string TranslateToString()
        {
            return "Damping = " + Value.ToString();
        }
        #endregion
    }
            
    public class Decorate : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = false;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return false;
        }

        public void SetDefault()
        {
            Set = true;
            Value = false;
        }
        
        public string TranslateToString()
        {
            return "decorate = " + Value.ToString();
        }
        #endregion
    }
            
    public class DefaultDist : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetMinimum()
        {
            return Double.Epsilon;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = Double.Epsilon;
        }
        
        public string TranslateToString()
        {
            return "defaultdist = " + Value.ToString();
        }
        #endregion
    }
            
    public class Dim : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private int m_value = 2;
        public int Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public int GetDefault()
        {
            return 2;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 2;
        }
        
        public int GetMinimum()
        {
            return 2;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 2;
        }
        
        public string TranslateToString()
        {
            return "dim = " + Value.ToString();
        }
        #endregion
    }
            
    public class Dimen : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private int m_value = 2;
        public int Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public int GetDefault()
        {
            return 2;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 2;
        }
        
        public int GetMinimum()
        {
            return 2;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 2;
        }
        
        public string TranslateToString()
        {
            return "dimen = " + Value.ToString();
        }
        #endregion
    }
            
    public class Distortion : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 0.0;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 0.0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 0.0;
        }
        
        public double GetMinimum()
        {
            return -100.0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = -100.0;
        }
        
        public string TranslateToString()
        {
            return "distortion = " + Value.ToString();
        }
        #endregion
    }
            
    public class Dpi : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 0.0;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 0.0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 0.0;
        }
        
        public string TranslateToString()
        {
            return "dpi = " + Value.ToString();
        }
        #endregion
    }
            
    public class Edgehref : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "edgehref = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class EdgeTarget : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value;
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string TranslateToString()
        {
            return "edgetarget = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class EdgeToolTip : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "edgetooltip = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class EdgeURL : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "edgeURL = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class Epsilon : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 0.001;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 0.001;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 0.001;
        }
        
        public string TranslateToString()
        {
            return "epsilon = " + Value.ToString();
        }
        #endregion
    }
            
    public class FontColor : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "DataTypes.Color.X11.black";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "DataTypes.Color.X11.black";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "DataTypes.Color.X11.black";
        }
        
        public string TranslateToString()
        {
            return "fontcolor = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class Fontname : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "Times-Roman";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "Times-Roman";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "Times-Roman";
        }
        
        public string TranslateToString()
        {
            return "fontname = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class Fontnames : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "fontnames = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class FontPath : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "fontpath = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class Fontsize : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 14.0;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 14.0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 14.0;
        }
        
        public double GetMinimum()
        {
            return 1.0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 1.0;
        }
        
        public string TranslateToString()
        {
            return "fontsize = " + Value.ToString();
        }
        #endregion
    }
            
    public class ForceLabels : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = true;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return true;
        }

        public void SetDefault()
        {
            Set = true;
            Value = true;
        }
        
        public string TranslateToString()
        {
            return "forcelabels = " + Value.ToString();
        }
        #endregion
    }
            
    public class GradientAngle : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private int m_value;
        public int Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string TranslateToString()
        {
            return "gradientangle = " + Value.ToString();
        }
        #endregion
    }
            
    public class Group : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "group = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class HeadClip : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = true;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return true;
        }

        public void SetDefault()
        {
            Set = true;
            Value = true;
        }
        
        public string TranslateToString()
        {
            return "headclip = " + Value.ToString();
        }
        #endregion
    }
            
    public class HeadHref : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "headhref = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class HeadLabel : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "headlabel = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class HeadTarget : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value;
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string TranslateToString()
        {
            return "headtarget = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class HeadToolTip : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "headtooltip = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class HeadURL : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "headURL = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class Height : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 0.5;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 0.5;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 0.5;
        }
        
        public double GetMinimum()
        {
            return 0.02;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0.02;
        }
        
        public string TranslateToString()
        {
            return "height = " + Value.ToString();
        }
        #endregion
    }
            
    public class Href : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "href = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class ID : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "id = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class Image : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "image = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class ImagePath : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "imagepath = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class ImagePos : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "mc";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "mc";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "mc";
        }
        
        public string TranslateToString()
        {
            return "imagepos = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class ImageScale : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = false;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return false;
        }

        public void SetDefault()
        {
            Set = true;
            Value = false;
        }
        
        public string TranslateToString()
        {
            return "imagescale = " + Value.ToString();
        }
        #endregion
    }
            
    public class InputScale : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string TranslateToString()
        {
            return "inputscale = " + Value.ToString();
        }
        #endregion
    }
            
    public class k : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 0.3;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 0.3;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 0.3;
        }
        
        public double GetMinimum()
        {
            return 0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0;
        }
        
        public string TranslateToString()
        {
            return "K = " + Value.ToString();
        }
        #endregion
    }
            
    public class Label : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "label = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class LabelScheme : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private int m_value = 0;
        public int Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public int GetDefault()
        {
            return 0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 0;
        }
        
        public int GetMinimum()
        {
            return 0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0;
        }
        
        public string TranslateToString()
        {
            return "label_scheme = " + Value.ToString();
        }
        #endregion
    }
            
    public class LabelAngle : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = -25.0;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return -25.0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = -25.0;
        }
        
        public double GetMinimum()
        {
            return -180.0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = -180.0;
        }
        
        public string TranslateToString()
        {
            return "labelangle = " + Value.ToString();
        }
        #endregion
    }
            
    public class LabelDistance : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 1.0;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 1.0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 1.0;
        }
        
        public double GetMinimum()
        {
            return 0.0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0.0;
        }
        
        public string TranslateToString()
        {
            return "labeldistance = " + Value.ToString();
        }
        #endregion
    }
            
    public class LabelFloat : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = false;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return false;
        }

        public void SetDefault()
        {
            Set = true;
            Value = false;
        }
        
        public string TranslateToString()
        {
            return "labelfloat = " + Value.ToString();
        }
        #endregion
    }
            
    public class LabelFontColor : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "DataTypes.Color.X11.black";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "DataTypes.Color.X11.black";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "DataTypes.Color.X11.black";
        }
        
        public string TranslateToString()
        {
            return "labelfontcolor = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class LabelFontname : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "Times-Roman";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "Times-Roman";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "Times-Roman";
        }
        
        public string TranslateToString()
        {
            return "labelfontname = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class LabelFontsize : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 14.0;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 14.0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 14.0;
        }
        
        public double GetMinimum()
        {
            return 1.0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 1.0;
        }
        
        public string TranslateToString()
        {
            return "labelfontsize = " + Value.ToString();
        }
        #endregion
    }
            
    public class LabelHref : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "labelhref = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class LabelJust : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "c";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "c";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "c";
        }
        
        public string TranslateToString()
        {
            return "labeljust = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class LabelLoc : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "labelloc = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class LabelTarget : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value;
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string TranslateToString()
        {
            return "labeltarget = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class LabelToolTip : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "labeltooltip = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class LabelURL : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "labelURL = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class Landscape : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = false;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return false;
        }

        public void SetDefault()
        {
            Set = true;
            Value = false;
        }
        
        public string TranslateToString()
        {
            return "landscape = " + Value.ToString();
        }
        #endregion
    }
            
    public class LayerListSep : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = ",";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return ",";
        }

        public void SetDefault()
        {
            Set = true;
            Value = ",";
        }
        
        public string TranslateToString()
        {
            return "layerlistsep = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class LayerSep : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = ":\t";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return ":\t";
        }

        public void SetDefault()
        {
            Set = true;
            Value = ":\t";
        }
        
        public string TranslateToString()
        {
            return "layersep = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class Layout : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "layout = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class Len : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string TranslateToString()
        {
            return "len = " + Value.ToString();
        }
        #endregion
    }
            
    public class Levels : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private int m_value = int.MaxValue;
        public int Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public int GetDefault()
        {
            return int.MaxValue;
        }

        public void SetDefault()
        {
            Set = true;
            Value = int.MaxValue;
        }
        
        public int GetMinimum()
        {
            return 0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0;
        }
        
        public string TranslateToString()
        {
            return "levels = " + Value.ToString();
        }
        #endregion
    }
            
    public class LevelsGap : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 0.0;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 0.0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 0.0;
        }
        
        public string TranslateToString()
        {
            return "levelsgap = " + Value.ToString();
        }
        #endregion
    }
            
    public class LHead : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "lhead = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class LHeight : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string TranslateToString()
        {
            return "lheight = " + Value.ToString();
        }
        #endregion
    }
            
    public class LTail : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "ltail = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class LWidth : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string TranslateToString()
        {
            return "lwidth = " + Value.ToString();
        }
        #endregion
    }
            
    public class MClimit : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 1.0;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 1.0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 1.0;
        }
        
        public string TranslateToString()
        {
            return "mclimit = " + Value.ToString();
        }
        #endregion
    }
            
    public class Mindist : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 1.0;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 1.0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 1.0;
        }
        
        public double GetMinimum()
        {
            return 0.0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0.0;
        }
        
        public string TranslateToString()
        {
            return "mindist = " + Value.ToString();
        }
        #endregion
    }
            
    public class MinLen : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private int m_value = 1;
        public int Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public int GetDefault()
        {
            return 1;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 1;
        }
        
        public int GetMinimum()
        {
            return 0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0;
        }
        
        public string TranslateToString()
        {
            return "minlen = " + Value.ToString();
        }
        #endregion
    }
            
    public class Mode : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "major";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "major";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "major";
        }
        
        public string TranslateToString()
        {
            return "mode = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class Model : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "shortpath";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "shortpath";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "shortpath";
        }
        
        public string TranslateToString()
        {
            return "model = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class Mosek : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = false;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return false;
        }

        public void SetDefault()
        {
            Set = true;
            Value = false;
        }
        
        public string TranslateToString()
        {
            return "mosek = " + Value.ToString();
        }
        #endregion
    }
            
    public class NewRank : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = false;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return false;
        }

        public void SetDefault()
        {
            Set = true;
            Value = false;
        }
        
        public string TranslateToString()
        {
            return "newrank = " + Value.ToString();
        }
        #endregion
    }
            
    public class NodeSep : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 0.25;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 0.25;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 0.25;
        }
        
        public double GetMinimum()
        {
            return 0.02;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0.02;
        }
        
        public string TranslateToString()
        {
            return "nodesep = " + Value.ToString();
        }
        #endregion
    }
            
    public class NoJustify : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = false;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return false;
        }

        public void SetDefault()
        {
            Set = true;
            Value = false;
        }
        
        public string TranslateToString()
        {
            return "nojustify = " + Value.ToString();
        }
        #endregion
    }
            
    public class NoTranslate : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = false;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return false;
        }

        public void SetDefault()
        {
            Set = true;
            Value = false;
        }
        
        public string TranslateToString()
        {
            return "notranslate = " + Value.ToString();
        }
        #endregion
    }
            
    public class NSLimit : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string TranslateToString()
        {
            return "nslimit = " + Value.ToString();
        }
        #endregion
    }
            
    public class NSLimit1 : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string TranslateToString()
        {
            return "nslimit1 = " + Value.ToString();
        }
        #endregion
    }
            
    public class Ordering : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "ordering = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class OverlapScaling : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = -4;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return -4;
        }

        public void SetDefault()
        {
            Set = true;
            Value = -4;
        }
        
        public string TranslateToString()
        {
            return "overlap_scaling = " + Value.ToString();
        }
        #endregion
    }
            
    public class OverlapShrink : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = true;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return true;
        }

        public void SetDefault()
        {
            Set = true;
            Value = true;
        }
        
        public string TranslateToString()
        {
            return "overlap_shrink = " + Value.ToString();
        }
        #endregion
    }
            
    public class PenColor : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "DataTypes.Color.X11.black";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "DataTypes.Color.X11.black";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "DataTypes.Color.X11.black";
        }
        
        public string TranslateToString()
        {
            return "pencolor = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class PenWidth : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 1;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 1;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 1;
        }
        
        public double GetMinimum()
        {
            return 0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0;
        }
        
        public string TranslateToString()
        {
            return "penwidth = " + Value.ToString();
        }
        #endregion
    }
            
    public class Peripheries : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private int m_value = 1;
        public int Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public int GetDefault()
        {
            return 1;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 1;
        }
        
        public int GetMinimum()
        {
            return 0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0;
        }
        
        public string TranslateToString()
        {
            return "peripheries = " + Value.ToString();
        }
        #endregion
    }
            
    public class Pin : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = false;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return false;
        }

        public void SetDefault()
        {
            Set = true;
            Value = false;
        }
        
        public string TranslateToString()
        {
            return "pin = " + Value.ToString();
        }
        #endregion
    }
            
    public class Quantum : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 0.0;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 0.0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 0.0;
        }
        
        public double GetMinimum()
        {
            return 0.0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0.0;
        }
        
        public string TranslateToString()
        {
            return "quantum = " + Value.ToString();
        }
        #endregion
    }
            
    public class Regular : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = false;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return false;
        }

        public void SetDefault()
        {
            Set = true;
            Value = false;
        }
        
        public string TranslateToString()
        {
            return "regular = " + Value.ToString();
        }
        #endregion
    }
            
    public class Remincross : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = true;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return true;
        }

        public void SetDefault()
        {
            Set = true;
            Value = true;
        }
        
        public string TranslateToString()
        {
            return "remincross = " + Value.ToString();
        }
        #endregion
    }
            
    public class RepulsiveForce : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 1.0;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 1.0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 1.0;
        }
        
        public double GetMinimum()
        {
            return 0.0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0.0;
        }
        
        public string TranslateToString()
        {
            return "repulsiveforce = " + Value.ToString();
        }
        #endregion
    }
            
    public class Resolution : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string TranslateToString()
        {
            return "resolution = " + Value.ToString();
        }
        #endregion
    }
            
    public class Rotate : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private int m_value = 0;
        public int Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public int GetDefault()
        {
            return 0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 0;
        }
        
        public string TranslateToString()
        {
            return "rotate = " + Value.ToString();
        }
        #endregion
    }
            
    public class Rotation : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 0;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 0;
        }
        
        public string TranslateToString()
        {
            return "rotation = " + Value.ToString();
        }
        #endregion
    }
            
    public class SameHead : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "samehead = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class SameTail : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "sametail = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class SamplePoints : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private int m_value = 8;
        public int Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public int GetDefault()
        {
            return 8;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 8;
        }
        
        public string TranslateToString()
        {
            return "samplepoints = " + Value.ToString();
        }
        #endregion
    }
            
    public class SearchSize : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private int m_value = 30;
        public int Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public int GetDefault()
        {
            return 30;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 30;
        }
        
        public string TranslateToString()
        {
            return "searchsize = " + Value.ToString();
        }
        #endregion
    }
            
    public class Shape : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "ellipse";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "ellipse";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "ellipse";
        }
        
        public string TranslateToString()
        {
            return "shape = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class ShapeFile : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "shapefile = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class ShowBoxes : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private int m_value = 0;
        public int Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public int GetDefault()
        {
            return 0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 0;
        }
        
        public int GetMinimum()
        {
            return 0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0;
        }
        
        public string TranslateToString()
        {
            return "showboxes = " + Value.ToString();
        }
        #endregion
    }
            
    public class Sides : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private int m_value = 4;
        public int Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public int GetDefault()
        {
            return 4;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 4;
        }
        
        public int GetMinimum()
        {
            return 0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0;
        }
        
        public string TranslateToString()
        {
            return "sides = " + Value.ToString();
        }
        #endregion
    }
            
    public class Skew : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 0.0;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 0.0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 0.0;
        }
        
        public double GetMinimum()
        {
            return -100.0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = -100.0;
        }
        
        public string TranslateToString()
        {
            return "skew = " + Value.ToString();
        }
        #endregion
    }
            
    public class Sortv : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private int m_value = 0;
        public int Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public int GetDefault()
        {
            return 0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 0;
        }
        
        public int GetMinimum()
        {
            return 0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0;
        }
        
        public string TranslateToString()
        {
            return "sortv = " + Value.ToString();
        }
        #endregion
    }
            
    public class StyleSheet : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "stylesheet = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class TailClip : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value = true;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public bool GetDefault()
        {
            return true;
        }

        public void SetDefault()
        {
            Set = true;
            Value = true;
        }
        
        public string TranslateToString()
        {
            return "tailclip = " + Value.ToString();
        }
        #endregion
    }
            
    public class Tailhref : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "tailhref = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class TailLabel : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "taillabel = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class TailTarget : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value;
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string TranslateToString()
        {
            return "tailtarget = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class TailToolTip : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "tailtooltip = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class TailURL : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "tailURL = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class Target : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value;
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string TranslateToString()
        {
            return "Target = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class ToolTip : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "tooltip = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class TrueColor : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private bool m_value;
        public bool Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string TranslateToString()
        {
            return "truecolor = " + Value.ToString();
        }
        #endregion
    }
            
    public class url : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value;
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string TranslateToString()
        {
            return "URL = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class VoroMargin : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 0.05;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 0.05;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 0.05;
        }
        
        public double GetMinimum()
        {
            return 0.0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0.0;
        }
        
        public string TranslateToString()
        {
            return "voro_margin = " + Value.ToString();
        }
        #endregion
    }
            
    public class Weight : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 1;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 1;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 1;
        }
        
        public double GetMinimum()
        {
            return 0;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0;
        }
        
        public string TranslateToString()
        {
            return "weight = " + Value.ToString();
        }
        #endregion
    }
            
    public class Width : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 0.75;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 0.75;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 0.75;
        }
        
        public double GetMinimum()
        {
            return 0.01;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0.01;
        }
        
        public string TranslateToString()
        {
            return "width = " + Value.ToString();
        }
        #endregion
    }
            
    public class XDotVersion : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value;
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string TranslateToString()
        {
            return "xdotversion = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class XLabel : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "";
        public string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public string GetDefault()
        {
            return "";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "";
        }
        
        public string TranslateToString()
        {
            return "xlabel = \"" +  Value +  "\"";
        }
        #endregion
    }
        
    public class Z : IAttribute
    {
        #region Properties

        public bool Set { get; set; } = false;
        private double m_value = 0;
        public double Value
        {
            get
            {
                return m_value;
            }
            set
            {
                Set = true;
                m_value = value;
            }
        }
        #endregion  

        #region Member Functions
        public double GetDefault()
        {
            return 0;
        }

        public void SetDefault()
        {
            Set = true;
            Value = 0;
        }
        
        public double GetMinimum()
        {
            return -1000;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = -1000;
        }
        
        public string TranslateToString()
        {
            return "z = " + Value.ToString();
        }
        #endregion
    }
            }