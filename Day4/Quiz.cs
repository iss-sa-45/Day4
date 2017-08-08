using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Quiz
    {
        static void Main(string[] args)
        {
            int numRetries = 0;
            bool correctPIN = false;
            string pin = "123456";

            Console.WriteLine("Welcome to the Bank of ISS");

            do
            {
                //ask for PIN
                Console.Write("Enter your PIN: ");
                string input = Console.ReadLine();

                numRetries++;

                if (input == pin)
                {
                    correctPIN = true;
                }

                if (!correctPIN && numRetries < 3)
                {
                    Console.WriteLine("Incorrect PIN. Please try again.");
                }
            } while (numRetries < 3 && !correctPIN);

            //we know that either numRetries >=3 or correctPIN
            if (correctPIN) //correctPIN==true
            {
                Console.WriteLine("PIN accepted. You can access your account now.");
            } else
            {
                Console.WriteLine("Too many wrong PIN entries. Your account is now locked");
            }
        }
    }
}
