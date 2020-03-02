/*
Given a sorted array in non-decreasing order, return an array of squares of each number, also in non-decreasing order. For example:[-4,-2,-1,0,3,5] -> [0,1,4,9,16,25]
*/
using System;

namespace InterviewCampProblems.Code {
    public class Class6 {

        public static int[] SquareOfEachNumber (int[] arr) {

            if (arr == null || arr.Length == 0) {
                System.Console.WriteLine ("Null, Empty or Invalid array.");
                return arr;
            }
            int[] output = new int[arr.Length];
            int outputindex = arr.Length - 1;
            int startIndex = 0;
            int endIndex = arr.Length - 1;

            while (startIndex <= endIndex) {

                if (Math.Abs (arr[startIndex]) > Math.Abs (arr[endIndex])) {
                    AddSquare (output, outputindex, arr[startIndex]);
                    startIndex++;
                } else {
                    AddSquare (output, outputindex, arr[endIndex]);
                    endIndex--;
                }
                outputindex--;

            }
            return output;
        }

        private static void AddSquare (int[] output, int index, int value) {
            output[index] = value * value;
        }
    }
}