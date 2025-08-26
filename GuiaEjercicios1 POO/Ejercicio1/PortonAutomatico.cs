using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class PortonAutomatico
    {
        // Constructor vacío: inicia cerrado
        public PortonAutomatico()
        {
            Apertura = 0;
        }

        // Constructor con apertura inicial (validación incluida)
        public PortonAutomatico(int aperturaInicial)
        {
            Apertura = aperturaInicial;
        }

        private int apertura;
        public int Apertura
        {
            get { return apertura; }
            set
            {
                if (value < 0) apertura = 0;
                else if (value > 100) apertura = 100;
                else apertura = value;
            }
        }
        // Propiedades derivadas - su valor depende de apertura, no tiene set 
        public bool EstaCerrado
        {
            get { return Apertura == 0; }
        }
        public bool EstaAbiertoCompleto
        {
            get { return Apertura == 100; }
        }

        //PARTE (A) METODOS

        public void Abrir()
        {
            if (Apertura == 100)
                Console.WriteLine("Ya está abierto al 100%");
            else
                Apertura = 100;
        }

        public void Cerrar()
        {
            if (Apertura == 0)
                Console.WriteLine("Ya está completamente cerrado");
            else
                Apertura = 0;
        }

        public void MostrarEstado()
        {
            if (EstaCerrado)
                Console.WriteLine("Cerrado");
            else if (EstaAbiertoCompleto)
                Console.WriteLine("Abierto total (100%)");
            else
                Console.WriteLine($"Abierto parcial ({Apertura}%)");
        }

        //PARTE B 
        public void Abrir(int porcentaje)
        {
            if (porcentaje < 1 || porcentaje > 99)
                Console.WriteLine("Porcentaje inválido (1–99)");
            else
                Apertura = porcentaje;
        }

        public void AbrirPeatonal()
        {
            Apertura = 20;
        }


        // --- PARTE C ---
        public void Stop()
        {
            Console.WriteLine("Movimiento detenido");
        }

        public bool Toggle()
        {
            if (EstaCerrado)
            {
                Apertura = 100;
                return true;
            }
            else
            {
                Apertura = 0;
                return false;
            }
        }



    }
}

