using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace csdot
{
    public class DotDocument
    {
        #region Methods

        #region LoadDigraph

        
        //public Graph LoadDigraph(string i_fileLocation)
        //{
        //    #region NewImplementaion

        //    Graph loadedGraph = null;

        //    if (!File.Exists(i_fileLocation))
        //        throw new FileNotFoundException($"The localtion {i_fileLocation} is not accessible");
            
        //    string dotFile = File.ReadAllText(i_fileLocation, Encoding.UTF8);
        //    dotFile = GetRefactoredContent(dotFile);
        //    string[] dotTokens = dotFile.Split(' ');
        //    dotTokens = dotTokens.Where(s => !string.IsNullOrEmpty(s)).ToArray();
        //    dotTokens = dotTokens.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

        //    if (!dotTokens.Contains("graph") && !dotTokens.Contains("digraph"))
        //        throw new Exception("graph/digraph keyword should be present for a valid dot file");

        //    for (int i =0; i < dotTokens.Length; i++)
        //    {
        //        // forming Graph
        //        if(dotTokens[i] == "graph" || dotTokens[i] == "digraph")
        //        {
        //            bool strict = false;
        //            string name = "Default";
        //            if (i != 0 && dotTokens[i - 1] == "strict")
        //                strict = true;
        //            if (dotTokens[i + 1] != "{")
        //            {
        //                name = dotTokens[i + 1];
        //                i += 1;
        //            }
        //            loadedGraph = GetGraph(strict, name);
        //        }

        //        //forming Nodes
        //        if (i+1 < dotTokens.Length && dotTokens[i+1] == "[")
        //        {
        //            List<string> nodeProperties = GetProperties(dotTokens, i + 1, out int endIndex);
        //            Node newNode = GetNode(dotTokens[i], nodeProperties);
        //            loadedGraph.AddElement(newNode);
        //        }


        //    }

        //    return loadedGraph;

        //    #endregion

        //    #region OldImplementattion
        //    /*
        //    if (!File.Exists(i_fileLocation))
        //    {
        //        //File does not exist
        //        return -1;
        //    }
        //    CultureInfo ci;
        //    ci = new CultureInfo("en-US");
        //    string dotFile = File.ReadAllText(i_fileLocation, Encoding.UTF8);
        //    //2nd Pass, need to implement 1st Pass
        //    dotFile = dotFile.Replace(";", " ; ");
        //    dotFile = dotFile.Replace(",", " , ");
        //    dotFile = dotFile.Replace("=", " ");
        //    dotFile = dotFile.Replace("\"", " ");
        //    dotFile = dotFile.Replace("[", " [ ");
        //    dotFile = dotFile.Replace("]", " ] ");
        //    dotFile = dotFile.Replace("(", " ");
        //    dotFile = dotFile.Replace(")", " ");
        //    dotFile = dotFile.Replace("\n", " \n ");
        //    dotFile = dotFile.Replace("{", " { ");
        //    dotFile = dotFile.Replace("}", " } ");
        //    string[] dotFileSplitTemp = dotFile.Split(' ');
        //    string[] dotFileSplit = new string[dotFileSplitTemp.Length];
        //    int j = 0;
        //    for (int i = 0; i < dotFileSplitTemp.Length; i++)
        //    {
        //        if (dotFileSplitTemp[i].Length >= 1)
        //        {
        //            dotFileSplit[j++] = dotFileSplitTemp[i];
        //        }
        //    }
        //    var length = j;
        //    for (int i = 0; i < length; i++)
        //    {
        //        if (dotFileSplit[i].Equals("}"))
        //        {
        //            break;
        //        }
        //        else if (dotFileSplit[i].Equals("digraph"))
        //        {
        //            this.m_name = dotFileSplit[i + 1];
        //            i++;
        //        }
        //        else if (dotFileSplit[i].Equals("{"))
        //        {
        //            continue;
        //        }
        //        else if (dotFileSplit[i].Equals("["))
        //        {
        //            DotNode n = new DotNode(dotFileSplit[i - 1]);
        //            i++;
        //            DotAttribute a = new DotAttribute();
        //            List<string> dotLabelList = new List<string>();
        //            string tempstr = "";
        //            while (i != length)
        //            {
        //                if (dotFileSplit[i].Equals("]"))
        //                {
        //                    break;
        //                }
        //                else if (dotFileSplit[i].Equals("\n") || dotFileSplit[i].Equals(","))
        //                {
        //                    //i++;
        //                }
        //                else if (dotFileSplit[i].Equals("shape"))
        //                {
        //                    a.Shape = dotFileSplit[i + 1];
        //                    i++;
        //                }
        //                else if (dotFileSplit[i].Equals("color"))
        //                {
        //                    a.Color = dotFileSplit[i + 1];
        //                    i++;
        //                }
        //                else if (dotFileSplit[i].Equals("label"))
        //                {
        //                    i++;
        //                    tempstr = "";
        //                    while (true)
        //                    {
        //                        if (dotFileSplit[i].Equals("]"))
        //                        {
        //                            i--;
        //                            break;
        //                        }
        //                        else if (dotFileSplit[i].Equals(","))
        //                        {
        //                            if ((dotFileSplit[i + 1].Equals("color") || dotFileSplit[i + 1].Equals("shape")))
        //                            {
        //                                break;
        //                            }
        //                        }
        //                        else if (dotFileSplit[i].Equals(n.Name))
        //                        {
        //                            a.Label = dotFileSplit[i];
        //                        }
        //                        else if (dotFileSplit[i].Equals("\n"))
        //                        {
        //                            //do nothing
        //                        }
        //                        else if (dotFileSplit[i].Equals(";"))
        //                        {
        //                            a.AddLabelAsInLabelList(tempstr);
        //                            tempstr = "";
        //                        }
        //                        else
        //                        {
        //                            if (tempstr == "")
        //                            {
        //                                tempstr = dotFileSplit[i];
        //                            }
        //                            else
        //                            {
        //                                tempstr += dotFileSplit[i];
        //                            }

        //                            //dotLabelList.Add(dotFileSplit[i]);
        //                        }
        //                        i++;
        //                    }
        //                    if (tempstr != "")
        //                    {
        //                        a.AddLabelAsInLabelList(tempstr);
        //                    }
        //                }
        //                i++;
        //            }
        //            n.SetAttribute(a);
        //            this.AddNode(n);
        //        }

        //        else if (dotFileSplit[i].Equals("->"))
        //        {
        //            DotTransition t = new DotTransition(dotFileSplit[i - 1], dotFileSplit[i + 1]);
        //            i += 2;
        //            if (dotFileSplit[i].Equals("["))
        //            {
        //                i++;
        //                DotAttribute a = new DotAttribute();
        //                List<string> dotLabelList = new List<string>();
        //                string tempstr = "";
        //                while (i != length)
        //                {
        //                    if (dotFileSplit[i].Equals("]"))
        //                    {
        //                        i--;
        //                        break;
        //                    }
        //                    if (dotFileSplit[i].Equals("shape"))
        //                    {
        //                        a.Shape = dotFileSplit[i + 1];
        //                        i += 2;
        //                    }
        //                    if (dotFileSplit[i].Equals("color"))
        //                    {
        //                        a.Color = dotFileSplit[i + 1];
        //                        i += 2;
        //                    }
        //                    else if (dotFileSplit[i].Equals("label"))
        //                    {
        //                        i++;
        //                        tempstr = "";
        //                        while (true)
        //                        {
        //                            if (dotFileSplit[i].Equals("]"))
        //                            {
        //                                break;
        //                            }
        //                            else if (dotFileSplit[i].Equals(","))
        //                            {
        //                                if ((dotFileSplit[i + 1].Equals("color") || dotFileSplit[i + 1].Equals("shape")))
        //                                {
        //                                    break;
        //                                }
        //                            }
        //                            else if (dotFileSplit[i].Equals("\n"))
        //                            {
        //                                //do nothing 
        //                            }
        //                            else if (dotFileSplit[i].Equals(";"))
        //                            {
        //                                a.AddLabelAsInLabelList(tempstr);
        //                                tempstr = "";
        //                            }
        //                            else
        //                            {
        //                                if (tempstr == "")
        //                                {
        //                                    tempstr = dotFileSplit[i];
        //                                }
        //                                else
        //                                {
        //                                    tempstr += ", " + dotFileSplit[i];
        //                                }
        //                            }
        //                            i++;
        //                        }
        //                        if (tempstr != "")
        //                        {
        //                            a.AddLabelAsInLabelList(tempstr);
        //                        }
        //                    }
        //                    if (dotFileSplit[i].Equals("\n") || dotFileSplit[i].Equals(","))
        //                    {
        //                        i++;
        //                    }
        //                }
        //                t.SetAttribute(a);
        //                this.AddTransition(t);
        //            }
        //        }
        //    }
            
        //    return 0;*/
        //    #endregion

        //}

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
        
        //private string GetRefactoredContent(string i_dotFile)
        //{
        //    i_dotFile = i_dotFile.Replace(";", " ; ");
        //    i_dotFile = i_dotFile.Replace("\t", "");
        //    i_dotFile = i_dotFile.Replace("\r", "");
        //    i_dotFile = i_dotFile.Replace(",", " , ");
        //    i_dotFile = i_dotFile.Replace("=", " = ");
        //    i_dotFile = i_dotFile.Replace("\"", " ");
        //    i_dotFile = i_dotFile.Replace("[", " [ ");
        //    i_dotFile = i_dotFile.Replace("]", " ] ");
        //    //i_dotFile = i_dotFile.Replace("(", " ");
        //    //i_dotFile = i_dotFile.Replace(")", " ");
        //    i_dotFile = i_dotFile.Replace("\n", " ");
        //    i_dotFile = i_dotFile.Replace("{", " { ");
        //    i_dotFile = i_dotFile.Replace("}", " } ");
        //    return i_dotFile;
        //}


        //private Graph GetGraph(bool i_strict, string i_name)
        //{
        //    Graph newGraph = new Graph(i_name);
        //    newGraph.strict = i_strict;
        //    return newGraph;
        //}

        //private Node GetNode(string i_name, List<string> i_properties)
        //{
        //    Node newNode = new Node(i_name);
        //    for (int i = 0; i <i_properties.Count; i+=2)
        //    {
        //        if (newNode.attributeMap.TryGetValue(i_properties[i], out var attribute))
        //            attribute.TranslateToValue(i_properties[i + 1]);
        //        else
        //            throw new Exception($"{i_properties[i]} attribute is not valid or not supported");
        //    }
        //    return newNode;
        //}

        //private List<string> GetProperties(string[] i_dotTokens, int i_startIndex, out int o_endIndex)
        //{
        //    List<string> properties = new List<string>();
        //    int i = i_startIndex;
        //    while(i_dotTokens[i] != "]")
        //    {
        //        if (i_dotTokens[i] == "=")
        //        {
        //            properties.Add(i_dotTokens[i - 1]);
        //            properties.Add(i_dotTokens[i + 1]);
        //        }
        //        i++;
        //    }
        //    o_endIndex = i;
        //    return properties;
        //}


        #endregion // Utility Methods

    }
}
