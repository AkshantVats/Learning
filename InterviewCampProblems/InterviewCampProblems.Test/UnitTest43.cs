/*
Given a Linked List with a cycle, find the node where the cycle begins.For example, node 2 in this linked list: 1->2->3->4->5->2

Using Class 35 which contains Linked List implementation
*/

using System;
using System.Collections.Generic;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test
{
    public class UnitTest43
    {
        [Fact]
        public void Test1()
        {
            int expected = 2;
            var linkedList = new LinkedList();
            Node repeatNode = new Node(null, 2);
            linkedList.AppendLinkedList(new Node(null, 1));
            linkedList.AppendLinkedList(repeatNode);
            linkedList.AppendLinkedList(new Node(null, 3));
            linkedList.AppendLinkedList(new Node(null, 4));
            linkedList.AppendLinkedList(new Node(repeatNode, 5));
            var result = Class43.FindCycleStart(linkedList);
            Assert.Equal(expected, result.GetData());
        }

        [Fact]
        public void Test2()
        {
            int expected = 7;
            var linkedList = new LinkedList();
            Node repeatNode = new Node(null, 7);
            linkedList.AppendLinkedList(new Node(null, 1));
            linkedList.AppendLinkedList(repeatNode);
            linkedList.AppendLinkedList(new Node(repeatNode, 3));
            var result = Class43.FindCycleStart(linkedList);
            Assert.Equal(expected, result.GetData());
        }

        [Fact]
        public void Test3()
        {
            var linkedList = new LinkedList();
            Node repeatNode = new Node(null, 7);
            linkedList.AppendLinkedList(new Node(null, 1));
            var result = Class43.FindCycleStart(linkedList);
            Assert.Null(result);
        }


    }
}