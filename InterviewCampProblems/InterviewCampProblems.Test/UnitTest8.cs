/*
You are given an array of integers. Rearrange the array so that all zeroes are at the beginning of the array.For example,a = [4,2,0,1,0,3,0] -> [0, 0, 0, 1, 2, 3, 4]
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest8 {
        [Fact]
        public void Test1 () {

            int[] expected = new int[] { 0, 0, 0, 1, 2, 3, 4 };
            int[] arr = new int[] { 4, 2, 0, 1, 0, 3, 0 };
            var actual = Class8.MoveZerosToStart (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {

            int[] expected = new int[] { 4 };
            int[] arr = new int[] { 4 };
            var actual = Class8.MoveZerosToStart (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {

            int[] expected = new int[] { 0 };
            int[] arr = new int[] { 0 };
            var actual = Class8.MoveZerosToStart (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {

            int[] expected = null;
            int[] arr = null;
            var actual = Class8.MoveZerosToStart (arr);
            Assert.Equal (expected, actual);
        }
    }
}