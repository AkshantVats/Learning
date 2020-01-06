/*
You are given a sorted array A and a target T. If the target is found, return the index. If not,return the index where it would be placed if inserted in order.For example,A = [1,2,4,4,5,6,8] and T = 3, return index 2A = [1,2,4,4,5,6,8] and T = 0, return index 0A = [1,2,4,4,5,6,8] and T = 4, return index 2, 3 or 4 (they're all valid).
*/
using System;
using System.Collections.Generic;

namespace InterviewCampProblems.Code
{
    public class Class19
    {

        public static int FindInsertionIndex(int[] arr, int target)
        {

            if (arr == null || arr.Length == 0)
            {
                System.Console.WriteLine("Null, Empty or Invalid string.");
                return -1;
            }

            int startIndex = 0;
            int endIndex = arr.Length - 1;
            int mid = 0;
            while (startIndex <= endIndex)
            {
                mid = startIndex + (endIndex - startIndex) / 2;
                if (arr[mid] <= target)
                {
                    if (mid == arr.Length - 1)
                    {
                        return arr.Length;
                    }

                    startIndex = mid + 1;
                }
                else
                {
                    if (mid == 0 || arr[mid - 1] <= target)
                    {
                        return mid;
                    }
                    endIndex = mid - 1;
                }
            }
            return -1;
        }
    }
}