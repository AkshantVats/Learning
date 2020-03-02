/*
Coin Change Problem: Given a set of coin denominations, print out the different ways you can make a target amount. You can use as many coins of each denomination as you like.For example: If coins are [1,2,5] and the target is 5, output will be:[1,1,1,1,1][1,1,1,2][1,2,2][5]
*/

using System;
using System.Collections.Generic;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest31 {
        [Fact]
        public void Test1 () {
            List<int[]> expected = new List<int[]> {
                new int[] { 1, 1, 1, 1, 1 },
                new int[] { 2, 1, 1, 1 },
                new int[] { 2, 2, 1 },
                new int[] { 5 },
            };
            int[] input = new int[] { 1, 2, 5 };
            int target = 5;
            var actual = Class31.PrintCoins (input, target);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {
            List<int[]> expected = null;
            int[] input = new int[] { 1, 2, 5 };
            int target = 0;
            var actual = Class31.PrintCoins (input, target);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {
            List<int[]> expected = new List<int[]> {
                new int[] { 1, 1, 1 },
                new int[] { 2, 1 }
            };
            int[] input = new int[] { 1, 2, 5 };
            int target = 3;
            var actual = Class31.PrintCoins (input, target);
            Assert.Equal (expected, actual);
        }
    }
}