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
