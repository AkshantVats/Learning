/*
Find if a given Linked List has a cycle.

Using Class 35 which contains Linked List implementation
*/

using System;
using System.Collections.Generic;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test
{
    public class UnitTest40
    {
        [Fact]
        public void Test1()
        {
            var linkedList = new LinkedList();
            Node repeatNode = new Node(null, 2);
            linkedList.AppendLinkedList(new Node(null, 1));
            linkedList.AppendLinkedList(repeatNode);
            linkedList.AppendLinkedList(new Node(null, 3));
            linkedList.AppendLinkedList(new Node(null, 4));
            linkedList.AppendLinkedList(new Node(repeatNode, 5));
            var result = Class40.HasCycle(linkedList);
            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            var linkedList = new LinkedList();
            Node repeatNode = new Node(null, 2);
            linkedList.AppendLinkedList(new Node(null, 1));
            linkedList.AppendLinkedList(repeatNode);
            linkedList.AppendLinkedList(new Node(null, 3));
            linkedList.AppendLinkedList(new Node(null, 4));
            linkedList.AppendLinkedList(new Node(null, 5));
            var result = Class40.HasCycle(linkedList);
            Assert.False(result);
        }


        [Fact]
        public void Test3()
        {
            var linkedList = new LinkedList();
            Node repeatNode = new Node(null, 2);
            linkedList.AppendLinkedList(new Node(null, 1));
            var result = Class40.HasCycle(linkedList);
            Assert.False(result);
        }

    }
}