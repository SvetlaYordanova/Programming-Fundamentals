using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_var
{
    class Program
    {
       

        static void Main(string[] args)
        {
            const int invaledPrice = -1;
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            int price;

            if (0 <= age && age <= 18)

                switch (day)
                {
                    case "weekday":
                        price = 12;
                        break;

                    case "weekend":
                        price = 15;
                        break;
                    case "holiday":
                        price = 5;
                        break;
                    default:
                        price = invaledPrice;
                        break;
                }

            else if (18 < age && age <= 64)
                switch (day)
                {
                    case "weekday":
                        price = 18; break;
                    case "weekend":
                        price = 20; break;
                    case "holiday":
                        price = 12; break;
                    default:
                        price = invaledPrice;
                        break;

                }
            else if (64 < age && age <= 122)
                switch (day)
                {
                    case "weekday":
                        price = 12; break;
                    case "weekend":
                        price = 15; break;
                    case "holiday":
                        price = 10; break;
                    default:
                        price = invaledPrice;
                        break;
                }
            else
            {
                price = invaledPrice;
            }

            if (price != invaledPrice)
            {
                Console.WriteLine("{0}$", price);
            }
            else
                Console.WriteLine("Error!");
        }


    }
}



