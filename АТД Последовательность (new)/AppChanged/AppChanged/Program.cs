using System;
using System.IO;
using System.Collections.Generic;

namespace AppChanged
{
    class MainClass
    {

        static void Main(string[] args)
        {

            const string data = @"D:\Учёба\С#\Готовые лабы по C#\АТД Последовательность (new)\AppChanged\Inlet.in";
            const string dataOut = @"D:\Учёба\С#\Готовые лабы по C#\АТД Последовательность (new)\AppChanged\Outlet.out";



            writeIntoMyFile(dataOut, readMyFile2(data));
          

            Console.WriteLine("Press something!");
            Console.ReadKey();


        }


        public static void writeIntoMyFile(string file, string text)
        {
            using (StreamWriter sw = new StreamWriter(file, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
            }
        }
        public static string readMyFile2(string file)
        {
            List<string> myArray = new List<string>();
            string[] lines = File.ReadAllLines(file);
            foreach (string s in lines)
            {
                myArray.Add(s);
            }

            List<string> results = new List<string>();

            // findMaxElement(myArray) - массив индексов элементов, которые нужно убрать 

            for(int i = 0; i < myArray.Count; i++)
            {
                if(!(findMaxElement(myArray)).Contains(i))
                {
                    results.Add(myArray[i]);
                }
            }
            

            return string.Join(" ", results);


        }

        public static System.Collections.Generic.List<int> findMaxElement(System.Collections.Generic.List<string> arr)
        {

            List<int> indexes = new List<int>();

            int index = 0;
            double max = 0;

            for(int i = 0; i < arr.Count; i++)
            {
                double el = Math.Abs(Convert.ToDouble(arr[i].Replace('.', ',')));
                if (max < el)
                {
                    max = Math.Abs(Convert.ToDouble(arr[i].Replace('.', ',')));
                    index = i;
                }
            }

            for (int i = 0; i < arr.Count; i++)
            {
                double unsuall = max * (-1);
                double usuall = max;

                if(unsuall == Convert.ToDouble(arr[i].Replace('.', ',')) || usuall == Convert.ToDouble(arr[i].Replace('.', ',')))
                {
                    indexes.Add(i);
                }

            }

                return indexes;
        }


    }
}

