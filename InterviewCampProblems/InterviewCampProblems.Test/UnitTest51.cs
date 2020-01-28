/*
Implement a Stack with a max() function. This function runs in O(1) time and returns the value of the maximum number on the stack
*/

using System;
using System.Collections.Generic;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test
{
    public class UnitTest51
    {
        [Fact]
        public void Test1()
        {
            int expected = 3;
            Class51 stackWithMax = new Class51();
            stackWithMax.Push(1);
            stackWithMax.Push(2);
            stackWithMax.Push(3);
            stackWithMax.Push(2);
            stackWithMax.Push(1);
            var result = stackWithMax.Max();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            int expected = 1;
            Class51 stackWithMax = new Class51();
            stackWithMax.Push(1);
            var result = stackWithMax.Max();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            int expected = 2;
            Class51 stackWithMax = new Class51();
            stackWithMax.Push(1);
            stackWithMax.Push(2);
            stackWithMax.Push(3);
            stackWithMax.Push(2);
            stackWithMax.Push(1);

            stackWithMax.Pop();
            stackWithMax.Pop();
            stackWithMax.Pop();

            var result = stackWithMax.Max();
            Assert.Equal(expected, result);
        }
    }
}