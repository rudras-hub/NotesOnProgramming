# Heap

## Summary
- Heaps can be visualized like a tree structure, with root, parent and children nodes. 
    - More commonly a binary tree structure.
- Heaps define rule between a parent and child node.
    - Max Heap: Parent node's value is greater than its children. _Max on top_.
    - Min Heap: Parent node's value is less than its children. _Min on top_.

- Heaps are typically stored in arrays:
    - 0 index is left empty.
    - Root at index 1. 
    - For any node at ith in the array:
        - _Left child_ is at `2*i` position.
        - _Right child_ is at `(2*i)+1` position. 
        - Leaf nodes exist at indices in the range [`(N/2)+1` `(N/2)+N`]

## Balancing
- Heaps at all time must maintain their property, which is order between parents and children.
- SFollowing is the rough code that defines balancing strategy for a max heap:
``` C#
// arr is the heap.
// i is the root or any position from where balancing will begin.
// N is the last position to consider
public void BalanceMaxHeap(int[] arr, int i, int N){
    // Calculate left and right child indices
    var leftChild = 2*i;
    var rightChild = (2*i) + 1;

    // Assume root at the right position; i.e. position of max value is the root.
    int maxPosition = i;

    // If left child > root then position of max value is left child's position.
    if(leftChild < N && arr[leftChild] > arr[i]){
        maxPosition = leftChild;
    }

    // If right child > value at new max position, then position of max value is right child's position.
    if(rightChild < N && arr[rightChild] > arr[maxPosition]){
        maxPosition = rightChild;
    }

    // If max position is no longer position of root
    // Swap values between root and max position.
    // Recursively call BalanceMaxHeap starting from the max position. 
    // value at maxPosition has now changed and it may require more swaps going down.
    if(maxPosition != i){
        var temp = arr[i];
        arr[i] = arr[maxPosition];
        arr[maxPosition] = temp;

        BalanceMaxHeap(arr, maxPosition, N);
    }

}
```
- Time complexity: `O(log(N)`
    - _Further explanation needed._

## Building a heap
- The following code defines strategy for building a max heap from an unsorted array. 
- The algorithm starts at the last node of the second last level. _Last node before the leaf nodes_
- Calls Balance function to swap values with it's children. 
- Goes one level up an repeats. 
- At the second last level, the balance recursive call (from above algorithm) will not do anything as it's at the leaf level.
- At the third last level, Balance recursive call will execute once.
- Theefore building will keep going one level up at each iteration, and balancing will balance down from that level. 

``` C#
public void BuildMaxHeap(int[] arr){
    for(i = arr.Length/2; i >= 1; ++i){
        BalanceMaxHeap(arr, i, arr.Length);
    }
}
```
- Time Complexity:
    - Outer loop: N/2
    - Balancing: log(N)
    - Amortized time complexity: `O(N)`.

## Heap Sort
- Following steps and algo for using a max heap to sort in ascending order:
    1. Build Max Heap out of unsorted array.
    2. Swap the root (max element) with the last element of the array. 
    3. Balance the array from 0 to Length -1 (_excludes the max element pushed to the end)
        - This will cause the second largest element to now be at the root.
    4. Repeat till all elements in right order.
``` C#
public void HeapSort(int[] arr){

    // O(N)
    BuildMaxHeap(arr); 

    for(var size = N ; size >= 2; size--){
        var temp = arr[1];
        arr[1] = arr[size -1];
        arr[size-1] = temp;

        // O(log(N))
        BalanceMaxHeap(arr, 1, size);
    }
}
```
- Time Complexity: `O(N*log(N))`

## Priority Queue Implementation:
- Heaps are preferred for implementation of priority queue. 
- Characteristics of priority queue: 
    - Dequeue element with highest priority first. 
    - If two elements have same priority, dequeue them in the order of occurrence.

> NOTE: C# does not have built-in support for priority queue. Java does.

### Common API
- Peek Highest Priority
    - Time Complexity: `O(1)`.
``` C#
public int Peek(int[] arr){
    return arr[1];
}
```
- Pop Highest Priority
    - Time Complexity: `O(log(N))`
``` C#
public int Pop(int[] arr){
    var max = arr[1];

    arr[1] = arr[length -1];
    arr[length -1] = max;

    BalanceMaxHeap(arr, 1, length -1);
}
```
- Increase Priority at an index
    - Time Complexity : `O(log(N))`
        - _Further explanation needed_.
``` C#
public void IncreasePriority( int[] arr, int index, int newValue){
    // New value is not increasing the priority.
    if(newVal < arr[i]){
        return;
    }

    // Value of i has increased.
    arr[i] = newValue; 

    // It may now need to be swapped with it's parent and higher up. 
    while(i > 1 && arr[i/2] < arr[i]){
        var temp = arr[i/2];
        arr[i/2] = arr[i];
        arr[i] = temp;
    }
}
```
- Add To Queue (Enqueue)
    - Time Complexity : `O(log(N))`
``` C#
public void Enqueue(int[] arr, int val){
    // increase length
    length++;

    // Add low priority val at the end
    arr[length] = -1; 

    // increase priority to the required val.
    IncreasePriority(arr, length, val);
}
```

## Application
- Pros:
    - Fast removal of root node => Fast access to min/ max value.
    - Fast insertion. O(1) if leads to no balancing. O(log(N)) if leads to balancing needed.
- Cons: 
    - O(n) scan.

- Use it when:
    - You only care about max/ min value.

- Don't use it:
    - For searching for values.

- Used in:
    - Priority queues.



