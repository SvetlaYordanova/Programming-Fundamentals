using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int Health = int.Parse(Console.ReadLine());
            int HealthMax = int.Parse(Console.ReadLine());
            int Energy = int.Parse(Console.ReadLine());
            int EnergyMax = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);

            Console.Write("Health: ");
            Console.Write("|");
            Console.Write (new string('|', Health));
            Console.Write (new string('.', HealthMax - Health));
            Console.WriteLine("|");

            Console.Write("Energy: ");
            Console.Write("|");
            Console.Write(new string('|', Energy));
            Console.Write(new string('.', EnergyMax - Energy));
            Console.WriteLine("|");

        }
    }
}
