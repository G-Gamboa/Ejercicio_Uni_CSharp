using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio1_Parqueo
{
    internal class Entrada_Salida_Carros :Funciones_Varias
    {
        //Variable a utilizar de manera interna
        string placa;

        //La función permite revisar si la placa ingresada ya se encuentra dentro del parqueo
        private void Placa_Repetida()
        {
            foreach(var pl in D_ingresos)
            {
                if (placa==pl.Key)
                {
                    Console.WriteLine("El vehículo ya se encuentra en el parqueo, favor ingresar nuevamente la placa");
                    placa=Console.ReadLine();
                }
            }
        }

        //La función permite el ingreso de un vehículo, se ingresa la placa y la hora de ingreso
        public void Ingresa_Carro()
        {
            Mostrar_Datos_Iniciales();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Placa del carro a ingresar: ");
            placa = Console.ReadLine();
            Placa_Repetida();

            Console.WriteLine("Hora de ingreso: ");
            hora_ingreso = int.Parse(Console.ReadLine());
            Revisar_Hora();
            D_ingresos.Add(placa,hora_ingreso);
            disponibles -= 1;

            if (apoyo==false)
            {
                D_ingresos.Remove(placa);
                disponibles += 1;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Mostrar_Datos_Iniciales();
        }

        //La función permite la salida de un vehículo, se ingresa la placa para buscar en el registro y se elimina
        public void Salida_Carro()
        {
            Mostrar_Datos_Iniciales();
            Impresion_diccionario_vehiculos();
            Console.WriteLine("Escribe la placa del vehículo que desea retirar:");
            placa= Console.ReadLine();
            Buscador(placa);
            D_ingresos.Remove(placa);
            disponibles += 1;
            Mostrar_Datos_Iniciales();

        }
    }
}
