/*
Given an array of integers, rearrange the elements such that all zeros aremoved to the end of the array.
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest9 {
        [Fact]
        public void Test1 () {

            int[] expected = new int[] { 4, 2, 3, 1, 0, 0, 0 };
            int[] arr = new int[] { 4, 2, 0, 1, 0, 3, 0 };
            var actual = Class9.MoveZerosToEnd (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {

            int[] expected = new int[] { 4 };
            int[] arr = new int[] { 4 };
            var actual = Class9.MoveZerosToEnd (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {

            int[] expected = new int[] { 0 };
            int[] arr = new int[] { 0 };
            var actual = Class9.MoveZerosToEnd (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {

            int[] expected = null;
            int[] arr = null;
            var actual = Class9.MoveZerosToEnd (arr);
            Assert.Equal (expected, actual);
        }
    }
}