using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class StacksEvent
    {
        public int MaxSize { get; set; }  // Array stacks you need a maximum size to init array
        // this holds our array
        public string[] stackArray { get; set; }
        // this keeps track of top
        public int Top { get; set; }

        public StacksEvent(int size)
        {
            // this holds constructure value 
            this.MaxSize = size;
            // creates array with size
            this.stackArray = new string[MaxSize];
            // We give top -1 because array is 0 index ; if we dont it will skip first element
            this.Top = -1;
        }

        public void Push(string item)
        {
            // increment top
            Top++;
            stackArray[Top] = item;

        }

        public string Pop()
        {
            // just a placeholder
            int oldTop = Top;
            //decrement  for new top
            Top--;
            return stackArray[oldTop];
        }
        public string Peek()
        {
            return stackArray[Top];
        }

        public bool isEmpty()
        {
            return Top == 0;
        }

        public bool isFull()
        {
            return MaxSize - 1 == Top;
        }

    }
}
