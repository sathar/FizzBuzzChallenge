using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a digit");
            while (true)
            {
                var input = Console.ReadLine();
                int result;
                if (!int.TryParse(input, out result))
                {
                    Console.WriteLine("Digit required");
                }
                else
                {
                    IFizzBuzzCommandProcessor fizzBuzzPrintCommandProccessor = new FizzBuzzCommandProcessor();
                    fizzBuzzPrintCommandProccessor.Process(Int32.Parse(input));
                }
            }

            Console.ReadLine();
        }
    }
}
