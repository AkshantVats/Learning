/*
Given an array of positive and negative integers, find a subarray whose sum equals X. For example: Input = [2,4,-2,1,-3,5,-3], X = 5 --> Result = [2,4,-2,1]
*/
using System;
using System.Collections.Generic;

namespace InterviewCampProblems.Code {
    public class Class16 {

        public static int[] TargetSumSubarray (int[] arr, int target) {

            if (arr == null || arr.Length == 0) {
                System.Console.WriteLine ("Null, Empty or Invalid string.");
                return null;
            }

            int sum = 0;
            Dictionary<int, int> dict = new Dictionary<int, int> ();
            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
                if (sum == target) {
                    return new int[] { 0, i };
                }
                if (dict.ContainsKey (sum - target)) {
                    return new int[] { dict[sum - target] + 1, i };
                }
                dict.Add (sum, i);
            }
            return null;
        }
    }
}