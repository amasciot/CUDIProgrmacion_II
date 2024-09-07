using System;
using System.Globalization;


internal class Program
{
    // se realizan dos funciones una que transforma la temepratura ingresada de Celsius a Fahrenheit y su homonina en Fahreheith a Celsius.
    private static double Celsius(double temperaturaFahrenheit)
    {
        double tempCelsius = (((temperaturaFahrenheit - 32) * 5) / 9);
        return tempCelsius;

    }
    private static double Fahrenheit(double temperaturaCelsius)
    {
        double tempFahrenheit = (((temperaturaCelsius * 9) / 5) + 32);
        return tempFahrenheit;
    }

    // En el main se realizan ambois calculos utilizando las funciones previamente creadas, 
    // se realiza una muestra del ambas conversiones entre tempraturas en dos tablas consecutivas
    private static void Main(string[] args)
    {
        
        Console.WriteLine($"Fahrenheit  a  Celsius\n");
        for (int i = 0; i < 101; i++) {
           Console.WriteLine($"{Fahrenheit(i)} | {Math.Round(Celsius(Fahrenheit(i)))}");
           
        }
        Console.WriteLine($"Celsius  a  Fahrenheit\n");
        for (int i = 32; i < 213; i++)
        {
            Console.WriteLine($"{Celsius(i)} | {Math.Round(Fahrenheit(Celsius(i)))}");
        }
        

    }
}
    
