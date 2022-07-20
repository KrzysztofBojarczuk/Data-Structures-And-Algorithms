using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.LinearSearch
{
    public class LinearSearchArray
    {
        public bool LinearSearch(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    return true;
                }
            }
            return false;
        }

        public bool LinearSearchWhile(int[] array, int key)
        {
            int i = 0;
            while (i < array.Length)
            {
                if (array[i] == key)
                {
                    return true;
                }
                i++;
                
                    
            }
            return false;
        }

    }
}
