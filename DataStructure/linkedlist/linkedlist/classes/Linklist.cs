using System;
using System.Collections.Generic;
using System.Text;

namespace linkedlist.classes 
{
    public class Linklist
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

    
        public void Insert(int value)
        {
            Node insertNode = new Node(value);
            insertNode.Next = Head;
            Head = insertNode;

        }




        public bool Includes(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.NEXT;

            }
            if (Current.Value == value)
            {
                return true;
            }
            return false;
        }

            public void print()
            {
                Current = Head;
                while(Current != null)
                {
                    Console.Write(Current.Value +" ");
                    Current = Current.Next;
                }
            }
        }
       




    }
}
