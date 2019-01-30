using System;

namespace Tree
{
    public class Program
    {
        public static void Main(string[] args)
        {

            BinarySearchTree binarT = createTree();
            bool a = binarT.contains(8);
            Console.WriteLine("this contains 8");            
            bool b = binarT.contains(6);
            Console.WriteLine("this Does not contain  6");
                     
            BinaryTree bbt = new BinaryTree();
            bbt.Tree();
          
            bbt.preOrder(bbt.Root);          
            bbt.inOrder(bbt.Root);                     
            bbt.postOrder(bbt.Root);
        }

        public static BinarySearchTree Tree()
        {
            BinarySearchTree bt = new BinarySearchTree();

            bt.Add(4);
            bt.Add(2);
            bt.Add(6);         
                 return bt;
        }

    }
}