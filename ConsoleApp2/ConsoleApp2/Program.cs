using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            Console.WriteLine("Enter words");
            string words = Console.ReadLine();
            string[] word = words.Split(" ");
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(word[i]);
            }*/
/*            int[,] matrix = new int[3, 4];
*/            int[,] matrix =
            {
                {2,4,5,4,},
                {3,6,7,8 },
                {2,5,8,3 },
            };
                for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i,j] + " ");
                }
            }
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
               


        }
    }
}
