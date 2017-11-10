using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    public class MyStack
    {
        public const int DEFAULT_STACK_SIZE = 10;

        private int currentIndex = 0;
        private int[] stack;

        public MyStack(int size = DEFAULT_STACK_SIZE)
        {
            stack = new int[size];
        }

        public int Size()
        {
            return currentIndex;
        }

        public void Push(int element)
        {
            stack[currentIndex] = element;
            currentIndex++;
        }

        public int Pop()
        {
            currentIndex--;
            return stack[currentIndex];
        }

        public int GetMaxStackSize()
        {
            return stack.Count();
        }

        public void Clear()
        {
            currentIndex = 0;
        }

        public bool IsEmpty()
        {
            return currentIndex == 0;            
        }
    }
}
