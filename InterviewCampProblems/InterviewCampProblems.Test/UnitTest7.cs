/*
Given an array of integers, find the shortest sub array, that if sorted, results in the entire array being sorted.For example:[1,2,4,5,3,5,6,7] --> [4,5,3] - If you sort from indices 2 to 4, the entire array is sorted.[1,3,5,2,6,4,7,8,9] --> [3,5,2,6,4] -  If you sort from indices 1 to 5, the entire array is sorted.
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest7 {
        [Fact]
        public void Test1 () {

            int[] expected = new int[] { 2, 4 };
            int[] arr = new int[] { 1, 2, 4, 5, 3, 5, 6, 7 };
            var actual = Class7.ShortestSubArray (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {

            int[] expected = new int[] { 1, 5 };
            int[] arr = new int[] { 1, 3, 5, 2, 6, 4, 7, 8, 9 };
            var actual = Class7.ShortestSubArray (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {

            int[] expected = new int[] { 1 };
            int[] arr = new int[] { 1 };
            var actual = Class7.ShortestSubArray (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {

            int[] expected = new int[] { 1, 1 };
            int[] arr = new int[] { 1, 1 };
            var actual = Class7.ShortestSubArray (arr);
            Assert.Equal (expected, actual);
        }
    }
}