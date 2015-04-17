using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
           Triangle tri = new Triangle(1,4,3);
          /* Console.WriteLine("Введите стороны треугольника:");
           Console.Write("a=");
           tri.A=double.Parse(Console.ReadLine());
           Console.Write("b=");
           tri.B = double.Parse(Console.ReadLine());
           Console.Write("c=");
           tri.C = double.Parse(Console.ReadLine());
           */
            Console.WriteLine("Triangle - {0}",  tri.GetCheckTriangle());
            Console.ReadKey();




        }
    }
}
