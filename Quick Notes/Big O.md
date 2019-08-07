# Big O

![](images/BigO.PNG)

## Overview
- Big O mathematically describes the complexity of an algorithm in terms of time and space.
    - It defines complexity in terms of _operations per input_.
- Study of how well algorithms scale (with number of inputs) in time and space.
- Most of the times, it describes the upper bound, or the worst case situation.

## O(1)
Order of 1 operation for all possible inputs.
- For 100 inputs only 1 operation is required.
- Constant time.
- Efficient and desirable
- Example: accessing a member of an array by index.

## O(n)
No. of operations scales linearly with the size of inputs.
- For 100 inputs, 100 operation required.
- Linear scaling.
- O(n+5) is still represented as O(n) and O(5) is still O(1). We are interested in the shape of curve and not the actual constants.
- Example: calculating a result by iterating once over a collection.
- _Efficient Alternative: Using mathematical (ex. progression) formula instead of iterating over the collection, when possible._

## O(n^2)
- For 100 inputs, 10000 operations required.
- Nested iteration over the same collection.
- Usually brute force solutions. Inefficient and inelegant. 
- _Efficient ALternative: There is almost always a better way. n^2 can almost always be brought down to at least n*log(n)_.

## O(log(n))
>__Example__: To find an array element by value, the standard brute force approach is to iterate over the array one, O(n). 
> But if it is a sorted list we can keep dividing the array into half till we find our value, O(log(n)). Here the log base is 2, and algorithm is binary search.

> The number of times input needs to be split/divided (for algorithms that _divide and conquer_, ike binary search).

- For 100 inputs, log(100) ~ 7 operations.
- It means that we need to split the collection log(N) times, and each time after splitting it's an O(1) operation => O(1*log(n)) => O(log(n)).
- Scales very well, very close to constant time operations.

## O(n*log(n))
> An outer loop with a nested log(n) operation/algorithm.

> Example: To find duplicates in a collection, brute force (n^2) approach is to loop twice. Better approach is to loop once (for each element) and find the element in rest of the collection by divide and conquer (n*Log(n)).

> Many algorithms, especially sorting ones like quick sort and merge sort are n*log(n).

- For 100 inputs, ~700 operations. 
- _Efficient Alternatives: Sometimes n*log(n) can be further brought down to O(n) using math tricks._
    - Example: To find duplicates, if the array is sorted and follows a series, use formula to find sum of series without duplicate. Loop through the collection to find actual sum, subtract the two sums, and you have your duplicate. O(1) + O(N) + O(1) => O(N).

## O(n!)
- Adding a loop for every element. 
- For 100 inputs, 100! = 9.332621544 E+157 operations! 
- Horrible. 
- Example: Listing all permutations of an array.

## O(2^n)
https://stackoverflow.com/a/34916117
> Algorithms with running time O(2^N) are often recursive algorithms that solve a problem of size N by recursively solving two smaller problems of size N-1 
- Very inefficient. 
- Few examples.

## Space Complexity
- How much resource (stack, heap etc.) is the algo using.
- When the stack keeps growing it's taking too much resource.
    - Common in recursive algorithms; results in stack overflow exceptions.
- C# strings are immutable, appending to strings means re-allocating a new spot on memory. Therefore algorithms altering strings can be costly (in terms of space).



