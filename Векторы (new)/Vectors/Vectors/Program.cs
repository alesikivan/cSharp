using System;
using System.Collections.Generic;

namespace TestConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {

           // int dataN = Convert.ToInt32(Console.ReadLine());
            string[] myarray = Console.ReadLine().Split(' ');

            int countS = 0;
            for(int i = 0; i < myarray.Length; i++)
            {
                if(myarray[i] == "0")
                {
                    countS++;
                }
            }


            List<string> arrayForZero = new List<string>();
            List<string> newMyArray = new List<string>();

            for (int i = 0; i < myarray.Length; i++)
            {
                if (myarray[i] == "0")
                {
                    arrayForZero.Add(myarray[i]);
                }
            }

            foreach(string el in myarray)
            {
                if(el != "0")
                {
                    newMyArray.Add(el);
                }
            }


            List<string> A = new List<string>();

            foreach (string el in newMyArray)
            {
                A.Add(el);
            }

            foreach (string el in arrayForZero)
            {
                A.Add(el);
            }

            Console.WriteLine();
            for (int i = 0; i < A.Count; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.ReadKey();
        }
    }
}