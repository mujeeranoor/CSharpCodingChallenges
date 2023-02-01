using System;
using System.Text.Json;

namespace JsonArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string array1 = @"[{""Name"" : ""Samuel"", ""Age"" : ""29"", ""designation"" : ""Team Lead""},
                                {""Name"" : ""Anna"", ""Age"" : ""33"", ""designation"" : ""Junior Developer(Team Member)""}]";

            using JsonDocument doc = JsonDocument.Parse(array1);
            JsonElement root = doc.RootElement;

            Console.WriteLine(root);

            var u1 = root[0];
            var u2 = root[1];
            Console.WriteLine(u1);
            Console.WriteLine(u2);

            Console.WriteLine(u1.GetProperty("Name"));
            Console.WriteLine(u1.GetProperty("Age"));
            Console.WriteLine(u1.GetProperty("designation"));

            Console.WriteLine(u2.GetProperty("Name"));
            Console.WriteLine(u2.GetProperty("Age"));
            Console.WriteLine(u2.GetProperty("designation"));
        }
    }
}
