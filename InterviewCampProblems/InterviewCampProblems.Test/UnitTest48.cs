/*
Find if a given number N exists in a stack S
*/

using System;
using System.Collections.Generic;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test
{
    public class UnitTest48
    {
        [Fact]
        public void Test1()
        {
            int target = 4;
            List<int> stackInput = new List<int>()
            {
                1,2,3,4,5
            };
            Stack<int> input = new Stack<int>(stackInput);
            var result = Class48.IsInStack(target, input);
            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            int target = 7;
            List<int> stackInput = new List<int>()
            {
                1,2,3,4,5
            };
            Stack<int> input = new Stack<int>(stackInput);
            var result = Class48.IsInStack(target, input);
            Assert.False(result);
        }


        [Fact]
        public void Test3()
        {
            int target = 7;
            Stack<int> input = new Stack<int>();
            var result = Class48.IsInStack(target, input);
            Assert.False(result);
        }
    }
}