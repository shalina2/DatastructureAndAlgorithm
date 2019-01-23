using QueueWithStacks;
using System;
using System.Collections;
using Xunit;
using static QueueWithStacks.PseudoQueue;

namespace QueueWithStacks { 

    public class UnitTest1
    {
        [Fact]
        public void EnqueueValue()
        {
            Stack stack = new Stack();
            PseudoQueue pseuedo = new PseudoQueue(stack);
            pseuedo.Enqueque(1);

            Assert.Equal(1, pseuedo.Front.Top.Value);

        }
    }
}
