using System;
using System.IO;
using System.Collections.Generic;


namespace TextFiles
{
    class MainClass
    {
        static void Main(string[] args)
        {
            string fileName = @"D:\Учёба\С#\Готовые лабы по C#\Текстовые файлы (new)\TextFiles\Inlet.in";   
            string writePath = @"D:\Учёба\С#\Готовые лабы по C#\Текстовые файлы (new)\TextFiles\Outlet.out";


            writeIntoMyFile(writePath, readMyFile2(fileName));


            Console.WriteLine("Press something!");
            Console.ReadKey();
        }

        public static void writeIntoMyFile(string file, System.Collections.Generic.List<string> arr)
        {
            using (StreamWriter sw = new StreamWriter(file, false, System.Text.Encoding.Default))
            {
                foreach(string element in arr)
                {
                    sw.WriteLine(element);
                }
            }
        }
        public static System.Collections.Generic.List<string> readMyFile2(string file)
        {
            List<string> myArray = new List<string>();
            string[] lines = File.ReadAllLines(file);
            foreach (string s in lines)
            {
                myArray.Add(theGreatestWord(s));
            }
            
            return myArray;
        }

        public static string theGreatestWord(string str)
        {
            string[] stringArray = str.Split(' ');
            int maxCount = 0;

            List<string> result = new List<string>();

            for (int i = 0; i < stringArray.Length; i++)
            {
                if ((stringArray[i]).Length > maxCount)
                {
                    maxCount = (stringArray[i]).Length;
                }
            }
            for (int i = 0; i < stringArray.Length; i++)
            {
                if ((stringArray[i]).Length == maxCount)
                {
                    result.Add(stringArray[i]);
                }
            }

            string resultOFArray = String.Join(" ", result); ;


            return resultOFArray;
        }
    }
}
