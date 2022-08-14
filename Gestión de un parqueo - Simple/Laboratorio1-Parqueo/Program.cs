using System;

namespace Laboratorio1_Parqueo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menú_Final cliente = new Menú_Final();
            //Se solicita el ingreso de los principales datos
            cliente.Ingreso_Datos();

            while (cliente.bandera) 
            {
                //El menú se muestra en pantalla repetidas veces hasta que el usuario 
                //decida salir del mismo
                cliente.Impresion_Menu();
            }
        }
    }
}

//Programa elaborado por Guillermo Gamboa
