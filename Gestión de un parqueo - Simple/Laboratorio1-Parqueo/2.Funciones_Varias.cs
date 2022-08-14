using System;

namespace Laboratorio1_Parqueo
{
    internal class Funciones_Varias : Cerebro_Programa
    {
        //La función muestra en pantalla un listado de los vehículos que se encuentran en el parqueo
        public void Impresion_diccionario_vehiculos()
        {
            foreach (var auto in D_ingresos)
            {
                Console.WriteLine("Placa #{0} \nHora de ingreso: {1}:00", auto.Key, auto.Value);
            }
        }

        //La función muestra en pantalla los números de placas, junto con las ganancias que dejó el vehículo
        private void Impresion_diccionario_ganancias()
        {
            foreach (var placas in D_ganancias)
            {
                Console.WriteLine("Placa #{0} --> Ganancia: Q{1}", placas.Key, placas.Value);
            }
        }

        //La función permite buscar la placa del vehículo, en el diccionario que almacena los vehículos dentro del parqueo
        public int Buscador(string x1)
        {
            int hr = 0;
            foreach (var placa_salida in D_ingresos)
            {
                if (x1 == placa_salida.Key)
                {
                   hr = placa_salida.Value;
                   horas_parking = hora_actual-hr;
                   D_ganancias.Add(x1,Ganancias(horas_parking));
                }
            }
            return horas_parking;
        }

        //La función permite calcular las ganancias obtenidas al momento de que un vehículo se retira del parqueo
        private double Ganancias(int x)
        {
            double gan = x*tarifa;
            ganancias += gan;
            return gan;
        }
        
        //La función permite analizar si la hora que se ingreso está dentro del horario de atención
        public void Revisar_Hora()
        {
            if (hora_ingreso <  hora_actual || hora_ingreso > 21)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡Hora Incorrecta!");
                Console.WriteLine("Ingresa una hora dentro del horario correcto");
                Console.ReadLine();
                apoyo = false;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        //La función muestra en pantalla las ganancias obtenidas a lo largo del día
        public void Mostrar_Ganancias()
        {
            Mostrar_Datos_Iniciales();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Impresion_diccionario_ganancias();
            Console.WriteLine("Total ganancias obtenidas durante el día: Q{0}",ganancias);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Presiona enter para regresar al menú");
            Console.ReadLine();
            Mostrar_Datos_Iniciales();

        }
        
        //La función permite avanzar una hora a la hora ingresa inicialmente
        public void Avanzar_Hora_Reloj()
        {
            hora_actual += 1;
            Horario();
        }

        //La función permite cambiar la tarifa ingresada inicialmente
        public void Cambiar_Tarifa()
        {
            Mostrar_Datos_Iniciales();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ingresa la nueva tarifa:");
            tarifa = int.Parse(Console.ReadLine());
            Mostrar_Datos_Iniciales();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
