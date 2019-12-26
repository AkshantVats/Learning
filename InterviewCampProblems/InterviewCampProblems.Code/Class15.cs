/*
Given an array of integers, both -ve and +ve, find a contiguous subarray that sums to 0.For example: [2,4,-2,1,-3,5,-3] --> [4,-2,1,-3]
*/
using System;
using System.Collections.Generic;

namespace InterviewCampProblems.Code {
    public class Class15 {

        public static int[] ZeroSumSubarray (int[] arr) {

            if (arr == null || arr.Length == 0) {
                System.Console.WriteLine ("Null, Empty or Invalid string.");
                return null;
            }

            int sum = 0;
            Dictionary<int, int> dict = new Dictionary<int, int> ();
            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
                if (sum == 0) {
                    return new int[] { 0, i };
                }

                if (dict.ContainsKey (sum)) {
                    return new int[] { dict[sum] + 1, i };
                }
                dict.Add (sum, i);
            }

            return null;

        }
    }
}