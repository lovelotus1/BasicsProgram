//C# program to convert a Fahrenheit temperature into Celsius.

using System;

class Program
{
    static double convertToCelsius(double ferTemp)
    {
        double cTemp = 0;

        cTemp = (ferTemp - 32) * 5 / 9;
        return cTemp;
    }
    static void Main(string[] args)
    {
        double celTemp = 0;
        double ferTemp = 0;

        Console.Write("Enter the value of temperature in Fahrenheite(°F): ");
        ferTemp = double.Parse(Console.ReadLine());

        celTemp = convertToCelsius(ferTemp);
        Console.WriteLine("Celsius temperature is(°C) : " + celTemp);
    }
}
