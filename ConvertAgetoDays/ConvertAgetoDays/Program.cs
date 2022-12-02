using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertAgetoDays
{
    class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //creating object of the class program
            Program p = new Program();
            p.CalcAge(25); // calling method
            Console.ReadLine();
        }

        /// <summary>
        /// A method to calculate age and return it into days
        /// </summary>
        /// <param name="age">age</param>
        /// <returns>age in days</returns>
        public int CalcAge(int age)
        {
            int a = age * 365;
            Console.WriteLine(a);
            return age;
        }
    }
}


//use 365 days as the length of a year for this challenge
//Ignore leap years
//consider only positive integer inputs
