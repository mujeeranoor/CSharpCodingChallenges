using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToThePowerOf
{
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program p = new Program(); // creating an object for class Program
            p.CalculateExponent(2,4); // calling method
        }

        /// <summary>
        /// Takes two integer inputs and returns 'exponent' times 'number'
        /// </summary>
        /// <param name="number">number</param>
        /// <param name="exponent">exponent</param>
        /// <returns>exponent times number</returns>
        public long CalculateExponent(long number, long exponent)
        {
            Console.WriteLine((long) Math.Pow(number, exponent));
            Console.ReadLine();
            return (long)Math.Pow(number, exponent);
        }
    }
}
