using System;
using System.Runtime.InteropServices;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)

        {
            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            int index = int.Parse(Console.ReadLine());

            if (index <=0 || index > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(days[index - 1]);
            }
           

        }

 
        }
        
    }

