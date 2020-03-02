/*
Given a linked list that has a cycle, find the length of the cycle. The length is in number of nodes.

Using Class 35 which contains Linked List implementation
*/

using System;
using System.Collections.Generic;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test
{
    public class UnitTest41
    {
        [Fact]
        public void Test1()
        {
            int expected = 4;
            var linkedList = new LinkedList();
            Node repeatNode = new Node(null, 2);
            linkedList.AppendLinkedList(new Node(null, 1));
            linkedList.AppendLinkedList(repeatNode);
            linkedList.AppendLinkedList(new Node(null, 3));
            linkedList.AppendLinkedList(new Node(null, 4));
            linkedList.AppendLinkedList(new Node(repeatNode, 5));
            var result = Class41.CycleLength(linkedList);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            int expected = -1;
            var linkedList = new LinkedList();
            Node repeatNode = new Node(null, 2);
            linkedList.AppendLinkedList(new Node(null, 1));
            linkedList.AppendLinkedList(repeatNode);
            linkedList.AppendLinkedList(new Node(null, 3));
            linkedList.AppendLinkedList(new Node(null, 4));
            var result = Class41.CycleLength(linkedList);
            Assert.Equal(expected, result);
        }


        [Fact]
        public void Test3()
        {
            int expected = -1;
            var linkedList = new LinkedList();
            Node repeatNode = new Node(null, 2);
            var result = Class41.CycleLength(linkedList);
            Assert.Equal(expected, result);
        }

    }
}