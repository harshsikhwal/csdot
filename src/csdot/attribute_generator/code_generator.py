import json
import os
import shutil

attribute_code = """
using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.DataTypes;

namespace csdot.Attributes.Types
{"""

node_attribute_code = """
using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class NodeAttribute : IDotAttribute
	{"""

cluster_attribute_code = """
using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class ClusterAttribute : IDotAttribute
	{"""

graph_attribute_code = """
using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class GraphAttribute : IDotAttribute
	{"""

subgraph_attribute_code = """
using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class SubgraphAttribute : IDotAttribute
	{"""

edge_attribute_code = """
using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;

namespace csdot.Attributes
{
	public class EdgeAttribute : IDotAttribute
	{"""

if_begin_attr = """
		public string AttributesToString()
		{
			string attribute = "";"""

if_end_attr = """
			return attribute;
		}
	}
}"""


def generate_class(l):
    name = l["name"]
    default = l["default"]
    minimum = l["minimum"]
    type = l["type"]
    class_str = """
    public class {classname} : IAttribute
    {{
        #region Properties

        public bool Set {{ get; set; }} = false;
        """.format(classname=l["class_name"])
    if default == "nil":
        class_str = class_str + r"private {classtype} m_value;".format(classtype=type)
    else:
        if type == "string":
            class_str = class_str + "private {classtype} m_value = \"{classdefault}\";".format(classtype=type,
                                                                                               classdefault=default)
        else:
            class_str = class_str + r"private {classtype} m_value = {classdefault};".format(classtype=type,
                                                                                            classdefault=default)
    class_str = class_str + r"""
        public {classtype} Value
        {{
            get
            {{
                return m_value;
            }}
            set
            {{
                Set = true;
                m_value = value;
            }}
        }}
        #endregion  

        #region Member Functions""".format(classtype=type)
    if default != "nil":
        if type == "string":
            class_str = class_str + """
        public {classtype} GetDefault()
        {{
            return \"{classdefault}\";
        }}

        public void SetDefault()
        {{
            Set = true;
            Value = \"{classdefault}\";
        }}
        """.format(classtype=type, classdefault=default)
        else:
            class_str = class_str + r"""
        public {classtype} GetDefault()
        {{
            return {classdefault};
        }}

        public void SetDefault()
        {{
            Set = true;
            Value = {classdefault};
        }}
        """.format(classtype=type, classdefault=default)
    if minimum != "nil":
        if type == "string":
            class_str = class_str + r"""
        public {classtype} GetMinimum()
        {{
            return \"{classminimum}\";
        }}

        public void SetMinimum()
        {{
            Set = true;
            Value = \"{classminimum}\";
        }}
        """.format(classtype=type, classminimum=minimum)
        else:
            class_str = class_str + r"""
        public {classtype} GetMinimum()
        {{
            return {classminimum};
        }}

        public void SetMinimum()
        {{
            Set = true;
            Value = {classminimum};
        }}
        """.format(classtype=type, classminimum=minimum)
    if type == "string":
        class_str = class_str + r"""
        public {classtype} TranslateToString()
        {{
            return "{classname} = \"" +  Value +  "\"";
        }}

        public void TranslateToValue(string i_value)
        {{
            Value = i_value;
        }}
        #endregion
    }}
        """.format(classtype=type, classname=name)
    else:
        
        if type != "bool":
            class_str = class_str + r"""
        public void TranslateToValue(string i_value)
        {{
            bool converted = {typename}.TryParse(i_value, out {typename} o_intVal);
            if(converted)
                Value = o_intVal;
        }} 
            """.format(typename=type)
        else:
           class_str = class_str + r"""
        public void TranslateToValue(string i_value)
        {{
            if (i_value.ToLower() == "yes" || i_value.ToLower() == "true" || i_value == "0")
                Value = true;
            else if(i_value.ToLower() == "no" || i_value.ToLower() == "false" || i_value == "1")
                Value = false;
            else
                throw new Exception("not a valid bool value");
        }} 
            """.format(typename=type) 
    
        class_str = class_str + r"""
        public string TranslateToString()
        {{
            return "{classname} = " + Value.ToString();
        }}
        #endregion
    }}""".format(classname=name)
    return class_str


if __name__ == '__main__':

    print("Generating Attribute Code")
    json_file = json.load(open("attribute_generator\code_data.json", "r"))
    code_list = json_file["code"]

    graph_class = ""
    node_class = ""
    cluster_class = ""
    # subgraph_class = ""
    edge_class = ""

    graph_if = ""
    node_if = ""
    cluster_if = ""
    # subgraph_if = ""
    edge_if = ""

    graph_traversed = False
    node_traversed = False
    cluster_traversed = False
    subgraph_traversed = False
    edge_traversed = False

    for l in code_list:
        use = l["use"]
        name = l["name"]
        attribute_code = attribute_code + generate_class(l)
        # generate per class
        if "G" in use:
            graph_class = graph_class + """
        public {classname} {name} = new {classname}();""".format(classname=l["class_name"], name=name)
            if graph_traversed:
                graph_if = graph_if + """
            if ({name}.Set)
            {{
                attribute = ("" == attribute) ? attribute + {name}.TranslateToString() : attribute + "\\n" + {name}.TranslateToString();
            }}""".format(name=name)
            else:
                graph_if = graph_if + """
            if ({name}.Set)
            {{
                attribute = attribute + {name}.TranslateToString();
            }}""".format(name=name)
            graph_traversed = True

        if "N" in use:
            node_class = node_class + """
        public {classname} {name} = new {classname}();""".format(classname=l["class_name"], name=name)
            if node_traversed:
                node_if = node_if + """
            if ({name}.Set)
            {{
                attribute = ("" == attribute) ? attribute + " " + {name}.TranslateToString() : attribute + ", " + {name}.TranslateToString();
            }}""".format(name=name)
            else:
                node_if = node_if + """
            if ({name}.Set)
            {{
                attribute = attribute + " " + {name}.TranslateToString();
            }}""".format(name=name)
            node_traversed = True

        if "C" in use:
            cluster_class = cluster_class + """
        public {classname} {name} = new {classname}();""".format(classname=l["class_name"], name=name)
            if cluster_traversed:
                cluster_if = cluster_if + """
            if ({name}.Set)
            {{
                attribute = ("" == attribute) ? attribute + " " + {name}.TranslateToString() : attribute + ", " + {name}.TranslateToString();
            }}""".format(name=name)
            else:
                cluster_if = cluster_if + """
            if ({name}.Set)
            {{
                attribute = attribute + " " + {name}.TranslateToString();
            }}""".format(name=name)
            cluster_traversed = True

        if "E" in use:
            edge_class = edge_class + """
        public {classname} {name} = new {classname}();""".format(classname=l["class_name"], name=name)
            if edge_traversed:
                edge_if = edge_if + """
            if ({name}.Set)
            {{
                attribute = ("" == attribute) ? attribute + " " + {name}.TranslateToString() : attribute + ", " + {name}.TranslateToString();
            }}""".format(name=name)
            else:
                edge_if = edge_if + """
            if ({name}.Set)
            {{
                attribute = attribute + " " + {name}.TranslateToString();
            }}""".format(name=name)
            edge_traversed = True

    # form the specific attribute class

    attribute_code = attribute_code + "\n}"
    node_attribute_code = node_attribute_code + node_class + "\n" + if_begin_attr + node_if + if_end_attr
    # subgraph_attribute_code = subgraph_attribute_code + subgraph_class + "\n" + if_begin_attr + subgraph_if + if_end_attr
    graph_attribute_code = graph_attribute_code + graph_class + "\n" + if_begin_attr + graph_if + if_end_attr
    cluster_attribute_code = cluster_attribute_code + cluster_class + "\n" + if_begin_attr + cluster_if + if_end_attr
    edge_attribute_code = edge_attribute_code + edge_class + "\n" + if_begin_attr + edge_if + if_end_attr

    # Create dirs
    # shutil.rmtree("Attributes")
    # os.makedirs("Attributes\Types")

    # Dump to file
    node_attribute_file = open(".\Attributes\\NodeAttribute.cs", "w")
    node_attribute_file.write(node_attribute_code)

    # subgraph_attribute_file = open("..\Attributes\\SubgraphAttribute.cs", "w")
    # subgraph_attribute_file.write(subgraph_attribute_code)

    graph_attribute_file = open(".\Attributes\\GraphAttribute.cs", "w")
    graph_attribute_file.write(graph_attribute_code)

    cluster_attribute_file = open(".\Attributes\\ClusterAttribute.cs", "w")
    cluster_attribute_file.write(cluster_attribute_code)

    edge_attribute_file = open(".\Attributes\\EdgeAttribute.cs", "w")
    edge_attribute_file.write(edge_attribute_code)

    root_attribute_file = open(".\Attributes\Types\Attribute.cs", "w")
    root_attribute_file.write(attribute_code)

    print("Attribute Code Generated Successfully")

def unused():
        if "S" in use:
            subgraph_class = subgraph_class + """
        public {classname} {name} = new {classname}();""".format(classname=l["class_name"], name=name)
            if subgraph_traversed:
                subgraph_if = subgraph_if + """
            if ({name}.Set)
            {{
                attribute = ("" == attribute) ? attribute + " " + {name}.TranslateToString() : attribute + ", " + {name}.TranslateToString();
            }}""".format(name=name)
            else:
                subgraph_if = subgraph_if + """
            if ({name}.Set)
            {{
                attribute = attribute + " " + {name}.TranslateToString();
            }}""".format(name=name)
            subgraph_traversed = True
            