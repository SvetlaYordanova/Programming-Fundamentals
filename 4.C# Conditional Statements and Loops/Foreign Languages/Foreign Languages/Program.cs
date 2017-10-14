using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine();
            string langluages;

            switch (country.ToLower())
            {
                case "england":
                case "usa":
                    langluages = "English";
                    break;

                case "spain":
                case "argentina":
                case "mexico":

                    langluages = "Spanish"; break;

                default:
                    langluages = "unknown"; break;
            }
                    Console.WriteLine(langluages);


            }



        }
    }

