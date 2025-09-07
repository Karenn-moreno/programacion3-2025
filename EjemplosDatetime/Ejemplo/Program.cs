using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;

            //fecha.Year asi para los diferentes datos trabajar por separado..
            Console.Write("La fecha es :"+ fecha.ToString("dd/MM/yy"));
            Console.ReadKey();
        }
    }
}
     