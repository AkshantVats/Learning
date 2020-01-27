/*
Reverse a linked list. You should use O(1) space.

Using Class 35 which contains Linked List implementation
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCampProblems.Code
{
    public static class Class46
    {
        public static int[] Reverse(LinkedList linkedList)
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
            return ToArray(prev);
        }

        private static int[] ToArray(Node next)
        {
            List<int> result = new List<int>();
            while (next != null)
            {
                result.Add(next.GetData());
                next = next.GetNext();
            }
            return result.ToArray();
        }
    }
}