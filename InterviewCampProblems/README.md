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

  24. A peak element in an array A is an A[i] where its neighboring elements are less than A[i].So, A[i - 1] < A[i] and A[i + 1] < A[i].Assume there are no duplicates. Also, assume that A[-1] and A[length] are negative infinity (-∞).So A[0] can be a peak if A[1] < A[0].A = [1,3,4,5,2] => Peak = 5 A = [5,3,1] => Peak = 5 A = [1,3,5] => Peak = 5

  25. Find the nth number in the Fibonacci series. Fibonacci series is as follows:1, 1, 2, 3, 5, 8, 13, 21, .. After the first two 1’s, each number is the sum of the previous two numbers.

  26. Power Function: Implement a function to calculate X^N. Both X and N can be positive or negative. You can assume that overflow doesn't happen.(Try doing it in ​O(log(N))​ time)For example: 2 ^ 2  = 4  2 ^ -2 = 0.25 -2 ^ 3  = -8

  27. Given an array of integers, print all combinations of size X.

  28. Phone Number Mnemonics: Given an N digit phone number, print all the strings that can be made from that phone number. Since 1 and 0 don't correspond to any characters, ignore them.

  29. Given an array of integers A, print all its subsets.For example:Input:​ [1, 2, 3]Output:[][1][2][3][1, 2][1, 3][2, 3][1, 2, 3]

  30. Given an array A, print all permutations of size X.For example,Input:A = [1,2,3]X = 2Output:[1, 2][1, 3][2, 1][2, 3][3, 1][3, 2]

  31. Coin Change Problem: Given a set of coin denominations, print out the different ways you can make a target amount. You can use as many coins of each denomination as you like.For example: If coins are [1,2,5] and the target is 5, output will be:[1,1,1,1,1][1,1,1,2][1,2,2][5]

  32. Maze Problem: You are given a 2D array that represents a maze. It can have 2 values - 0 and 1. 1 represents a wall and 0 represents a path.The objective is to reach the bottom right corner, i.e, A[A.length-1][A.length-1]. You start fromA[0][0]. You can move in 4 directions - up, down, left and right. Find if a path exists to the bottom right of the maze.For example, a path exists in the following maze:0 1 1 1 0 1 1 1 0 0 0 0 1 1 1 0

  33. SudokuSolver:​ Given a Sudoku board, find a solution. The board can have some squares filled out already. You have to fill the rest of the squares.(Rules of Sudoku are as follows: In each column, row and 3 x 3 square, you cannot have duplicate numbers. Also, only numbers 1-9 are allowed.) -- Not Done

  34. WordBreakProblem​: Given a String S, which contains letters and no spaces, determine if you can break it into valid words. Return one such combination of words.You can assume that you are provided a dictionary of English words. For example:S = "ilikemangotango" Output:Return any one of these:"i like mango tango""i like man go tan go""i like mango tan go""i like man go tango" -- Not Done

  35. Linked List Implementation

  36. You are given a LinkedList with nodes that have values 0,1 or 2.Sort the linked list.

  37. Odd Even Linked List: Given a LinkedList L separate it into 2 LinkedLists. One contains L's odd nodes and the other contains L's even nodes.For example:Input: Head -> 1 -> 2 -> 3 -> 4 -> 5Result 1: Head -> 1 -> 3 -> 5Result 2: Head -> 2 -> 4

  38. Given a linked list and pointers to a node N and its previous node Prev, delete N from the linked list. -- Not Done

  39. Follow Up: Given a node N in a Linked List, can you delete it without the previous node in O(1) time? -- Not Done

  40. Find if a given Linked List has a cycle.

  41. Given a linked list that has a cycle, find the length of the cycle. The length is in number of nodes.