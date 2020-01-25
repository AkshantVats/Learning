/*
Find the median node of a linked list. For example: 1 -> 2 -> 3 -> 4 -> 5      
Median node is 3.

Using Class 35 which contains Linked List implementation
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCampProblems.Code
{

    public static class Class42
    {
        public static int FindMedian(LinkedList input)
        {
            if (input == null || input.GetHead() == null)
            {
                return -1;
            }

            Node fastPointer = input.GetHead();
            Node slowPointer = input.GetHead();

            while (fastPointer.GetNext() != null)
            {
                fastPointer = fastPointer.GetNext();
                if (fastPointer.GetNext() != null)
                {
                    fastPointer = fastPointer.GetNext();
                    slowPointer = slowPointer.GetNext();
                }
            }

            return slowPointer.GetData();
        }
    }
}