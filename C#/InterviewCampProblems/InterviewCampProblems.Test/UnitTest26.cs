/*
Power Function: Implement a function to calculate X^N. Both X and N can be positive or negative. You can assume that overflow doesn't happen.(Try doing it in ​O(log(N))​ time)For example: 2 ^ 2  = 4  2 ^ -2 = 0.25 -2 ^ 3  = -8
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest26 {
        [Fact]
        public void Test1 () {
            int expected = 4;
            int inputNumber = 2;
            int inputPower = 2;
            var actual = Class26.Power (inputNumber, inputPower);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {
            double expected = 0.25;
            int inputNumber = 2;
            int inputPower = -2;
            var actual = Class26.Power (inputNumber, inputPower);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {
            double expected = -8;
            int inputNumber = -2;
            int inputPower = 3;
            var actual = Class26.Power (inputNumber, inputPower);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {
            double expected = 2;
            int inputNumber = 2;
            int inputPower = 1;
            var actual = Class26.Power (inputNumber, inputPower);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test5 () {
            double expected = 1;
            int inputNumber = 2;
            int inputPower = 0;
            var actual = Class26.Power (inputNumber, inputPower);
            Assert.Equal (expected, actual);
        }
    }
}