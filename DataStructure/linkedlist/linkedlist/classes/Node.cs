using System;
using System.Collections.Generic;
using System.Text;

namespace linkedlist.classes
{
    class Node
    {
        public int VALUE { get; set; }
        public int Next{ get; set; }

        public Node(int value)
        {
            VALUE = value;
        }
    }
}
