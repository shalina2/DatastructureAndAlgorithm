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

            Assert.True(listed.includes(34));
        }

        [Fact]
        public void ifnotexist()
        {
            linklist listed = new linklist();
            listed.Insert(34);

            Assert.False(listed.Includes(4));
        }
        [FACT]
        public void ifvalueexists()
        {
            linklist listed = new linklist();
            listed.Insert(2);
            listed.Insert(4);
            listed.Insert(6);
            Assert.True(listed.Includes(8));
        }
    }
    
    }
    


