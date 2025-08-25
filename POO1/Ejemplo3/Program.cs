using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre ="Karen";
            // nombre=Console.ReadLine(); //.Readline() devuelve tipo string
            nombre = "hola como estas?" + nombre;

            int cant = nombre.Length;
           // nombre.ToUpper();//convierte a mayuscula
           // nombre=nombre.ToUpper();
            nombre = nombre.Replace('a', 'e'); //cambia los caracteres o cadena
            Console.WriteLine(nombre);
            Console.ReadKey();
        }
    }
}
