using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class LinearFunction
    {
        private double a;
        private double b;

        public LinearFunction()
        { }
        public LinearFunction( double p_a, double p_b)
        {
            a = p_a;
            b = p_b;
        }

        public double A
        {
            get {return a;}
            set {a=value;}
        }
        
        public double B
        {
            get {return b;}
            set {b=value;}
        }
        
        public double GetFunctionY(double x)
        {
            return (A * x) + B;
        }
    }
}
