/*
Search Array of Unknown length You are given an array, but you don't know the length. Write a program to find a target element in the array.
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest22 {
        [Fact]
        public void Test1 () {
            int expected = 1;
            int[] input = new int[] { 1, 2, 3, 4, 5 };
            var actual = Class22.FindWithUnknownLength (input, 2);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {
            int expected = 0;
            int[] input = new int[] { 1, 2 };
            var actual = Class22.FindWithUnknownLength (input, 1);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {
            int expected = -1;
            int[] input = new int[] { 1, 2 };
            var actual = Class22.FindWithUnknownLength (input, 5);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {
            int expected = -1;
            int[] input = null;
            var actual = Class22.FindWithUnknownLength (input, 1);
            Assert.Equal (expected, actual);
        }
    }
}