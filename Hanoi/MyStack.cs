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

        private int m_currentIndex = 0;
        private int[] m_stack;
        
        public MyStack(int size = DEFAULT_STACK_SIZE)
        {
            m_stack = new int[size];
        }

        public int Size()
        {
            return m_currentIndex;
        }

        public void Push(int element)
        {
            m_stack[m_currentIndex] = element;
            m_currentIndex++;
        }

        public int Pop()
        {
            m_currentIndex--;
            return m_stack[m_currentIndex];
        }

        public int GetMaxStackSize()
        {
            return m_stack.Count();
        }

        public void Clear()
        {
            m_currentIndex = 0;
        }

        public bool IsEmpty()
        {
            return m_currentIndex == 0;            
        }

        public int At(int index)
        {
            if (index >= m_currentIndex)
                throw new IndexOutOfRangeException();
            else
                return m_stack[index];
        }
    }
}
