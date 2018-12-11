using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise64
{
   public class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter a number: ");
                var input = Console.ReadLine();

                IsInt(input);

               Console.Write("Would you like to continue? (y/n): ");
            } while (Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase));



        }

        public static bool IsInt(string input)
        {
            int parsedInput;
            bool parsed = Int32.TryParse(input, out parsedInput);

            if (!parsed)
            {
                Console.WriteLine($"{input} cannot be parsed as an integer.");
            }
            else
            {
                Console.WriteLine($"{input} can be parsed as an integer.");
            }

            return parsed;
        }
    }
}
