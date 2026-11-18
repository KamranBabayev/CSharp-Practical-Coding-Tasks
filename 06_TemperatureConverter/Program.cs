

namespace _06_TemperatureConverter;

internal class Program
{
    static void Main(string[] args)
    {

        //Task 6.
        //Extension for double:
        //ToFahrenheit() - Celsius dəyərini Fahrenheit - ə çevirsin.Formul; F = C * 1.8 + 32
        //ToCelsius() - Fahrenheit dəyərini Celsius - a şevirsin.Formul: C = (F - 32) / 1.8
        //Main:
        //7 temperatur dəyərindən ibarət array yaradın.Hamısını çevirin və ekrana yazdırın.


        double []temperatures =new double[7];

        temperatures[0] = 25;
        temperatures[1] = 30;
        temperatures[2] = 15;
        temperatures[3] = 10;
        temperatures[4] = 0;
        temperatures[5] = 35;
        temperatures[6] = 20;

        foreach(double temperature in temperatures)
        {
            Console.WriteLine(temperature.ToFahrenheit());
        }
      
    }
}