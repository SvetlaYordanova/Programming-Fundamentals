using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurrenc
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var words = input.ToLower().Split(' ');
            

            var count = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (count.ContainsKey(word))
                {
                    count[word]++;
                }
                else
                {
                    count[word] = 1;
                }
            }
            List<string> results = new List<string>();
            foreach (var item in count)
                {
                    if (item.Value % 2 != 0)
                    {
                    results.Add(item.Key);
                }


                    
                }

            Console.WriteLine(string.Join(", ", results));

        }

           

        }
    }

