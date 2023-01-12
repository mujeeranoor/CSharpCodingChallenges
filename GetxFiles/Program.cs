using System;
using System.IO;

namespace GetxFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] GetFileName = Directory.GetFiles(@"D:\Mujeera Noor\Pythonworkspace");
            for (int i = 0; i < GetFileName.Length; i++)
            {
                string path = GetFileName[i];
                Console.WriteLine(System.IO.Path.GetFileName(path));
            }
            Console.ReadLine();
        }
    }
}
