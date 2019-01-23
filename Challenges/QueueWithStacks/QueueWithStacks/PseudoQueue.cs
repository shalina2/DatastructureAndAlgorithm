using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QueueWithStacks;

namespace QueueWithStacks
{
  
        public class PseudoQueue
        {
            public Stack Front { get; set; }
            public Stack back { get; set; }
            
        public PseudoQueue(Stack stack)
        {
            Front = stack;
            back = stack;
        }

        public void Enqueque(int value)
        {
            Stack temp = new Stack();
            while (Front.Top.Next != null)
            {
                Node tempNode = Front.Pop();
                temp.Push(tempNode.Value);
            }
            Node tempNode2 = Front.Pop();
            temp.Push(tempNode2.Value);

                //Pushing the node to the stack

                Front.Push(value);
                while(temp.Top.Next != null)
                {
                    Node tempNode = temp.Pop();
                    Front.Push(tempNode.Value);
                }
            Node tempNode3 = temp.Pop();

            Front.Push(tempNode3.Value);
            }

          public void Dequeue()
        {
            Node pop = Front.Pop();

            Console.WriteLine(pop.Value);
          }

        public void Print(Stack stack)
        {
            Node current = stack.Top;
            int counter = 0;
            while(current.Next != null)
            {
                counter++;
                current = current.Next;
            }
            counter++;

            int[] arr = new int[counter];
            current = stack.Top;

        }


        }
    }
    

