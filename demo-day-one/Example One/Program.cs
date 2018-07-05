using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = int.Parse(Console.ReadLine());
            double coef = 1;
            int sum = 0;
            int[,] matrix = new int[n, n];
            for(int i = 0; i<n; i++)
            {
                for(int f = 0; f<n; f++)
                {
                    matrix[i, f] = (int)Math.Pow(2,coef);
                    coef++;
                    Console.Write(matrix[i, f] + " ");
                    if(f >= i)
                    {
                        sum += matrix[i, f];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Sum is {0}", sum);
        }
    }
}
