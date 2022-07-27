using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Recursion
{
    public class RecursionClass
    {
        public void MinusByOne(int n)
        {
            //Base case is going to prevent a stack overlogw
            if (n != 0)
            {
                MinusByOne(n - 1);
            }
            //All these function are going execute, store state, THEN they are going minus
            Console.WriteLine("Call: " + n);
        }

        public int RecursiveFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * RecursiveFactorial(num - 1);
        }

        
        
        //Bad - źle
        int IterativeFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            int factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
