/*
Given an array A, print all permutations of size X.For example,Input:A = [1,2,3]X = 2Output:[1, 2][1, 3][2, 1][2, 3][3, 1][3, 2]
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCampProblems.Code {
    public class Class30 {

        public static List<int[]> PrintPerms (int[] arr, int x) {
            if (arr == null || arr.Length == 0 || x > arr.Length) {
                return null;
            }

            int[] buffer = new int[x];
            bool[] isInBuffer = new bool[arr.Length];
            List<int[]> result = new List<int[]> ();
            PrintPermsHelper (arr, buffer, 0, isInBuffer, result);
            return result;
        }

        private static void PrintPermsHelper (int[] arr, int[] buffer, int bufferIndex, bool[] isInBuffer, List<int[]> result) {

            if (bufferIndex == buffer.Length) {
                result.Add (buffer.ToArray ());
                return;
            }

            for (int i = 0; i < arr.Length; i++) {
                if (!isInBuffer[i]) {
                    buffer[bufferIndex] = arr[i];
                    isInBuffer[i] = true;
                    PrintPermsHelper (arr, buffer, bufferIndex + 1, isInBuffer, result);
                    isInBuffer[i] = false;
                }
            }
        }

    }
}