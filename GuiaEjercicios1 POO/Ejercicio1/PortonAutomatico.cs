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

    }

   
}
