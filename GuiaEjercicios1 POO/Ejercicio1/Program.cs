using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PortonAutomatico porton = new PortonAutomatico();

            // 1. Iniciar cerrado, Abrir() → 100 → “Abierto total (100%)”
            porton.MostrarEstado(); // Cerrado
            porton.Abrir();
            porton.MostrarEstado(); // Abierto total (100%)

            // 2. AbrirPeatonal() desde 100 → pasar a 20 y mostrar “Abierto parcial (20%)”
            porton.AbrirPeatonal();
            porton.MostrarEstado();

            // 3. Cerrar() → 0
            porton.Cerrar();
            porton.MostrarEstado();

            // 4. Abrir(105) → “Porcentaje inválido. Debe ser 1–99.”
            porton.Abrir(105);

            // 5. Simulación: Abrir(10) y avanzar hasta 50, detener en 50
            for (int i = 10; i <= 100; i += 10)
            {
                porton.Abrir(i);
                porton.MostrarEstado();

                if (porton.Apertura == 50)
                {
                    porton.Stop();
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
