using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Hanoi;

namespace HanoiTests
{
    public class StackTest
    {
        public const int TEST_ELEMENT = 5;
        [Test]
        public void DefaultConstructorShouldSetStackSizeToDefaultValue()
        {
            var stack = new MyStack();
            Assert.AreEqual(MyStack.DEFAULT_STACK_SIZE, stack.GetMaxStackSize());
        }

        [Test]
        public void DefaultConstructorShouldSetStackSizeToParameterValue()
        {
            int wantedStackSize = 5;
            var stack = new MyStack(wantedStackSize);
            Assert.AreEqual(wantedStackSize, stack.GetMaxStackSize());
        }

        [Test]
        public void StackSizeShouldBeZeroWhenCreated()
        {
            var stack = new MyStack();
            Assert.Zero(stack.Size());
        }

        [Test]
        public void StackSizeShouldBeIncrementedWhenItemAdded()
        {
            var stack = new MyStack();
            stack.Push(TEST_ELEMENT);

            int expectedStackSize = 1;
            Assert.AreEqual(expectedStackSize, stack.Size());
        }

        [Test]
        public void StackSizeShouldBeDecrementedWhenItemSubtracted()
        {
            var stack = new MyStack();
            stack.Push(TEST_ELEMENT);
            stack.Pop();

            Assert.Zero(stack.Size());
        }

        [Test]
        public void StackContentShouldBeRemoved()
        {
            var stack = new MyStack();
            stack.Push(TEST_ELEMENT);
            stack.Clear();

            Assert.Zero(stack.Size());
        }

        [Test]
        public void StackIsEmptyReturnTrueWhenNoItemsAdded()
        {
            var stack = new MyStack();
            Assert.True(stack.IsEmpty()); 
        }

        [Test]
        public void StackIsEmptyReturnFalseWhenItemsAdded()
        {
            var stack = new MyStack();
            stack.Push(TEST_ELEMENT);

            Assert.False(stack.IsEmpty());
        }
    }
}
