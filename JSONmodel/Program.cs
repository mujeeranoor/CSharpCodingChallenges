using System;
using System.IO;
using System.Text.Json;

namespace JSONmodel
{
    public class PersonInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string DOB { get; set; } 
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string fileHandle = @"C:\Users\mujeera.noor\source\repos\info.json";
            string jsonString = File.ReadAllText(fileHandle);
            PersonInfo personINFO = JsonSerializer.Deserialize<PersonInfo>(jsonString);

            Console.WriteLine($"Name: {personINFO.Name}");
            Console.WriteLine($"Age: {personINFO.Age}");
            Console.WriteLine($"DOB: {personINFO.DOB}");
            Console.ReadLine();
        }
    }
}
