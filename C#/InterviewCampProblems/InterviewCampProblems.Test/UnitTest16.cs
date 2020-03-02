/*
Given an array of positive and negative integers, find a subarray whose sum equals X. For example: Input = [2,4,-2,1,-3,5,-3], X = 5 --> Result = [2,4,-2,1]
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest16 {
        [Fact]
        public void Test1 () {
            int[] expected = new int[] { 0, 3 };
            int[] input = new int[] { 2, 4, -2, 1, -3, 5, -3 };
            var actual = Class16.TargetSumSubarray (input, 5);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {
            int[] expected = new int[] { 1, 2 };
            int[] input = new int[] {-1, 2, 3 };
            var actual = Class16.TargetSumSubarray (input, 5);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {
            int[] expected = null;
            int[] input = new int[] {-1, -2, -3 };
            var actual = Class16.TargetSumSubarray (input, 5);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {
            int[] expected = null;
            int[] input = null;
            var actual = Class16.TargetSumSubarray (input, 5);
            Assert.Equal (expected, actual);
        }
    }
}