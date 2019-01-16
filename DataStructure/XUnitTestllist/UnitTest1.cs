using System;
using Xunit;

namespace XUnitTestllist
{
    public class UnitTest1
    {
        [Fact]
        public void ifexists()
        {
            Linklist = new Linklist();
            listing.Insert(34);

            Assert.True(listing.includes(34));
        }

        [Fact]
        public void ifnotexist()
        {
            linklist listed = new linklist();
            listed.Insert(34);

            Assert.False(listed.Includes(4));
        }
        [Fact]
        public void ifvalueexists()
        {
            linklist listed = new linklist();
            listed.Insert(2);
            listed.Insert(4);
            listed.Insert(6);
            Assert.True(listed.Includes(8));
        }
        [Fact]
        public void canAppendValue()
        {
            linklist listed = new linklist();
            listed.Insert(0);
            listed.Insert(120);
            listed.Insert(30);
            listed.print();

            listed.Current = listed.Head;
            while(listed.Current.Next != null)
            {
                listed.Current = listed.current.Next;
            }
            int lookingfor = listed.Current.Value;
            Assert.True(lookingfor == 53);
        }
        [Fact]
        public void canAppendValuetolast()
        {
            linklist listed = new linklist();
            listed.Insert(0);
            listed.Insert(10);

            listed.Insert(38);

            listed.print();

            listed.Append(53);

            listed.Append(26);
            listed.Current = listed.head;
            while(listed.current.Next != null)
            {
                listed.current = listed.current.Next;
            }
            int lookingfor = listed.current.Value;
            Assert.True(lookingfor == 26);

        }
        [Fact]
        public void insertbeforelast()
        {
            linklist listed = new linklist();
            listed.Insert(0);
            listed.Insert(10);

            listed.Insert(38);

            listed.print();

            listed.InsertBefore(38, 40);
            listed.current=listed.Head;
            int lookingfor = 0;
            while (listed.Current .Next != null)
            {
                listed.Current = listed.Current.Next;
                if(listed.Current.VAlue == 24)
                {
                    lookingfor = listed.current.next.value;
                }
            }

            Assert.True(lookingfor == 26);
        }
    }
    }
    
    
    
    


