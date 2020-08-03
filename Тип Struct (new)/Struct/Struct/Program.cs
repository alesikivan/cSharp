using System;
using System.IO;
using System.Collections.Generic;

namespace Struct
{
    class MainClass
    {
        static void Main(string[] args)
        {
            const string data = @"D:\Учёба\С#\Готовые лабы по C#\Тип Struct (new)\Struct\Inlet.in";
            const string dataOut = @"D:\Учёба\С#\Готовые лабы по C#\Тип Struct (new)\Struct\Outlet.out";

            writeIntoMyFile(dataOut, readMyFile2(data));


            Console.WriteLine("Press something!");
            Console.ReadKey();
        }

        public static void writeIntoMyFile(string file, System.Collections.Generic.List<string> arr)
        {
            using (StreamWriter sw = new StreamWriter(file, false, System.Text.Encoding.Default))
            {
                foreach(string text in arr)
                {
                    sw.WriteLine(text);
                }
            }
        }
        public static System.Collections.Generic.List<string> readMyFile2(string file)
        {
            
            string[] lines = File.ReadAllLines(file);

            List<string> nameArray = new List<string>();
            List<string> markArray = new List<string>();
            List<string> newMarkArrray = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if(i % 2 == 0)
                {
                    nameArray.Add(lines[i]);
                }
                else
                {
                    markArray.Add(lines[i]);
                }
            }

            foreach(string element in markArray)
            {
                newMarkArrray.Add(sumMyElement(element));
            }

            nameArray.Sort();

            return arrayUnit(nameArray, newMarkArrray);
            



        }

        public static string sumMyElement(string arr) // "9 10 3 3 9"
        {
            
            List<string> markArray = new List<string>();

            int i = 0;
            string str = "";
            while (i < arr.Length)
            {
                
                if (arr[i] != ' ')
                {
                    str += arr[i];
                }
                else
                {
                    markArray.Add(str);
                    str = "";
                }
                i++;
            }

            double sum = 0;
            foreach (string el in markArray)
            {
                sum += Convert.ToInt32(el);
            }

            double result = sum / markArray.Count;

            return Convert.ToString(result);


        }

        public static System.Collections.Generic.List<string> arrayUnit(System.Collections.Generic.List<string> arr1, System.Collections.Generic.List<string> arr2)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < arr1.Count; i++)
            {
                result.Add(arr1[i]);
                //result.Add(arr2[i]);
            }

            int max = 0;
            foreach (string el in arr2)
            {
                if(Convert.ToDouble(el) >= 4)
                {
                    max++;
                }
            }

            result.Add("Success children = " + max);

            return result;
        }
    }
}