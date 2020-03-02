/*
Given a Linked List, determine if it is a Palindrome. For example, the following lists are palindromes:
A -> B -> C -> B -> A
A -> B -> B -> A
K -> A -> Y -> A -> K

*/

using System;
using System.Collections.Generic;
using InterviewCampProblems.Code;
using Xunit;

namespace InterviewCampProblems.Test
{
    public class UnitTest47
    {
        [Fact]
        public void Test1()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AppendNodes(new List<Node>()
            {
                new Node(null,1),
                new Node(null,2),
                new Node(null,3),
                new Node(null,2),
                new Node(null,1),
            });
            var result = Class47.isPalindrome(linkedList);
            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AppendNodes(new List<Node>()
            {
                new Node(null,1),
                new Node(null,3),
                new Node(null,3),
                new Node(null,2),
                new Node(null,1),
            });
            var result = Class47.isPalindrome(linkedList);
            Assert.False(result);
        }

        [Fact]
        public void Test3()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AppendNodes(new List<Node>()
            {
                new Node(null,1),
            });
            var result = Class47.isPalindrome(linkedList);
            Assert.True(result);
        }
    }
}