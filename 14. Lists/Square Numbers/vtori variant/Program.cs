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
                List<double> spis = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .OrderByDescending(a => a).ToList();

                foreach (var item in spis)
                {
                    var help = Math.Sqrt(item);
                    if (help == (int)help)
                        Console.Write(item + " ");
                }
            }
        }
    }

