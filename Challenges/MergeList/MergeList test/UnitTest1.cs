using LinkedList.Classes;
using MergeList;
using System;
using Xunit;

namespace MergeList_test
{
    public class UnitTest1
    {
        [Fact]
        public void FirstListLong()
        {
        LList list1 = new LList();

        list1.Insert(1);
        list1.Insert(2);
        list1.Insert(3);
        list1.Insert(4);
            LList list2 = new LList();
            list2.Insert(5);
            list2.Insert(10);
           Program.MergeList (list1, list2);
            Assert.Equal(5, list1.GetValue(1));
        }
    }
}

