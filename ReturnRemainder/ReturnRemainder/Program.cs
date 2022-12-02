using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnRemainder
{
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //creating object of the class program
            Program p = new Program();
            //p.Remainder(4,5);
            //p.Remainder(20,0);
            //p.Remainder(8,4);
            p.Remainder(10,7);
            Console.ReadLine();

            //Remove slashes to check output of each.
        }

        /// <summary>
        /// Returns the remainder of two integers
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        /// <returns>remainder</returns>
        public int Remainder(int x, int y)
        {
            if (y == 0)
            {
                throw new Exception("Second number cannot be zero! Cannot divide by zero.");
            }
            if (x < y)
            {
                throw new Exception("First number should not be less than the second number, it should be greater than that");
            }
            else
                Console.WriteLine(x % y);
            return (x % y);
        }
    }
}
