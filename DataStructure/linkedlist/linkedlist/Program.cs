using System;
using linkedlist.classes;
using LinkedList.Classes;

namespace linkedlist
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinkedList!");

            LList listing1 = new LList();
            listing1.Insert(2);
            listing1.Insert(4);
            listing1.Insert(6);
            LList listing2 = new LList();
            listing2.Print();                    
            listing2.Insert (8);          
            listing2.Insert(10);
            listing2.Print();           
            Console.WriteLine();
            MergeLists(listing1, listing2);
        }

            public static void MergeLists(LList list1, LList list2)

            {
            // defining the length of the List.
                list1.Current = list1.Head;
                list2.Current = list2.Head;
                int counter1 = 0;
                int counter2 = 0;
                while (list1.Current.Next != null)
               {

                    list1.Current = list1.Current.Next;
                    counter1++;
                }

                counter1++;

                while (list2.Current.Next != null)

                {
                    list2.Current = list2.Current.Next;            
                    counter2++;
                }

                counter2++;
                //reset the current to the head
                list1.Current = list1.Head;
                list2.Current = list2.Head;
                while (counter1 > counter2 && list1.Current.Next != null)
                {

                    Node temp = list1.Current.Next;
                    list1.Current.Next = list2.Current;
                   list1.Current = list1.Current.Next;
                   list2.Current = list2.Current.Next;
                    list1.Current.Next = temp;
                    list1.Current = list1.Current.Next;
                }

                while (counter1 == counter2 && list2.Current.Next != null)
                {

                    Node temp = list1.Current.Next;
                    list1.Current.Next = list2.Current;
                    list1.Current = list1.Current.Next;
                    list2.Current = list2.Current.Next;
                    list1.Current.Next = temp;
                    list1.Current = list1.Current.Next;
                }

                while (counter1 < counter2 && list1.Current.Next != null)

                {

                    Node temp = list1.Current.Next;
                    list1.Current.Next = list2.Current;
                    list1.Current = list1.Current.Next;
                    list2.Current = list2.Current.Next;
                    list1.Current.Next = temp;
                    list1.Current = list1.Current.Next;
                }

                list1.Current.Next = list2.Current;
                list1.Print();
            }
    }
}
