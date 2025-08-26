using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehiculo >Auto >Autodeportivo >AutoUrbano
            //Camioneta
            //Moto
            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();


            Vehiculo v2 = new Camioneta(); //si porque una camioneta es un vehiculo
            //Camioneta c2 = new Vehiculo();// no se puede ya que un vehiculo puedo o no ser una camioneta
            Camioneta c3 = new Camioneta();
            c1.Color = "Rojo";
            c2.Color = "Amarillo";
            c3.Color = "Blanco";


            List<Camioneta> listaCamionetas =new List<Camioneta>();//Existe la lista de camioneta ----tengo una variable del tipo lista de Camioneta
            listaCamionetas.Add(c1);
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);

            /*
            Console.WriteLine("La cantidad de camionestas es:" + listaCamionetas.Count);
            //listaCamionetas[1].Color = "Negra";
            c2.Color = "Verde";
            Console.WriteLine("El color es:" + listaCamionetas[1].Color);
            listaCamionetas.Remove(c3);
            Console.WriteLine("La cantidad de camionestas es:" + listaCamionetas.Count);
            */

            foreach (Camioneta item in listaCamionetas)
            {
                Console.WriteLine("El color de la camioneta es:" + item.Color);
            }

            Console.ReadKey();
        }
    }
}
