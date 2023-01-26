using System;
using System.Text.Json;
using System.IO;

namespace JSONtoObject
{
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\mujeera.noor\source\repos\JSONtoObject\weatherForecast.json";
            string jsonString = File.ReadAllText(fileName);
            WeatherForecast weatherforecast = JsonSerializer.Deserialize<WeatherForecast>(jsonString);

            Console.WriteLine($"Date: {weatherforecast.Date}");
            Console.WriteLine($"TemperatureCelsius: {weatherforecast.TemperatureCelsius}");
            Console.WriteLine($"Summary: {weatherforecast.Summary}");
            Console.ReadLine();
        }
    }
}
