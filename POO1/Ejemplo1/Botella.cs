using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Botella
    {
        //Botella: Capacidad , color , Material
        private int capacidad;
        private string color;
        private string material;

        //PROPIEDAD -seudometodo
        public int Capacidad //reemplazo 
        {
            get { return capacidad; }
            set { capacidad = value; }
        }


    }
}
