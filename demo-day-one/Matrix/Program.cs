using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int f = 0; f < n; f++)
                {
                    matrix[i, f] = i + f + 1;
                    Console.Write(matrix[i, f] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
