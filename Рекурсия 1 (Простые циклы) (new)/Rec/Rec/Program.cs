using System;
using System.Collections.Generic;

namespace TestConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)       
        {


            double data = Convert.ToDouble(Console.ReadLine());  // 0,007

            double sum = 0;
            double slug;
            int i = 1;

            slug = 0;
            while((1.0 / ((4 * i - 1) * (4 * i + 1))) > data)
            {
                slug = (1.0 / ((4 * i - 1) * (4 * i + 1)));  
                sum += slug;
                i++;
            }



            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}

