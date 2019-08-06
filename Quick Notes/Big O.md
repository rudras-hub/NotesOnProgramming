# Big O

## Overview
Big O mathematically describes the complexity of an algorithm in terms of time and space.
It defines complexity in terms of _operations per input_.

## O(1)
Order of 1 operation for all possible inputs.
- For 100 inputs only 1 operation is required.
- Constant time.
- Efficient and desirable
- Example: accessing a member of an array by index.

## O(N)
No. of operations scales linearly with the size of inputs.
- For 100 inputs, 100 operation required.
- Linear scaling.
- O(n+5) is still represented as O(n) and O(5) is still O(1). We are interested in the shape of curve and not the actual constants.
- Example: calculating a result by iterating once over a collection.
- Efficient Alternative: There may be some efficient alternatives. Using mathematical progression formula instead of iterating over the collection, when possible.

## O(N^2)
- For 100 inputs, 10000 operations required.
- Nested iteration over the same collection.
- Usually brute force solutions. Inefficient and inelegant. _There is almost always a better way_.

## O(log(N))
>__Example__: To find an array element by value, the standard brute force approach is to iterate over the array one, O(N). 
>But if it is a sorted list we can keep dividing the array into half till we find our value, O(log(N)). Here the log base is 2, and algorithm is binary search.

The number of times input needs to be split/divided (for algorithms that _divide and conquer_ like binary search).
- For 100 inputs, log(100) ~ 7 operations.
