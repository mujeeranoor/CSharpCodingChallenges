using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareStringsByCountOfCharacters
{
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program p = new Program(); //creating an object of class Program
            p.Compare("Mujeera", "Noor"); // calling method
        }

        /// <summary>
        /// returns true if strings are equal else returns false
        /// </summary>
        /// <param name="str1">string1</param>
        /// <param name="str2">string2</param>
        /// <returns>true or false</returns>
        public bool Compare(string str1, string str2)
        {
            if (str1.Length == str2.Length)
            {
                Console.WriteLine("Strings are equal.");
                Console.ReadLine();
                return true;
            }
            else
            {
                Console.WriteLine("Strings are not equal.");
                Console.ReadLine();
                return false;
            }
        }
    }
}
