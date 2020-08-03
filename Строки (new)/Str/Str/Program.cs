using System;
using System.Collections.Generic;
using System.IO;

namespace Str
{
    class MainClass
    {
        static void Main(string[] args)
        {

            const string data = @"D:\Учёба\С#\Готовые лабы по C#\Строки (new)\Str\Inlet.in";
            const string dataOut = @"D:\Учёба\С#\Готовые лабы по C#\Строки (new)\Str\Outlet.out";

            writeIntoMyFile(dataOut, readMyFile2(data));

            Console.WriteLine("Press something!");
            Console.ReadKey();


        }












        public static void writeIntoMyFile(string file,string text)
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
                myArray.Add(replaceLetter(s));
            }
            string str = string.Join(" ", myArray);
            return str;
        }
        public static string readMyFile(string str)
        {
            using (FileStream fstream = File.OpenRead(str))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                return textFromFile;
            }
        }

        public static string replaceLetter(string str)
        {
            List<string> myArray = new List<string> ();

            for(int i = 0; i < str.Length; i++)
            {
                
                
                if(str[str.Length - 1] == str[i] && i != (str.Length - 1))
                {
                    myArray.Add("_");
                }
                else
                {
                    myArray.Add(str[i].ToString());
                }
            }

            string s = string.Join("", myArray);
            return s;
        }
    }
}
