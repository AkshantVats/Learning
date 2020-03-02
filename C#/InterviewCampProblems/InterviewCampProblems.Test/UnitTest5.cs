/*
2 Sum Problem: Given a sorted array of integers, find two numbers in the array that sum to a given integer target.For example, if a = [1,2,3,5,6,7] and target = 11, the answer will be 5 and 6.
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest5 {
        [Fact]
        public void Test1 () {

            int target = 11;
            int[] expected = new int[] { 5, 6 };
            int[] arr = new int[] { 1, 2, 3, 5, 6, 7 };
            var actual = Class5.SumOfTwoNumbers (arr, target);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {

            int target = 0;
            int[] expected = null;
            int[] arr = new int[] { 1, 2, 3, 5, 6, 7 };
            var actual = Class5.SumOfTwoNumbers (arr, target);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {

            int target = 1;
            int[] expected = null;
            int[] arr = new int[] { 1 };
            var actual = Class5.SumOfTwoNumbers (arr, target);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {

            int target = 3;
            int[] expected = new int[] { 1, 2 };;
            int[] arr = new int[] { 1, 2 };
            var actual = Class5.SumOfTwoNumbers (arr, target);
            Assert.Equal (expected, actual);
        }
    }
}