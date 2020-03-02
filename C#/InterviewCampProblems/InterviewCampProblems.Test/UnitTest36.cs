/*
You are given a LinkedList with nodes that have values 0,1 or 2.Sort the linked list.

Using Class 35 which contains Linked List implementation
*/

using System;
using System.Collections.Generic;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test
{
    public class UnitTest36
    {
        [Fact]
        public void Test1()
        {
            int[] expected = new int[] { 0, 0, 0, 0, 1, 1, 2, 2 };
            var linkedList = new LinkedList();
            linkedList.AppendNodes(new List<Node>() {
                new Node (null, 0),
                    new Node (null, 0),
                    new Node (null, 2),
                    new Node (null, 0),
                    new Node (null, 1),
                    new Node (null, 0),
                    new Node (null, 1),
                    new Node (null, 2),
            });
            var result = Class36.SortLinkedList(linkedList);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            int[] expected = new int[] { };
            var linkedList = new LinkedList();
            var result = Class36.SortLinkedList(linkedList);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            int[] expected = new int[] { 1, 1, 2, 2 };
            var linkedList = new LinkedList();
            linkedList.AppendNodes(new List<Node>() {
                    new Node (null, 2),
                    new Node (null, 1),
                    new Node (null, 1),
                    new Node (null, 2),
            });
            var result = Class36.SortLinkedList(linkedList);
            Assert.Equal(expected, result);
        }

    }
}