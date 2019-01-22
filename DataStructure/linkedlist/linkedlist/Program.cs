using System;
using LinkedList.classes;

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
            
                     

        }
    }
}
