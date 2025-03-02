using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_ValidacionDeNumerosPrimos
{
    internal class Primo
    {
        public static bool EsPrimo(int numero) // creamos el metodo EsPrimo para validar si el numero ingresado por el usuario es primo o no
        {
            int contador = 0; // se crea e inicializa una variable del tipo entero que nos servira como contador en cada vuelta del for
            for (int i = 1; i <= numero; i++)  // se usa un for para poder recorrer los numeros desde el 1 hasta el numero mismo ingresado por el usuario
            {
                if (numero % i == 0) // se usa una condicional para evaluar si el numero ingresado da como residuo un cero
                {
                    contador +=1; // si en caso es divisible entre cero pues vamos a contar cuantas veces es divisible 
                }
            }
            if (contador == 2) // luego de terminada todas las vueltas del for vamos a ver cuantas divisores tiene el numero ingresado por el usuario
                //  si el numero de divisores es igual a dos significa que es un numero primo ya que el numero prime tiene dos divisores, el 1 y si mismo
            {
                return true; // si en caso es asi me retorna un true lo que significa que realmente es un numero primo
            }
            else
            {
                return false; // si en caso el numero de divisores es distinto a 2 osea mayor a dos pues significa que no es primo y por ende retorno un false
            }
        }
    }
}
