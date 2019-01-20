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
                    Console.Write($"{Current.Value} => ");
                    Current = Current.Next;
                }

                Console.WriteLine($"{Current.Value} => Null");
            }
            else
            {
                Console.WriteLine("Your LL is empty");
            }

        }       
              
            }
        }
    
