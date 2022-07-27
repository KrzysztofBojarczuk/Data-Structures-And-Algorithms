using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.BubbleSort
{
    public class BubleSortClass
    {
        public int[] BubbleSort(int[] array)
        {
            // hold temporary swap variable. Think state;
            int temp = 0;
            //Iterate over entire loop MANY times
            for (int pointer = 0; pointer < array.Length; pointer++)
            {
                //Forms the box that does the comparison
                for (int sort = 0; sort < array.Length -1; sort++)
                {
                    //This checks to see if left side is larger then the right
                    if (array[sort] > array[sort + 1])
                    {
                        //swap
                        //We store variable as temo so we don't overwrite is when we swap
                        temp = array[sort + 1];
                        //put left varaible in the right
                        array[sort + 1] = array[sort];
                        //put the right varaible in the left
                        array[sort] = temp;
                            
                    }
                }
            }
            return array;
           
        }
 
    }
}
