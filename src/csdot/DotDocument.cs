using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using csdot.Attributes.DataTypes;

namespace csdot
{
    public class DotDocument
    {
        #region Methods

        #region LoadDigraph


        public Graph LoadDigraph(string i_fileLocation)
        {
            #region NewImplementaion

            Graph loadedGraph = null;

            if (!File.Exists(i_fileLocation))
                throw new FileNotFoundException($"The localtion {i_fileLocation} is not accessible");

            string dotFile = File.ReadAllText(i_fileLocation, Encoding.UTF8);
            dotFile = GetRefactoredContent(dotFile);
            string[] dotTokens = dotFile.Split(' ');
            dotTokens = dotTokens.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            dotTokens = dotTokens.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

            if (!dotTokens.Contains("graph") && !dotTokens.Contains("digraph"))
                throw new Exception("graph/digraph keyword should be present for a valid dot file");

            Dictionary<string, List<int>> codeBlocks= GetCodeBlocks(dotTokens);
            loadedGraph = ParseGraph(loadedGraph, dotTokens, codeBlocks) as Graph;

            return loadedGraph;

            #endregion

            #region OldImplementattion
            /*
            if (!File.Exists(i_fileLocation))
            {
                //File does not exist
                return -1;
            }
            CultureInfo ci;
            ci = new CultureInfo("en-US");
            string dotFile = File.ReadAllText(i_fileLocation, Encoding.UTF8);
            //2nd Pass, need to implement 1st Pass
            dotFile = dotFile.Replace(";", " ; ");
            dotFile = dotFile.Replace(",", " , ");
            dotFile = dotFile.Replace("=", " ");
            dotFile = dotFile.Replace("\"", " ");
            dotFile = dotFile.Replace("[", " [ ");
            dotFile = dotFile.Replace("]", " ] ");
            dotFile = dotFile.Replace("(", " ");
            dotFile = dotFile.Replace(")", " ");
            dotFile = dotFile.Replace("\n", " \n ");
            dotFile = dotFile.Replace("{", " { ");
            dotFile = dotFile.Replace("}", " } ");
            string[] dotFileSplitTemp = dotFile.Split(' ');
            string[] dotFileSplit = new string[dotFileSplitTemp.Length];
            int j = 0;
            for (int i = 0; i < dotFileSplitTemp.Length; i++)
            {
                if (dotFileSplitTemp[i].Length >= 1)
                {
                    dotFileSplit[j++] = dotFileSplitTemp[i];
                }
            }
            var length = j;
            for (int i = 0; i < length; i++)
            {
                if (dotFileSplit[i].Equals("}"))
                {
                    break;
                }
                else if (dotFileSplit[i].Equals("digraph"))
                {
                    this.m_name = dotFileSplit[i + 1];
                    i++;
                }
                else if (dotFileSplit[i].Equals("{"))
                {
                    continue;
                }
                else if (dotFileSplit[i].Equals("["))
                {
                    DotNode n = new DotNode(dotFileSplit[i - 1]);
                    i++;
                    DotAttribute a = new DotAttribute();
                    List<string> dotLabelList = new List<string>();
                    string tempstr = "";
                    while (i != length)
                    {
                        if (dotFileSplit[i].Equals("]"))
                        {
                            break;
                        }
                        else if (dotFileSplit[i].Equals("\n") || dotFileSplit[i].Equals(","))
                        {
                            //i++;
                        }
                        else if (dotFileSplit[i].Equals("shape"))
                        {
                            a.Shape = dotFileSplit[i + 1];
                            i++;
                        }
                        else if (dotFileSplit[i].Equals("color"))
                        {
                            a.Color = dotFileSplit[i + 1];
                            i++;
                        }
                        else if (dotFileSplit[i].Equals("label"))
                        {
                            i++;
                            tempstr = "";
                            while (true)
                            {
                                if (dotFileSplit[i].Equals("]"))
                                {
                                    i--;
                                    break;
                                }
                                else if (dotFileSplit[i].Equals(","))
                                {
                                    if ((dotFileSplit[i + 1].Equals("color") || dotFileSplit[i + 1].Equals("shape")))
                                    {
                                        break;
                                    }
                                }
                                else if (dotFileSplit[i].Equals(n.Name))
                                {
                                    a.Label = dotFileSplit[i];
                                }
                                else if (dotFileSplit[i].Equals("\n"))
                                {
                                    //do nothing
                                }
                                else if (dotFileSplit[i].Equals(";"))
                                {
                                    a.AddLabelAsInLabelList(tempstr);
                                    tempstr = "";
                                }
                                else
                                {
                                    if (tempstr == "")
                                    {
                                        tempstr = dotFileSplit[i];
                                    }
                                    else
                                    {
                                        tempstr += dotFileSplit[i];
                                    }

                                    //dotLabelList.Add(dotFileSplit[i]);
                                }
                                i++;
                            }
                            if (tempstr != "")
                            {
                                a.AddLabelAsInLabelList(tempstr);
                            }
                        }
                        i++;
                    }
                    n.SetAttribute(a);
                    this.AddNode(n);
                }

                else if (dotFileSplit[i].Equals("->"))
                {
                    DotTransition t = new DotTransition(dotFileSplit[i - 1], dotFileSplit[i + 1]);
                    i += 2;
                    if (dotFileSplit[i].Equals("["))
                    {
                        i++;
                        DotAttribute a = new DotAttribute();
                        List<string> dotLabelList = new List<string>();
                        string tempstr = "";
                        while (i != length)
                        {
                            if (dotFileSplit[i].Equals("]"))
                            {
                                i--;
                                break;
                            }
                            if (dotFileSplit[i].Equals("shape"))
                            {
                                a.Shape = dotFileSplit[i + 1];
                                i += 2;
                            }
                            if (dotFileSplit[i].Equals("color"))
                            {
                                a.Color = dotFileSplit[i + 1];
                                i += 2;
                            }
                            else if (dotFileSplit[i].Equals("label"))
                            {
                                i++;
                                tempstr = "";
                                while (true)
                                {
                                    if (dotFileSplit[i].Equals("]"))
                                    {
                                        break;
                                    }
                                    else if (dotFileSplit[i].Equals(","))
                                    {
                                        if ((dotFileSplit[i + 1].Equals("color") || dotFileSplit[i + 1].Equals("shape")))
                                        {
                                            break;
                                        }
                                    }
                                    else if (dotFileSplit[i].Equals("\n"))
                                    {
                                        //do nothing 
                                    }
                                    else if (dotFileSplit[i].Equals(";"))
                                    {
                                        a.AddLabelAsInLabelList(tempstr);
                                        tempstr = "";
                                    }
                                    else
                                    {
                                        if (tempstr == "")
                                        {
                                            tempstr = dotFileSplit[i];
                                        }
                                        else
                                        {
                                            tempstr += ", " + dotFileSplit[i];
                                        }
                                    }
                                    i++;
                                }
                                if (tempstr != "")
                                {
                                    a.AddLabelAsInLabelList(tempstr);
                                }
                            }
                            if (dotFileSplit[i].Equals("\n") || dotFileSplit[i].Equals(","))
                            {
                                i++;
                            }
                        }
                        t.SetAttribute(a);
                        this.AddTransition(t);
                    }
                }
            }
            
            return 0;*/
            #endregion

        }

        #endregion

        #region SaveToFile

        public void SaveToFile(Graph i_graph, string i_fileLocation)
        {

            if (File.Exists(i_fileLocation))
            {
                File.Delete(i_fileLocation);
            }
            using (StreamWriter sw = File.CreateText(i_fileLocation))
            {

            }
            File.WriteAllText(i_fileLocation, i_graph.ElementToString(1));
        }


        #endregion //SaveToFile

        #region CloneToFile
        /*
        public int CloneToFile(string i_srcFile, string i_dstFile)
        {
            /*
            if (!File.Exists(i_srcFile))
            {
                return -1;
            }
            Digraph di = new Digraph();
            di.LoadDigraph(i_srcFile);
            di.SaveToFile(i_dstFile);
            
            return 0;
        }
        */

        #endregion  //CloneToFile

        #endregion  //Methods

        #region Utility Methods

        private IElement ParseGraph(IElement i_graph, string[] i_dotTokens, Dictionary<string, List<int>> i_codeBlocks, int i_startIndex = 0, int i_endIndex = 0)
        {
            Stack<string> paranthesis = new Stack<string>();
            i_endIndex = i_endIndex == 0 ? i_dotTokens.Length : i_endIndex;
            bool grapghFound = false;
            for (int i = i_startIndex; i < i_endIndex; i++)
            {
                // forming Graph
                if ((i_dotTokens[i] == "graph" || i_dotTokens[i] == "digraph") && !grapghFound)
                {
                    bool strict = false;
                    string name = "";
                    string graphType = i_dotTokens[i] == "graph" ? "graph" : "digraph";
                    if (i != 0 && i_dotTokens[i - 1] == "strict")
                        strict = true;
                    if (i_dotTokens[i + 1] != "{")
                    {
                        name = i_dotTokens[i + 1];
                        i += 1;
                    }
                    i_graph = GetGraph(strict, name, graphType);
                    grapghFound = true;
                }

                //forming subgraphs or clusters with no keywords
                if (i_dotTokens[i] == "{")
                {
                    if (paranthesis.Count == 0)
                        paranthesis.Push("{");
                    else
                    {
                        // it means there is a cluster or subgrapgh
                        paranthesis.Push("{");
                        IDot subgraphOrCluster = GetSubgraphOrCluster(i_dotTokens, i_codeBlocks, i, out int endIndex);
                        i_graph.AddElement(subgraphOrCluster);
                        i = endIndex;
                    }
                }

                //forming subgraphs or clusters with keywords
                if (i_dotTokens[i].ToLower() == "subgraph" || i_dotTokens[i].ToLower().Contains("cluster"))
                {
                    // it means there is a cluster or subgrapgh
                    
                    // this check is if the word subgraph is present between any quotes
                    paranthesis.Push("{");
                    int index = Array.IndexOf(i_dotTokens, "{", i);
                    if (index != -1)
                    {
                        IDot subgraphOrCluster = GetSubgraphOrCluster(i_dotTokens, i_codeBlocks, index, out int endIndex);
                        i_graph.AddElement(subgraphOrCluster);
                        i = endIndex;
                    }
                }

                //forming graph properties
                if (i_dotTokens[i] == "=")
                {
                    string att;
                    string value;
                    if (i_dotTokens[i - 1] == "\"")
                        att = GetString(i_dotTokens, i - 1, "rev", out int endIndex);
                    else
                        att = i_dotTokens[i - 1];
                    if (i_dotTokens[i + 1] == "\"")
                    {
                        value = GetString(i_dotTokens, i + 1, "front", out int end);
                        i = end;
                    }
                    else
                    {
                        value = i_dotTokens[i + 1];
                        i += 1;
                    }
                    if (i_graph.attributes.TryGetValue(att, out var attribute))
                        attribute.TranslateToValue(value);
                    else
                        throw new Exception($"{att} attribute is not valid or not supported for Graph");
                }
                
                //forming Nodes
                if (i + 1 < i_dotTokens.Length && i_dotTokens[i + 1] == "[")
                {
                    List<string> nodeProperties = GetProperties(i_dotTokens, i + 1, out int endIndex);
                    Node newNode = GetNode(i_dotTokens[i], nodeProperties);
                    i_graph.AddElement(newNode);
                    i = endIndex;
                }

                //forming Nondes with no properties
                if ( (i-1 > 0 && i_dotTokens[i-1] == "{") || 
                     (i-1 > 0 && i_dotTokens[i-1] != "=" && i_dotTokens[i - 1] != "]" && i_dotTokens[i - 1] != "->" && i_dotTokens[i - 1] != "--"))
                {

                    if (i_dotTokens[i] != "[" && i_dotTokens[i] != "]" && i_dotTokens[i] != "{" && i_dotTokens[i] != "}" && i_dotTokens[i] != "->" && i_dotTokens[i] != "--"
                        && i_dotTokens[i] != ";" && i_dotTokens[i] != "," && i_dotTokens[i] != "\"")
                    {
                        if (i + 1 < i_dotTokens.Length && (i_dotTokens[i + 1] == ";" ||
                            (i_dotTokens[i + 1] != "=" && i_dotTokens[i + 1] != "[" && i_dotTokens[i + 1] != "->" && i_dotTokens[i + 1] != "--")))
                        {
                            if ( i_dotTokens[i + 1] == "\"" && (i_dotTokens[i + 2] == "=" && i_dotTokens[i + 2] == "[" && i_dotTokens[i + 2] == "->" && i_dotTokens[i + 2] != "--"
                                && i_dotTokens[i + 2] == "]"))
                            {
                                // do nothing
                            }
                            else
                            {
                                Node newNode = GetNode(i_dotTokens[i], null);
                                i_graph.AddElement(newNode);
                                if (i_dotTokens[i + 1] == ";")
                                    i += 1;
                            }
                        }
                    }
                }

                //forming edges
                if (i_dotTokens[i] == "->" || i_dotTokens[i] == "--")
                {
                    List<Transition> transitions = GetTransitions(i_dotTokens, i_codeBlocks, i, i_graph, out int endIndex);
                    List<string> properties = null;
                    int index = endIndex;
                    if (index + 1 < i_dotTokens.Length && i_dotTokens[index + 1] == "[")
                    {
                        properties = GetProperties(i_dotTokens, index + 1, out int outIndex);
                        index = outIndex;
                    }
                    Edge newEdge = GetEdge(transitions, properties);
                    i_graph.AddElement(newEdge);
                    i = index;
                }

                //for parathesis checking
                if (i_dotTokens[i] == "}")
                {
                    if (paranthesis.Peek() == "{")
                        paranthesis.Pop();
                }

            }
            if (paranthesis.Count != 0)
                throw new Exception($"Error in parsing the file has unbalanced parenthesis");
            return i_graph;
        }
        
        private string GetRefactoredContent(string i_dotFile)
        {
            i_dotFile = i_dotFile.Replace(";", " ; ");
            i_dotFile = i_dotFile.Replace("\t", "");
            i_dotFile = i_dotFile.Replace("\r", "");
            i_dotFile = i_dotFile.Replace(",", " , ");
            i_dotFile = i_dotFile.Replace("=", " = ");
            i_dotFile = i_dotFile.Replace("\"", " \" ");
            i_dotFile = i_dotFile.Replace("[", " [ ");
            i_dotFile = i_dotFile.Replace("]", " ] ");
            //i_dotFile = i_dotFile.Replace("(", " ");
            //i_dotFile = i_dotFile.Replace(")", " ");
            i_dotFile = i_dotFile.Replace("\n", " ");
            i_dotFile = i_dotFile.Replace("{", " { ");
            i_dotFile = i_dotFile.Replace("}", " } ");
            return i_dotFile;
        }

        private Dictionary<string,List<int>> GetCodeBlocks(string[] i_dotTokens)
        {
            Dictionary<string, List<int>> codeBlocks = new Dictionary<string, List<int>>()
            {
                { "{", new List<int>() },
            };
            Stack<int> indices = new Stack<int>();
            Stack<string> braces = new Stack<string>();
            
            //storing indices of all curly braces
            for(int i =0; i< i_dotTokens.Length; i++)
            {
                if (i_dotTokens[i] == "{")
                {
                    codeBlocks["{"].Add(i);
                }
            }
            List<int> closingIndices = new List<int>(codeBlocks["{"].Count);
            closingIndices.AddRange(Enumerable.Repeat(0, codeBlocks["{"].Count));
            //deciding ending braces for each
            for (int i = 0; i < i_dotTokens.Length; i++)
            {
                if (i_dotTokens[i] == "{")
                {
                    braces.Push("{");
                    indices.Push(i);
                }
                else if (i_dotTokens[i] == "}")
                {
                    if (braces.Peek() == "{")
                    {
                        braces.Pop();
                        int index = codeBlocks["{"].IndexOf(indices.Pop());
                        if (index != -1)
                            closingIndices[index] = i;
                        else
                            throw new Exception("somehow indices were not found bug in parsing");
                    }
                    else
                        throw new Exception("braces dont match please check the file");
                }
            }
            codeBlocks["}"] = closingIndices;
            return codeBlocks;
        }
        
        private Graph GetGraph(bool i_strict, string i_name, string i_type)
        {
            Graph newGraph = i_name == "" ? new Graph() : new Graph(i_name);
            newGraph.strict = i_strict;
            newGraph.type = i_type;
            return newGraph;
        }

        private Node GetNode(string i_name, List<string> i_properties)
        {
            Node newNode = new Node(i_name);
            if (null != i_properties)
            {
                for (int i = 0; i < i_properties.Count; i += 2)
                {
                    if (newNode.attributes.TryGetValue(i_properties[i], out var attribute))
                        attribute.TranslateToValue(i_properties[i + 1]);
                    else
                        throw new Exception($"{i_properties[i]} attribute is not valid or not supported for Node");
                }
            }
            return newNode;
        }

        private Edge GetEdge(List<Transition> i_transitions, List<string> i_properties)
        {
            Edge newEdge = new Edge(i_transitions);
            if (null != i_properties)
            {
                for (int i = 0; i < i_properties.Count; i += 2)
                {
                    if (newEdge.attributes.TryGetValue(i_properties[i], out var attribute))
                        attribute.TranslateToValue(i_properties[i + 1]);
                    else
                        throw new Exception($"{i_properties[i]} attribute is not valid or not supported for Edge");
                }
            }
            return newEdge;
        }

        private List<string> GetProperties(string[] i_dotTokens, int i_startIndex, out int o_endIndex)
        {
            List<string> properties = new List<string>();
            int i = i_startIndex;
            while (i_dotTokens[i] != "]")
            {
                if (i_dotTokens[i] == "=")
                {
                    if (i_dotTokens[i - 1] == "\"")
                        properties.Add(GetString(i_dotTokens, i - 1, "rev", out int endIndex));
                    else
                        properties.Add(i_dotTokens[i - 1]);
                    if (i_dotTokens[i + 1] == "\"")
                        properties.Add(GetString(i_dotTokens, i + 1, "front", out int endIndex));
                    else
                        properties.Add(i_dotTokens[i + 1]);
                }
                i++;
            }
            o_endIndex = i;
            return properties;
        }

        private string GetString(string[] i_dotTokens, int i_startIndex, string i_direction, out int o_endIndex)
        {
            string properties = "";
            int i = 0;
            if (i_direction == "front")
            {
                i = i_startIndex + 1;
                while (i_dotTokens[i] != "\"")
                {
                    properties += i_dotTokens[i] + " ";
                    i++;
                }
            }
            else if (i_direction == "rev")
            {
                i = i_startIndex - 1;
                while (i_dotTokens[i] != "\"")
                {
                    properties += i_dotTokens[i] + " ";
                    i--;
                }
            }
            o_endIndex = i;
            return properties.Trim();
        }

        private List<Transition> GetTransitions(string[] i_dotTokens, Dictionary<string, List<int>> i_codeBlocks, int i_stratIndex, IElement i_graph, out int o_endIndex)
        {
            List<Transition> transtions = new List<Transition>();
            int i = i_stratIndex - 1;
            while (true)
            {
                if (i + 1 >= i_dotTokens.Length)
                    break;

                // checking if there is a continuos chain of edges
                if (i_dotTokens[i + 1] == "->" || i_dotTokens[i + 1] == "--")
                {
                    Node node;
                    string edgeType = "";
                    if (i_dotTokens[i + 1] == "->")
                        edgeType = EdgeOp.directed;
                    if (i_dotTokens[i + 1] == "--")
                        edgeType = EdgeOp.undirected;
                    node = i_graph.GetElementByName(i_dotTokens[i]) as Node;
                    if (null == node)
                    {
                        node = new Node(i_dotTokens[i]);
                    }
                    transtions.Add(new Transition(node, edgeType));
                    i += 2;
                }
                else if (i_dotTokens[i].ToLower() == "subgraph" || i_dotTokens[i] == "{" || i_dotTokens[i + 1] == "{")
                {
                    // will be a subgraph not mplemented till yet
                    int startIndex = -1;
                    int endIndex = -1;
                    bool hasId = false;
                    IDot element;
                    string type = "";
                    if (i_dotTokens[i] == "{")
                        startIndex = i;
                    else
                    {
                        startIndex = Array.IndexOf(i_dotTokens, "{", i);
                        if (i_dotTokens[startIndex - 1].ToLower() == "subgraph")
                            type = "subgraph";
                        hasId = true;
                    }
                    endIndex = i_codeBlocks["}"][i_codeBlocks["{"].IndexOf(startIndex)];
                    if (startIndex == -1 || endIndex == -1)
                        throw new Exception("braces not matching");
                    if (hasId)
                    {
                        if (i_dotTokens[startIndex-1].ToLower().Contains("cluster"))
                        {
                            Cluster loaddedCluster = new Cluster(i_dotTokens[i - 1]);
                            element = ParseGraph(loaddedCluster, i_dotTokens, i_codeBlocks, startIndex, endIndex + 1) as Cluster;
                        }
                        else
                        {
                            Subgraph loaddedSubgraph = new Subgraph();
                            element = ParseGraph(loaddedSubgraph, i_dotTokens, i_codeBlocks, startIndex, endIndex + 1) as Subgraph;
                            element.type = type;
                        }
                    }
                    else
                    {
                        Subgraph loaddedSubgraph = new Subgraph();
                        element = ParseGraph(loaddedSubgraph, i_dotTokens, i_codeBlocks, startIndex, endIndex + 1) as Subgraph;
                        //element.type = "";
                    }

                    if (endIndex + 1 >= i_dotTokens.Length && i_dotTokens[endIndex + 1] == ";")
                        endIndex += 1;

                    if (endIndex + 1 >= i_dotTokens.Length && (i_dotTokens[endIndex+1] == "->" || i_dotTokens[endIndex + 1] == "--"))
                    {
                        string edgeType = "";
                        if (i_dotTokens[i + 1] == "->")
                            edgeType = EdgeOp.directed;
                        if (i_dotTokens[i + 1] == "--")
                            edgeType = EdgeOp.undirected;
                        transtions.Add(new Transition(element, edgeType));
                        i = endIndex + 1;
                    }
                    else
                    {
                        transtions.Add(new Transition(element, EdgeOp.unspecified));
                        i = endIndex + 1;
                        break;
                    }
                }
                else
                {
                    // this means this the last node of the edge 
                    Node node;
                    node = i_graph.GetElementByName(i_dotTokens[i]) as Node;
                    if (null == node)
                    {
                        node = new Node(i_dotTokens[i]);
                    }
                    transtions.Add(new Transition(node, EdgeOp.unspecified));
                    break;
                }
            }
            o_endIndex = i;
            return transtions;
        }

        private IDot GetSubgraphOrCluster(string[] i_dotTokens, Dictionary<string, List<int>> i_codeBlocks, int i_startIndex, out int o_endIndex)
        {
            if (!i_dotTokens.Contains("}"))
                throw new Exception($"no matching }} braces found for the subgraph");

            int i = i_startIndex;
            if (i_dotTokens[i-1].ToLower().Contains("cluster"))
            {
                Cluster loaddedCluster = new Cluster(i_dotTokens[i-1]);
                o_endIndex = i_codeBlocks["}"][i_codeBlocks["{"].IndexOf(i_startIndex)];
                loaddedCluster = ParseGraph(loaddedCluster, i_dotTokens, i_codeBlocks, i, o_endIndex+1) as Cluster;
                return loaddedCluster;
            }
            else
            {
                Subgraph loaddedSubgraph = new Subgraph();
                o_endIndex = i_codeBlocks["}"][i_codeBlocks["{"].IndexOf(i_startIndex)];
                loaddedSubgraph = ParseGraph(loaddedSubgraph, i_dotTokens, i_codeBlocks, i, o_endIndex+1) as Subgraph;
                loaddedSubgraph.type = "";
                return loaddedSubgraph;
            }
        }
        #endregion // Utility Methods

    }
}
