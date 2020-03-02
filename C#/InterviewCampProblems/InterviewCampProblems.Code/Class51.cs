/*
Implement a Stack with a max() function. This function runs in O(1) time and returns the value of the maximum number on the stack
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCampProblems.Code
{
    public class Class51
    {
        Stack<int> main;
        Stack<int> max;

        public Class51()
        {
            main = new Stack<int>();
            max = new Stack<int>();
        }


        public void Push(int a)
        {
            main.Push(a);
            if (max.Count() == 0 || a >= max.Peek())
            {
                max.Push(a);
            }
        }

        public int Max()
        {
            if (max.Count() == 0)
            {
                throw new InvalidOperationException();
            }
            return max.Peek();
        }

        public int Pop()
        {
            if (main.Count() == 0)
            {
                throw new InvalidOperationException();
            }

            int item = main.Pop();
            if (max.Peek() == item)
            {
                max.Pop();
            }
            return item;
        }
    }
}