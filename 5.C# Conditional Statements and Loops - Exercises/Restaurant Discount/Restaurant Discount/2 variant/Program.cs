using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_variant
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double price = 0;
            string hallName = "";
            bool ofLimit = false;



            if (groupSize <= 50)
            {
                price = 2500;
                hallName = "Small Hall";

            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                price = 5000;
                hallName = "Terrace";
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                price = 7500;
                hallName = "Great Hall";
            }


            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                ofLimit = true;

            }



            switch (type)
            {
                case "Normal":
                    price += 500;
                    price = (price - (price * 0.05)) / groupSize;
                    break;
                case "Gold":
                    price += 750;
                    price = (price - (price * 0.10)) / groupSize;
                    break;
                case "Platinum":
                    price += 1000;
                    price = (price - (price * 0.15)) / groupSize;
                    break;
            }


            if (!ofLimit)
            {
                Console.WriteLine($"We can offer you the {hallName}\nThe price per person is {price:f2}$");
            }

        }
    }
}
      