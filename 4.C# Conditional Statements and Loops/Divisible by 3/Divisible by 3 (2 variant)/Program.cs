using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible_by_3__2_variant_
{
    class Program
    {
        static void Main(string[] args)
            
        {
            for (int i = 1; i < 100; i++)

                if (i%3 == 0) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
