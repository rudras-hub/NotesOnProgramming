# Memory in .NET

## Reference types and Value Types
- variable name -> memory slot
- size of the slot -> type (value type or reference type) of variable.

- Reference Type: 
    - Memory slot holds either a reference to underlying type or null. 
    - Size of memeroy slot is the size of the pointer to the actual object 
        - 8 bytes for 32 bit architecture. 
    -  
- Value Type: 
    - Memory slot contains actual data. 
        - Can never contain `null`. Null is a reference type concept.

Generally value types go on the stack and reference types go on the heap. But this generalization needs further context.

## Storage Area
- On the stack: 
    - All types local variables (declared within a method) and method parameters. 
        - For reference types, slots on the stack point to whenre the object lives on the heap.
        - parameters with `ref` modifiers don't get their own slot; they share it with variable on the calling code.
    - Instance variable of value types: A struct of ints will be stored on the stack   

- On the heap:
    - Instance variables for a reference type.
    - Every static variable regardless of it's type.
    - Instance variable of value type: A struct two classes will be stored on the heap. 

## Memory management: 
- Stack:
    - Enetering a new function, stack pointer creates a stack frame by pointing to the closest available free space on stack. 
    - Pointer advances a we proceed through the function. 
    - When returning from the function, the pointer now rolls back to where it started at th begining of the function. 
    - The stack frame data is now unaccessible (_but not disposed_).
    - When entering a new function the data in the stack frame is overwritten.
    - StackOverflow Exception: Stack is at the top and grows downwards. Heap is at the bottom and grows upwards. Exception occurs when they areas collide.
        - Typically caused by recursive function calls in the actual code or even with the libraries.
- Heap:
    - Garbage Collection on managed heap.
    
Reference: https://jonskeet.uk/csharp/memory.html