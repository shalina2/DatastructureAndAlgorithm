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
            listing.insert(2);
            listing.insert(4);
            listing.insert(6);

            listing.print();


            listing.Append(8);
            listing.Append(10);
            listing.Append(12);

            listing.print();

            listing.InsertBefore(10, 11);
            listing.print();
            listing.InsertAfter(2, 100);
            listing.print();


            int a = listing.GetValue(13);
            int b = listing.GetValue(1);

            int c = listing.GetValue(130);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
