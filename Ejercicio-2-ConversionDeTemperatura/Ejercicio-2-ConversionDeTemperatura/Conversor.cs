using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_ConversionDeTemperatura
{
    internal class Conversor
    {
        public static double ConvertirFahrenheit(double celsius) // se crep este metodo para poder calcular la conversion del tipo de temperatura celsius a fahrenhiet
        {
            return (celsius * 9 / 5) + 32; // se usa una formula de conversion y este resultado se retorna al main
        }
    }
}
