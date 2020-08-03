using System;

namespace A_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите k x");
            string [] data = Console.ReadLine().Split(' ');

            double sum = 0;
            int k = Convert.ToInt32(data[0]);
            double x = Convert.ToDouble(data[1]);

            for (int n = 0; n < k; n++)
            {
                sum += Math.Pow((-1), (n + 1)) * Math.Pow( x, (2 * n + 1) ) / (2 * n + 1);
            }

            Console.WriteLine(sum + Math.PI/2);
            Console.ReadKey();
        }
    }
}
