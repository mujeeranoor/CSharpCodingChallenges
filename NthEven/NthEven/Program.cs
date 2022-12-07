using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthEven
{
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program p = new Program(); //creates object for the class Program
            p.NthEvenNumber(7); // calling method
        }

        /// <summary>
        /// returns nth even number
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>nth even number</returns>
        public int NthEvenNumber(int n)
        {
            int output = n * 2;
            Console.WriteLine(output);
            Console.ReadLine();
            return n;
        }
    }
}
