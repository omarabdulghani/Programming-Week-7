using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 1;


            do
            {
                Console.Write("Enter a year (0 is the stop value): ");
                n = int.Parse(Console.ReadLine());

                bool result = IsLeap(n);

                if (n == 0)

                {
                    Console.WriteLine("End of the program");


                }

                else if (result && n > 0)
                {
                    Console.WriteLine($"{n} is a leap year");

                }

                else
                {
                    Console.WriteLine($"{n} is not a leap year");
                }

            

            } while (n != 0);

            Console.ReadKey();

        }

        //.. Sub Program

        static bool IsLeap(int n)
        {
            bool isLeap = false;
          
            
            while(true) 
            {
                if (n % 400 == 0 || (n % 4 == 0 && n % 100 != 0))
                    isLeap = true;
                return isLeap;
            }

            
        }
    }
}
