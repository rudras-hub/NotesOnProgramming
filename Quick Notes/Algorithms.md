# Algorithms

## Classification of Algorithms
Based on:
- Time Complexity
- Space Complexity
- Stability
    - Preserves the relative order of elements with equal value (value of property based on which it was sorted).
- Internal vs External
    - Use of main memory (RAM) vs external memory (disk).
- Recursive vs Non-recursive.

## Algorithms:
- Selection Sort:
    - Scan for smallest swap with the current index. Scan for next smallest swap with the progressed index. So on.
    - Time complexity: O(n^2) - Best, average worst. (Needs nested loop).
    - Space complexity: O(1)- worst. No extra memory.

- Bubble Sort:
    - Go through the array and compare adjacent elements and swap if not in order. (Considered a pass)
    - First pass pushes the largest number to the end. Second pass pushes the second largest to the end, so on.
    - Guaranteed to be sorted after n-1 passes. Condition on outer loop.
        - Sorting might be done much before that.
        - It's done when no swaps occur in a pass.
    - Time Complexity:
        - Best Case: O(n) - already sorted list.
        - Average/Worst: O(n^2)
    - Space complexity: O(1)
    - Stable sorting algorithm

- Insertion Sort:
    - Starts from the second element.
    - Picks an element, compares it to the element(s) on it's left and "inserts" it in new appropriate position.
    - Left hand part is sorted, right hand part is unsorted. 
    - Sorted region grows and steps are repeated for next element in the unsorted region.
    - Time Complexity: 
        - Best Case: O(n) - already sorted.
        - Average/Worst: O(n^2). 
        - Although average/worst is same as bubble sort and selection sort, overall insertion sort does fewer comparison and swaps.
    - Space Complexity:
        - O(1) : The same array is divided into sorted and unsorted regions.

- Merge Sort:
    - Keep dividing an array into halves till we get array on single elements
    - Call a merging algorithm to merge sorted lists into parent list. 
    - Recursive calls for dividing.
        - Base Condition: One element array.
    - Time Complexity: O(n*log(n)) - best/worst/average.
    - Space Complexity: O(n) -  worst.
    - Other features: Divide and conquer, recursive, stable, _not_ in place (uses extra memory).

- Quick Sort:
    - Chose last element as the pivot
    - Rearrange array so that all elements less than the pivot are to the left in the array, pivot in between and all elements greater than pivot to the right.
    - Chose left segment of the array, pivot and rearrange.
    - Chose the right segment, pivot and rearrange. 
    - Recursive calls to break down array into smaller segments.
    - All re-arrangements in the same array.
    - Time complexity: 
        - Best/Average: O(n*log(n))
        - Worst: O(n^2)
    - Space complexity: 
        - Best/Worst/Aveage: O(log(n))     
