using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Program;

namespace OOP.Interface_LooselyCoupled
{
    public class Stack : IStack
    {
        private readonly IStack _stack;

        public Stack(IStack stack)
        {
            _stack = stack;
        }

        public void Pop()
        {
            _stack.Pop();
        }

        public void Push(int item)
        {
            _stack.Push(item);
        }
    }
}