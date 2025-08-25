using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Botella
    {
        /*Capacidad maxima =100
         * Cantidad actual: inicia en cero
         * metodo recarga: carga al 100 y devuelve el costo de recargar , 50 cada 100 */


        //constructor creado que recibe parametro 
        public Botella(string color, string material)
        { 
         this.color = color;//this apuntador a la clase asigna el color por parametro
         this.material = material;
         capacidad = 100;
         cantidadActual =0;
        }

        //SOBRECARGAR EL CONSTRUCTOR
        public Botella() {//vacio distinta firmas 
        
        }

        ~Botella() { 
        //logica...
        }

        //Botella: Capacidad , color , Material
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        //PROPIEDADES
        /*public int Capacidad //reemplazo 
        {
            get { return capacidad; }
            set { capacidad = value; }
        }*/

        public int Capacidad
        {
            get { return capacidad; }
        }
        public int CantidadActual
        {
            get { return cantidadActual; }
        }
        //Metodo 
         public float recargar()
        {
            if (cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                //100 50
                //dif
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

        public float recargar(int cantidad )
        {
            cantidadActual = cantidad;
            return cantidad*50/100;
        }

    }
}
