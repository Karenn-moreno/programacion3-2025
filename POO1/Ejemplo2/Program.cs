using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Primer lote con 10 registros de productos, cada producto tiene:
              -Codigo de Articulo (3 digitos con correlativos)
              -Precio
              -Codigo de Marca (1-10)
            Segundo lote con las ventas de la semana. Cada venta tine:
              -Codigo de articulo
              -Cantidad
              -Codigo Cliente (1 a 100)
            Este lote corta con Codigo de Cliente cero*/

            Articulo[] articulos = new Articulo[10];//creo mi vector de 10 art
            articulos[6].CodigoMarca = 3; //atributo cargado

            for (int i = 0; i < 10; i++)
            {

                articulos[i] = new Articulo();
                Console.WriteLine("Ingrese los datos del producto");
                Console.WriteLine("Codigo");
                articulos[i].CodigoArticulo=int.Parse(Console.ReadLine());
                Console.WriteLine("Precio");
                articulos[i].Precio=float.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 a 10)");
                articulos[i].CodigoMarca=int.Parse(Console.ReadLine());
            }
            //cargado el vector completo con los 10 articulos

            Venta venta = new Venta();
            Console.WriteLine("Ingrese la venta");
            Console.WriteLine("Ingrese codigo de cliente");
            venta.CodClientes=int.Parse(Console.ReadLine());

            

            while (venta.CodClientes !=0)
            { 
                Console.WriteLine("Codigo de articulo");
                venta.CodArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad");
                venta.Cantidad = int.Parse(Console.ReadLine());

                //trabajo..
                //Pido cliente nuevamente

                Console.WriteLine("Ingrese la venta");
                Console.WriteLine("Ingrese codigo de cliente");
                venta.CodClientes = int.Parse(Console.ReadLine());

            }

        }
    }
}
