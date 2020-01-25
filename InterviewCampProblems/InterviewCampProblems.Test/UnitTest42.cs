/*
Find the median node of a linked list. For example: 1 -> 2 -> 3 -> 4 -> 5      
Median node is 3.

Using Class 35 which contains Linked List implementation
*/

using System;
using System.Collections.Generic;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test
{
    public class UnitTest42
    {
        [Fact]
        public void Test1()
        {
            int expected = 4;
            var linkedList = new LinkedList();
            linkedList.AppendNodes(new List<Node>() {
                new Node (null, 1),
                    new Node (null, 2),
                    new Node (null, 3),
                    new Node (null, 4),
                    new Node (null, 5),
                    new Node (null, 6),
                    new Node (null, 7),
                    new Node (null, 8)
            });
            var result = Class42.FindMedian(linkedList);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            int expected = 1;
            var linkedList = new LinkedList();
            linkedList.AppendNodes(new List<Node>() {
                new Node (null, 1),
                    new Node (null, 2)
            });
            var result = Class42.FindMedian(linkedList);
            Assert.Equal(expected, result);
        }


        [Fact]
        public void Test3()
        {
            int expected = 1;
            var linkedList = new LinkedList();
            linkedList.AppendNodes(new List<Node>() {
                new Node (null, 1)
            });
            var result = Class42.FindMedian(linkedList);
            Assert.Equal(expected, result);
        }

    }
}