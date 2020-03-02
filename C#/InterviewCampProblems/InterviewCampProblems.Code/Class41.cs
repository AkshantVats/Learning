/*
Given a linked list that has a cycle, find the length of the cycle. The length is in number of nodes.

Using Class 35 which contains Linked List implementation
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCampProblems.Code
{

    public static class Class41
    {
        public static int CycleLength(LinkedList input)
        {
            if (input == null || input.GetHead() == null)
            {
                return -1;
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
                return -1;
            }

            fastPointer = fastPointer.GetNext();
            int nodePassed = 1;
            while (fastPointer != slowPointer)
            {
                fastPointer = fastPointer.GetNext();
                nodePassed++;
            }

            return nodePassed;

        }
    }
}