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
            List<int> zero = new List<int>();
            List<int> one = new List<int>();
            List<int> two = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 3 == 0)
                {
                    zero.Add(arr[i]);
                }
                else if(arr[i] % 3 == 1)
                {
                    one.Add(arr[i]);
                }
                else
                {
                    two.Add(arr[i]);
                }
            }
            Console.WriteLine(String.Join(" ", zero.ToArray()));
            Console.WriteLine(String.Join(" ", one.ToArray()));
            Console.WriteLine(String.Join(" ", two.ToArray()));
        }
        }
    }


