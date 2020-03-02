/*
Find if a given number N exists in a stack S
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCampProblems.Code
{
    public static class Class48
    {
        public static bool IsInStack(int target, Stack<int> stack)
        {

            if (stack == null)
            {
                return false;
            }

            Stack<int> tempStack = new Stack<int>();
            bool IsFound = false;

            while (stack.Count() != 0)
            {

                if (stack.Peek() == target)
                {
                    IsFound = true;
                    break;
                }

                tempStack.Push(stack.Pop());


            }

            while (tempStack.Count() != 0)
            {
                stack.Push(tempStack.Pop());
            }

            return IsFound;

        }
    }
}