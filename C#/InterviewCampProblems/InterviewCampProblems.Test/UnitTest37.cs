/*
Odd Even Linked List: Given a LinkedList L separate it into 2 LinkedLists. One contains L's odd nodes and the other contains L's even nodes.For example:Input: Head -> 1 -> 2 -> 3 -> 4 -> 5Result 1: Head -> 1 -> 3 -> 5Result 2: Head -> 2 -> 4

Using Class 35 which contains Linked List implementation
*/

using System;
using System.Collections.Generic;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test
{
    public class UnitTest37
    {
        [Fact]
        public void Test1()
        {
            int[] expected = new int[] { 2, 2, 2, 2, 1, 1, 1, 1 };
            var linkedList = new LinkedList();
            linkedList.AppendNodes(new List<Node>() {
                new Node (null, 1),
                    new Node (null, 2),
                    new Node (null, 1),
                    new Node (null, 2),
                    new Node (null, 1),
                    new Node (null, 2),
                    new Node (null, 1),
                    new Node (null, 2)
            });
            var result = Class37.EvenOddLinkedList(linkedList);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            int[] expected = new int[] { 1, 2 };
            var linkedList = new LinkedList();
            linkedList.AppendNodes(new List<Node>() {
                new Node (null, 2),
                    new Node (null, 1)
            });
            var result = Class37.EvenOddLinkedList(linkedList);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            int[] expected = new int[] { 1, 3, 2, };
            var linkedList = new LinkedList();
            linkedList.AppendNodes(new List<Node>() {
                new Node (null, 3),
                    new Node (null, 1),
                    new Node (null, 2)
            });
            var result = Class37.EvenOddLinkedList(linkedList);
            Assert.Equal(expected, result);
        }

    }
}