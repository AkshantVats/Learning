/*
Given a sorted array of Integers, find the target. If the target is not found,return the element closest to the target.For example,A = [1,2,4,5,7,8,9], Target = 6 -> Output Index = 3 or 4 (since both 5 and 7 are equally close)
*/

using System;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test
{
    public class UnitTest20
    {
        [Fact]
        public void Test1()
        {
            int expected = 3;
            int[] input = new int[] { 1, 2, 4, 5, 7, 8, 9 };
            var actual = Class20.ClosestElement(input, 6);
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Test2()
        {
            int expected = 0;
            int[] input = new int[] { 2, 4, 5, 7, 8, 9 };
            var actual = Class20.ClosestElement(input, 1);
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Test3()
        {
            int expected = 0;
            int[] input = new int[] { 2, 4 };
            var actual = Class20.ClosestElement(input, 3);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test4()
        {
            int expected = -1;
            int[] input = null;
            var actual = Class20.ClosestElement(input, 3);
            Assert.Equal(expected, actual);
        }
    }
}