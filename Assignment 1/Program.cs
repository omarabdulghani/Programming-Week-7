using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a price: ");

            float price = float.Parse(Console.ReadLine());

            float vat = VAT(price);

            Console.WriteLine("Price: {0:0.00}, VAT: {1:N2}, Total: {2:N2}", price, vat, price + vat);

            Console.ReadKey();
        }
        //Sub Program
        static float VAT(float money)
        {
            const float VAT = 0.21F;

            return money * VAT;
        }
    }
}