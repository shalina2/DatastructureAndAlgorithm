using System;
using System.Collections;
using System.Collections.Generic;

namespace StackQueues
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(7);
            q.Enqueue(9);

        }


        public class StackQueues
        {
            public Stack s1 = new Stack();
            public Stack s2 = new Stack();

            public void enQueue(int z)
            {
                while (s1.Count > 0)
                {
                    s2.Push(s1.Pop());
                }
                s1.Push(z);
                while (s2.Count > 0)
                {
                    s1.Push(s2.Pop());
                }
            }
        }
    }
}

        