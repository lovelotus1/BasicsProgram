//C# program to convert a Celsius temperature into Fahrenheit.

using System;

class Program
{
    static double convertToFahrenheit(double celTemp)
    {
        double fTemp = 0;

        fTemp = (celTemp * 9) / 5 + 32;

        return fTemp;
    }
    static void Main(string[] args)
    {
        double celTemp = 0;
        double ferTemp = 0;

        Console.Write("Enter the value of temperature in Celsius(°C): ");
        celTemp = double.Parse(Console.ReadLine());

        ferTemp = convertToFahrenheit(celTemp);
        Console.WriteLine("Fahrenheit temperature is(°F) : " + ferTemp);
    }
}
