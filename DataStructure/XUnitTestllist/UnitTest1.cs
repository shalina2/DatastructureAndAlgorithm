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
            listing.Insert(34);
            listing.Insert(6);

            Assert.True(listing.Includes(34));

        }

       [Fact]
        public void ifnotexist()
        {
            LList listing = new LList();
            listing.Insert(34);

            Assert.False(listing.Includes(4));
        }
        [Fact]
        public void ifvalueexists()
        {
            LList listing = new LList();
            listing.Insert(2);
            listing.Insert(4);
             listing.Insert(8);
               Assert.True(listing.Includes(8));
            }
            [Fact]
            public void canAppendValue()
            {
            LList listing = new LList();
            listing.Insert(0);
            listing.Insert(120);
            listing.Insert(30);
            listing.Print();

            listing.Current = listing.Head;
                while (listing.Current.Next != null)
                {
                listing.Current = listing.Current.Next;
               }
                int lookingfor = listing.Current.Value;
                Assert.True(lookingfor == 53);
            }
           [Fact]
            public void canAppendValuetolast()
            {
            LList listing = new LList();
            listing.Insert(0);
            listing.Insert(10);

            listing.Insert(38);

            listing.Print();

            listing.Append(53);
            listing.Append(26);
            listing.Current = listing.Head;
               while(listing.Current.Next != null)
                {
                listing.Current = listing.Current.Next;
                }
                int lookingfor = listing.Current.Value;
                Assert.True(lookingfor == 26);

            }
            [Fact]
        public void insertbeforelast()
        {
            LList listing = new LList();
            listing.Insert(0);
            listing.Insert(10);

            listing.Insert(38);

            listing.Print();

            listing.InsertBefore(38, 40);
            listing.Current = listing.Head;
            int lookingfor = 0;
            while (listing.Current.Next != null)
            {
                listing.Current = listing.Current.Next;
                if (listing.Current.Value == 24)
                {
                    lookingfor = listing.Current.Next.Value;
                }
            }

            Assert.True(lookingfor == 26);
        }
    }
}
    
    
    
    


