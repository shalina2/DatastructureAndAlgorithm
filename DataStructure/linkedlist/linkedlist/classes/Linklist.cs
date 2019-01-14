using System;
using System.Collections.Generic;
using System.Text;

namespace linkedlist
{
    public class Linklist
    {
        public Node Head { get; set; }
        public Node Current { get; set; }


        public void Insert(int value)
        { 
        
        Node insertedNode = new Node(value);
        insertedNode.Next=Head;
            Head =insertedNode;


     }
        public bool Includes(int values)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.value == VALUE)
                {
                    return true;
                }
                Current = Current.NEXT;

            }
            if (Current.Value == Value)
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
                    Console.Write(Current.VAlue + " ");
                    Current = Current.Next;
                }
            }
        }
       




    }
}
