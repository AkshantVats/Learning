/*
Given an array of integers, find the shortest sub array, that if sorted, results in the entire array being sorted.For example:[1,2,4,5,3,5,6,7] --> [4,5,3] - If you sort from indices 2 to 4, the entire array is sorted.[1,3,5,2,6,4,7,8,9] --> [3,5,2,6,4] -  If you sort from indices 1 to 5, the entire array is sorted.
*/
using System;

namespace InterviewCampProblems.Code {
    public class Class7 {

        public static int[] ShortestSubArray (int[] arr) {

            if (arr == null || arr.Length < 2) {
                System.Console.WriteLine ("Null, Empty or Invalid array.");
                return arr;
            }
            int startIndex = int.MinValue;
            int endIndex = int.MaxValue;
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;

            //find the dip from starting
            for (int i = 0; i < arr.Length - 1; i++) {
                if (arr[i + 1] < arr[i]) {
                    startIndex = i;
                    break;
                }
            }

            if (startIndex == int.MinValue) {
                //array is sorted
                return arr;
            }

            //find the bump from ending
            for (int i = arr.Length - 1; i > 0; i--) {
                if (arr[i - 1] > arr[i]) {
                    endIndex = i;
                    break;
                }
            }

            //finding min and max values from the subarray
            for (int i = startIndex; i <= endIndex; i++) {
                if (minValue > arr[i]) {
                    minValue = arr[i];
                }

                if (maxValue < arr[i]) {
                    maxValue = arr[i];
                }
            }

            while (startIndex > 0 && arr[startIndex - 1] > minValue) {
                startIndex--;
            }

            while (endIndex < arr.Length - 1 && arr[endIndex + 1] < maxValue) {
                endIndex++;
            }

            return new int[] { startIndex, endIndex };
        }
    }
}