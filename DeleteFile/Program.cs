using System;
using System.IO;

namespace DeleteFile
{
    class Program
    {
        static readonly string filepath = @"D:\Mujeera Noor\CSharp Workspace";
        
        static void Main(string[] args)
        {
            string mainFile = "hello.txt";

            try
            {
                if (File.Exists(Path.Combine(filepath, mainFile)))
                {
                    File.Delete(Path.Combine(filepath, mainFile));
                    Console.WriteLine("File has been deleted.");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
            catch (IOException ioexp)
            {
                Console.WriteLine(ioexp.Message);
            }
            Console.ReadLine();
        }
    }
}
