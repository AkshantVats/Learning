/*
Given a sorted array that can contain duplicates, find the first occurrence of the target element. For example:A = [1,3,4,6,6,6,7] and Target = 6, return index 3.
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test
{
    public class UnitTest18
    {
        [Fact]
        public void Test1()
        {
            int expected = 3;
            int[] input = new int[] { 1, 3, 4, 6, 6, 6, 7 };
            var actual = Class18.FirstOccurence(input, 6);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int expected = 3;
            int[] input = new int[] { 1, 3, 4, -6, -6, -6, 7 };
            var actual = Class18.FirstOccurence(input, -6);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            int expected = -1;
            int[] input = new int[] { 7 };
            var actual = Class18.FirstOccurence(input, 1);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            int expected = 0;
            int[] input = new int[] { 7, 7 };
            var actual = Class18.FirstOccurence(input, 7);
            Assert.Equal(expected, actual);
        }
    }
}