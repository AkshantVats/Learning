/*
Given an array that is cyclically sorted, find the minimum element. A cyclically sorted array is a sorted array rotated by some number of elements. Assume all elements are unique.For example:A = [4,5,1,2,3], which is just [1,2,3,4,5] rotated by 2 Result = index 2
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest21 {
        [Fact]
        public void Test1 () {
            int expected = 2;
            int[] input = new int[] { 4, 5, 1, 2, 3 };
            var actual = Class21.CyclicallySortedMin (input);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {
            int expected = 0;
            int[] input = new int[] { 4, 5 };
            var actual = Class21.CyclicallySortedMin (input);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {
            int expected = 0;
            int[] input = new int[] { 5 };
            var actual = Class21.CyclicallySortedMin (input);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {
            int expected = -1;
            int[] input = null;
            var actual = Class21.CyclicallySortedMin (input);
            Assert.Equal (expected, actual);
        }
    }
}