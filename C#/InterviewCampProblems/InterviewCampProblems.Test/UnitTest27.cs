/*
Given an array of integers, print all combinations of size X.
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest27 {
        [Fact]
        public void Test1 () {
            int[] expected = new int[] { 123, 124, 134, 234 };
            int[] input = new int[] { 1, 2, 3, 4 };
            int length = 3;
            var actual = Class27.PrintCombos (input, length);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {
            int[] expected = null;
            int[] input = new int[] { 1, 2 };
            int length = 3;
            var actual = Class27.PrintCombos (input, length);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {
            int[] expected = new int[] { 1 };
            int[] input = new int[] { 1 };
            int length = 1;
            var actual = Class27.PrintCombos (input, length);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {
            int[] expected = new int[] { 1, 2 };
            int[] input = new int[] { 1, 2 };
            int length = 1;
            var actual = Class27.PrintCombos (input, length);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test5 () {
            int[] expected = new int[] { 12 };
            int[] input = new int[] { 1, 2 };
            int length = 2;
            var actual = Class27.PrintCombos (input, length);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test6 () {
            int[] expected = null;
            int[] input = new int[] { };
            int length = 0;
            var actual = Class27.PrintCombos (input, length);
            Assert.Equal (expected, actual);
        }

    }
}