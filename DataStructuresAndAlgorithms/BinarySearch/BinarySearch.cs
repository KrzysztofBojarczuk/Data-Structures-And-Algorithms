using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.BinarySearch
{
    public class BinarySearch
    {
        public int BinarySearchMethod(int[] intArray, int value)
        {
            int start = 0;
            int end = intArray.Length;
            //start end + while less than is going ceiss crossing

            while (start < end)
            {
                //Put int parenthensis beacuse add them incorrect
                int midpoint = (start + end) / 2;

                //seatch the middle the of the book

                if (intArray[midpoint] == value)
                {
                    return midpoint;
                }
                else if (intArray[midpoint] < value)
                {
                    start = midpoint + 1;
                }
                else
                {
                    end = midpoint;
                }
                
            }
            return -1;
        }
    }
}
