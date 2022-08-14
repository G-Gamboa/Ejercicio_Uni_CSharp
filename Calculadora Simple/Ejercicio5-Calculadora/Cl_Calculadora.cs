using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5_Calculadora
{
    internal class Cl_Calculadora
    {
        /// <summary>
        /// Funcion SUMA Enteros
        /// </summary>
        /// <param name="Valor_1"> Valor 1 Entero </param>
        /// <param name="Valor_2"> Valor 2 Entero </param>
        /// <returns></returns>
        public int Suma(int Valor_1, int Valor_2)
        {
            int Respuesta = 0;
            Respuesta = Valor_1 + Valor_2;
            return Respuesta;
        }
        /// <summary>
        /// Funcion Suma Doubles
        /// </summary>
        /// <param name="Valor_1"> Valor 1 Double </param>
        /// <param name="Valor_2"> Valor 2 Double </param>
        /// <returns></returns>
        public double Suma(double Valor_1, double Valor_2)
        {
            double Respuesta = 0;
            Respuesta = Valor_1 + Valor_2;
            return Respuesta;
        }
        /// <summary>
        /// Funcion Suma Double Tres Parametros UPANA
        /// </summary>
        /// <param name="Valor_1">Valor 1 Double</param>
        /// <param name="Valor_2">Valor 2 Double</param>
        /// <param name="Valor_3">Valor 3 Double</param>
        /// <returns></returns>
        public double Suma(double Valor_1, double Valor_2, double Valor_3)
        {
            double Respuesta = 0;
            Respuesta = Valor_1 + Valor_2 + Valor_3;
            return Respuesta;
        }

    }
}
