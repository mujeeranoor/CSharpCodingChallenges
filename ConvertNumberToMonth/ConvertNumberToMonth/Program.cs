using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumberToMonth
{
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program p = new Program(); // creating an object for the class Program
            p.MonthName(7); // calling method
        }

        /// <summary>
        /// Converts int month to string month
        /// </summary>
        /// <param name="month">month</param>
        /// <returns>string month</returns>
        public string MonthName(int month)
        {
            DateTime date = new DateTime(2022, month, 1);
            Console.WriteLine(date.ToString("MMMM"));
            Console.ReadLine();
            return date.ToString("MMMM");
            
        }
    }
}
