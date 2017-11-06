using System;
using System.Linq;

namespace Reverse_an_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split(' ').ToArray();
            var reserved = number.Reverse();

            Console.WriteLine(string.Join( ",",reserved));

        }
    }
}
