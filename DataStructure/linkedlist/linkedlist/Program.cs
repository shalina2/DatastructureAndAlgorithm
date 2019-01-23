using System;

using linkedlist.classes;
using LinkedList.Classes;




namespace linkedlist
{
    public class Program
    {
       


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

            listing.Print();          
            
                     


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
