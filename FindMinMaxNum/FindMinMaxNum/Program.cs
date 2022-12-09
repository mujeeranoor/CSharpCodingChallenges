using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMinMaxNum
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
            p.FindMinMax(new int[] { 31, 24, 3, 48, 50, 98, 9, 83 }); //calling method
        }

        /// <summary>
        /// Takes integer array as input and gives minimum number and maximum number in output
        /// </summary>
        /// <param name="values">values</param>
        /// <returns>Min Max Number</returns>
        public int[] FindMinMax(int[] values)
        {
            Console.WriteLine(values.Min());
            Console.WriteLine(values.Max());
            Console.ReadLine();
            return new[] { values.Min(), values.Max() };
        }
    }
}
