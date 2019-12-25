/*
Given an array of integers that can be both +ve and -ve, find the contiguous subarray with the largest sum.For example:  [1,2,-1,2,-3,2,-5]  -> first 4 elements have the largest sum. Return (0,3)
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest12 {
        [Fact]
        public void Test1 () {
            int[] expected = new int[] { 0, 3 };
            int[] arr = new int[] { 1, 2, -1, 2, -3, 2, -5 };
            var actual = Class12.KadanesAlgo (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {

            int[] expected = new int[] { 0, 0 };
            int[] arr = new int[] { 2 };
            var actual = Class12.KadanesAlgo (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {

            int[] expected = new int[] { 1, 1 };
            int[] arr = new int[] {-2, -1 };
            var actual = Class12.KadanesAlgo (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {

            int[] expected = null;
            int[] arr = null;
            var actual = Class12.KadanesAlgo (arr);
            Assert.Equal (expected, actual);
        }
    }
}