using System;

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
        public void Pushonevalue()
        {
            Stack stack = new Stack();
            stack.Push(1);
            Assert.Equal(1, stack.Top.Value);

        }
        [Fact]
        public void PushNoNOdeToStack()
        {
            Node node = new Node(2);
            Stack stack = new Stack(node);
            stack.Push(7);
            Assert.Equal(7, stack.Top.Value);
        }


        [Fact]
        public void Pop()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(3);
            Assert.True(stack.Top.Value == 3);
            stack.Pop();
            Assert.False(stack.Top.Value == 3);
        }
        [Fact]
        public void PopnullNode()
        {
            Stack stack = new Stack();
            stack.Push(1);       
            Assert.True(stack.Top.Value == 1);
            stack.Pop();
            Assert.True(stack.Top == null);
        }


        [Fact]
        public void PopNode()
        {
            Node node = new Node(4);
            Stack stack = new Stack(node);
            stack.Push(1);
            stack.Push(3);
            Assert.True(stack.Top.Value == 3);
            stack.Pop();
            Assert.False(stack.Top.Value == 37);
        }

        [Fact]
        public void Peek()
        {
            Node node = new Node(7);
            Stack stack = new Stack(node);
            stack.Push(3);
            Assert.True(stack.Peek().Value == 3);
        }
        [Fact]
        public void Peekemptystack()
        {
           
            Stack stack = new Stack();
           
            Assert.True(stack.Peek() == null);
        }
        [Fact]
        public void PeekFromStack()
        {

            Node node = new Node(1);
            Stack stack = new Stack(node);

            Assert.True(stack.Peek().Value == 1);
        }
    }
}
