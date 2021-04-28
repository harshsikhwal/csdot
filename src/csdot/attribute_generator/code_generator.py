#!/usr/bin/python
# -- coding: utf-8 --

import json
import os
import shutil

# start initial cs file code

initial_code = """using System;
using System.Collections.Generic;
using System.Text;
using csdot.Attributes.Types;
"""

attribute_code = initial_code +"""
namespace csdot.Attributes.Types
{"""

node_attribute_code = initial_code +"""
namespace csdot.Attributes
{
	public class NodeAttribute : IDotAttribute
	{
        public Dictionary<string, string> CustomAttribute = new Dictionary<string, string>();"""

cluster_attribute_code = initial_code + """
namespace csdot.Attributes
{
	public class ClusterAttribute : IDotAttribute
	{
        public Dictionary<string, string> CustomAttribute = new Dictionary<string, string>();"""

graph_attribute_code = initial_code + """
namespace csdot.Attributes
{
	public class GraphAttribute : IDotAttribute
	{
        public Dictionary<string, string> CustomAttribute = new Dictionary<string, string>();"""

subgraph_attribute_code = initial_code + """
namespace csdot.Attributes
{
	public class SubgraphAttribute : IDotAttribute
	{
        public Dictionary<string, string> CustomAttribute = new Dictionary<string, string>();"""

edge_attribute_code = initial_code + """
namespace csdot.Attributes
{
    public class EdgeAttribute : IDotAttribute
	{
        public Dictionary<string, string> CustomAttribute = new Dictionary<string, string>();"""

# end initial cs file code

# start AttributesToString() initial code

if_begin_attr = """
		public string AttributesToString()
		{
			string attribute = "";"""

custom_attribute_graph = """
            if(CustomAttribute.Count > 0)
			{
                foreach (KeyValuePair<string, string> entry in CustomAttribute)
                {
                    var attr =  entry.Key + " = \\"" + entry.Value + "\\""; 
                    attribute = ("" == attribute) ? attribute + attr : attribute + "\\n" + attr;
                }
            }"""

custom_attribute_node = """
            if(CustomAttribute.Count > 0)
			{
                foreach (KeyValuePair<string, string> entry in CustomAttribute)
                {
                    var attr =  entry.Key + " = \\"" + entry.Value + "\\"";
                    attribute = ("" == attribute) ? attribute + " " + attr : attribute + ", " + attr;
                }
            }"""


if_end_attr = """
			return attribute;
		}
	}
}"""

# end AttributesToString() initial code

# start generate class, properties and the methods associated

# executed per attribute
def generate_class(l):
    # read from json for every attribute
    class_name = l['class_name']
    name = l["name"]
    default = l["default"]
    minimum = l["minimum"]
    type = l["type"]
    alternate_type = l['alternate_type']

    # class str is the string formed. Will be returned
    class_str = """
    public class {classname} : IAttribute
    {{
    """.format(classname = class_name)

    # str for region properties

    properties_str = """
        #region Properties

        public bool Set { get; set; } = false;
        """

    # str for member function
    function_str = """
        #region Member Functions
    """

    # check for default. Considering the type here.
    # the reason is when adding the alternate type, we might have some issues. So there will be a default_alternate attribute later
    if default == "nil":
        # initialize property and not the function
        if alternate_type == "List" or "List" in type:
            properties_str = properties_str + r"private List<{classtype}> m_value = new List<{classtype}>();".format(classtype=type)
        else:
            properties_str = properties_str + r"private {classtype} m_value;".format(classtype=type)
    else:
        if type == "string":
            # if string then enclose the same in ""
            if alternate_type == "List" or "List" in type:
                properties_str = properties_str + "private List<{classtype}> m_value = new List<{classtype}>() {{ \"{classdefault}\" }} ;".format(classtype=type, classdefault=default)
            else:
                properties_str = properties_str + "private {classtype} m_value = \"{classdefault}\";".format(classtype=type, classdefault=default)
            # generate the specific function str
            function_str = function_str + """
        public {classtype} GetDefault()
        {{
            return "{classdefault}";
        }}

        public void SetDefault()
        {{
            Set = true;
            Value = \"{classdefault}\";
        }}
        """.format(classtype=type, classdefault=default)
        else:
            # if not string then put the same value
            if alternate_type == "List" or "List" in type:
                properties_str = properties_str + r"private List<{classtype}> m_value = new List<{classtype}>( {classdefault} );".format(classtype=type, classdefault=default)
            else:
                properties_str = properties_str + r"private {classtype} m_value = {classdefault};".format(classtype=type,
                                                                                            classdefault=default)
            # generate the specific function str
            function_str = function_str + r"""
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

    # for minimum there is not property, just the function.
    # this minimum is just for the type. alternative_minimum will follow up.
    if minimum != "nil":
        if type == "string":
            function_str = function_str + r"""
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
            function_str = function_str + r"""
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

    # Alternate adder
    # this is only list. For instance color attribute will have color and colorList. So alternate will be just List
    if alternate_type == "List":
        properties_str = properties_str + r"""
        public {classtype} Value
        {{
            get
            {{
                return m_value[0];
            }}
            set
            {{
                Set = true;
                m_value.Clear();
                m_value.Add(value);
            }}
        }}

        public List<{classtype}> ValueList
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
        """.format(classtype = type)
    elif alternate_type != "":
        # add code here for the secondary type as well as first type
        pass
    else:
        # here alternate_type is null so we can just add type
        properties_str = properties_str + r"""
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
        """.format(classtype=type)
        
    # string translation to and from method:

    if type == "string":
        if alternate_type == "List":
            function_str = function_str + r"""
        public string TranslateToString()
        {{
    	    var valueBuilder = "";
            if(ValueList.Count == 0)
        	    return valueBuilder;
            int i;
            for(i = 0; i <= ValueList.Count-2; i++)
        	    valueBuilder = valueBuilder + ValueList[i] + ", ";
            valueBuilder = valueBuilder + ValueList[i];
            return "{classname} = \"" +  valueBuilder +  "\"";
        }}

        public void TranslateToValue(string i_value)
        {{
            Value = i_value;
        }}
        #endregion
    }}
        """.format(classname=name)
        else:
            function_str = function_str + r"""
        public string TranslateToString()
        {{
            return "{classname} = \"" +  Value +  "\"";
        }}

        public void TranslateToValue(string i_value)
        {{
            Value = i_value;
        }}
        #endregion
    }}
        """.format(classname=name)
    else:
        
        if type != "bool":
            function_str = function_str + r"""
        public void TranslateToValue(string i_value)
        {{
            bool converted = {typename}.TryParse(i_value, out {typename} o_intVal);
            if(converted)
                Value = o_intVal;
        }} 
            """.format(typename=type)
        else:
           function_str = function_str + r"""
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
            
        if alternate_type == "List":
            function_str = function_str + r"""
        public string TranslateToString()
        {{
    	    var valueBuilder = "";
            if(ValueList.Count == 0)
        	    return valueBuilder;
            int i;
            for(i = 0; i <= ValueList.Count-2; i++)
        	    valueBuilder = valueBuilder + ValueList[i].ToString() + ", ";
            valueBuilder = valueBuilder + ValueList[i];
            return "{classname} = \"" +  valueBuilder +  "\"";
        }}
        #endregion
    }}""".format(classname=name)
        else:
            function_str = function_str + r"""
        public string TranslateToString()
        {{
            return "{classname} = " + Value.ToString();
        }}
        #endregion
    }}""".format(classname=name)
    return class_str + properties_str + function_str

# end generate class, properties and the methods associated


if __name__ == '__main__':

    print("Generating Attribute Code")
    json_file = json.load(open("attribute_generator\code_data.json", "r"))
    code_list = json_file["code"]

    graph_class = ""
    node_class = ""
    cluster_class = ""
    subgraph_class = ""
    edge_class = ""

    graph_if = ""
    node_if = ""
    cluster_if = ""
    subgraph_if = ""
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
                attribute = ("" == attribute) ? attribute + {name}.TranslateToString() : attribute + "\\n" + {name}.TranslateToString();
            }}""".format(name=name)
            else:
                cluster_if = cluster_if + """
            if ({name}.Set)
            {{
                attribute = attribute + {name}.TranslateToString();
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
        if "S" in use or "G" in use:
            subgraph_class = subgraph_class + """
        public {classname} {name} = new {classname}();""".format(classname=l["class_name"], name=name)
            if subgraph_traversed:
                subgraph_if = subgraph_if + """
            if ({name}.Set)
            {{
                attribute = ("" == attribute) ? attribute + {name}.TranslateToString() : attribute + "\\n" + {name}.TranslateToString();
            }}""".format(name=name)
            else:
                subgraph_if = subgraph_if + """
            if ({name}.Set)
            {{
                attribute = attribute + {name}.TranslateToString();
            }}""".format(name=name)
            subgraph_traversed = True

    # form the specific attribute class

    attribute_code = attribute_code + "\n}"
    node_attribute_code = node_attribute_code + node_class + "\n" + if_begin_attr + node_if + custom_attribute_node + if_end_attr
    subgraph_attribute_code = subgraph_attribute_code + subgraph_class + "\n" + if_begin_attr + subgraph_if + custom_attribute_node + if_end_attr
    graph_attribute_code = graph_attribute_code + graph_class + "\n" + if_begin_attr + graph_if + custom_attribute_node + if_end_attr
    cluster_attribute_code = cluster_attribute_code + cluster_class + "\n" + if_begin_attr + cluster_if + custom_attribute_graph + if_end_attr
    edge_attribute_code = edge_attribute_code + edge_class + "\n" + if_begin_attr + edge_if + custom_attribute_node + if_end_attr

    # Create dirs
    # shutil.rmtree("Attributes")
    # os.makedirs("Attributes\Types")

    # Dump to file
    node_attribute_file = open(".\Attributes\\NodeAttribute.cs", "w")
    node_attribute_file.write(node_attribute_code)

    subgraph_attribute_file = open(".\Attributes\\SubgraphAttribute.cs", "w")
    subgraph_attribute_file.write(subgraph_attribute_code)

    graph_attribute_file = open(".\Attributes\\GraphAttribute.cs", "w")
    graph_attribute_file.write(graph_attribute_code)

    cluster_attribute_file = open(".\Attributes\\ClusterAttribute.cs", "w")
    cluster_attribute_file.write(cluster_attribute_code)

    edge_attribute_file = open(".\Attributes\\EdgeAttribute.cs", "w")
    edge_attribute_file.write(edge_attribute_code)

    root_attribute_file = open(".\Attributes\Types\Attribute.cs", "w")
    root_attribute_file.write(attribute_code)

    print("Attribute Code Generated Successfully")

            