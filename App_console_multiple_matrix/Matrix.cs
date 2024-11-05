using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_console_multiple_matrix
{
    class Matrix
    {
        public int m;

        public int n;

        public double[,] matrix;

        //Create method for multiplication of two matrices

        public double[,] ParseMatrix(string[] lines)
        {
            int rows = lines.Length;
            int cols = lines[0].Split('\t').Length; // Assuming tab-separated values
            double[,] matrix = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split('\t'); // Adjusted to tab-separated
                for (int j = 0; j < cols; j++)
                {
                    if (double.TryParse(values[j], out double result))
                    {
                        matrix[i, j] = result;
                    }
                    else
                    {
                        // Handle the error, e.g., set a default value or throw an exception
                        matrix[i, j] = 0; // Default value
                    }
                }
            }

            return matrix;
        }
        public double[,] GenerateRandomMatrix(int rows, int cols)
        {
            Random rand = new Random();
            double[,] matrix = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Math.Round(rand.NextDouble() * 100,5); // Random double numbers between 0 and 100
                }
            }
            return matrix;
        }
        public void setSize(Matrix matrix, int size)
        {
            matrix.n = size;
            matrix.m = size;
        }
        public void setSize(Matrix matrix, int rows, int cols)
        {
            matrix.n = cols;
            matrix.m = rows;
        }
        public static Matrix InputFromFile(Matrix matrix)
        {

            string filePath1 = Console.ReadLine();
            if (File.Exists(filePath1))
            {
                string[] lines = File.ReadAllLines(filePath1);
                int rows = lines.Length;
                int columns = lines[0].Split('\t').Length; // Assuming space-separated values

                matrix.setSize(matrix, rows, columns);
                matrix.matrix = matrix.ParseMatrix(lines);


            }
            else
            {
                Console.WriteLine("Файл не знайдено!");
                matrix = InputFromFile(matrix);
            }
            return matrix;
        }
        public static void PrintMatrix(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.m <= 15 && matrix1.n <= 15 && matrix2.m <= 15 && matrix2.n <= 15)
            {
                for (int i = 0; i < Math.Max(matrix1.m, matrix2.m); i++)
                {
                    for (int j = 0; j < matrix1.n; j++)
                    {
                        if (i < matrix1.m)
                        {
                            Console.Write($"  {matrix1.matrix[i, j],6}");
                        }
                        else
                        {
                            Console.Write("\t      ");
                        }
                    }

                    Console.Write(" | ");

                    for (int j = 0; j < matrix2.n; j++)
                    {
                        if (i < matrix2.m)
                        {
                            Console.Write($"  {matrix2.matrix[i, j],6}");
                        }
                        else
                        {
                            Console.Write("\t      ");
                        }
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("__________________________Виконання множення матриць__________________________");
            }
        }
    }
}
