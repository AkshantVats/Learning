/*
Odd Even Linked List: Given a LinkedList L separate it into 2 LinkedLists. One contains L's odd nodes and the other contains L's even nodes.For example:Input: Head -> 1 -> 2 -> 3 -> 4 -> 5Result 1: Head -> 1 -> 3 -> 5Result 2: Head -> 2 -> 4

Using Class 35 which contains Linked List implementation
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCampProblems.Code
{

    public static class Class37
    {

        public static int[] EvenOddLinkedList(LinkedList input)
        {

            if (input == null)
            {
                return null;
            }

            LinkedList even = new LinkedList();
            LinkedList odd = new LinkedList();

            Node current = input.GetHead();
            int index = 0;
            while (current != null)
            {

                index++;
                if (index % 2 == 0)
                {
                    even.AppendNode(current);
                }
                else
                {
                    odd.AppendNode(current);
                }
                current = current.GetNext();
            }

            LinkedList result = new LinkedList();
            AppendList(even, result);
            AppendList(odd, result);
            return result.ToArray();

        }

        private static void AppendList(LinkedList linkedList, LinkedList result)
        {
            if (linkedList == null || linkedList.GetHead() == null)
            {
                return;
            }
            result.AppendLinkedList(linkedList.GetHead());
        }
    }
}