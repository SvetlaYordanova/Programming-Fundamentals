using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "char")
            {
                char firstChar = Console.ReadLine()[0];
                char secondChar = Console.ReadLine()[0];
                char result = PrintMax(firstChar, secondChar);
                Console.WriteLine(result);
            }

            else if (type == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                int result = PrintMax(firstNum, secondNum);
                Console.WriteLine(result);

            }
            else if (type == "string")
            {
                string firstText = Console.ReadLine();
                string secondText = Console.ReadLine();
                string result = (PrintMax(firstText, secondText));
                Console.WriteLine(result);

            }
        }

        private static char PrintMax(char firstChar, char secondChar)
        {

            if (firstChar.CompareTo(secondChar) > 0) //ако е 1 - значи firstchar > secondchar
            {
                return (firstChar);
            }

            else
            {
                return (secondChar); //ако е -1 - значи firstchar < secondchar

            }
        }
        private static int PrintMax(int firstNum, int secondNum)
        {

            if (firstNum.CompareTo(secondNum) > 0) //ако е 1 - значи firstchar > secondchar
            {

                return (firstNum);


            }


            return (secondNum); //ако е -1 - значи firstchar < secondchar


        }
        private static string PrintMax(string firstText, string secondText)
        {

            if (firstText.CompareTo(secondText) > 0) //ако е 1 - значи firstchar > secondchar
            {
                return (firstText);
            }


            return (secondText); //ако е -1 - значи firstchar < secondchar


        }
    }
}