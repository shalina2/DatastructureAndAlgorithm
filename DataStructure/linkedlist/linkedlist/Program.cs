using System;
using LinkedList.classes;

namespace linkedlist
{
    public class Program
    {
       public static void Main(string[] args)
        {

            Console.WriteLine("LinkedList!");

            LList listing = new LList();
            listing.Insert(2);
            listing.Insert(4);
            listing.Insert(6);

            listing.Print();
            listing.InsertAfter(6, 8);
            listing.Print();
            listing.InsertBefore(6, 5);
            listing.Append(3);
            listing.Print();
            Console.WriteLine("...............");

            int a = listing.GetValue(9);
            int b = listing.GetValue(1);
            int c = listing.GetValue(44);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);



        }
    }
}
