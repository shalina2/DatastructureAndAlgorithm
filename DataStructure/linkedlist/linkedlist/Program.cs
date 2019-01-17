using System;
using LinkedList.Classes;

namespace linkedlist
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList!");

            LList listing = new LList();
            listing.Insert(2);
            listing.Insert(4);
            listing.Insert(6);

            listing.Print();


            listing.Append(8);
            listing.Append(10);
            listing.Append(12);

            listing.Print();

            listing.InsertBefore(10, 11);
            listing.Print();
            listing.InsertAfter(2, 100);
            listing.Print();


            int a = listing.GetValue(13);
            int b = listing.GetValue(2);

            int c = listing.GetValue(130);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
