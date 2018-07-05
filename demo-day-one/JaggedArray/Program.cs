using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int[][] jagged = new int[3][];
            int counterZero = 0;
            int counterOne = 0;
            int counterTwo = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                

                if(arr[i]%3 ==0)
                {
                    counterZero++;
                }
                else if(arr[i]%3 == 1)
                {
                    counterOne++;
                }
                else
                {
                    counterTwo++;
                }

            }
            for (int i = 0; i < arr.Length; i++)
            {
                jagged[i] = new int[counterZero];
                for (int f = 0; f < counterZero; f++)
                {
                    
                }
            }
        }
    }
}
