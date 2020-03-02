/*
Reverse a linked list. You should use O(1) space.

Using Class 35 which contains Linked List implementation
*/

using System;
using System.Collections.Generic;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test
{
    public class UnitTest46
    {
        [Fact]
        public void Test1()
        {
            int[] expected = new int[] { 5, 4, 3, 2, 1 };
            LinkedList linkedList = new LinkedList();
            linkedList.AppendNodes(new List<Node>()
            {
                new Node(null,1),
                new Node(null,2),
                new Node(null,3),
                new Node(null,4),
                new Node(null,5),
            });
            var result = Class46.Reverse(linkedList);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            int[] expected = new int[] { 1 };
            LinkedList linkedList = new LinkedList();
            linkedList.AppendNodes(new List<Node>()
            {
                new Node(null,1)
            });
            var result = Class46.Reverse(linkedList);
            Assert.Equal(expected, result);
        }
    }
}