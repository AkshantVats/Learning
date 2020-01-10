/*
Given an array that is cyclically sorted, find the minimum element. A cyclically sorted array is a sorted array rotated by some number of elements. Assume all elements are unique.For example:A = [4,5,1,2,3], which is just [1,2,3,4,5] rotated by 2 Result = index 2
*/
using System;
using System.Collections.Generic;

namespace InterviewCampProblems.Code {
    public class Class21 {

        public static int CyclicallySortedMin (int[] arr) {

            if (arr == null || arr.Length == 0) {
                System.Console.WriteLine ("Null, Empty or Invalid string.");
                return -1;
            }

            int startIndex = 0;
            int endIndex = arr.Length - 1;
            int right = arr[arr.Length - 1];
            while (startIndex <= endIndex) {
                int mid = startIndex + (endIndex - startIndex) / 2;
                if (arr[mid] <= right && (mid == 0 || arr[mid] < arr[mid - 1])) {
                    return mid;
                } else if (arr[mid] > right) {
                    startIndex = mid + 1;
                } else {
                    endIndex = mid - 1;
                }
            }
            return -1;
        }

    }
}