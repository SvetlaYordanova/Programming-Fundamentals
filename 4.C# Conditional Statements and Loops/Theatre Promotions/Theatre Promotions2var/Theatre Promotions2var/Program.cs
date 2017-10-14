using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_Promotions2var
{
    class Program
    {
        static void Main(string[] args)
        {

            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

           

            switch (day)
            {
                case "weekday":

                    if (0 <= age && age <= 18)
                    {
                        Console.WriteLine("12$");
                    }
                    else if (18 < age && age <= 64)
                    {
                        Console.WriteLine("18$");
                    }
                    else if (64 < age && age <= 122)
                    {
                        Console.WriteLine("12$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }

                    break;
             case "weekend" :

                    if (0 <= age && age <= 18)
                    {
                        Console.WriteLine("15$");
                    }
                    else if (18 < age && age <= 64)
                    {
                        Console.WriteLine("20$");
                    }
                    else if (64 < age && age <= 122)
                    {
                        Console.WriteLine("15$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }

                   break;
              case "holiday":

                    if (0 <= age && age <= 18)
                    {
                        Console.WriteLine("5$");
                    }
                    else if (18 < age && age <= 64)
                    {
                        Console.WriteLine("12$");
                    }
                    else if (64 < age && age <= 122)
                    {
                        Console.WriteLine("10$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }

                    break;
                default:

                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
