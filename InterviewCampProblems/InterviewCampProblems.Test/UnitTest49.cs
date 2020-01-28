/*
Implement a Queue using 2 stacks.
*/

using System;
using System.Collections.Generic;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test
{
    public class UnitTest49
    {
        [Fact]
        public void Test1()
        {
            int[] expected = new int[] { 1, 2, 3, 4, 5 };
            Class49_Queue<int> queue = new Class49_Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            var result = queue.ToArray();
            Assert.Equal(expected, result);
        }
    }
}