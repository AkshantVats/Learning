/*
Given an array of integers, both -ve and +ve, find a contiguous subarray that sums to 0.For example: [2,4,-2,1,-3,5,-3] --> [4,-2,1,-3]
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest15 {
        [Fact]
        public void Test1 () {
            int[] expected = new int[] { 1, 4 };
            int[] input = new int[] { 2, 4, -2, 1, -3, 5, -3 };
            var actual = Class15.ZeroSumSubarray (input);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {

            int[] expected = null;
            int[] input = new int[] {-1 };
            var actual = Class15.ZeroSumSubarray (input);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {

            int[] expected = new int[] { 0, 1 };
            int[] input = new int[] {-1, 1 };
            var actual = Class15.ZeroSumSubarray (input);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {

            int[] expected = new int[] { 0, 1 };
            int[] input = new int[] { 5, -5 };
            var actual = Class15.ZeroSumSubarray (input);
            Assert.Equal (expected, actual);
        }
    }
}