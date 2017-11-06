using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vtori_variant
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

            string Joint = string.Join(" <= ", numbers);
            Console.WriteLine(Joint);
        }
    }
}
