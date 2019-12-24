/*
You're given a list of Marbles. Each marble can have one of 3 colors (Red, White or Blue).Arrange the marbles in order of the colors (Red -> White -> Blue).Colors are represented as follows:0 - Red 1 - White 2 - Blue
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest11 {
        [Fact]
        public void Test1 () {
            int[] expected = new int[] { 0, 0, 1, 1, 2, 2 };
            int[] arr = new int[] { 0, 1, 2, 2, 1, 0 };
            var actual = Class11.ShortMarbles (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {

            int[] expected = new int[] { 2 };
            int[] arr = new int[] { 2 };
            var actual = Class11.ShortMarbles (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {

            int[] expected = new int[] { 0 };
            int[] arr = new int[] { 0 };
            var actual = Class11.ShortMarbles (arr);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {

            int[] expected = null;
            int[] arr = null;
            var actual = Class11.ShortMarbles (arr);
            Assert.Equal (expected, actual);
        }
    }
}