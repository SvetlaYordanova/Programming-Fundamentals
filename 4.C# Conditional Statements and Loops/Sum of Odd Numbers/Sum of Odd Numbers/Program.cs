using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int odd = 1;

            for (int i = 0; i <num; i++)
            {
                sum += odd;
             Console.WriteLine(odd);
                odd += 2;
            }
            Console.WriteLine( "Sum: "+sum);
        }

    }

}
