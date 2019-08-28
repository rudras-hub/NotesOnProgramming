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
    - n is _maximum number of edges_.

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
    - Trail: A path in which vertices can be repeated but edges must not be repeated.
    - Closed Walk: A path which starts and ends at the same vertex, and the length of the path is greater than 0.
    - Cycle: A closed walk with no vertex and edges repeated, other than the start vertex.
> NOTE: If any other path is possible between two vertices then a simple path is also exists between them.

- Graph: Connected vs Un-connected
    - Is connected if there exists a path from any vertex to any other vertex.

## Graph Implementation
- Graph Implementation - Lists:
    - List of vertices and List of edges. 
        - List of edges basically contains start vertex, end vertex and weight for each edge.
    - Time Complexity:
        - Vertex List = O(|v|); function of number of vertices.
        - Edge List: O(|e|) = O(|v|^2); function of square of number of vertices! 
        - Costly to find adjacent nodes and if two nodes are connected.
    - Space Complexity:
        - again O(|v|) and O(|v|^2) for vertex and edge respectively, but not as costly as adjacency matrix representation.

- Graph Implementation - Adjacency matrix
    - Vertices in a list, Edges in 2D array of size vxv. 
        - Store 1 or the weight if node i is connected to node j on cell Eij.
        - Adjacency matrix representation.
    - For an undirected graph, the matrix of edges E is symmetric => Eij = Eji.
        - Sufficient to analyze one of the diagonal half. 
    - Time Complexity: 
        - Vertex List = O(1) if we (know and )search by indices of vertex, otherwise O(|v|) to scan the list for vertex.
        - Edge List
            - Finding Adjacent Nodes: Simply go through the row corresponding to the vertex and pick up connected nodes. 
                - O(|v|).
            - Find if two node are connected: Pick up value from Eij
                - O(1)
            - Good time complexity!
    - Space Complexity: 
        - O(|v|^2) for edges. 
        - Bad space complexity, especially for large sparse graphs. 
            - Lot of memory used to represent few connections.
        > NOTE: Adjacency matrix representation is good when the graph is dense.

- Graph Implementation - Adjacency List
    - Vertices in a list. 
    - Edges are stored in a collection of linked list.
        - A linked list to hold all connected nodes and weights for a vertex. 
        - A Collection of such linked lists to represent all edges of a graph.
        - The edges list is much smaller than a vxv, as unconnected nodes for a vertex is not represented. 
    - Time Complexity:
         - Vertex List: O(1) if we (know and )search by indices of vertex, otherwise O(|v|) to scan the list for vertex.
         - Edge List: 
            - Finding Adjacent Nodes: Scan and pick up connected nodes from the edges list for the relevant vertex. 
                - O(|v|), worst case if a vertex is connected to all other vertex.
            - Find if two nodes are connected: Scan the list of connected nodes from the edges list for the relevant vertex nad check if desire node exists
                - O(|v|), worst case if a vertex is connected to all other vertex.
            - > NOTE: Easy insertion and deletion of new  edges because of linked lists.
    - Space Complexity:
        - O(|e|), here |e| << |v|^2 as graph is sparse. 
        - Much better space complexity.
