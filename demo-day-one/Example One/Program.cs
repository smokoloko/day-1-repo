using System;
using System.Numerics;
namespace Example_One
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            ulong sum = 0;
            double[,] matrix = new double[n, n];
            for(int i = 0; i<n; i++)
            {
                for (int f = 0; f < n; f++)
                {
                    matrix[i, f] = Math.Pow(2, i + f);
                    if(i >= f)
                    {
                        sum += (ulong)matrix[i, f];
                    }
                }
            }
             
            Console.WriteLine(sum);
        }
    }
}
