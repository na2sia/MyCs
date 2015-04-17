using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{

    class Test1_Program
    {
        static void Main(string[] args)
        {
            LinearFunction LF = new LinearFunction(4,5);
           // LF.A=10;
            //LF.B=3;
            Console.Write("X=");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("Y={0}",LF.GetFunctionY(x));
            Console.ReadKey();
        }
    }
}
