using System;
using System.IO;
using System.Collections.Generic;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"D:\Учёба\С#\Оля\String\Inlet.in";
            string writePath = @"D:\Учёба\С#\Оля\String\Outlet.out";


            writeIntoMyFile(writePath, readMyFile(fileName));


            Console.WriteLine("Press something!");
            Console.ReadKey();
        }
        public static void writeIntoMyFile(string file, System.Collections.Generic.List<string> arr)
        {
            using (StreamWriter sw = new StreamWriter(file, false, System.Text.Encoding.Default))
            {
                foreach (string element in arr)
                {
                    sw.WriteLine(element);
                }
            }
        }

        public static System.Collections.Generic.List<string> readMyFile(string file)
        {
            List<string> myArray = new List<string>();
            string[] lines = File.ReadAllLines(file);
            foreach (string s in lines)
            {
                if (s != "")
                {
                    myArray.Add(devideToWords(s));
                }

            }

            return myArray;
        }

        public static string devideToWords(string str)
        {
            List<string> myArrayOfWord = new List<string>();
            int i = 0;
            string myStr = "";
            while (i < str.Length)
            {
                if (str[i] != ' ')
                {
                    myStr += str[i];
                }
                else
                {
                    if (myStr.Trim() != " ")
                    {
                        myArrayOfWord.Add(myStr);
                        myStr = "";
                    }
                }
                i++;
            }

            List<string> finalArrayOfWord = new List<string>();
            foreach (string element in myArrayOfWord)
            {
                    finalArrayOfWord.Add(replaceLetter(element));
            }

            string[] strs = new string[finalArrayOfWord.Count];
            for (int k = 0; k < finalArrayOfWord.Count; k++)
            {
                strs[k] = finalArrayOfWord[k];
            }

            string a = "";
            foreach (string element in strs)
            {
                a = a + " " + element + " ";
            }

            return a;

        }
        public static string replaceLetter(string str)
        {
            List<string> myArray = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {


                if (str[0] == str[i] && i != (0))
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
