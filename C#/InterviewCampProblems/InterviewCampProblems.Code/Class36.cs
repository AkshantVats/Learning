/*
You are given a LinkedList with nodes that have values 0,1 or 2.Sort the linked list.

Using Class 35 which contains Linked List implementation
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCampProblems.Code
{

    public static class Class36
    {

        public static int[] SortLinkedList(LinkedList input)
        {

            if (input == null)
            {
                return null;
            }

            LinkedList linkedList0 = new LinkedList();
            LinkedList linkedList1 = new LinkedList();
            LinkedList linkedList2 = new LinkedList();

            Node current = input.GetHead();

            while (current != null)
            {
                switch (current.GetData())
                {

                    case 0:
                        linkedList0.AppendNode(current);
                        break;
                    case 1:
                        linkedList1.AppendNode(current);
                        break;
                    case 2:
                        linkedList2.AppendNode(current);
                        break;
                    default:
                        throw new ArgumentException("Invalid value: " + current.GetData());

                }
                current = current.GetNext();
            }

            LinkedList result = new LinkedList();
            AppendList(linkedList0, result);
            AppendList(linkedList1, result);
            AppendList(linkedList2, result);

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