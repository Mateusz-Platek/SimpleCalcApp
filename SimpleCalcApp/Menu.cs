using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalcApp
{
    public static class Menu
    {
        public static void showMenu()
        {
            Console.WriteLine("A: " + CalcOperation.A);
            Console.WriteLine("B: " + CalcOperation.B);
            Console.WriteLine("1 - Set A");
            Console.WriteLine("2 - Set B");
            Console.WriteLine("3 - Sum");
            Console.WriteLine("4 - Subtract");
            Console.WriteLine("5 - Multiply");
            Console.WriteLine("6 - Divide");
            Console.WriteLine("7 - Exit");
            Console.WriteLine("Select option:");
        }

        public static void setA()
        {
            Console.WriteLine("Input A:"); 
            try
            {
                CalcOperation.A = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong number");
            }
        }

        public static void setB()
        {
            Console.WriteLine("Input B:");
            try
            {
                CalcOperation.B = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong number");
            }
        }

        public static void sum()
        {
            CalcOperation.A = CalcOperation.sum();
            CalcOperation.B = 0;
            Console.WriteLine("Result: " + CalcOperation.A);
        }

        public static void subtract()
        {
            CalcOperation.A = CalcOperation.subtraction();
            CalcOperation.B = 0;
            Console.WriteLine("Result: " + CalcOperation.A);
        }

        public static void multiply()
        {
            CalcOperation.A = CalcOperation.multiplication();
            CalcOperation.B = 0;
            Console.WriteLine("Result: " + CalcOperation.A);
        }

        public static void divide()
        {
            CalcOperation.A = CalcOperation.division();
            CalcOperation.B = 0;
            Console.WriteLine("Result: " + CalcOperation.A);
        }
    }
}
