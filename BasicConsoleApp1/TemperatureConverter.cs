using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApp1
{
    //12.Static & Instance Members
    public static class TemperatureConverter
    {
       public static int dayno = 1;
        public static int marks = 2;
        //sttaic class - static contructor
        static TemperatureConverter()
        {
            dayno = 5;
        }
        public static double CelsiusToFahrenheit(double celsius)
        {
           
            // Convert Celsius to Fahrenheit.
            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {

            // Convert Fahrenheit to Celsius.
            double celsius = (fahrenheit - 32) * 5 / 9;

            return celsius;
        }

    }
}
