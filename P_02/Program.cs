using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Black;

            int n1 = 1000;
            int n2 = 1000000;
            int n3 = 100000000;
            int n = n3;
            ulong[] vector_v2 = new ulong[n];
            ulong[] vector_v1 = new ulong[n];
            Console.WriteLine("Amount numbers: {0}", n);

            // Fill the vectors with random numbers
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                vector_v1[i] = (ulong)rand.Next(0, n);
                vector_v2[i] = (ulong)rand.Next(0, n);
            }

            DateTime startTime = DateTime.Now;
            
                ulong sum1 = vector_v1.Aggregate((acc, val) => acc + val);
                Console.WriteLine("Sum of vector_v1: " + sum1);

                ulong sum2 = vector_v2.Aggregate((acc, val) => acc + val);
                Console.WriteLine("Sum of vector_v2: " + sum2);
            // Calculate the total sum
            ulong totalSum = vector_v1.Aggregate((acc, val) => acc + val) + vector_v2.Aggregate((acc, val) => acc + val);
            Console.WriteLine("Total sum: " + totalSum);
            DateTime endTime = DateTime.Now;
            TimeSpan executionTime = endTime - startTime;
            Console.WriteLine("Execution time: " + executionTime.TotalMilliseconds + " ms");
            Console.ReadKey();
        }
    }
}

