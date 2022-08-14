using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio1_Parqueo
{
    internal class Cerebro_Programa
    {
        //Variables globales que se usan en las diferentes clases
        public int hora_actual;
        public double tarifa;
        public int disponibles;
        public double ganancias;
        public int opcion_menu;
        public int horas_parking;
        public bool bandera = true;
        public bool apoyo=true;
        public int hora_ingreso;
        public Dictionary<string, int> D_ingresos = new Dictionary<string, int>();
        public Dictionary<string, double> D_ganancias = new Dictionary<string, double>();

        //La función permite el ingreso de los datos principales, que son la hora y la tarifa del parking
        public void Ingreso_Datos()
        {
            Console.WriteLine("Ingresa la hora actual (Formato 24 horas)");
            hora_actual = int.Parse(Console.ReadLine());
            Horario();

            Console.WriteLine("Ingresa la tarifa actual");
            tarifa = double.Parse(Console.ReadLine());

            disponibles = 40;
            Mostrar_Datos_Iniciales();
        }

        //La función permite mostrar en la parte superior los datos como la hora, la tarifa y los espacios disponibles
        public void Mostrar_Datos_Iniciales()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("La hora es: {0}:00  |  La tarifa es: Q{1}  |  Espacios disponibles: {2}\n", hora_actual,tarifa,disponibles);
            Console.ForegroundColor = ConsoleColor.White;
            apoyo = true;
        }

        //La función permite analizar al momento de aumentar una hora en el horario, que está no se pase del mismo
        public void Horario()
        {
            Console.Clear();
            if (hora_actual < 6 || hora_actual > 21)
            {
                hora_actual = 21;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nuestro horario es de 6:00-21:00 horas");
                Console.WriteLine("Presiona enter para regresar al menú");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                Mostrar_Datos_Iniciales();
            }
            else
            {
                Mostrar_Datos_Iniciales();
            }
        }
    }
}
