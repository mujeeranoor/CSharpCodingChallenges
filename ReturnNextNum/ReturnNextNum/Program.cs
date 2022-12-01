using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnNextNum
{
    class Program
    {
        /// <summary>
        /// Returns the next number from the integer passed.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int Addition(int num)
        {
            int n = num + 1;
            Console.WriteLine(n);
            return num;
        }

        /// <summary>
        /// Main method of the program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Creating object of the class Program
            Program p = new Program();
            p.Addition(33); //calling method
            Console.ReadLine(); //for the console screen to stay
        }
    }
}
