/*
Given an array of integers, print all combinations of size X.
*/
using System;
using System.Collections.Generic;

namespace InterviewCampProblems.Code {
    public class Class27 {

        public static int[] PrintCombos (int[] arr, int x) {
            if (arr == null || arr.Length == 0 || arr.Length < x) {
                return null;
            }

            int[] buffer = new int[x];
            List<int> result = new List<int> ();
            PrintCombosHelper (arr, buffer, 0, 0, result);
            return result.ToArray ();
        }

        private static void PrintCombosHelper (int[] arr, int[] buffer, int startIndex, int bufferIndex, List<int> result) {
            if (bufferIndex == buffer.Length) {
                result.Add (ConvertToInt (buffer));
                return;
            }

            if (startIndex != arr.Length) {

                for (int i = startIndex; i < arr.Length; i++) {
                    buffer[bufferIndex] = arr[i];

                    PrintCombosHelper (arr, buffer, i + 1, bufferIndex + 1, result);
                }
            }
        }

        private static int ConvertToInt (int[] buffer) {
            int x = 0;
            int multipicator = 1;
            for (int i = buffer.Length - 1; i >= 0; i--) {
                x += buffer[i] * multipicator;
                multipicator *= 10;
            }

            return x;
        }
    }
}