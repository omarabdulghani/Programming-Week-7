using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text > ");
            string text = Console.ReadLine();

            int nrOfFullStops, nrOfCommas, nrOfSemiColons;

            SearchText(text, out nrOfFullStops, out nrOfCommas, out nrOfSemiColons);

            Console.Write($"Result: {nrOfFullStops} full stops, {nrOfCommas} commas, {nrOfSemiColons} semicolons");

            Console.ReadKey();

        }


    

    static void SearchText(string text, out int nrOfFullStops, out int nrOfCommas, out int nrOfSemiColons)
    {
        

        nrOfFullStops = 0;
        nrOfCommas = 0;
        nrOfSemiColons = 0;

        foreach (char c in text)
            if (c == '.') nrOfFullStops++;

       

            else if (c == ',') nrOfCommas++;

        

            else if (c == ';') nrOfSemiColons++;

       

    }

    }
}
