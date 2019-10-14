# Graphs

## Overview:
- Like trees, graphs are collection of nodes connected through edges. 
- Differences:
    - A tree with N node will always have N-1 edges.
        - Every node has only 1 edge connecting it to its parent. Except the root node.
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
        - Every node can be connected to every other node, except self.
        - max `n-1` edges for a node. So max `n*(n-1)` total edges. 
    - Undirected: `0 <= E <= n(n-1)/2`
        - Max no. of edges originating from 1st node = `n-1`.
        - Max no. of edges from second node = `n-2`. 
            - To every other node, except self. And except first node, which is already connected.
        - For third `n-3`, for fourth `n-4` and so on.
        - Max total edges = `(n-1) + (n-2) + (n-3)+ ... 3+2+1` = `n(n-1)/2`
    - n is _maximum number of nodes_.

- Graph: Dense vs Sparse Graphs: 
    - Dense: Graph with edges close to the max limit
    - Sparse: Graph with edges close to min limit or number od vertices.
    - Storage:
        - Dense: Adjacency Matrix.
        - Sparse: Adjacency List.
    - This is an important attribute of graphs that helps make other decisions, as well.

- Path: 
    - A sequence of vertices where all adjacent vertices are connected by nodes. In case of a directed graph, edges connecting vertices must also be aligned in direction.

- Graph: Connected vs Un-connected
    - Is strongly connected if there exists a path from any vertex to any other vertex.

## Graph Implementation
- Graph Implementation - Lists:
    - List of vertices and List of edges. 
        - List of edges basically contains start vertex, end vertex and weight for each edge.
    - Time Complexity:
        - Vertex List = O(|v|); function of number of vertices.
        - Edge List: O(|e|) = O(|v|^2); As max edges is a function of square of number of vertices.
        - Costly to find adjacent nodes and if two nodes are connected.
    - Space Complexity:
        - again O(|v|) and O(|v|^2) for vertex and edge respectively, but not as costly as adjacency matrix representation.
        - O(|v|^2) is the worst case space complexity of the edges list.

- Graph Implementation - Adjacency matrix
    - Vertices in a list, Edges in 2D array of size `v x v`. 
        - Store 1 or the weight if node i is connected to node j on cell Eij.
    - For an _undirected graph_, the matrix of edges E is symmetric => `Eij = Eji`.
        - Sufficient to analyze one of the diagonal halves of the matrix. 
    - Time Complexity: 
        - Vertex List = O(1) if we (know and )search by indices of vertex, otherwise O(|v|) to scan the list for vertex.
        - Edge List
            - Finding Adjacent Nodes: Simply go through the row corresponding to the vertex and pick up connected nodes. 
                - O(|v|).
            - Find if two node are connected: Pick up value from Eij
                - O(1)
            - Good time complexity!
    - Space Complexity: 
        - O(|v|^2) for edges matrix. _Best, average and worst case_. 
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
            - Find if two nodes are connected: Scan the list of connected nodes from the edges list for the relevant vertex and check if desire node exists
                - O(|v|), worst case if a vertex is connected to all other vertex.
            - > NOTE: Easy insertion and deletion of new  edges because of linked lists.
    - Space Complexity:
        - O(|e|), here |e| << |v|^2 as graph is sparse. 
        - Much better space complexity.

## Graph Traversals
### DFS
- Used to explore the whole graph and not just a particular reachable destination.
- Each vertex and each edge is visited.
    - Directed Graph : Each edge gets visited once.
    - Undirected Graph: Each edge gets visited twice, once from each side.
- Applications:
    - Edge classification
    - Cycle detection
    - Topological sort

- Edge Classification:
    - Tree Edge: Edge leads to an unvisited vertex. Tree edges of a graph form a trees.
    - Forward Edge: Go from _node-> descendent_ in the tree.
    - Backward Edge: Go from _node->ancestor_ in the tree.
    - Cross edges: Connecting different sub-trees.
    - _Undirected graphs_  only have _tree and forward_ edges.
    - Used for: Cycle detection and topological sort.

- Cycle detection
    - A graph (directed or undirected) has cycles _iff_ there exists a back edge
    - Back edge => edge to a node already in class stack while traversing recursively.
        - As descendants are finished processing first, before bubbling back up to ancestors in the stack.

- Topological Sort
    - Typically used in job scheduling problems.
    - On directed graphs.
    - Vertices of the graph are arranged such that for every edge u->v, vertex u comes before vertex v in the ordering.
    - Topological ordering is possible _iff_ the directed graph has no cycles. 
    - Again, the descendents are finished processing first. 
    - When a node (all it's descendent) have been, it's bee marked visited and added to a stack.
    - Next it's parent will be done and will be added to the stack. 
    - Once we fully return from the recursive call, the stack can be popped to give the topological order. 


### BFS
- Application
    - To find is the shortest source->destination path or if any such path exists.
