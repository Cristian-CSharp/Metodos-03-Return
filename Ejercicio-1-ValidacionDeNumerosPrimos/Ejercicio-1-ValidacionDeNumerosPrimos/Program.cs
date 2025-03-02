using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_ValidacionDeNumerosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("---- VERIFICANDO SI ES NUMERO PRIMO O NO ----"); // el titulo
            Console.Write("Ingrese un numero entero: ");// se ordena que el usuario ingrese un numero

            
            while (!int.TryParse(Console.ReadLine(), out numero) || !(numero > 1)) // se valida que el valor ingresado sea un numero y que sea mayor a 1
            {
                Console.WriteLine("Valor invalido, debe ingresar un numero entero mayor a 0"); // si en caso no es un numero o no es mayor a 1 pues se manda un mensaje de error
                Console.Write("Ingrese de nuevo un numero valido: "); // y ademas se pide que ingrese otro numero y este ciclo no parara hasta que no ingrese un valor valido
            }

            Console.WriteLine(Primo.EsPrimo(numero)); // al finañ se llama al metodo para dar la respuesta de si es o no primo
        } 
    }
}
