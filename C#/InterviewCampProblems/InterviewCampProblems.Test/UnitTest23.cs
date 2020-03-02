/*
Find the square root of an integer X. For example, squareRoot(4) = 2.If X is not a perfect square, find the integer floor of the square root. For example,squareRoot(5) & squareRoot(8) will return 2. squareRoot(9) will return 3.
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest23 {
        [Fact]
        public void Test1 () {
            int expected = 2;
            var actual = Class23.FloorSquareRoot (4);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {
            int expected = 2;
            var actual = Class23.FloorSquareRoot (5);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {
            int expected = 1;
            var actual = Class23.FloorSquareRoot (1);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {
            int expected = 3;
            var actual = Class23.FloorSquareRoot (9);
            Assert.Equal (expected, actual);
        }
    }
}