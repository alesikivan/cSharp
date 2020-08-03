using System;
using System.Collections.Generic;
using System.IO;

namespace L1
{
    class Program
    {
        static void Main(string[] args)
        {

            const string data = @"D:\Учёба\С#\Готовые лабы по C#\АТД Л1_список\L1\Inlet.in";
            const string dataOut = @"D:\Учёба\С#\Готовые лабы по C#\АТД Л1_список\L1\Outlet.out";

            writeIntoMyFile(dataOut, readMyFile2(data));

            Console.WriteLine("Press something!");
            Console.ReadKey();
        }

        public static void writeIntoMyFile(string file, int text)
        {
            using (StreamWriter sw = new StreamWriter(file, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
            }
        }
        public static int readMyFile2(string file)
        {
            List<int> myArray = new List<int>();
            string[] lines = File.ReadAllLines(file);
            foreach (string s in lines)
            {
                myArray.Add(CountOfWords(s));
            }
            string str = string.Join(" ", myArray);


            return allCount(myArray);

        }

        public static int CountOfWords(string str)
        {
            int count = 0;

            string [] wordArray = str.Split(' ');

            for (int i = 0; i < wordArray.Length; i++)
            {


                if(str != "")
                {
                    if (wordArray[i][wordArray[i].Length - 1] == wordArray[i][0])
                    {
                        count++;
                    }
                }
                
            }

            
            return count;
        }

        public static int allCount(System.Collections.Generic.List<int> arr)
        {
            int count = 0;
            foreach (int el in arr)
            {
                count += el;
            }
            return count; 
        }
    }
}
