using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
          string inputLine = Console.ReadLine();

            List<string> items = inputLine.Split(' ').ToList();

            List<double> numbers = new List<double>();

            foreach (var item in items)
            {
                numbers.Add(double.Parse(item));
            }
            numbers.Sort();

            for (var i = 0; i < numbers.Count ;i++)
            {

               

                bool lastNumber = i == numbers.Count - 1;
                Console.Write(numbers[i]);

                if (!lastNumber)

                {
                    Console.Write("  <= ");
                }

                
            }
            Console.WriteLine();
        }
    }
}
