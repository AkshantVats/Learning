/*
Given an array, reverse the order of its elements.For example, [3,5,2,5,2,3,9] → [9,3,2,5,2,5,3]
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest4 {
        [Fact]
        public void Test1 () {

            int[] expected = new int[] { 9, 3, 2, 5, 2, 5, 3 };
            int[] arr = new int[] { 3, 5, 2, 5, 2, 3, 9 };
            var actual = Class4.ReverseElement (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {

            int[] expected = null;
            int[] arr = null;
            var actual = Class4.ReverseElement (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {

            int[] expected = new int[] { };
            int[] arr = new int[] { };
            var actual = Class4.ReverseElement (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {

            int[] expected = new int[] { 1 };
            int[] arr = new int[] { 1 };
            var actual = Class4.ReverseElement (arr);
            Assert.Equal (expected, actual);
        }
    }
}