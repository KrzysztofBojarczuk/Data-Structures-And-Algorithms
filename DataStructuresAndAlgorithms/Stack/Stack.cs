using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Stack
{
    public class Stack
    {
        public int MaxSize { get; set; } // Array stacks you need a maxsize to init array
        //this holds our array
        public string[] StackArray { get; set; }
        //this keeps tacks of the top
        public int Top { get; set; }


        public Stack(int size)
        {
            //This holds constructor vallue
            this.MaxSize = size;
            //Creates array with size
            this.StackArray = new string[MaxSize];
            // We give the top -1 beacuse array is zero index; If we don't it will sjip first element.
            this.Top = -1;
        }

        public void Push(string item)
        {
            //
            Top++;
            StackArray[Top] = item;
        }
        public string Pop()
        {
            //Think palceholder
            int old_Top = Top;
            //Decrement for the new top
            Top--;
            return StackArray[old_Top];
        }
        public string Peek()
        {
            return StackArray[Top];
        }
        public bool isEmpty()
        {
            return Top == 0;
        }
        public bool isFull()
        {
            return (MaxSize - 1 == Top);
        }
    }
}
