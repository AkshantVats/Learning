/*
Given an array, reverse the order of its elements.For example, [3,5,2,5,2,3,9] → [9,3,2,5,2,5,3]
*/
using System;

namespace InterviewCampProblems.Code {
    public class Class4 {

        public static int[] ReverseElement (int[] arr) {

            if (arr == null || arr.Length == 0) {
                System.Console.WriteLine ("Null or Empty array.");
                return arr;
            }
            int startIndex = 0;
            int endIndex = arr.Length - 1;

            while (startIndex < endIndex) {
                SwapValues (arr, startIndex, endIndex);
                startIndex++;
                endIndex--;
            }

            return arr;
        }

        private static void SwapValues (int[] arr, int startIndex, int endIndex) {
            int temp = arr[startIndex];
            arr[startIndex] = arr[endIndex];
            arr[endIndex] = temp;
        }
    }
}