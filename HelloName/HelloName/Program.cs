using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object of class program
            Program p = new Program();
            p.Greeting("Alexa"); // calling method
            p.Greeting("Sam"); // calling method
            Console.ReadLine();
        }

        /// <summary>
        /// Returns "Hello (input name)"
        /// </summary>
        /// <param name="name">name</param>
        /// <returns>name with greeting</returns>
        public string Greeting(string name)
        {
            Console.WriteLine("Hello " + name);
            return name;
        }
    }
}
