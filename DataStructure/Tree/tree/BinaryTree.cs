using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void Tree() //creating new tree
        {
            Root = new Node(3);
            Root.LeftChild = new Node(59);
            Root.RightChild = new Node(8);
          
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
       
        public void postOrder(Node node)// Root comes last
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