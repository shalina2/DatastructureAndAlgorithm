using System;
using System.Collections.Generic;
using System.Text;

namespace stackandqueues.classes
{
  public  class Queue
    {
        public Node Front { get; set; }
        public Node Back { get; set; }
        public Queue(Node node)
        {
            Front = node;
            Back = node;
        }
        
        ///  included or added a node to the queue
        
        public void Enqueue(int value)
        {
            Node node = new Node(value);

            Back.Next = node;
            Back = node;
        }

        /// taking out the front node
        
        public Node Peek()
        {
            return Front;
        }

    }
}
