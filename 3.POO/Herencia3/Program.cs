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

            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(new Pez());
            animales.Add(new Canario());
            animales.Add(g1);
            animales.Add(new Aguila());
            animales.Add(new Gato());

            //interfases
            List <Flyable> listaVoladores =new List<Flyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());

            //foreach (Animal item in animales) //recorrer la lista
            //{
            //    Console.WriteLine(item.comunicarse());
            //}


            /*POLIMORFISMO*/

            /* Animal a1 = g1;
             Gato g8=(Gato)a1; //  Casteo 
             g8.Nombre = "Morenita";
            */

            /*  Console.WriteLine(g8.Nombre);
              Console.WriteLine(p1.comunicarse());*/
            Console.ReadKey();
        }
    }
}
