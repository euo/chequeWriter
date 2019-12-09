using ChequeWriterLib;
using System;

namespace ChequeWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Cheque Writer Utility ---");
            Console.WriteLine("- Enter a number up to 2 billion, with or without decimal parts");
            Console.WriteLine("- Enter 'quit' to exit");

            string input = Console.ReadLine();
            while (string.IsNullOrEmpty(input) || !input.ToLower().Equals("quit"))
            {
                decimal number = 0;
                if (!decimal.TryParse(input, out number))
                {
                    Console.WriteLine("Please enter a valid number");
                }
                else
                {
                    Console.WriteLine(ChequeWriterUtil.GetString(number));
                }

                input = Console.ReadLine();
            }
        }
    }
}
