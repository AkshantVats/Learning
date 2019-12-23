/*
Given a sorted array in non-decreasing order, return an array of squares of each number, also in non-decreasing order. For example:[-4,-2,-1,0,3,5] -> [0,1,4,9,16,25]
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest6 {
        [Fact]
        public void Test1 () {

            int[] expected = new int[] { 0, 1, 4, 9, 16, 25 };
            int[] arr = new int[] {-4, -2, -1, 0, 3, 5 };
            var actual = Class6.SquareOfEachNumber (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {

            int[] expected = new int[] { };
            int[] arr = new int[] { };
            var actual = Class6.SquareOfEachNumber (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {

            int[] expected = null;
            int[] arr = null;
            var actual = Class6.SquareOfEachNumber (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {

            int[] expected = new int[] { 1, 4 };
            int[] arr = new int[] {-2, 1 };
            var actual = Class6.SquareOfEachNumber (arr);
            Assert.Equal (expected, actual);
        }
    }
}