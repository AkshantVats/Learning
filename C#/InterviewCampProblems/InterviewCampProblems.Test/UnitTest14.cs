/*
Given a String, find the longest substring with unique characters. For example: "whatwhywhere" --> "atwhy"
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest14 {
        [Fact]
        public void Test1 () {
            int[] expected = new int[] { 2, 6 };
            string input = "whatwhywhere";
            var actual = Class14.SlidingSubArrayString (input);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {

            int[] expected = new int[] { 0, 3 };
            string input = "abcd";
            var actual = Class14.SlidingSubArrayString (input);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {

            int[] expected = new int[] { 0, 0 };
            string input = "aaaa";
            var actual = Class14.SlidingSubArrayString (input);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {

            int[] expected = new int[] { 0, 1 };
            string input = "ab";
            var actual = Class14.SlidingSubArrayString (input);
            Assert.Equal (expected, actual);
        }
    }
}