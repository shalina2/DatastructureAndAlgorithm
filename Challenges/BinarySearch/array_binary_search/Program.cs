using System;

namespace array_binary_search
{
   public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = { 2, 4, 6, 8, 10, 12 };
            int searchkey = 6;
            int index = BinarySearch(nums, searchkey);
            Console.WriteLine(index);
        }
        public static int BinarySearch(int[] arr,int searchkey)/// declaring two indexes leftand right
        {
            int rightIndex = arr.Length -1;
            int leftIndex = 0;

            while(leftIndex <=rightIndex)
            {
                int middle = (leftIndex + rightIndex) / 2;//showing the middlepoint.
                if(searchkey == arr[middle])
                {
                    return middle;
                }
                else if(searchkey > arr[middle]) //when the searchKey is greater than the middpoint return middlepoint +1
                {
                    leftIndex = middle + 1;
                }
                else
                {
                    rightIndex = middle - 1; //if the searchkey is less than the middlepoint.
                }
            }
            return -1;

        }
    }
}
