using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class D4
    {
        static void Main()
        {
            //take input -> N
            Console.Write("Please enter N: ");
            int N = Int32.Parse(Console.ReadLine());

            //get a random number G
            Random r = new Random();
            double G = r.Next(1, N);
            //double G = r.NextDouble() * N;

            //while(G*G not close to N to 5 decimal points)
            while( Math.Abs(G*G-N) > 0.00001)
            {
                //recalculate G
                G = (G + N / G) / 2;
            }

            //print G -> sqrt of N
            Console.WriteLine("Square root of {0} is {1}", N, G);
        }
    }
}
