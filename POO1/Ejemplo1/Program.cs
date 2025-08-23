using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejmeplo 1-------- Persona: Edad , Sueldo , Nombre
            /*int edad;
            float sueldo;
            string nombre;
            int[] edades = new int[10];
            float[] sueldos=new float[10];
            string[]nombres=new string[10];
            */
            Persona p1 = new Persona(); // instancio crea obj
            p1.setEdad(20);

            Console.WriteLine("La edad de la persona es:"+p1.getEdad());
           

            /*----------Ejemplo 2------------*/
            Botella b1=new Botella();//instancio obj
            b1.Capacidad = 200;
            int algo = b1.Capacidad;


            /*---------Ejemplo 3 ----------*/

            Perro Dg = new Perro();
            Dg.Nombre = "Eddie";
            Dg.Color = "Marrón";
            Dg.Origen = "Argentino";

            Console.WriteLine("Nombre del perro: " + Dg.Nombre);
            Console.WriteLine("Color: " + Dg.Color);
            Console.WriteLine("Origen: " + Dg.Origen);

            Console.ReadKey();


        }
    }
}
