# Arrays and Relatives

## Arrays
- Array values are allocated in contiguous memory locations, when created (true for most languages - Java, C#, C++; not true for Javascript).

- Array elements must be of the same type, in strongly typed languages.

- Adding more items to an array typically involves copying the original plus new values into a separate memory location.

- __C# lists are basically arrays under the hood__

- Advantages:
    - O(1) random access by index. (If you know the index of an element,then quick access to it).
    - Lightweight, easy to use. Good performance, generally.

- Limitations
    - Costly to resize an array. Growing needs moving.
    - Finding a member by its value require O(n) operation. (Have to loop)
    - Can not insert and/or delete stuff in the middle.

> Note: On javascript arrays: List-like objects. May not have contiguous memory locations. Length of the array or the types of elements is not fixed.

## Stack
- No random access. Can only retrieve the member from the top.
- Last In First Out (LIFO).
- Methods - Push, Pop and Peek.

- Advantages:
    - O(1) operations only (since touching just the top element).

- Limitations:
    - No random access.

- Application: Algos where we need to know the last value
    - Reversing a string
    - Traversing a graph or tree.
    - Writing compilers, call stack etc.

## Queue
- No random access
- Value added to the top. Value removed from bottom. 
    - Again access to only the element at one end.
- First In First Out (FIFO).

- Methods: 
    - Enqueue: Add item to the end of the queue.
    - Dequeue: Remove item from beginning the queue. 

- Variations:
    - Priority Queue:
        - Members have priority associated with them. Higher priority items are dequeued first.
        - If priorities are same, then falls back to FIFO.
    - Double Ended Queue:
        - Allows inserts and deletes at both ends. Hybrid of stack + queue.
    - Circular Queue (Ring Buffer)
        - Last item holds a reference to the first item.

## Linked List
- Made up of _nodes_. Nodes contain the actual value to be stored and pointer(s) to next and/or previous node.
- Types: 
    - Singly Linked List: Node = value + pointer to next node.
    - Doubly Linked List Node = pointer to previous node + value + pointer to next node.
        - Overhead of setting an additional pointer. But much easier to drop an item as compared to Singly Linked List.
- Null terminated: Pointers for (first and) last nodes will be null to indicate (beginning and) end.
- _Nodes are not next to each other in memory_

- Advantages:
    - Easy resizing (non-contiguous).
    - Easy to insert and delete stuff from middle (just reset pointers).

- Limitation:
    - No random access by index.
    - Finding member by value needs traversing the list - O(n).
    - Bad choice for binary searches.
    - Extra memory requirement for holding pointers.

- Application: 
    - When easy growing and shrinking is required. Lots of inserts/deletes.
    - No random access needed.

> Note: Stacks can be implemented with singly linked list, as we just need to add or remove the last element.
