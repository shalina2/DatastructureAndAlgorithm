using System;
using System.Collections.Generic;
using System.Text;

namespace linkedlist.classes
{
    class Node
    {
        public int Value { get; set; }
        public int Next{ get; set; }

        public Node(int value)
        {
            Value = value;
        }

        public static implicit operator int(Node v)
        {
            throw new NotImplementedException();
        }
    }
}
