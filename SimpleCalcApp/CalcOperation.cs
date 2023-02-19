using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalcApp
{
    public static class CalcOperation
    {
        private static double a = 0.0;
        private static double b = 0.0;

        public static double A {   
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        public static double B
        {
            get
            {
                return b;
            }

            set
            { 
                b = value;
            }

        }

        public static double sum()
        {
            return a + b;
        }

        public static double subtraction()
        {
            return a - b;
        }

        public static double multiplication()
        {
            return a * b;
        }

        public static double division()
        {
            if (double.IsNaN(a / b) || double.IsInfinity(a / b))
            {
                Console.WriteLine("Divided by 0");
                return 0;
            }
            return a / b;
        }
    }
}
