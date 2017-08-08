using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class E5
    {
        static void Main()
        {
            for (int k = 5; k<=100; k++)
            {
                //is k a prime?

                int N = k;

                //a prime number is a number that is only divisible by itself and 1
                //count from 2 to N-1, if any of the number can divide N, then it's not prime
                int i = 2;
                bool divisorNotFound = true;

                //while the number is still less than N and we haven't find any divisor yet
                while (i < N && divisorNotFound)
                {
                    if (N % i == 0)
                    {
                        divisorNotFound = false;
                        //we found another divisor between 2 to N-1
                    }
                    i++;
                }

                //print out whether it's prime or not.
                if (divisorNotFound && N > 0)
                {
                    Console.WriteLine("{0} is a prime", N);
                }


            }
        }
    }
}
