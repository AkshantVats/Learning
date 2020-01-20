/*
Phone Number Mnemonics: Given an N digit phone number, print all the strings that can be made from that phone number. Since 1 and 0 don't correspond to any characters, ignore them.
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest28 {
        [Fact]
        public void Test1 () {
            string[] expected = new string[] { "a", "b", "c" };
            int[] input = new int[] { 1, 2 };
            var actual = Class28.PrintCombos (input);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {
            string[] expected = new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };
            int[] input = new int[] { 2, 3 };
            var actual = Class28.PrintCombos (input);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {
            string[] expected = null;
            int[] input = new int[] { };
            var actual = Class28.PrintCombos (input);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test4 () {
            string[] expected = new string[] { "" };
            int[] input = new int[] { 1 };
            var actual = Class28.PrintCombos (input);
            Assert.Equal (expected, actual);
        }

    }
}