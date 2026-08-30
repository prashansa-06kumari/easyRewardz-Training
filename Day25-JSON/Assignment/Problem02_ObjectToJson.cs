using System;
using Newtonsoft.Json;

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class Problem02_ObjectToJson
{
    public static void Run()
    {
        Car car = new Car
        {
            Brand = "Toyota",
            Model = "Camry",
            Year = 2025
        };

        string json = JsonConvert.SerializeObject(
            car,
            Formatting.Indented
        );

        Console.WriteLine(json);
    }
}