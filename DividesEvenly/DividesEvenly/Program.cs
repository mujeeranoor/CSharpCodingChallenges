using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividesEvenly
{
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program p = new Program(); //creating object of the class Program
            p.dividesEvenly(15,5); // calling method 
        }

        /// <summary>
        /// takes two inputs, checks if they can be divisible by eachother evenly.
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="b">b</param>
        /// <returns>true or false</returns>
        public bool dividesEvenly(int a, int b)
        {
            //Console.WriteLine("Enter First number: ");
            //a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter second number: ");
            //b = int.Parse(Console.ReadLine());

            if (a % b == 0)
            {
                Console.WriteLine("The numbers are evenly divisible.");
                Console.ReadLine();
                return true;
            }
            else
            {
                Console.WriteLine("The numbers are not evenly divisible");
                Console.ReadLine();
                return false;
            }
        }
    }
}
