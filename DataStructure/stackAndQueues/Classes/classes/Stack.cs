using System;
using System.Collections.Generic;
using System.Text;

namespace stackandqueues.classes
{
   public class Stack
    {
        public Node Top { get; set; }
        public Stack(Node node)
        {
            Top = node;
        }

        public Stack() //creataing a new stack so leaving it empty.
        {

        }

        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }
        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }
        public Node Peek()
        {
            return Top;
        }
    }
}
