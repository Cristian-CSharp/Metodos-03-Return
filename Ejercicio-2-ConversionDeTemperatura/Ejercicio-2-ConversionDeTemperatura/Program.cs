using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_ConversionDeTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Conversor de Grados Celsius a Fahrenheit"); // titulo 
            double celsius; // se declaro la variable 
            Console.Write("Ingresa la temperatura en Celsius: "); // se pide al usuario que ingrese un valor numerico para la temperatura

            while (!double.TryParse(Console.ReadLine(), out celsius)) // se usa un bucle while para validar que el valor ingresado sea un numero
            {
                Console.WriteLine("¡¡¡Error, debe ingresar un valor numerico!!!"); // si en caso el valor ingresado no un numero, se manda un mensaje de error
                Console.Write("Ingrese nuevamente un temperatura en Celsius: "); // y ademas se pide que ingrese la temperatura del valor numerico otra vez
            }

            double Fahrenheit = Math.Round(Conversor.ConvertirFahrenheit(celsius),2); // se llama al metodo y se guarda el valor en una nueva variable en el main

            Console.WriteLine($"{celsius}ºC equivale a {Fahrenheit}ºF"); // y se imprime el resultado de la conversion 
            
        }
    }
}
