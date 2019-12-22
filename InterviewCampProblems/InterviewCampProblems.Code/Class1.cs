/*
Given an array of numbers, replace each even number with two of the same number. e.g, [1,2,5,6,8, , , ,] -> [1,2,2,5,6,6,8,8].Assume that the array has the exact amount of space to accommodate the result.
*/

using System;

namespace InterviewCampProblems.Code {
    public class Class1 {

        public static int[] CloneEvenNumbers (int[] arr) {
            if (arr == null || arr.Length == 0) {
                System.Console.WriteLine ("Null or Empty array");
                return null;
            }
            int i = arr.Length - 1;
            int j = GetLastElementindex (arr);

            for (int k = j; k >= 0; k--) {
                if (arr[k] % 2 == 0) {
                    arr[i--] = arr[k];
                }
                arr[i--] = arr[k];
            }
            return arr;
        }

        private static int GetLastElementindex (int[] arr) {
            for (int i = arr.Length - 1; i >= 0; i--) {
                if (arr[i] != -1) {
                    return i;
                }
            }
            return 0;
        }
    }
}