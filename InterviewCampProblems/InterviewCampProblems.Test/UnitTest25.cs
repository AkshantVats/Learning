/*
Find the nth number in the Fibonacci series. Fibonacci series is as follows:1, 1, 2, 3, 5, 8, 13, 21, .. After the first two 1’s, each number is the sum of the previous two numbers.
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest25 {
        [Fact]
        public void Test1 () {
            int expected = 8;
            int input = 6;
            var actual = Class25.FibonacciSeries (input);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {
            int expected = 1;
            int input = 2;
            var actual = Class25.FibonacciSeries (input);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {
            int expected = 0;
            int input = 0;
            var actual = Class25.FibonacciSeries (input);
            Assert.Equal (expected, actual);
        }
    }
}