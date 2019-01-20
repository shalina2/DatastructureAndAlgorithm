using LinkedList.classes;
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

        [Fact]
        public void PrintValue()
        {
            LList listing = new LList();
            listing.Insert(0);
            listing.Insert(20);
            listing.Print();
            listing.Current = listing.Head;
            while (listing.Current.Next != null)
            {
                listing.Current = listing.Current.Next;
            }
            int lookingfor = listing.Current.Value;
            Assert.False(lookingfor == 20);
        }       
    }

        
    }
    
    
    
    


