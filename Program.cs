using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static int CRD(string crd, string point)
        {
            Console.Write($"Введите координату {crd} точки {point}: ");
            return Convert.ToInt16(Console.ReadLine());
        }

       static double Decision(double x1, double x2,
                           double y1, double y2,
                           double z1, double z2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                             Math.Pow((y2 - y1), 2) +
                             Math.Pow((z2 - z1), 2));
        }

        static void Main(string[] args)
        {
            ///Задача 21
            int x1 = CRD("x", "A");
            int y1 = CRD("y", "A");
            int z1 = CRD("z", "A");
            int x2 = CRD("x", "B");
            int y2 = CRD("y", "B");
            int z2 = CRD("z", "B");


            double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);

            Console.WriteLine($"Длина отрезка => {segmentLength}");

        }
    }
}
