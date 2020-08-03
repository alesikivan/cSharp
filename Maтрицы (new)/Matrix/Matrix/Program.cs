using System;
using System.Collections.Generic;

namespace TestConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args) // готово
        {
            int result = 0;


            Console.WriteLine("Введите количество строк в матрице: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов в матрице: ");
            int colums = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[rows + 2, colums + 2];
            


            int matrixRows = matrix1.GetUpperBound(0) + 1;
            int matrixColums = matrix1.GetUpperBound(1) + 1;
            Random randNum = new Random();
            for (int i = 0; i < matrixRows; i++)
            {
                for (int j = 0; j < matrixColums; j++)
                {
                    
                    matrix1[i,j] = randNum.Next(1, 100);
                }
            }

            changeElements(matrix1);

            for (int i = 1; i < matrixRows - 1; i++)
            {
                for (int j = 1; j < matrixColums - 1; j++)
                {
                    Console.Write(matrix1[i, j] + "  ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    
                        if (
                         (matrix1[i + 1, j + 1] < matrix1[i, j + 1] || matrix1[i, j + 1] == 0) &&
                         (matrix1[i + 1, j + 1] < matrix1[i + 2, j + 1] || matrix1[i + 2, j + 1] == 0) &&
                         (matrix1[i + 1, j + 1] < matrix1[i + 1, j] || matrix1[i + 1, j] == 0) &&
                         (matrix1[i + 1, j + 1] < matrix1[i + 1, j + 2] || matrix1[i + 1, j + 2] == 0) &&
                         (matrix1[i + 1, j + 1] < matrix1[i + 2, j + 2] || matrix1[i + 2, j + 2] == 0) &&
                         (matrix1[i + 1, j + 1] < matrix1[i, j] || matrix1[i, j] == 0) &&
                         (matrix1[i + 1, j + 1] < matrix1[i, j + 2] || matrix1[i, j + 2] == 0) &&
                         (matrix1[i + 1, j + 1] < matrix1[i + 2, j] || matrix1[i + 2, j] == 0)
                       )
                        {
                            result++;
                        }
                    

                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static void changeElements(int[,] arr)
        {
            //int matrixRows = arr.GetUpperBound(0) + 1;
            int matrixColums = arr.GetUpperBound(1) + 1;

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < matrixColums; j++)
                {
                    arr[i, j] = 0;
                }
            }

            for (int i = arr.GetUpperBound(0); i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrixColums; j++)
                {
                    arr[i, j] = 0;
                }
            }


            for (int i = 0; i < matrixColums; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    arr[i, j] = 0;
                }
            }

            for (int i = 0; i < matrixColums; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    arr[i, j] = 0;
                }
            }

            for (int i = 0; i < matrixColums; i++)
            {
                for (int j = arr.GetUpperBound(0); j < arr.GetUpperBound(0) + 1; j++)
                {
                    arr[i, j] = 0;
                }
            }

        }
    }
}