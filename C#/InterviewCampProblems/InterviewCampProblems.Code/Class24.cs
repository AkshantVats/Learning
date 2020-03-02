/*
A peak element in an array A is an A[i] where its neighboring elements are less than A[i].So, A[i - 1] < A[i] and A[i + 1] < A[i].Assume there are no duplicates. Also, assume that A[-1] and A[length] are negative infinity (-∞).So A[0] can be a peak if A[1] < A[0].A = [1,3,4,5,2] => Peak = 5 A = [5,3,1] => Peak = 5 A = [1,3,5] => Peak = 5
*/
using System;
using System.Collections.Generic;

namespace InterviewCampProblems.Code {
    public class Class24 {

        public static int FindPeak (int[] arr) {

            if (arr == null || arr.Length == 0) {
                System.Console.WriteLine ("Null, Empty or Invalid string.");
                return -1;
            }

            int low = 0;
            int high = arr.Length - 1;
            while (low <= high) {
                int mid = low + (high - low) / 2;

                int left = (mid > 0) ? arr[mid - 1] : int.MinValue;
                int right = (mid < arr.Length - 1) ? arr[mid + 1] : int.MinValue;

                if (left < arr[mid] && right > arr[mid]) {
                    low = mid + 1;
                } else if (right < arr[mid] && left > arr[mid]) {
                    high = mid - 1;
                } else if (right > arr[mid] && left > arr[mid]) {
                    high = mid - 1;
                } else {
                    return mid;
                }
            }
            return -1;
        }
    }
}