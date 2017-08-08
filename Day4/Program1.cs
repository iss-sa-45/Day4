using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program1
    {
        static void Main()
        {
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i == 3)
                    {
                        break;
                    }
                    Console.WriteLine("{0}-{1}",j, i);
                }
            }

            Console.WriteLine("End of program");
        }
    }
}
