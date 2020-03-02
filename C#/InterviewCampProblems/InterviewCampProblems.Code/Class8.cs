/*
You are given an array of integers. Rearrange the array so that all zeroes are at the beginning of the array.For example,a = [4,2,0,1,0,3,0] -> [0, 0, 0, 1, 2, 3, 4]
*/
using System;

namespace InterviewCampProblems.Code {
    public class Class8 {

        public static int[] MoveZerosToStart (int[] arr) {

            if (arr == null || arr.Length == 0) {
                System.Console.WriteLine ("Null, Empty or Invalid array.");
                return arr;
            }

            int boundary = 0;
            for (int i = 0; i <= arr.Length - 1; i++) {
                if (arr[i] == 0) {
                    Swap (arr, i, boundary);
                    boundary++;
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