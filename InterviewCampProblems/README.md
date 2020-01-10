# Interview Camp Problems

  # Pattern
  If the problem number is 1 then the solution is in Class1.cs and unit test is in UnitTest1.cs
  
  # Problems

  1. Given an array of numbers, replace each even number with two of the same number. e.g, [1,2,5,6,8, , , ,] -> [1,2,2,5,6,6,8,8].Assume that the array has the exact amount of space to accommodate the result.

  2. Given an array of numbers, move each zero number at the end of the array. e.g, [1,0,5,0,8] -> [1,5,8,0,0].

  3. Given a sentence, reverse the words of the sentence.For example,"i live in a house" becomes "house a in live i".

  4. Given an array, reverse the order of its elements.For example, [3,5,2,5,2,3,9] → [9,3,2,5,2,5,3]

  5. 2 Sum Problem: Given a sorted array of integers, find two numbers in the array that sum to a given integer target.For example, if a = [1,2,3,5,6,7] and target = 11, the answer will be 5 and 6.

  6. Given a sorted array in non-decreasing order, return an array of squares of each number, also in non-decreasing order. For example:[-4,-2,-1,0,3,5] -> [0,1,4,9,16,25]

  7. Given an array of integers, find the shortest sub array, that if sorted, results in the entire array being sorted.For example:[1,2,4,5,3,5,6,7] --> [4,5,3] - If you sort from indices 2 to 4, the entire array is sorted.[1,3,5,2,6,4,7,8,9] --> [3,5,2,6,4] -  If you sort from indices 1 to 5, the entire array is sorted.

  8. You are given an array of integers. Rearrange the array so that all zeroes are at the beginning of the array.For example,a = [4,2,0,1,0,3,0] -> [0,0,0,1,2,3,4]

  9. Given an array of integers, rearrange the elements such that all zeros are moved to the end of the array.

  10. You are given an array of integers and a pivot. Rearrange the array in the following order:[all elements less than pivot, elements equal to pivot, elements greater than pivot]For example,a = [5,2,4,4,6,4,4,3] and pivot = 4 --> result = [3,2,4,4,4,4,6,5].

  11. You're given a list of Marbles. Each marble can have one of 3 colors (Red, White or Blue).Arrange the marbles in order of the colors (Red -> White -> Blue).Colors are represented as follows:0 - Red 1 - White 2 - Blue

  12. Given an array of integers that can be both +ve and -ve, find the contiguous subarray with the largest sum.For example:  [1,2,-1,2,-3,2,-5]  -> first 4 elements have the largest sum. Return (0,3)

  13. Given an array of positive integers, find a subarray that sums to a given number X.For e.g, input = [1,2,3,5,2] and X=8, Result = [3,5] (indexes 2,3)

  14. Given a String, find the longest substring with unique characters.For example: "whatwhywhere" --> "atwhy"

  15. Given an array of integers, both -ve and +ve, find a contiguous subarray that sums to 0.For example: [2,4,-2,1,-3,5,-3] --> [4,-2,1,-3]

  16. Given an array of positive and negative integers, find a subarray whose sum equals X. For example: Input = [2,4,-2,1,-3,5,-3], X = 5 --> Result = [2,4,-2,1]

  17. Given a sorted array, search for a target item.( Binary search)

  18. Given a sorted array that can contain duplicates, find the first occurrence of the target element. For example:A = [1,3,4,6,6,6,7] and Target = 6, return index 3.

  19. You are given a sorted array A and a target T. If the target is found, return the index. If not,return the index where it would be placed if inserted in order.For example,A = [1,2,4,4,5,6,8] and T = 3, return index 2A = [1,2,4,4,5,6,8] and T = 0, return index 0A = [1,2,4,4,5,6,8] and T = 4, return index 2, 3 or 4 (they're all valid).

  20. Given a sorted array of Integers, find the target. If the target is not found,return the element closest to the target.For example,A = [1,2,4,5,7,8,9], Target = 6 -> Output Index = 3 or 4 (since both 5 and 7 are equally close)

  21. Given an array that is cyclically sorted, find the minimum element. A cyclically sorted array is a sorted array rotated by some number of elements. Assume all elements are unique.For example:A = [4,5,1,2,3], which is just [1,2,3,4,5] rotated by 2 Result = index 2

  22. Search Array of Unknown length You are given an array, but you don't know the length. Write a program to find a target element in the array.

  23. Find the square root of an integer X. For example, squareRoot(4) = 2.If X is not a perfect square, find the integer floor of the square root. For example,squareRoot(5) & squareRoot(8) will return 2. squareRoot(9) will return 3.