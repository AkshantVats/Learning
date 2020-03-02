/*
Given an array of integers A, print all its subsets.For example:Input:​ [1, 2, 3]Output:[][1][2][3][1, 2][1, 3][2, 3][1, 2, 3]
*/

using System;
using System.Collections.Generic;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest29 {
        [Fact]
        public void Test1 () {
            List<int[]> expected = new List<int[]> {
                new int[] { },
                new int[] { 1 },
                new int[] { 2 },
                new int[] { 3 },
                new int[] { 1, 2 },
                new int[] { 1, 3 },
                new int[] { 2, 3 },
                new int[] { 1, 2, 3 }
            };
            int[] input = new int[] { 1, 2, 3 };
            var actual = Class29.PrintSubset (input);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {
            List<int[]> expected = null;
            int[] input = new int[] { };
            var actual = Class29.PrintSubset (input);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {
            List<int[]> expected = new List<int[]> {
                new int[] { },
                new int[] { 1 },
                new int[] { 1, 1 },
                new int[] { 1, 2 },
                new int[] { 2 },
                new int[] { 2, 1 },
                new int[] { 2, 2 }
            };
            int[] input = new int[] { 1, 2 };
            var actual = Class29.PrintSubset (input);
            Assert.Equal (expected, actual);
        }
    }
}