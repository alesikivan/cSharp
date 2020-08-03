using System;
using System.Collections.Generic;

namespace TestConsoleApp
{
    class MainClass
    {
        static double f(double x)
        {
            return x*x*x - 2 * x * x - 0.2 * x + 0.5; ;
        }
        static double taskResult(double a, double b, double c, double accuracy)
        {
            while (Math.Abs(c - a) > accuracy)
            {
                if (f(a) * f(c) < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }
                c = 0.5 * (a + b);
            }
            return c;
        }

        static void Main(string[] args)
        {

            string  data = Console.ReadLine();
            string[] myArray = data.Split(' ');
            double a = double.Parse(myArray[0]);
            double b = double.Parse(myArray[1]);
            double accuracy = double.Parse(myArray[2]);
            double c = (a + b) * 0.5;
            c = taskResult(a, b, c, accuracy);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}

