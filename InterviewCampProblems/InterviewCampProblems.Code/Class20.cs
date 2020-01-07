/*
Given a sorted array of Integers, find the target. If the target is not found,return the element closest to the target.For example,A = [1,2,4,5,7,8,9], Target = 6 -> Output Index = 3 or 4 (since both 5 and 7 are equally close)
*/
using System;
using System.Collections.Generic;

namespace InterviewCampProblems.Code
{
    public class Class20
    {

        public static int ClosestElement(int[] arr, int target)
        {

            if (arr == null || arr.Length == 0)
            {
                System.Console.WriteLine("Null, Empty or Invalid string.");
                return -1;
            }

            int startIndex = 0;
            int endIndex = arr.Length - 1;
            int mid = 0;
            int result = -1;
            while (startIndex <= endIndex)
            {
                mid = startIndex + (endIndex - startIndex) / 2;
                result = Record(mid, target, result, arr);
                if (arr[mid] < target)
                {
                    startIndex = mid + 1;
                }
                else if (arr[mid] > target)
                {
                    endIndex = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return result;
        }

        private static int Record(int mid, int target, int result, int[] arr)
        {
            if (result == -1 || Math.Abs(arr[mid] - target) < Math.Abs(arr[result] - target))
            {
                return mid;
            }
            return result;
        }
    }
}