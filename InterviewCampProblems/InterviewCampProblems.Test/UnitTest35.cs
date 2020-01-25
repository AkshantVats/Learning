/*
Linked List Implementation
*/

using System;
using System.Collections.Generic;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test {
    public class UnitTest35 {
        [Fact]
        public void Test1 () {
            int[] expected = new int[] { 1, 2 };
            var linkedList = new LinkedList (new Node (null, 1));
            linkedList.InsertNode (1, new Node (null, 2));
            Assert.Equal (expected, linkedList.ToArray ());
        }

        [Fact]
        public void Test2 () {
            int[] expected = new int[] { 1, 3, 2 };
            var linkedList = new LinkedList (new Node (null, 1));
            linkedList.InsertNode (1, new Node (null, 2));
            linkedList.InsertNode (1, new Node (null, 3));
            Assert.Equal (expected, linkedList.ToArray ());
        }

        [Fact]
        public void Test3 () {
            int[] expected = new int[] { 1, 2 };
            var linkedList = new LinkedList (new Node (null, 1));
            linkedList.InsertNode (1, new Node (null, 2));
            linkedList.InsertNode (1, new Node (null, 3));
            linkedList.RemoveNode (2);
            Assert.Equal (expected, linkedList.ToArray ());
        }

        [Fact]
        public void Test4 () {
            int expected = 2;
            var linkedList = new LinkedList (new Node (null, 1));
            linkedList.InsertNode (1, new Node (null, 2));
            linkedList.InsertNode (2, new Node (null, 3));
            var node = linkedList.GetNode (2);
            Assert.Equal (expected, node.GetData ());
        }

        [Fact]
        public void Test5 () {
            int[] expected = new int[] { 1, 3 };
            var linkedList = new LinkedList (new Node (null, 1));
            linkedList.InsertNode (1, new Node (null, 2));
            linkedList.InsertNode (2, new Node (null, 3));
            linkedList.RemoveNode (2);
            Assert.Equal (expected, linkedList.ToArray ());
        }

        [Fact]
        public void Test6 () {
            int[] expected = new int[] { 2, 3 };
            var linkedList = new LinkedList (new Node (null, 1));
            linkedList.InsertNode (1, new Node (null, 2));
            linkedList.InsertNode (2, new Node (null, 3));
            linkedList.RemoveHead ();
            Assert.Equal (expected, linkedList.ToArray ());
        }

        [Fact]
        public void Test7 () {
            int[] expected = new int[] { 2, 3 };
            var linkedList = new LinkedList (new Node (null, 1));
            linkedList.InsertNode (1, new Node (null, 2));
            linkedList.InsertNode (2, new Node (null, 3));
            linkedList.RemoveNode (1);
            Assert.Equal (expected, linkedList.ToArray ());
        }

    }
}