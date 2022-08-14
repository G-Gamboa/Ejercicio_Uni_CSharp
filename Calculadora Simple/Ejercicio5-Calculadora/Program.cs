using System;

namespace Ejercicio5_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SobreCarga Metodos");
            int RespuestaEntero = 0;
            double RespuestaDouble = 0.0;
            Cl_Calculadora Calculos = new Cl_Calculadora();
            RespuestaEntero = Calculos.Suma(5, 3);
            Console.WriteLine("La Suma enteros es: {​0}​", RespuestaEntero);
            RespuestaDouble = Calculos.Suma(5.5, 12.5);
            Console.WriteLine("La Suma doubles es: {​0}​", RespuestaDouble);
            RespuestaDouble = Calculos.Suma(5.5, 12.5, 14.5);
            Console.WriteLine("La Suma doubles 3 parametros es: {​0}​", RespuestaDouble);
        }
    }
}
