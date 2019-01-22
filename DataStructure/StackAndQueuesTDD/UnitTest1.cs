using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using stackandqueues.classes;

namespace StackAndQueuesTDD
{
    public class UnitTest1
    {
        [Fact]
        public void Push()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            Assert.Equal(2, stack.Top.Value);

        }
        [Fact]
        public void Pop()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(3);
            Assert.True(stack.Top.Value == 3);
            stack.Pop();
            Assert.True(stack.Top.Value == 1);
        }
        [Fact]
        public void Peek()
        {
            Node node = new Node("7");
            Stack stack = new Stack(node);
            stack.Push(13);
            Assert.True(stack.Peek().Value == 13);
        }
    }
}
