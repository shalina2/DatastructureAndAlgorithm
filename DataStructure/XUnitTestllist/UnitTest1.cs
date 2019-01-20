using LinkedList.Classes;
using System;
using Xunit;

namespace XUnitTestllist
{
    public class UnitTest1
    {
        [Fact]
        public void ifexists()
        {
            LList listing = new LList();
            listing.Insert(2);
            listing.Insert(4);
            listing.Insert(6);

            Assert.True(listing.Includes(4));

        }

        [Fact]
        public void ifnotexist()
        {
            LList listing = new LList();
            listing.Insert(44);

            Assert.False(listing.Includes(4));
        }
        
        //[Fact]
        //public void canAppendValue()
        //{
        //    linklist listed = new linklist();
        //    listed.Insert(0);
        //    listed.Insert(120);
        //    listed.Insert(30);
        //    listed.print();

        //    listed.Current = listed.Head;
        //    while(listed.Current.Next != null)
        //    {
        //        listed.Current = listed.current.Next;
        //    }
        //    int lookingfor = listed.Current.Value;
        //    Assert.True(lookingfor == 53);
        //}
        //[Fact]
        //public void canAppendValuetolast()
        //{
        //    linklist listed = new linklist();
        //    listed.Insert(0);
        //    listed.Insert(10);

        //    listed.Insert(38);

        //    listed.print();

        //    listed.Append(53);

        //    listed.Append(26);
        //    listed.Current = listed.head;
        //    while(listed.current.Next != null)
        //    {
        //        listed.current = listed.current.Next;
        //    }
        //    int lookingfor = listed.current.Value;
        //    Assert.True(lookingfor == 26);

        //}
        //[Fact]
        //public void insertbeforelast()
        //{
        //    linklist listed = new linklist();
        //    listed.Insert(0);
        //    listed.Insert(10);

        //    listed.Insert(38);

        //    listed.print();

        //    listed.InsertBefore(38, 40);
        //    listed.current=listed.Head;
        //    int lookingfor = 0;
        //    while (listed.Current .Next != null)
        //    {
        //        listed.Current = listed.Current.Next;
        //        if(listed.Current.VAlue == 24)
        //        {
        //            lookingfor = listed.current.next.value;
        //        }
        //    }

        //    Assert.True(lookingfor == 26);
        //}
    }
    }
    
    
    
    


