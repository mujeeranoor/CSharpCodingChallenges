using System;
using System.IO;

namespace GetxFiles2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] GetFileName = Directory.GetFiles(@"D:\Mujeera Noor\Pythonworkspace");
            string[] GetAllFilesFromDir = Directory.GetFiles(@"C:\Users\mujeera.noor\source\repos", "*.*", SearchOption.AllDirectories);


            for (int i = 0; i < GetFileName.Length; i++)
            {
                string path = GetFileName[i];
                Console.WriteLine(System.IO.Path.GetFileName(path));
            }
            Console.WriteLine();

            for (int j = 0; j < GetAllFilesFromDir.Length; j++)
            {
                string pathDir = GetAllFilesFromDir[j];
                Console.WriteLine();
                Console.WriteLine(System.IO.Path.GetFileName(pathDir));
            }
            Console.ReadLine();
        }
    }
}
