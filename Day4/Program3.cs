using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program3
    {
        static void Main()
        {
            int[] items = new int[] { 34, 72, 24, 16, 95, 43, 34, 67, 22, 51 };

            //printing of array items
            Console.Write("[");
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i]);
                if (i < items.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("]");
            //-----

            for (int green=0;green<items.Length - 1; green++)
            {
                for (int red=green+1; red<items.Length; red++)
                {
                    
                    if (items[green] < items[red])
                    {
                        //swap
                        int c = items[green];
                        items[green] = items[red];
                        items[red] = c;
                    }
                }
            }

            //printing of array items
            Console.Write("[");
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i]);
                if (i < items.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("]");
            //-----


        }
    }
}
