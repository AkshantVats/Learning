/*
Find if a given Linked List has a cycle.

Using Class 35 which contains Linked List implementation
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCampProblems.Code
{

    public static class Class40
    {
        public static bool HasCycle(LinkedList input)
        {
            if (input == null || input.GetHead() == null)
            {
                return false;
            }

            Node fastPointer = input.GetHead();
            Node slowPointer = input.GetHead();

            while (fastPointer != null)
            {
                fastPointer = fastPointer.GetNext();
                if (fastPointer == slowPointer)
                {
                    return true;
                }
                if (fastPointer != null)
                {
                    fastPointer = fastPointer.GetNext();
                    if (fastPointer == slowPointer)
                    {
                        return true;
                    }
                }
                slowPointer = slowPointer.GetNext();
            }

            return false;
        }
    }
}