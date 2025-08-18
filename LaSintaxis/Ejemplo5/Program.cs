using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FUNCIONES...
            //declaro fuera del main que es una funcion
            Console.WriteLine(saludar("karen"));
            Console.ReadKey();
        }

        static int sumar(int a, int b) { //por el momento con static class
        return a + b;
        }

        static string saludar (string nombre)
        {
            return "hola" + nombre;
        }
    }
}
