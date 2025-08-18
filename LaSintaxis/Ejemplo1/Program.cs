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
        {   //VARIABLES
            //int float bool char
            //double decimal long short string datetime
            int a,b,c ;
            float d,f ;
            Console.WriteLine("Hola , todo bien?");
            Console.WriteLine("Ingrese un numero:");
            a = int.Parse(Console.ReadLine()); //Transformo lo que leo en consola y lo guardo en la variable
            b = 10;//literal constante
            c = a + b;

            Console.WriteLine("El resultado es:" +c);
            Console.ReadKey();
        }
    }
}
