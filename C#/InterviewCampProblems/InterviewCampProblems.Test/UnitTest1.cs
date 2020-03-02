/*
Given an array of numbers, replace each even number with two of the same number. e.g, [1,2,5,6,8, , , ,] -> [1,2,2,5,6,6,8,8].Assume that the array has the exact amount of space to accommodate the result.
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest1 {
        [Fact]
        public void Test1 () {

            int[] expected = new int[] { 1, 2, 2, 5, 6, 6, 8, 8 };
            int[] arr = new int[] { 1, 2, 5, 6, 8, -1, -1, -1 };
            var actual = Class1.CloneEvenNumbers (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {

            int[] expected = null;
            int[] arr = null;
            var actual = Class1.CloneEvenNumbers (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {

            int[] expected = new int[] {-1, -1, -1, -1, -1, -1, -1, -1 };
            int[] arr = new int[] {-1, -1, -1, -1, -1, -1, -1, -1 };
            var actual = Class1.CloneEvenNumbers (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {

            int[] expected = new int[] { };
            int[] arr = new int[] { };
            var actual = Class1.CloneEvenNumbers (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test5 () {

            int[] expected = new int[] { 1, 3, 5 };
            int[] arr = new int[] { 1, 3, 5 };
            var actual = Class1.CloneEvenNumbers (arr);
            Assert.Equal (expected, actual);
        }

    }
}