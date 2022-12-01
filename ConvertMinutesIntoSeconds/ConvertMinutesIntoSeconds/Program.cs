using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMinutesIntoSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating object of the class ConvertMINtoSEC
            ConvertMINtoSEC c = new ConvertMINtoSEC();
            c.convert(2); //calling method within the class
            c.convert(3); //calling method within the class
            Console.ReadLine();
        }
    }
}
