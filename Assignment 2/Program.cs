using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 1;


            do
            {
                Console.Write("Enter a number (0 is the stop value): ");
                n = int.Parse(Console.ReadLine());

                bool result = IsPrime(n);

                if (n == 0)

                {
                    Console.WriteLine("End of the program");


                }

                else if (result && n > 0)
                {
                    Console.WriteLine($"{n} is a prime number");

                }

                else if (n < 0)
                {
                    Console.WriteLine("Negative number entered...");
                }

                else
                {
                    Console.WriteLine($"{n} is not a prime number");

                }






            } while (n != 0);

            Console.ReadKey();

        }

        //.. Sub Program

        static bool IsPrime(int n)
        {
            bool isPrime = true;
            int i = 2;

            while ((i < n) && isPrime)
            {
                if ((n % i) == 0)
                    isPrime = false;
                else
                    i++;
            }

            return isPrime;
        }
    }
}
