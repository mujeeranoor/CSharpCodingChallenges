using System;
using System.IO;

namespace MoveFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"D:\Mujeera Noor\CSharp Workspace\people.txt";
            string path2 = @"D:\Mujeera Noor\Terminal 123 Data\hello.txt";


            try
            {
                //if (!File.Exists(path1))
                //{
                //    using (FileStream fs = File.Create(path1)) { }
                //}

                if (File.Exists(path2))
                {
                    Console.WriteLine("The file already exists");
                }

                if (File.Exists(path1))
                {
                    File.Move(path1, path2);
                    Console.WriteLine("The file has been moved");
                }

                else
                {
                    Console.WriteLine("Code has been messed up");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed", e.ToString());
            }
            }   
    }
}
