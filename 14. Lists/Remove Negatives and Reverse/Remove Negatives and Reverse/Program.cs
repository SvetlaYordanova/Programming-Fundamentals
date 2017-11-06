using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    Console.Write(array[i] + " ");
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("empty");
            }
        }
    }
}
   
