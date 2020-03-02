/*
You are given an array of integers and a pivot. Rearrange the array in thefollowing order:[all elements less than pivot, elements equal to pivot, elements greater than pivot]For example,a = [5,2,4,4,6,4,4,3] and pivot = 4 --> result = [3,2,4,4,4,4,6,5].
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest10 {
        [Fact]
        public void Test1 () {

            int[] expected = new int[] { 3, 2, 4, 4, 4, 4, 6, 5 };
            int[] arr = new int[] { 5, 2, 4, 4, 6, 4, 4, 3 };
            var actual = Class10.DutchNationalFlag (arr, 4);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {

            int[] expected = new int[] { 4 };
            int[] arr = new int[] { 4 };
            var actual = Class10.DutchNationalFlag (arr, 4);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {

            int[] expected = new int[] { 0 };
            int[] arr = new int[] { 0 };
            var actual = Class10.DutchNationalFlag (arr, 4);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {

            int[] expected = null;
            int[] arr = null;
            var actual = Class10.DutchNationalFlag (arr, 4);
            Assert.Equal (expected, actual);
        }
    }
}