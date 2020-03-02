/*
Implement a Queue using 2 stacks.
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCampProblems.Code
{

    public class Class49_Queue<A>
    {
        Stack<A> s1;
        Stack<A> s2;

        public Class49_Queue()
        {
            s1 = new Stack<A>();
            s2 = new Stack<A>();

        }


        public void Enqueue(A a)
        {
            s1.Push(a);

        }


        public A Dequeue()
        {
            if (s2.Count() == 0)
            {
                FlushToS2();
            }

            if (s2.Count() == 0)
            {
                throw new ArgumentNullException();
            }

            return s2.Pop();
        }

        public void FlushToS2()
        {
            while (s1.Count() != 0)
            {
                s2.Push(s1.Pop());
            }
        }


        public A[] ToArray()
        {
            List<A> result = new List<A>();
            bool exceptionThrows = false;
            while (!exceptionThrows)
            {
                try
                {
                    result.Add(Dequeue());
                }
                catch (ArgumentNullException)
                {
                    exceptionThrows = true;
                }
            }

            return result.ToArray();

        }
    }
}