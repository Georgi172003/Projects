using System;
using System.Linq;

namespace Zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ").ToArray();
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
