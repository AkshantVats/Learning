/*
Given an array of integers A, print all its subsets.For example:Input:​ [1, 2, 3]Output:[][1][2][3][1, 2][1, 3][2, 3][1, 2, 3]
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCampProblems.Code {
    public class Class29 {

        public static List<int[]> PrintSubset (int[] arr) {
            if (arr == null || arr.Length == 0) {
                return null;
            }

            int[] buffer = new int[arr.Length];
            List<int[]> result = new List<int[]> ();
            PrintSubsetHelper (arr, buffer, 0, 0, result);
            return result;
        }

        private static void PrintSubsetHelper (int[] arr, int[] buffer, int startIndex, int bufferIndex, List<int[]> result) {

            result.Add (buffer.Take (bufferIndex).ToArray ());

            if (bufferIndex == buffer.Length) {
                return;
            }
            if (startIndex == arr.Length) {
                return;
            }

            for (int i = 0; i < arr.Length; i++) {
                buffer[bufferIndex] = arr[i];
                PrintSubsetHelper (arr, buffer, startIndex + 1, bufferIndex + 1, result);
            }
        }

    }
}