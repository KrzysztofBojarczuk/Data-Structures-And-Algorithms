using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Queues
{
    public class Queue
    {
        public int MaxSize { get; set; } // See the number of elemnts beaucse this is an array
        public int[] QueueArray { get; set; } // Actual array we will store elemnts in
        public int Front { get; set; } // Index to keep track of front
        public int Rear { get; set; } // Index to keeo track of adds
        public int NItems { get; set; } // This will keep track of lengrh

        public Queue(int size)
        {
            this.MaxSize = size;
            this.QueueArray = new int[size];
            Front = 0;
            Rear = -1;
        }
        //Somebody is going into chik fila line
        public void Enqueue(int item)
        {
            //Increment our pointers
            Rear++;
            //Insert into where the rear was incremented
            QueueArray[Rear] = item;
            //Incrmented
            NItems++;
        }
        public int Dequeue()
        {
            int temp = QueueArray[Front];
            Front++;
            if (Front == MaxSize)
            {
                Front = 0;
            }
            NItems--;
            return temp;

        }
        public int Peek()
        {
            return QueueArray[Front];
        }
    }
}
