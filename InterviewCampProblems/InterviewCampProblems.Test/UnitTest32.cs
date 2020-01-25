/*
Maze Problem: You are given a 2D array that represents a maze. It can have 2 values - 0 and 1. 1 represents a wall and 0 represents a path.The objective is to reach the bottom right corner, i.e, A[A.length-1][A.length-1]. You start fromA[0][0]. You can move in 4 directions - up, down, left and right. Find if a path exists to the bottom right of the maze. For example, a path exists in the following maze:0 1 1 1 0 1 1 1 0 0 0 0 1 1 1 0

Solution:
Core Idea:        From every ​a[i][j]​, check if there is a path to the end.
Steps/Splits:     Check from left element, right element, up and down.
Converge/Collect: If any of the checks returns ​true​, return ​true​.
Memoization:      Can we memoize? Yes, for every element, we cansave three states: ​UNVISITED​, ​VISITING​,NO_PATH_FOUND​.
Base Cases:       a[i][j]​ is Out of Bounds, Wall,or the  last element
*/

using System;
using System.Collections.Generic;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest32 {
        [Fact]
        public void Test1 () {
            int[, ] input = new int[4, 4] { { 0, 0, 0, 1 }, { 1, 1, 0, 1 }, { 1, 1, 0, 1 }, { 1, 1, 0, 0 } };
            var actual = Class32.PathExists (input);
            Assert.True (actual);
        }

        [Fact]
        public void Test2 () {
            int[, ] input = new int[4, 4] { { 0, 0, 0, 1 }, { 1, 1, 1, 1 }, { 1, 1, 0, 1 }, { 1, 1, 0, 0 } };
            var actual = Class32.PathExists (input);
            Assert.False (actual);
        }

        [Fact]
        public void Test3 () {
            int[, ] input = new int[0, 0];
            var actual = Class32.PathExists (input);
            Assert.False (actual);
        }

        [Fact]
        public void Test4 () {
            int[, ] input = new int[2, 2] { { 0, 0 }, { 1, 1 } };
            var actual = Class32.PathExists (input);
            Assert.False (actual);
        }

        [Fact]
        public void Test5 () {
            int[, ] input = new int[2, 2] { { 0, 0 }, { 1, 0 } };
            var actual = Class32.PathExists (input);
            Assert.True (actual);
        }

    }
}