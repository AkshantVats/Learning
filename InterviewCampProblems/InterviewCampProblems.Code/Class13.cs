/*
Given an array of positive integers, find a subarray that sums to a given number X.For e.g, input = [1,2,3,5,2] and X=8, Result = [3,5] (indexes 2,3)
*/
using System;

namespace InterviewCampProblems.Code {
    public class Class13 {

        public static int[] SlidingSubArray (int[] arr, int target) {

            if (arr == null || arr.Length == 0) {
                System.Console.WriteLine ("Null, Empty or Invalid array.");
                return arr;
            }

            int startIndex = 0;
            int endIndex = 0;
            int sum = arr[0];

            while (startIndex < arr.Length) {
                if (startIndex > endIndex) {
                    endIndex = startIndex;
                    sum = arr[startIndex];
                }

                if (sum < target) {
                    if (endIndex == arr.Length - 1) {
                        break;
                    }
                    endIndex++;
                    sum = sum + arr[endIndex];
                } else if (sum > target) {

                    sum = sum - arr[startIndex];
                    startIndex++;
                } else {
                    return new int[] { startIndex, endIndex };
                }
            }
            return null;
        }
    }
}