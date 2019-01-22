using array_binary_search;
using System;
using Xunit;

namespace BinarySearch
{
    public class UnitTest1
    {
        [Fact]
        public void UnavailableIndexReturn()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int searchkey = 10;
            int lookingFor = -1;
            Assert.Equal(lookingFor,Program.BinarySearch(arr, searchkey));
        }
        [Fact]
        public void ReturningIndex2()
        {
            int[] arr = { 2, 4, 6, 8, 10, 12 };
            int searchkey = 6;
            int lookingFor = 2;
            Assert.Equal(lookingFor, Program.BinarySearch(arr, searchkey));

        }
        [Fact]
        public void NotReturningIndex()
        {
            int[] arr = { };
            int searchKey = 7;
            int lookingFor = -1;
            Assert.Equal(lookingFor, Program.BinarySearch(arr, searchKey));


        }
    }
}
