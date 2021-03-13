# csdot
![Nuget](https://img.shields.io/nuget/v/csdot?style=for-the-badge)

![GitHub release (latest by date)](https://img.shields.io/github/v/release/harshsikhwal/csdot?style=for-the-badge)

![GitHub Workflow Status](https://img.shields.io/github/workflow/status/harshsikhwal/csdot/Csdot_Build?style=plastic)
[![GitHub issues](https://img.shields.io/github/issues/harshsikhwal/csdot?style=plastic)](https://github.com/harshsikhwal/csdot/issues)
[![GitHub stars](https://img.shields.io/github/stars/harshsikhwal/csdot?style=plastic)](https://github.com/harshsikhwal/csdot/stargazers)
[![GitHub license](https://img.shields.io/github/license/harshsikhwal/csdot?style=plastic)](https://github.com/harshsikhwal/csdot/blob/main/LICENSE)
![GitHub contributors](https://img.shields.io/github/contributors/harshsikhwal/csdot?style=plastic)
![Nuget](https://img.shields.io/nuget/dt/csdot)

A c# library to process Dot language used by Graphviz.

Currently it can generate DOT and dump as a file

Development occurs at GitHub, where you can report issues and request enhancement.

## Usage:

Just import the library for your respective framework and start working!

## csdot library

In csdot: **graph**, **node**, **edge**, **subgraph**, **clusters** are represented as Elements (implements IDot interface for grouping). 

As they are grouped, they can be added to the root element using a single function: 
```public void AddElement(IDot i_dot)``` 

To add multiple attribute to root element, you can use:
```public void AddElements(params IDot [] i_dot)```

Each element generated a unique ID  **UID** which refers to that particular element. One can access it by calling:
```csharp
var unique_id = graph.uid
``` 
(*Considering ```graph``` is object of ```class Graph```*)

### Elements of Dot 

#### Graph:

To create a graph
```csharp
Graph graph = new Graph("id");          // where id is the graph-ID string.
```

To set type 'strict'
```csharp
graph.strict = true;
```

To set the type 'graph' or 'diagraph'
```csharp
graph.type = "graph";
```

#### Node:

To create a node:
```csharp
Node node = new Node("id");		// where id is the node-id
```

To set the compass point:
```csharp
node.compassPoint = DataTypes.CompassPoint.North;
```
(Will explain the DataTypes later in this thread)

#### Edge:

To create an edge, we need to add a transition. A Transition is an element of edge.
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

Transition also supports ID:
```csharp
List<Transition> transition = new List<Transition>()
{
	new Transition("a", EdgeOp.directed),
	new Transition("b", EdgeOp.unspecified)
};
Edge edge = new Edge(transition);
```
Here no node is created, and the edge is created using the *ID*. Edge also supports adding of Elements.

#### Add elements to a root(like Graph, Subgraph):
```csharp
graph.AddElement(node)
graph.AddElement(edge)
```

or you can directly call:
```csharp
graph.AddElements(node, edge)
```

### Attributes

Each element of Dot can have its respective attribute as defined in the dot guidelines.
In csdot, we have covered many attributes respective to the type specified.

#### Set the value of attribute
The attributes are present in Attribute property of every element. Therefore to set a specific attribute, you need to call the property, which contains all the attribute objects and set its value as mentioned here:
```csharp
graph.Attribute.center.Value = true;
```
This will set the center attribute of graph. The generated graph will have this attribute.

#### Removing attribute from Element using Set property

Natrually the attributes are just defined but not added to the element. Once the value is set for a particular attribute, it is added to the element. 

You can remove the attribute by setting the ```Set``` property of that attribute to ```false```
```csharp
graph.Attribute.center.Set = false;
```

To set Node attribute "color"
```csharp
node.Attribute.color.Value = Color.X11.darkviolet;
```
#### Default and Minimum:

Also we can get the default and minimum as well as set the default and minimum.
```csharp
graph.Attribute.center.SetDefault();
```

To Set Minimum
```csharp
graph.Attribute.voro_margin.SetMinimum();
```

Simiarly to Get default and minimum, one can invoke ```GetDefault()``` ```GetMinimum()```

#### DataTypes

A few inbuilt classes are defined where the developer can check the available list of properties and set accordingly. Like ```Color``` in namespace ```namespace csdot.Attributes.DataTypes``` can be used. Most of these are static classes where the const data is present. Others are created for attributes supporting derived datatypes:
```csharp
public class point
```
is one such example. 

#### Attributes currently not added:

* esep
* headport
* layer
* layers
* layerselect
* normalize
* orientation
* pad
* page
* pagedir
* quadtree
* ratio
* sep
* size
* start
* style
* tailport
* vertices
* viewport

These will be added in the upcoming versions and well as LoadDiagraph feature. 

There are multiple known issues in the Attribute segment like handling of multi-types (color and colorList) as well as multi-default and multi-minimum. 
Please refer doc: *csdot\Docs\Attribute Status.docs* for more info

### DotDocument

To load and save a file, you need to create a DotDocument object.

The current release do not support Loading of the graph, but you can save it by calling the API mentioned below:
```csharp
public void SaveToFile(Graph i_graph, string i_fileLocation)
```

## License:
Distributed under MIT license.

## Contacts:

**Harsh**     (harshsikhwal7@gmail.com)
**Vibaswan**  (vroychowdhury@gmail.com)

