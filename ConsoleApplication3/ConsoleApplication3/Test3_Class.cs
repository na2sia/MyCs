using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test3
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;
        
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public Triangle()
        { }
        public Triangle(double SideA, double SideB, double SideC)
        {
            a = SideA;
            b = SideB;
            c = SideC;
        }
        public bool CheckSide()
        {
            return ((A < B + C) & (A > B - C) & (B < A + C) & (B > A - C) & (C < A + B) & (C > A - B));
        }

        enum TypeTriangle { Obtuse, Acute, Rectang, NotExist }
        //string s = Enum.GetName(typeof(TypeTriangle), 1);
        public double[] SortValueSide()
        {
            double[] arr = new double[] { A, B, C };
            double tmp;
            for (int i = 0; i < 3; ++i)        
            {
                int pos = i;
                tmp = arr[i];
                for (int j = i + 1; j < 3; ++j)
                {
                    if (arr[j] < tmp)
                    {
                        pos = j;
                        tmp = arr[j];
                    }
                }
                arr[pos] = arr[i];
                arr[i] = tmp; 
            }
            return arr;
        }
        public string GetCheckTriangle()
        {
            if (CheckSide())
            {
                double[] arr1 = SortValueSide();

                if ((arr1[0] * arr1[0] + arr1[1] * arr1[1]) < arr1[2] * arr1[2])
                {
                    return Enum.GetName(typeof(TypeTriangle), 0);
                }
                else
                {
                    if ((arr1[0] * arr1[0] + arr1[1] * arr1[1]) > arr1[2] * arr1[2])
                    {
                        return Enum.GetName(typeof(TypeTriangle), 1);
                    }
                    else { return Enum.GetName(typeof(TypeTriangle), 2); }
                }
            }
            else { return Enum.GetName(typeof(TypeTriangle), 3); }
            
        }
    }
}
