/*
Given an array A, print all permutations of size X.For example,Input:A = [1,2,3]X = 2Output:[1, 2][1, 3][2, 1][2, 3][3, 1][3, 2]
*/

using System;
using System.Collections.Generic;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest30 {
        [Fact]
        public void Test1 () {
            List<int[]> expected = new List<int[]> {
                new int[] { 1, 2 },
                new int[] { 1, 3 },
                new int[] { 2, 1 },
                new int[] { 2, 3 },
                new int[] { 3, 1 },
                new int[] { 3, 2 }
            };
            int[] input = new int[] { 1, 2, 3 };
            int length = 2;
            var actual = Class30.PrintPerms (input, length);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {
            List<int[]> expected = null;
            int[] input = new int[] { 1, 2, 3 };
            int length = 4;
            var actual = Class30.PrintPerms (input, length);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {
            List<int[]> expected = new List<int[]> {
                new int[] { 1 },
                new int[] { 2 },
                new int[] { 3 },
            };
            int[] input = new int[] { 1, 2, 3 };
            int length = 1;
            var actual = Class30.PrintPerms (input, length);
            Assert.Equal (expected, actual);
        }
    }
}