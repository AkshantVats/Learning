/*
Given a sentence, reverse the words of the sentence.For example,"i live in a house" becomes "house a in live i"
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest3 {
        [Fact]
        public void Test1 () {
            string expected = "house a in live i";
            string sentence = "i live in a house";
            var actual = Class3.ReverseSentence (sentence);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test2 () {
            string expected = " ";
            string sentence = " ";
            var actual = Class3.ReverseSentence (sentence);
            Assert.Equal (expected, actual);
        }

        [Fact]
        public void Test3 () {
            string expected = null;
            string sentence = null;
            var actual = Class3.ReverseSentence (sentence);
            Assert.Equal (expected, actual);
        }

    }
}