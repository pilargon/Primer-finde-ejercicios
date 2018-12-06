using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrar en pantalla las diferentes opciones ("1- Pedir menú", "2- Pedir hamburguesa", 
            //“3- Pedir bebida”, “4- Salir”) Que el usuario elija una opción y mostrar en pantalla la 
            //opción que ha elegido (o que la opción elegida no existe) y acabar el programa.

            string [] opcion = { "1- Pedir menú", "2- Pedir hamburguesa", "3- Pedir bebida", "4- Salir" } ;
            int respuesta;

            Console.WriteLine(" Hola,Bienvenido a Bootmdonals!" +
                "\n Elija una opcion: \n 1 " +
                "- Pedir menú \n 2 - Pedir hamburguesa \n 3 - Pedir bebida \n 4 - Salir");
            
            respuesta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ha elegido la opcion: " + opcion[respuesta-1]);
            Console.ReadLine();
            




























        }

    }
}
