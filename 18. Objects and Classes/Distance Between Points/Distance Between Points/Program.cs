using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Between_Points
{
    class Program
    {
        class Point
        {
            public double X { get; set; }
            public  double Y { get; set;  }

        }
        static double CalcDistans(Point a, Point b)
        {
            double deltaX = a.X - b.X;
            double deltaY = a.Y - b.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

        }
        static void Main(string[] args)
        {

            string[] p1Values = Console.ReadLine().Split();
            Point p1 = new Point()
            {
                X = double.Parse(p1Values[0]),
                Y = double.Parse(p1Values[1])
            };


            string[] p2Values = Console.ReadLine().Split();
            Point p2 = new Point();
            
            p2.X = double.Parse(p2Values[0]);
            p2.Y = double.Parse(p2Values[1]);

            Console.WriteLine(CalcDistans(p1, p2));
        }

        
    }
}
