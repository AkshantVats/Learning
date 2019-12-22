/*
Given an array of numbers, move each zero number at the end of the array. e.g, [1,0,5,0,8] -> [1,5,8,0,0].
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest2 {
        [Fact]
        public void Test1 () {

            int[] expected = new int[] { 1, 5, 8, 0, 0 };
            int[] arr = new int[] { 1, 0, 5, 0, 8 };
            var actual = Class2.MoveZerosToEnd (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {

            int[] expected = null;
            int[] arr = null;
            var actual = Class2.MoveZerosToEnd (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {

            int[] expected = new int[] { 1, 2, 3, 4 };
            int[] arr = new int[] { 1, 2, 3, 4 };
            var actual = Class2.MoveZerosToEnd (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {

            int[] expected = new int[] { };
            int[] arr = new int[] { };
            var actual = Class2.MoveZerosToEnd (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test5 () {

            int[] expected = new int[] { 0 };
            int[] arr = new int[] { 0 };
            var actual = Class2.MoveZerosToEnd (arr);
            Assert.Equal (expected, actual);
        }

    }
}