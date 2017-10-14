using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_in_30_Minutes_2_var
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 30;

            if (minutes > 59) 
            {
                hours++;
                minutes -= 60;
            }
                if (hours > 23) 
                {
                    hours -= 24;
                }

                Console.WriteLine("{0}:{1:D2}",hours, minutes);

                    

            }


        }
    }

