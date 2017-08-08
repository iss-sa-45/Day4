using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program2
    {
        static void Main()
        {
            int[] A = new int[] { 12, 3, 8, 45, 2, 9};

            int[] B = new int[6];

            double[] E = new double[] { 10.0, 5.3, 6.9, 0.0, 2 };

            string[] EmpName = new string[]
                                   {"Venkat", "John", "Sabina"};

            Console.WriteLine(A[5]);
            A[5] = 20;
            Console.WriteLine(A[5]);

            //A[6] = 6; error

            for (int i = 0; i < B.Length; i++)
            {
                B[i] = i;
            }

            Array.Resize<int>(ref A, 10);
            A[9] = 9;
            Console.WriteLine(A[9]);

            //printing of array items
            Console.Write("[");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]);
                if (i < A.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("]");
            //-----

            int[,] Marks = new int[,] 
                    {   { 35, 82 }, 
                        { 67, 45 }, 
                        { 62, 77 } };

        }
    }
}
