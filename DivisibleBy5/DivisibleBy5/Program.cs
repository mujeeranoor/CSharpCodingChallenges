using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy5
{
    class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // creating object of class Program
            Program p = new Program();
            p.divisibleByFive(10); // calling method
        }

        /// <summary>
        /// Checks if the number is divisible by 5
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>True or False</returns>
        public bool divisibleByFive(int n)
        {
            if (n % 5 == 0)
            {
                Console.WriteLine("The Number is divisible by 5.");
                Console.ReadLine();
                return true;
            }
            else
            {
                Console.WriteLine("The Number is not divisible by 5.");
                Console.ReadLine();
                return false;
            }
            
        }
    }
}
