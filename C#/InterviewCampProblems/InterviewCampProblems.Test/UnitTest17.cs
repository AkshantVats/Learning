/*
Given a sorted array, search for a target item.( Binary search)
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest17 {
        [Fact]
        public void Test1 () {
            int expected = 1;
            int[] input = new int[] {-2, -1, 4, 5, 6 };
            var actual = Class17.BinarySearch (input, -1);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {
            int expected = -1;
            int[] input = new int[] { 0 };
            var actual = Class17.BinarySearch (input, -1);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {
            int expected = 1;
            int[] input = new int[] { 0, 2 };
            var actual = Class17.BinarySearch (input, 2);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {
            int expected = -1;
            int[] input = null;
            var actual = Class17.BinarySearch (input, 2);
            Assert.Equal (expected, actual);
        }
    }
}