using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class B9
    {
        static void Main()
        {
            Console.Write("Enter distance: ");
            double distance = Double.Parse(Console.ReadLine());

            double fare = 2.4 + 0.4 * distance;

            //round up the fare
            //if the fare is 3.72, 3.72 -> 37.2 -> round up to 38 -> 3.8
            fare = 10 * fare; //3.72 -> 37.2
            fare = Math.Ceiling(fare); //37.2 -> 38
            fare = fare / 10; //38 -> 3.8

            Console.WriteLine("Your fare is {0}", fare);
             
        }
    }
}
