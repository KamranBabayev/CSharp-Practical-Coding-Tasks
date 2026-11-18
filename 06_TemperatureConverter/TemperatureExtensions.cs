using System;
using System.Collections.Generic;
using System.Text;

namespace _06_TemperatureConverter
{
    internal static class TemperatureExtensions
    {

        public static  double ToFahrenheit(this double celsius)
        {
            return celsius * 1.8 + 32;
        }


        public static double ToCelsius(this double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }

    }
}
