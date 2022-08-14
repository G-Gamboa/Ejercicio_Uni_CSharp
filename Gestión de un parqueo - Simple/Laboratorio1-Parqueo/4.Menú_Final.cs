using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio1_Parqueo
{
    internal class Menú_Final:Entrada_Salida_Carros
    {
        //La función muestra el menú en pantalla con las diferentes opciones por seleccionar
        public void Impresion_Menu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----Selecciona la acción que deseas realizar----");
            Console.WriteLine("[1] Ingresar un vehículo");
            Console.WriteLine("[2] Retirar un vehículo");
            Console.WriteLine("[3] Mostrar un informe de las ganancias obtenidas hasta el momento");
            Console.WriteLine("[4] Avanzar una hora del reloj");
            Console.WriteLine("[5] Cambiar la tarifa del parking");
            Console.WriteLine("[6] Salir del programa");
            opcion_menu = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Eleccion_Correcta();
        }

        //La función sirve para organizar la opción ingresada anteriormente y llamar a las diferentes funciones 
        //según corresponda
        private void Eleccion_Correcta()
        {
            Console.Clear();
            if (opcion_menu==0||opcion_menu > 7)
            {
                Console.WriteLine("Por Favor Seleccione la opción correcta");
                Impresion_Menu();
            }

            switch (opcion_menu)
            {
                case 1: 
                    Ingresa_Carro();
                    break;

                case 2:
                    Salida_Carro();
                    break;

                case 3:
                    Mostrar_Ganancias();
                    break;

                case 4:
                    Avanzar_Hora_Reloj();
                    break;

                case 5:
                    Cambiar_Tarifa();
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Saliendo...");
                    bandera = false;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

        }
    }
}
