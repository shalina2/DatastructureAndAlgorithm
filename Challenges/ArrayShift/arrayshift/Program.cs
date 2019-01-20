using System;

namespace arrayshift
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 1, 3, 5, 7};
            
            Console.Write("[");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{ array[i]},");
            }
            Console.Write($"{ array[array.Length - 1]}");
            Console.WriteLine("]");

            int val = 5;
            int[] newarray = Arrayshift(array, val); ////it goes to the array and print each number on the screen.;
            Console.Write("[");
            for(int i=0;i < newarray.Length - 1; i++)
            {
                Console.Write($"{newarray[i]},");
            }
            Console.Write($"{newarray[newarray.Length - 1]}");
            Console.Write(" ]");
        
        }

        public static int[] Arrayshift(int[] array, int val)
        {
            int[] newArray = new int[array.Length + 1];
            if(array.Length % 2 ==0)
            {
                int middlePointindex = array.Length * 1 / 2;
                for(int i =0; i <newArray.Length; i++)
                {
                    if(i < middlePointindex)
                    {
                        newArray[i] = array[i];
                    }
                    else if (i == middlePointindex)
                    {
                        newArray[i] = val;
                    }
                    else
                    {
                        newArray[i] = array[i - 1];
                    }
                }
                return newArray;
            }

            else
            {
                int middlePointindex = (array.Length + 1) * 1 / 2;
                for(int i=0;i < newArray.Length; i++)
                {
                    if (i < middlePointindex)
                    {
                        newArray[i] = array[i];
                    }
                    else if (i == middlePointindex)
                    {
                        newArray[i] = val;
                    }
                    else
                    {
                        newArray[i] = array[i - 1];
                    }
                }
                return newArray;
            }


            
        }
    }
}
