using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteSum
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
            p.GetAbsoluteSum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }); // calling method
        }

        /// <summary>
        /// Returns sum of every element in an array
        /// </summary>
        /// <param name="Array1">Array1</param>
        /// <returns>result</returns>
        public int GetAbsoluteSum(int[] Array1)
        {
            var result = 0;
            for (int i = 0; i < Array1.Length; i++)
            {
                result = result + Array1[i];
            }
            Console.WriteLine(result);
            Console.ReadLine();
            return result;
        }
    }
}
