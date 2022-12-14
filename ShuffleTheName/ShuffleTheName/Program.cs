using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleTheName
{
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program p = new Program(); //creating object for class Program
            p.NameShuffle("Mujeera Noor"); // calling method
        }

        /// <summary>
        /// Takes string input and prints shuffled string.
        /// </summary>
        /// <param name="str1">str1</param>
        /// <returns>shuffled string</returns>
        public string NameShuffle(string str1)
        {
            string[] result = str1.Split(' ');
            Console.WriteLine(result[1] + " " + result[0]);
            Console.ReadLine();
            return "";
        }
    }
}
