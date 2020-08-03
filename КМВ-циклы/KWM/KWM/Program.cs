using System;
using System.Collections.Generic;

namespace TestConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string[] data = Console.ReadLine().Split(' '); // 2 0,042 - 0,6666666666

            double x = Convert.ToDouble(data[0]);
            double e = Convert.ToDouble(data[1]);

            double sum = 0;
            double slug = 0;
            int i = 0;
            slug = Math.Pow((x - 1), (i + 1)) / ((i + 1) * Math.Pow(x, (i + 1)));

            while (slug > e)
            {
                slug = Math.Pow((x - 1), (i + 1)) / ((i + 1) * Math.Pow(x, (i + 1)));
                sum += slug;
                i++;
            }


            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}

