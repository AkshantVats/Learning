/*
Given an array of integers that can be both +ve and -ve, find the contiguous subarray with the largest sum.For example:  [1,2,-1,2,-3,2,-5]  -> first 4 elements have the largest sum. Return (0,3)
*/
using System;

namespace InterviewCampProblems.Code {
    public class Class12 {

        public static int[] KadanesAlgo (int[] arr) {

            if (arr == null || arr.Length == 0) {
                System.Console.WriteLine ("Null, Empty or Invalid array.");
                return arr;
            }
            int maxEndingHere = 0;
            int maxSum = int.MinValue;
            int startIndex = 0;
            int endIndex = 0;
            int s = 0;
            for (int i = 0; i <= arr.Length - 1; i++) {
                maxEndingHere += arr[i];
                if (maxSum < maxEndingHere) {
                    maxSum = maxEndingHere;
                    startIndex = s;
                    endIndex = i;
                }

                if (maxEndingHere < 0) {
                    s = i + 1;
                    maxEndingHere = 0;
                }
            }

            return new int[] { startIndex, endIndex };
        }
    }
}