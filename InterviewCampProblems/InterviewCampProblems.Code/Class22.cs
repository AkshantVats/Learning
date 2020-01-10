/*
Search Array of Unknown length You are given an array, but you don't know the length. Write a program to find a target element in the array.
*/
using System;
using System.Collections.Generic;

namespace InterviewCampProblems.Code {
    public class Class22 {

        public static int FindWithUnknownLength (int[] arr, int target) {

            if (arr == null || arr.Length == 0) {
                System.Console.WriteLine ("Null, Empty or Invalid string.");
                return -1;
            }

            int high = 1;
            int endIndex = -1;
            while (true) {
                try {
                    int temp = arr[high];
                } catch (IndexOutOfRangeException ex) {
                    endIndex = BinarySearchForLastIndex (arr, high / 2, high);
                    break;
                }
                high *= 2;
            }
            return BinarySearchOverRange (arr, target, 0, endIndex);
        }

        private static int BinarySearchOverRange (int[] arr, int target, int low, int high) {
            while (low <= high) {
                int mid = low + (high - low) / 2;
                if (arr[mid] == target) {
                    return mid;
                } else if (arr[mid] < target) {
                    low = mid + 1;
                } else {
                    high = mid - 1;
                }
            }
            return -1;
        }

        private static int BinarySearchForLastIndex (int[] arr, int low, int high) {
            while (low <= high) {
                int mid = low + (high - low) / 2;
                try {
                    int temp = arr[mid];
                } catch (IndexOutOfRangeException ex) {
                    high = mid - 1;
                    continue;
                }

                try {
                    int temp = arr[mid + 1];
                } catch (IndexOutOfRangeException ex) {
                    return mid;
                }

                low = mid + 1;
            }
            return -1;
        }
    }
}