/*
Given a Linked List with a cycle, find the node where the cycle begins.For example, node 2 in this linked list: 1->2->3->4->5->2

Using Class 35 which contains Linked List implementation
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCampProblems.Code
{

    public static class Class43
    {
        public static Node FindCycleStart(LinkedList input)
        {
            if (input == null || input.GetHead() == null)
            {
                return null;
            }

            Node fastPointer = input.GetHead();
            Node slowPointer = input.GetHead();

            while (fastPointer != null)
            {
                fastPointer = fastPointer.GetNext();
                if (fastPointer == slowPointer)
                {
                    break;
                }

                if (fastPointer != null)
                {
                    fastPointer = fastPointer.GetNext();
                    if (fastPointer == slowPointer)
                    {
                        break;
                    }
                }

                slowPointer = slowPointer.GetNext();
            }

            if (fastPointer == null)
            {
                return null;
            }

            fastPointer = fastPointer.GetNext();
            int cycleNodes = 1;
            while (fastPointer != slowPointer)
            {
                fastPointer = fastPointer.GetNext();
                cycleNodes++;
            }

            Node front = input.GetHead(), back = input.GetHead();

            for (int i = 0; i < cycleNodes; i++)
            {
                front = front.GetNext();
            }

            while (front != back)
            {
                front = front.GetNext();
                back = back.GetNext();
            }

            return front;
        }
    }
}