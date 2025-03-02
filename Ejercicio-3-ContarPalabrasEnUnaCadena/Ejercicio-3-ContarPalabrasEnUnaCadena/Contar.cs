using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_ContarPalabrasEnUnaCadena
{
    internal class Contar
    {
        public static int ContarPalabras(string texto) // se crea el metodo para contar palabras de un texto
        {
            bool esPalabra = false; // se declara una variable del tipo booleano el cual usaremos para validar que estamos dentro de una palabra
            // y esta cambiara si valor de true a false o viceversa si estamos en una palabra o en un espacio

            int longitud = texto.Length; // para contar la cantidad de caracteres que tiene el texto
            int contador = 0; // este contador nos servira cuando el booleano sea true, ya que recien contara cuando el booleano tenga ese valor 

            for (int i = 0; i < longitud; i++) // use el for para recorrer todo el texto
            {
                if (texto[i] != ' ') // Si no es un espacio, estamos dentro de una palabra / use este condicional para saber si estamos en una palabra y no en un espacio en blanco 
                {
                    if (!esPalabra) // Si veníamos de un espacio, es una nueva palabra / esta condicional nos ayudara a reafirmar que estamos en una palabra 
                    {
                        contador++; 
                        esPalabra = true; // Ahora estamos dentro de una palabra
                    }
                }
                else
                {
                    esPalabra = false; // Si es un espacio, ya no estamos en una palabra
                }
            }

            return contador;
        }
    }
}
