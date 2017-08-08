using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class E4
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = Int32.Parse(Console.ReadLine());

            //is n a perfect number
            //compare n with the sum of its factors

            int sum = 0;
            //loop through from 1 to N-1
            for (int i = 1; i <= n - 1; i++)
            {
                //check whether it's a factor
                bool isFactor = (n % i) == 0;
                //if it's a factor then add it to the sum
                if (isFactor)
                {
                    sum = sum + i;
                }
            }

            //compare n with the sum, if it's the same, then it's a perfect number
            if (sum == n)
            {
                Console.WriteLine("It's a perfect number");
            }
        }
    }
}
