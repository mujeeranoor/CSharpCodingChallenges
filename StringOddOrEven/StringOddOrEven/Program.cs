using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOddOrEven
{
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program p = new Program(); //creating object of class Program
            p.OddOrEven("Mujeera"); //calling method
        }

        /// <summary>
        /// Checks if the string length is even or odd.
        /// </summary>
        /// <param name="word">word</param>
        /// <returns>true or false</returns>
        public bool OddOrEven(string word)
        {
            int length = word.Length;
            if (length % 2 == 0)
            {
                Console.WriteLine("String length is EVEN");
                Console.ReadLine();
                return true;
            }
            else
            {
                Console.WriteLine("String length is ODD");
                Console.ReadLine();
                return false;
            }
        }
    }
}
