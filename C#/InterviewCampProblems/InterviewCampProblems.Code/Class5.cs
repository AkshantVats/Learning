/*
2 Sum Problem: Given a sorted array of integers, find two numbers in the array that sum to a given integer target.For example, if a = [1,2,3,5,6,7] and target = 11, the answer will be 5 and 6.
*/
using System;

namespace InterviewCampProblems.Code {
    public class Class5 {

        public static int[] SumOfTwoNumbers (int[] arr, int target) {

            if (arr == null || arr.Length < 2) {
                System.Console.WriteLine ("Null, Empty or Invalid array.");
                return null;
            }
            int startIndex = 0;
            int endIndex = arr.Length - 1;

            while (startIndex < endIndex) {
                if (target == arr[startIndex] + arr[endIndex]) {
                    return new int[] { arr[startIndex], arr[endIndex] };
                } else if (target > arr[startIndex] + arr[endIndex]) {
                    startIndex++;
                } else if (target < arr[startIndex] + arr[endIndex]) {
                    endIndex--;
                }
            }
            return null;
        }
    }
}