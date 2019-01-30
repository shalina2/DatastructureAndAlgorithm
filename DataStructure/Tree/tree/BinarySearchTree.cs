using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }
        
        private Node addRecursive(Node current, int value)
        {
            if (current == null)
            {
                return new Node(value);
            }
            if (value < current.Value)
            {
                current.LeftChild = addRecursive(current.LeftChild, value);
            }

            else if (val > current.Value)
            {
                current.RightChild = addRecursive(current.RightChild, value);
            }
            else
            {
                return current;
            }
            return current;


        }

       
        public void Add(int value)
        {
            Root = addRecursive(Root, value);// calling recursive method

        }

       
        private bool containsVal(Node curr, int val)
        {
            if (curr == null)
            {
                return false;
            }

            if (val == curr.Value)
            {
                return true;
            }
            return value < curr.Value ? containsVal(current.LeftChild, value) : containsVal(current.RightChild, value);
        }


        public bool contains(int value)
        {
            return containsValue(Root, value);
        }



        public void preOrder(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                preOrder(node.LeftChild);
                preOrder(node.RightChild);
            }

        }



        public void inOrder(Node node)
        {
            if (node != null)
            {
                inOrder(node.LeftChild);
                Console.WriteLine(node.Value);

                inOrder(node.RightChild);
            }

        }


        public void postOrder(Node node)
        {
            if (node != null)
            {
                postOrder(node.LeftChild);
                postOrder(node.RightChild);
                Console.WriteLine(node.Value);
            }

        }

    }
}