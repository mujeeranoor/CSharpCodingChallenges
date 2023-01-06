using System;

namespace SmallerStringNumber
{
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            Program p = new Program(); //creating object of a class Program
            p.smallerNum("2","7"); //calling method
        }

        /// <summary>
        /// Returns smallest string number
        /// </summary>
        /// <param name="n1">n1</param>
        /// <param name="n2">n2</param>
        /// <returns>Smallest string number</returns>
        public string smallerNum(string n1, string n2)
        {
            string Result = Int32.Parse(n1) > Int32.Parse(n2) ? n2 : n1;
            Console.WriteLine(Result);
            Console.ReadLine();
            return Result;
        }
    }
}
