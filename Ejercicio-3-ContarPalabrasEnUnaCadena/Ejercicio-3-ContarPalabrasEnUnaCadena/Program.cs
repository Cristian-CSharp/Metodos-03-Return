using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_ContarPalabrasEnUnaCadena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un texto: ");
            string texto = Console.ReadLine().Trim();

            Console.WriteLine($"La cantidad de palabras que tiene el texto es {Contar.ContarPalabras(texto)}");
        }
    }
}
