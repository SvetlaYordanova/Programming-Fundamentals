using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            List<int> reversedNums = new List<int>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                List<int> nums = input[i]
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                foreach (var number in nums)
                {
                    reversedNums.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ", reversedNums));
        }
    }
}
