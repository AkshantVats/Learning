/*
Given a sorted array, search for a target item.( Binary search)
*/
using System;
using System.Collections.Generic;

namespace InterviewCampProblems.Code {
    public class Class17 {

        public static int BinarySearch (int[] arr, int target) {

            if (arr == null || arr.Length == 0) {
                System.Console.WriteLine ("Null, Empty or Invalid string.");
                return -1;
            }

            int startIndex = 0;
            int endIndex = arr.Length - 1;
            int mid = 0;
            while (startIndex <= endIndex) {
                mid = startIndex + (endIndex - startIndex) / 2;
                if (arr[mid] < target) {
                    startIndex = mid + 1;
                } else if (arr[mid] > target) {
                    endIndex = mid - 1;
                } else {
                    return mid;
                }
            }
            return -1;
        }
    }
}