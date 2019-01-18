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
            list1.Insert(4);
            LList list2 = new LList();
            list2.Insert(5);
            list2.Insert(9);
            Program.MergeList(list1, list2);
            Assert.Equal(5, list1.GetValue(1));
        }
        [Fact]

        public void havesamelength()

        {

            LList list1 = new LList();
            list1.Insert(1);
            list1.Insert(2);
            LList list2 = new LList();
            list2.Insert(5);
            list2.Insert(9);
            Program.MergeList(list1, list2);
            Assert.Equal(1, list1.GetValue(1));


        }

        [Fact]
        public void list2islonger()

        {

            LList list1 = new LList();
            list1.Insert(1);
            list1.Insert(2);
            LList list2 = new LList();
            list2.Insert(5);
            list2.Insert(9);
            list2.Insert(99);
           Program.MergeList(list1, list2);          
            Assert.Equal(9, list1.GetValue(1));



        }

    }
}

