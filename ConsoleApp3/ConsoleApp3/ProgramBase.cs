using System;

namespace ConsoleApp3
{
    internal class ProgramBase
    {
        private static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the number of rows");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns");
            int col = int.Parse(Console.ReadLine());
            int[,] matrixx = new int[row, col];
            Console.WriteLine("Enter the cells of the matrix:");
            for (int rows = 0; rows < row; rows++)
            {
                for (int cols = 0; cols < col; cols++)
                {
                    Console.Write("matrixx[{0},{1}] = ", rows, cols);
                    matrixx[rows, cols] = int.Parse(Console.ReadLine());

                }

            }
            for (int rows = 0; rows < row; rows++)
            {
                for (int cols = 0; cols < col; cols++)
                {
                    Console.Write(matrixx[rows, cols] + " ");

                }
                Console.WriteLine();
            }
            int[,] matrix =
            {
                {1,2,3,4},
                {6,7,8,9},
                {2,3,4,5},
                {4,5,6,7},

            };
        long maxsum = long.MinValue;
        int bestrow = 0;
        int bestcol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++) 
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    long sum = matrix[row, col] + matrix[row + 1, col] + matrix[row,col + 1] + matrix[row + 1,col + 1];
                    if (sum > maxsum)
                    {
                        maxsum = sum;
                        bestrow = row;
                        bestcol = col;
                    }
                }
                Console.WriteLine(matrix[bestrow, bestcol] + matrix[bestrow + 1, bestcol] + matrix[bestrow, bestcol + 1] + matrix[bestrow + 1, bestcol + 1]);
            }
            if (maxsum % 2 == 0)
            {
                Console.WriteLine(maxsum);
            }
           if ((maxsum % 3==0) && (maxsum % 5==0))
            {
                Console.WriteLine(maxsum);
            }*/
            Console.WriteLine("Length of the jagged array");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("number of element");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the element of array");
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {

                    }
                }
                Console.WriteLine(b);
            }



































        }
    }
}