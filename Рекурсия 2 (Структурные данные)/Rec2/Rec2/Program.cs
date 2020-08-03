using System;

namespace Rec2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] matrix = { { 1, 2, 3, 4 }, { 7, 8, 1, 4 }, { 1, 2, 3, 4 } };
            int[,] matrix = { { 1, 4, 9 }, { 4, 5, 2}, { 3, 2, 1} };
            //int[,] matrix = { { 1, 4, 3, 8 }, { 4, 1, 6, 8}, { 3, 6, 1, 3 }, { 8, 7, 3, 1 } };

            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.GetUpperBound(1) + 1;
            char result;
            bool boolean = true;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }

            // проверка, является ли матрица симметрично относительно диагонали

            for (int i = 0; i < (matrix.GetUpperBound(0) + 1); i++)
            {
                for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    if (matrix[i, j] == matrix[j, i])
                    {
                        boolean = true;
                    }
                    else
                    {
                        boolean = false;
                        break;
                    }
                }
            }

            if (boolean) result = 'Y';
            else result = 'N';





            /*Console.WriteLine("Введите количество строк в матрице: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов в матрице: ");
            int colums = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[rows, colums];


            int matrixRows = matrix1.GetUpperBound(0) + 1;
            int matrixColums = matrix1.GetUpperBound(1) + 1;
            Random randNum = new Random();
            for (int i = 0; i < matrixRows; i++)
            {
                for (int j = 0; j < matrixColums; j++)
                {
                    
                    matrix1[i,j] = randNum.Next(0, 100);
                }
            }

            for (int i = 0; i < matrixRows; i++)
            {
                for (int j = 0; j < matrixColums; j++)
                {
                    Console.Write(matrix1[i, j] + "  ");
                }
                Console.WriteLine();
            }*/


            Console.WriteLine("Ответ " + result);
            Console.ReadKey();
        }
    }
}
