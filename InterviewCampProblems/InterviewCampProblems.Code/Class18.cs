/*
Given a sorted array that can contain duplicates, find the first occurrence of the target element. For example:A = [1,3,4,6,6,6,7] and Target = 6, return index 3.
*/
using System;
using System.Collections.Generic;

namespace InterviewCampProblems.Code
{
    public class Class18
    {

        public static int FirstOccurence(int[] arr, int target)
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
                if (arr[mid] < target)
                {
                    startIndex = mid + 1;
                }
                else if (arr[mid] > target || (arr[mid] == target && mid > 0 && arr[mid - 1] == target))
                {
                    endIndex = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}