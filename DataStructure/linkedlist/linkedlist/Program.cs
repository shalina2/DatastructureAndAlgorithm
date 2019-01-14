using System;

namespace linkedlist
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList!");

            Linklist listing = new Linklist();
            int[] array = { 2, 4, 6, 8, 10, 12 };
            for(int i=0;i < array.Length; i++)
            {
                listing.Insert(array[i]);
            }
            listing.print();
        }
    }
}
