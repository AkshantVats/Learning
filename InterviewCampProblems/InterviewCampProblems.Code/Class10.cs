/*
You are given an array of integers and a pivot. Rearrange the array in thefollowing order:[all elements less than pivot, elements equal to pivot, elements greater than pivot]For example,a = [5,2,4,4,6,4,4,3] and pivot = 4 --> result = [3,2,4,4,4,4,6,5].
*/
using System;

namespace InterviewCampProblems.Code {
    public class Class10 {

        public static int[] DutchNationalFlag (int[] arr, int pivot) {

            if (arr == null || arr.Length == 0) {
                System.Console.WriteLine ("Null, Empty or Invalid array.");
                return arr;
            }

            int lowboundary = 0;
            int highboundary = arr.Length - 1;
            int i = 0;
            while (i <= highboundary) {
                if (arr[i] < pivot) {
                    Swap (arr, i, lowboundary);
                    lowboundary++;
                    i++;
                } else if (arr[i] > pivot) {
                    Swap (arr, i, highboundary);
                    highboundary--;
                } else {
                    i++;
                }
            }
            return arr;
        }

        private static void Swap (int[] arr, int i, int boundary) {
            int temp = arr[i];
            arr[i] = arr[boundary];
            arr[boundary] = temp;
        }
    }
}