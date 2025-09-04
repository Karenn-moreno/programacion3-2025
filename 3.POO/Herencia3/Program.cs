using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato g1 = new Gato();
            g1.Nombre = "Luna"; 
            Perro p1 = new Perro();
            p1.Nombre = "Eddie";

            Console.WriteLine(g1.comunicarse());
            Console.WriteLine(p1.comunicarse());
            Console.ReadKey();
        }
    }
}
