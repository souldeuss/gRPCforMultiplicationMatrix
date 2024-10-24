using System;
namespace P_02
{
    internal class Vector
    {
        public long n;
        public long[] vector;

        public Vector(long n)
        {
            this.n = n;
            vector = new long[n];
        }

        public long sum (Vector v1)
        {
            // Sum all elements of the vector
            long summa = 0;
            for (int i = 0; i < v1.vector.Length; i++)
            {
                summa += v1.vector[i];
            }


            return summa;
        }
    }
}
