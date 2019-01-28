using System;

namespace Tree
{
    public class Program
    {
        public static void Main(string[] args)
        {

            BinarySearchTree binarT = createTree();
            bool a = binarT.contains(38);
            Console.WriteLine("this contains 38");
            Console.WriteLine(a);
            bool b = binarT.contains(2);
            Console.WriteLine("this Does not contain  2");
            Console.WriteLine(b);


            Console.WriteLine("========================");
            BinaryTree bb = new BinaryTree();
            bb.Tree();
            Console.WriteLine("========PreOrder=======");
            bb.preOrder(bb.Root);          
            bb.inOrder(bb.Root);
            Console.WriteLine();          
            bb.postOrder(bb.Root);
        }

        public static BinarySearchTree Tree()
        {
            BinarySearchTree bt = new BinarySearchTree();

            bt.Add(4);
            bt.Add(2);
            bt.Add(6);
            bt.Add(28);
            bt.Add(73);
            bt.Add(100);
            bt.Add(300);
            bt.Add(15);
            bt.Add(10);
            return bt;
        }

    }
}