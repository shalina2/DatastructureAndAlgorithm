using System;
using System.Collections.Generic;

namespace QueueWithStacks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QueueWithStacks();

        }
        public static void QueueWithStacks()
        {
            Node node1 = new Node(5);
            Stack stack = new Stack(node1);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            PseudoQueue pseuedo = new PseudoQueue(stack);
            pseuedo.Print(stack);
            pseuedo.Enqueque(6);
            Console.WriteLine(" xxxxxxxxxxxxxxxxxxxxxxxxxxx");

            pseuedo.Print(stack);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("afterDeque");
            pseuedo.Dequeue();
            pseuedo.Print(stack);

        }
    }
}
