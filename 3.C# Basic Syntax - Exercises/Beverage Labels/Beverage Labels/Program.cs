using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_Labels
{
    class Program
    {
        public static void Main ()
        {
            var name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContent = double.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            double energy = (energyContent * volume) / 100;
            double sugar = (volume * sugarContent) / 100;

            Console.WriteLine( "{0}ml {1}:", volume,name );

            Console.WriteLine("{0}kcal, {1}g sugars", energy, sugar);


        }
    }
}
