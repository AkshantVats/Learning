/*
Given an array of integers, rearrange the elements such that all zeros aremoved to the end of the array.
*/
using System;

namespace InterviewCampProblems.Code {
    public class Class9 {

        public static int[] MoveZerosToEnd (int[] arr) {

            if (arr == null || arr.Length == 0) {
                System.Console.WriteLine ("Null, Empty or Invalid array.");
                return arr;
            }

            int boundary = arr.Length - 1;
            for (int i = arr.Length - 1; i >= 0; i--) {
                if (arr[i] == 0) {
                    Swap (arr, i, boundary);
                    boundary--;
                }
            }
            return arr;
        }

        private static void Swap (int[] arr, int i, int boundary) {
            int temp = arr[i];
            arr[i] = arr[boundary];
            arr[boundary] = temp;
        }
    }
}