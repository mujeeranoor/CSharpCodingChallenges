using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatinateName
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
            p.concatName("Mujeera ", "Noor"); // calling method
        }

        /// <summary>
        /// Concats first name and last name as fullname
        /// </summary>
        /// <param name="firstname">firstname</param>
        /// <param name="lastname">lastname</param>
        /// <returns>fullname</returns>
        public string concatName(string firstname, string lastname)
        {
            string fullname = firstname + lastname;
            Console.WriteLine(fullname);
            Console.ReadLine();
            return fullname;
        }
    }
}
