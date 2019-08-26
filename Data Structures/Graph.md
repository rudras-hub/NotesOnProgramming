# Graphs

## Overview:
- Like trees, graphs are collection of nodes connected through edges. 
- Differences:
    - A tree with N node will always have N-1 edges.
    - In a tree, there is exactly one path from the root to a node.
- Graph is an ordered pair of set of vertices and set of edges. `G = (V, E)`
- Graphs can represent objects with pair-wise relationship.
   
## Properties of Graphs:
- Edges: Directed vs Undirected
    - Directed: One node is the origin and other the destination. 
    - Undirected: No one node is the origin or destination.
    - Graph with all directed edges is Directed Graph or _Digraph_.
    - Graph with all undirected edges is undirected graph.

- Edges: Weighted vs Un-weighted
 - Edges have different weights associated with them to represent certain attributes like length, priority etc.

- Edges: Self loop: 
    - Edge loops back to the same node.

- Edges: Multi-Edge Graph:
    - Edges occur more than once in a graph

> NOTE: A graph with no self loop or multi-edge is a simple graph.

- Graph: Number of Edges: 
    - Directed: `0 <= E <= n(n-1)`
    - Undirected: `0 <= E <= m(n-1)/2`
    - n is number of edges.

- Graph: Dense vs Sparse Graphs: 
    - Dense: Graph with edges close to the max limit
    - Sparse: Graph with edges close to min limit or number od vertices.
    - Storage:
        - Dense: Adjacency Matrix.
        - Sparse: Adjacency List.
    - Important attribute to make other decisions, as well.

- Path: 
    - A sequence of vertices where all adjacent vertices are connected by nodes. In case of a directed graph, edges connecting vertices must also be aligned in direction.
    - Simple Path: A path with no repeated vertices and edges.
    - Trail: A path in which vertices can be repeated but edges must not e repeated.
> NOTE: If any other path is possible between two vertices then a simple path is also exists between them.



