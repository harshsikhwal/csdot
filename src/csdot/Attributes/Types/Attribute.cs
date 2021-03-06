using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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
        private string m_value = "normal";
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
            return "normal";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "normal";
        }
        
        public string TranslateToString()
        {
            return "arrowhead = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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
        private string m_value = "normal";
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
            return "normal";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "normal";
        }
        
        public string TranslateToString()
        {
            return "arrowtail = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
        }
        #endregion
    }
        
    public class BB : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private DataTypes.Rect m_value;
        public DataTypes.Rect Value
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = DataTypes.Rect.TryParse(i_value, out DataTypes.Rect o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "bb = " + Value.ToString();
        }
        #endregion
    }
    public class BGColor : IAttribute
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
            return "bgcolor = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
        } 
            
        public string TranslateToString()
        {
            return "center = " + Value.ToString();
        }
        #endregion
    }
    public class Charset : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "UTF-8";
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
            return "UTF-8";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "UTF-8";
        }
        
        public string TranslateToString()
        {
            return "charset = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
        }
        #endregion
    }
        
    public class _Class : IAttribute
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
            return "_class = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
        }
        #endregion
    }
        
    public class ClusterRank : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "local";
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
            return "local";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "local";
        }
        
        public string TranslateToString()
        {
            return "clusterrank = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
        }
        #endregion
    }
        
    public class Color : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "black";
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
            return "black";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "black";
        }
        
        public string TranslateToString()
        {
            return "color = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
        }
        #endregion
    }
        
    public class _Comment : IAttribute
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
            return "comment = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = int.TryParse(i_value, out int o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = int.TryParse(i_value, out int o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "dimen = " + Value.ToString();
        }
        #endregion
    }
    public class Dir : IAttribute
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
            return "dir = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
        }
        #endregion
    }
        
    public class DirEdgeConstraints : IAttribute
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
        } 
            
        public string TranslateToString()
        {
            return "diredgeconstraints = " + Value.ToString();
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
        }
        #endregion
    }
        
    public class Epsilon : IAttribute
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "epsilon = " + Value.ToString();
        }
        #endregion
    }
    public class FillColor : IAttribute
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
            return "fillcolor = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
        }
        #endregion
    }
        
    public class FixedSize : IAttribute
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
        } 
            
        public string TranslateToString()
        {
            return "fixedsize = " + Value.ToString();
        }
        #endregion
    }
    public class FontColor : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "black";
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
            return "black";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "black";
        }
        
        public string TranslateToString()
        {
            return "fontcolor = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
        }
        #endregion
    }
        
    public class FontPath : IAttribute
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
            return "fontpath = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = int.TryParse(i_value, out int o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
        }
        #endregion
    }
        
    public class HeadLP : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private DataTypes.point m_value;
        public DataTypes.point Value
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = DataTypes.point.TryParse(i_value, out DataTypes.point o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "head_lp = " + Value.ToString();
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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
            return "label = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = int.TryParse(i_value, out int o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
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
        private string m_value = "black";
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
            return "black";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "black";
        }
        
        public string TranslateToString()
        {
            return "labelfontcolor = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
        }
        #endregion
    }
        
    public class LabelLoc : IAttribute
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
            return "labelloc = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = int.TryParse(i_value, out int o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "lheight = " + Value.ToString();
        }
        #endregion
    }
    public class LP : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private DataTypes.point m_value;
        public DataTypes.point Value
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = DataTypes.point.TryParse(i_value, out DataTypes.point o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "lp = " + Value.ToString();
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "lwidth = " + Value.ToString();
        }
        #endregion
    }
    public class Margin : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private DataTypes.point m_value;
        public DataTypes.point Value
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = DataTypes.point.TryParse(i_value, out DataTypes.point o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "margin = " + Value.ToString();
        }
        #endregion
    }
    public class Maxiter : IAttribute
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = int.TryParse(i_value, out int o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "maxiter = " + Value.ToString();
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = int.TryParse(i_value, out int o_intVal);
            if(converted)
                Value = o_intVal;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
        }
        #endregion
    }
        
    public class OutputOrder : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "breadthfirst";
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
            return "breadthfirst";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "breadthfirst";
        }
        
        public string TranslateToString()
        {
            return "outputorder = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
        }
        #endregion
    }
        
    public class Overlap : IAttribute
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
        } 
            
        public string TranslateToString()
        {
            return "overlap = " + Value.ToString();
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
        } 
            
        public string TranslateToString()
        {
            return "overlap_shrink = " + Value.ToString();
        }
        #endregion
    }
    public class Pack : IAttribute
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
        } 
            
        public string TranslateToString()
        {
            return "pack = " + Value.ToString();
        }
        #endregion
    }
    public class PackMode : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "node";
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
            return "node";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "node";
        }
        
        public string TranslateToString()
        {
            return "packmode = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
        }
        #endregion
    }
        
    public class PenColor : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "black";
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
            return "black";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "black";
        }
        
        public string TranslateToString()
        {
            return "pencolor = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = int.TryParse(i_value, out int o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
        } 
            
        public string TranslateToString()
        {
            return "pin = " + Value.ToString();
        }
        #endregion
    }
    public class Pos : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private DataTypes.point m_value;
        public DataTypes.point Value
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = DataTypes.point.TryParse(i_value, out DataTypes.point o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "pos = " + Value.ToString();
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "quantum = " + Value.ToString();
        }
        #endregion
    }
    public class Rank : IAttribute
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
            return "rank = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
        }
        #endregion
    }
        
    public class RankDir : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "TB";
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
            return "TB";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "TB";
        }
        
        public string TranslateToString()
        {
            return "rankdir = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
        }
        #endregion
    }
        
    public class RankSep : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private List<double> m_value = new List<double>();
        public double Value
        {
            get
            {
                return m_value[0];
            }
            set
            {
                Set = true;
                m_value.Clear();
                m_value.Add(value);
            }
        }

        public List<double> ValueList
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
            return 0.02;
        }

        public void SetMinimum()
        {
            Set = true;
            Value = 0.02;
        }
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
    	    var valueBuilder = "";
            if(ValueList.Count == 0)
        	    return valueBuilder;
            int i;
            for(i = 0; i <= ValueList.Count-2; i++)
        	    valueBuilder = valueBuilder + ValueList[i].ToString() + ", ";
            valueBuilder = valueBuilder + ValueList[i];
            return "ranksep = \"" +  valueBuilder +  "\"";
        }
        #endregion
    }
    public class Rects : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private DataTypes.Rect m_value;
        public DataTypes.Rect Value
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = DataTypes.Rect.TryParse(i_value, out DataTypes.Rect o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "rects = " + Value.ToString();
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "resolution = " + Value.ToString();
        }
        #endregion
    }
    public class Root : IAttribute
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
    
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
        } 
            
        public string TranslateToString()
        {
            return "root = " + Value.ToString();
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = int.TryParse(i_value, out int o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = int.TryParse(i_value, out int o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "samplepoints = " + Value.ToString();
        }
        #endregion
    }
    public class Scale : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private DataTypes.point m_value;
        public DataTypes.point Value
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = DataTypes.point.TryParse(i_value, out DataTypes.point o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "scale = " + Value.ToString();
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = int.TryParse(i_value, out int o_intVal);
            if(converted)
                Value = o_intVal;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = int.TryParse(i_value, out int o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = int.TryParse(i_value, out int o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "skew = " + Value.ToString();
        }
        #endregion
    }
    public class Smoothing : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private string m_value = "none";
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
            return "none";
        }

        public void SetDefault()
        {
            Set = true;
            Value = "none";
        }
        
        public string TranslateToString()
        {
            return "smoothing = \"" +  Value +  "\"";
        }

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = int.TryParse(i_value, out int o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "sortv = " + Value.ToString();
        }
        #endregion
    }
    public class SPLines : IAttribute
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
    
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
        } 
            
        public string TranslateToString()
        {
            return "splines = " + Value.ToString();
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
        }
        #endregion
    }
        
    public class TailLP : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private DataTypes.point m_value;
        public DataTypes.point Value
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = DataTypes.point.TryParse(i_value, out DataTypes.point o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "tail_lp = " + Value.ToString();
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
        
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
    
        public void TranslateToValue(string i_value)
        {
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
        } 
            
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
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

        public void TranslateToValue(string i_value)
        {
            Value = i_value;
        }
        #endregion
    }
        
    public class XLP : IAttribute
    {
    
        #region Properties

        public bool Set { get; set; } = false;
        private DataTypes.point m_value;
        public DataTypes.point Value
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
    
        public void TranslateToValue(string i_value)
        {
            bool converted = DataTypes.point.TryParse(i_value, out DataTypes.point o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "xlp = " + Value.ToString();
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
        
        public void TranslateToValue(string i_value)
        {
            bool converted = double.TryParse(i_value, out double o_intVal);
            if(converted)
                Value = o_intVal;
        } 
            
        public string TranslateToString()
        {
            return "z = " + Value.ToString();
        }
        #endregion
    }
}