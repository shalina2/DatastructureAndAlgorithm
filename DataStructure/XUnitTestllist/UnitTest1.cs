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
           
            Assert.True(listing.Includes(2));

        }

       [Fact]
        public void ifnotexist()
        {
            LList listing = new LList();
            listing.Insert(2);

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
            listing.Append(13);

            listing.Current = listing.Head;
                while (listing.Current.Next != null)
                {
                listing.Current = listing.Current.Next;
               }

                int lookingfor = listing.Current.Value;
                Assert.True(lookingfor == 13);
            }


        [Fact]
            public void canAppendValuetolast()
        { 
            LList listing = new LList();
            listing.Insert(0);
            listing.Insert(10);

            listing.Insert(18);

            listing.Print();

            listing.Append(13);
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
        public void insertbefore()
        {
            LList listing = new LList();
            listing.Insert(0);
            listing.Insert(10);

            listing.Insert(18);

            listing.Print();

            listing.InsertBefore(10, 40);
            listing.Current = listing.Head;
            int lookingfor = 0;
            while (listing.Current.Next != null)
            {
                listing.Current = listing.Current.Next;
                if (listing.Current.Value == 40)
                {
                    lookingfor = listing.Current.Next.Value;
                }
            }

            Assert.True(lookingfor == 10);
        }
    }
}
    
    
    
    


