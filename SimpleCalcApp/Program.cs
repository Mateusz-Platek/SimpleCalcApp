using System;

namespace SimpleCalcApp
{ 
    class Program
    {
        static void Main(String[] args)
        {
            int option;
            while (true)
            {
                Menu.showMenu();   
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Menu.setA();
                        break;
                    case 2:
                        Menu.setB();
                        break;
                    case 3:
                        Menu.sum();
                        break;
                    case 4:
                        Menu.subtract();
                        break;
                    case 5:
                        Menu.multiply();
                        break;
                    case 6:
                        Menu.divide();
                        break;
                    case 7:
                        Console.WriteLine("End");
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong number");
                        break;
                }
            }
        }
    }
}