using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach_project
{
    class Matrix
    {
        public int m;

        public int n;

        public double[,] matrix;

        //Create method for multiplication of two matrices

        
        public int[,] ParseMatrix(string[] lines)
        {
            int rows = lines.Length;
            int cols = lines[0].Split('\t').Length; // Assuming tab-separated values
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split('\t'); // Adjusted to tab-separated
                for (int j = 0; j < cols; j++)
                {
                    if (int.TryParse(values[j], out int result))
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
                    matrix[i, j] = rand.NextDouble() * 100; // Random double numbers between 0 and 100
                }
            }
            return matrix;
        }
        public void setSize(Matrix matrix,int size)
        {
            matrix.n = size;
            matrix.m = size;
        }
        public void setSize(Matrix matrix, int rows, int cols)
        {
            matrix.n = cols;
            matrix.m = rows;
        }
    }
}
