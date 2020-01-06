/*
You are given a sorted array A and a target T. If the target is found, return the index. If not,return the index where it would be placed if inserted in order.For example,A = [1,2,4,4,5,6,8] and T = 3, return index 2A = [1,2,4,4,5,6,8] and T = 0, return index 0A = [1,2,4,4,5,6,8] and T = 4, return index 2, 3 or 4 (they're all valid).
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test
{
    public class UnitTest19
    {
        [Fact]
        public void Test1()
        {
            int expected = 2;
            int[] input = new int[] { 1, 2, 4, 4, 5, 6, 8 };
            var actual = Class19.FindInsertionIndex(input, 3);
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Test2()
        {
            int expected = 0;
            int[] input = new int[] { 1, 2, 4, 4, 5, 6, 8 };
            var actual = Class19.FindInsertionIndex(input, 0);
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Test3()
        {
            int expected = 4;
            int[] input = new int[] { 1, 2, 4, 4, 5, 6, 8 };
            var actual = Class19.FindInsertionIndex(input, 4);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            int expected = 3;
            int[] input = new int[] { 7, 7, 9 };
            var actual = Class19.FindInsertionIndex(input, 10);
            Assert.Equal(expected, actual);
        }
    }
}