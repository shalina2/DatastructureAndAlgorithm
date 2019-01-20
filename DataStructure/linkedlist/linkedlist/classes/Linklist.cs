using linkedlist.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.classes
{
   public class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

      /// <summary>
      /// we are trying to insert a new Node in the list.
      /// </summary>
      /// <param name="value"></param>

        public void Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }
        /// <summary>
        /// below we are trying to give bool value which is if the next node in the list is not null to return a value which is true.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Includes(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }
            if (Current.Value == value)
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// this  is the print which we output the list
        /// </summary>

        public void Print()
        {
            if (Head != null)
            {
                Current = Head;

                while (Current.Next != null)
                {
                    System.Console.Write($"{Current.Value} => ");
                    Current = Current.Next;
                }

                System.Console.WriteLine($"{Current.Value} => Null");
            }
            else
            {
                System.Console.WriteLine("Your LL is empty");
            }


        }

        public void Append(int value)
        {
            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Node node = new Node(value);

            Current.Next = node;

        }
        /// <summary>
        /// below we are trying to write a method which help us insert a value before any value we want.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="newValue"></param>
        public void InsertBefore(int value, int newValue)
        {
            Current = Head;

            if (Current.Value == value)
            {
                Insert(newValue);
                return;
            }


            while (Current.Next != null)
            {
                if (Current.Next.Value == value)
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }

                Current = Current.Next;
            }
        }
        public void InsertAfter(int value,int newvalue)
        {
            Current = Head;
            if(Current == null)
            {
                Console.WriteLine("no list");
                return;
            }
            if (Current.Value == value)
            {
                Node newNode = new Node(newvalue);
                newNode.Next = Current.Next;
                Current.Next = newNode;
                return;
            }
            while(Current.Next != null)
            {
                if (Current.Value == value)
                {
                    Node newNode = new Node(newvalue);
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                }
                Current = Current.Next;
            }
            if(Current.Value == value)
            {
                Node newNode = new Node(newvalue);
                newNode.Next = Current.Next;
                Current.Next = newNode;
            }
            return;
        }

        public int GetValue(int k)
        {
            Current = Head;
            int counter = 0;

            while (Current.Next != null)
            {
                Current = Current.Next;
                counter++;
            }
            counter++;

            Current = Head;
            int counter2 = 0;
            while(Current.Next != null)
            {
                counter2++;
                if (counter2 + k == counter) return Current.Value;
                Current = Current.Next;
            }
            counter2++;
            if (counter2 + k == counter) return Current.Value;
            else
            {
                Console.Write("Exception!");
                return -1;
              
            }
        }
    }
}