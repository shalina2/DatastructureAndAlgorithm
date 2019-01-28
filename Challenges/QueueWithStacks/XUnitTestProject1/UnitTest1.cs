using System.Collections;
using Xunit;
using static QueueWithStacks.PseudoQueue;


namespace QueueWithStacks
{

    public class UnitTest1
    {
        [Fact]
        public void EnqueueValue()
        {
          Stack stack = new Stack();
            PseudoQueue pseudo = new PseudoQueue(stack);
            pseudo.Enqueque(1);

            Assert.Equal(1, pseudo.Front.Top.Value);

        }
        [Fact]
        public void EnqueueValueToTheQueue()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            PseudoQueue pse = new PseudoQueue(stack);
            pse.Enqueque(8);
            while (pse.Front.Top.Next != null)
            {
                pse.Front.Top = pse.Front.Top.Next;
            }
            int res = pse.Front.Top.Value;
            Assert.Equal(8, res);
        }
    }
}
