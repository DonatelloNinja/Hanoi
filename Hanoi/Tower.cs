using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    public class Tower
    {
        private MyStack m_stack;

        public Tower(int size)
        {
            m_stack = new MyStack(size);
        }

        public void Push(int element)
        {
            m_stack.Push(element);
        }

        public int Pop()
        {
            return m_stack.Pop();
        }
    }
}
