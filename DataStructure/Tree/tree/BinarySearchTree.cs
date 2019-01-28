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
        
        private Node addRecursive(Node current, int val)
        {
            if (current == null)
            {
                return new Node(val);
            }
            if (val < current.Value)
            {
                current.LeftChild = addRecursive(current.LeftChild, val);
            }

            else if (val > current.Value)
            {
                current.RightChild = addRecursive(current.RightChild, val);
            }
            else
            {
                return current;
            }
            return current;


        }

       
        public void Add(int val)
        {
            Root = addRecursive(Root, val);

        }

        /// <summary>
        /// should be private, doesn't need to show public the process 
        /// </summary>
        /// <param name="curr"></param>
        /// <param name="val"></param>
        /// <returns></returns>
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
            return val < curr.Value ? containsVal(curr.LeftChild, val) : containsVal(curr.RightChild, val);
        }


        public bool contains(int val)
        {
            return containsVal(Root, val);
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