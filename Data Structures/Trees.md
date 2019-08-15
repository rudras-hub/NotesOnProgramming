# Trees

## Overview
- Non-linear data structure
- Store hierarchical data.
- Trees can be implemented using: 
    - Dynamically created nodes. With pointers to left and right child. Similar to linked lists.
    - Arrays. Array implementation specifically used in implementing heap.

## Terminology
- Root - top most node.
- Link/Edge: Connection between two nodes.
- Parent Node: A node that has at least 1 child node.
- Child Node: Node with a parent node.
- Leaf Node: Node with no children.
- Height of a tree: Longest path between root to a leaf. 
- Depth of a node: Length of the path to the root.

## Binary Tree
- _Each node can have 0, 1 or 2 children_
- _Strict/Proper Binary Tree_: If each node has 0 0r 2 children.
- _Complete Binary Tree_: All levels except the last level are completely filled and all nodes are as left as possible. 
- _Perfect Binary Tree_: All levels are completely filled.
- _Balanced Binary Tree_: For each node in the tree, the difference between the height of its left and right subtree is less than k (k is mostly 1).
    - Well balanced tree are dense and have less height overall.
### Math
- Levels: 0 to h, where 0 is the level of root and h is the height of the tree.
- Max nodes at a level i = 2^i.
- Max no. of nodes in a binary tree = 2^0 + 2^1 + ... + 2^h = 2^(h+1) - 1.
    - ` max nodes  = 2^(h+1) - 1`
- Other way around: Given n nodes of a perfect binary tree, height is
    - `h = log(n+1) - 1`, log to base 2. To further simplify:
    - `h = floor(log(n))`, log to base 2 again.
    - _This is the minimum possible height for  any binary tree._
- Height of any binary tree:
    - `Min height = floor(log(n))`, tree is dense.
    - `Max height = n -1`, tree is sparse, as good as a linked list.
- Time complexity for searching/ inserting/ removing nodes from binary tree  is proportional to the height of the tree.
    - Best case: O(log(n)) for dense trees.
    - Worst case: O(n), for sparse trees.

### Binary Search Tree
- For each node in the tree, value of all nodes in the left subtree are less than or equal to itself, and values of all nodes in the right subtree are greater than itself.
- Average of searching, inserting and removing is O(log(n)).
- Searching: _Best/Average = O(log(n)). Worst = O(n)_
    - For every node is the search value is less than the node go to the left and discard the right subtree, and vice versa for when search value is greater. 
    - Reducing search area by half each time (similar to binary search in sorted array.) => O(log(n))
    - log(n) is the best case, happens when the tree is balanced. 
    - For a very sparse linked list like tree, every time we are reducing the search area by 1 node only = > O(n)
- Recursive Operations:
    - Implementation
    - Search
    - Find min and max values
    - Find height
- Traversals:
    - Breadth first
    - Depth First
        - Pre-order (root->left->right)
        - In-order (left->root->right)
            - >NOTE: In-order traversal of binary search tree gives sorted list.
        - Post-order (left->right->root)






