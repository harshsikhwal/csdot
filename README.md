#csdot
csdot: A c# library to process Dot language used by Graphviz.

Currently it can generate DOT and dump as a file

Development occurs at GitHub, where you can report issues.

Examples:
The examples here will show you the most common input, editing and output methods.

Usage:

Just import the library for your respective framework and start working!

To create a Graph:
```csharp
Graph graph = new Graph("id");          // where id is the graph-ID string.
```

To create a node:

```csharp
Node node = new Node("id");				// where id is the node-id
```

Each graph element has Attribute property which has all the attribute objects set. For instance Graph only has center attribute.
So to set the attribute

```csharp
graph.Attribute.center.Value = true;
```

This will set the property and will generate the graph with this attribute. 

Similarly to set node property: 

```csharp
node.Attribute.color.Value = Color.X11.darkviolet;
```

A few inbuilt classes are defined where the developer can check the available list of properties and set accordingly. Like ```csharpColor``` in name space namespace ```csharpcsdot.Attributes.DataTypes``` can be used. 

To add an element to a graph:

```csharp
graph.AddElement(node)
```

To create an edge, we need to add a transition. A Transition is an element of edge:

To create an edge:

```csharp

Node a = new Node("a");
Node b = new Node("b");
Node c = new Node("c");

Edge edge = new Edge();

List<Transition> transition = new List<Transition>()
{
	new Transition(a, EdgeOp.directed),
	new Transition(b, EdgeOp.undirected),
	new Transition(c, EdgeOp.unspecified)
};
edge.Transition = transition;

```

To add it to graph:

```csharp
graph.AddElement(edge)
```

To save to a file, you need to create a DotDocument object and call SaveToFile()

```csharp
public void SaveToFile(Graph i_graph, string i_fileLocation)
```

Currently we do not support the following attributes:
* bb
* bgcolor
* charset
* class
* clusterrank
* comment
* dir
* diredgeconstraints
* esep
* fillcolor
* fixedsize
* head_lp
* headport
* layer
* layers
* layerselect
* lp
* margin
* maxiter
* normalize
* orientation
* overlap
* pack
* pad
* page
* pagedir
* pos
* quadtree
* rank
* rankdir
* ranksep
* ratio
* rects
* root
* scale
* sep
* size
* smoothing
* splines
* start
* style
* tail_lp
* tailport
* vertices
* viewport
* xlp

These will be added in the upcoming versions and well as LoadDiagraph feature. 



License
Distributed under MIT license.

Contacts:
Harsh     (harshsikhwal7@gmnail.com)
Vibaswan  (vroychowdhury@gmail.com)
