/*
Given an array of positive integers, find a subarray that sums to a given number X.For e.g, input = [1,2,3,5,2] and X=8, Result = [3,5] (indexes 2,3)
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest13 {
        [Fact]
        public void Test1 () {
            int[] expected = new int[] { 2, 3 };
            int[] arr = new int[] { 1, 2, 3, 5, 2 };
            var actual = Class13.SlidingSubArray (arr, 8);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {

            int[] expected = new int[] { 0, 0 };
            int[] arr = new int[] { 1 };
            var actual = Class13.SlidingSubArray (arr, 1);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {

            int[] expected = new int[] { 5, 5 };
            int[] arr = new int[] { 1, 2, 3, 4, 5, 16 };
            var actual = Class13.SlidingSubArray (arr, 16);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {

            int[] expected = null;
            int[] arr = new int[] { 0 };
            var actual = Class13.SlidingSubArray (arr, 1);
            Assert.Equal (expected, actual);
        }
    }
}