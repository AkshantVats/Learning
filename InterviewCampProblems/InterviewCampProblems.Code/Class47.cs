/*
Given a Linked List, determine if it is a Palindrome. For example, the following lists are palindromes:
A -> B -> C -> B -> A
A -> B -> B -> A
K -> A -> Y -> A -> K

*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCampProblems.Code
{
    public static class Class47
    {
        public static bool isPalindrome(LinkedList linkedList)
        {
            var head = linkedList.GetHead();
            if (head == null)
            {
                return false;
            }
            Node median = FindMedian(head);
            Node last = Reverse(new LinkedList(median));
            Node start = head, end = last;
            while (start != null && end != null)
            {
                if (start.GetData() != end.GetData())
                {
                    return false;
                }

                start = start.GetNext();
                end = end.GetNext();
            }
            return true;

        }

        public static Node FindMedian(Node head)
        {

            Node fast = head, slow = head;
            while (fast.GetNext() != null)
            {
                fast = fast.GetNext();
                if (fast.GetNext() == null)
                {
                    break;
                }
                fast = fast.GetNext();
                slow = slow.GetNext();
            }

            return slow;

        }

        public static Node Reverse(LinkedList linkedList)
        {
            Node prev = null;
            Node curr = linkedList.GetHead();

            while (curr != null)
            {
                Node next = curr.GetNext();
                curr.SetNext(prev);
                prev = curr;
                curr = next;

            }
            return prev;
        }
    }
}