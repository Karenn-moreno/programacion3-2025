using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Persona
    {
        // Persona: Edad , Sueldo , Nombre
        //ATRIBUTOS - MIEMBROS
        private int edad;
        private float sueldo;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad() {
          return edad;
        }

        //Metodos
        public string Saludar()
        {
            return "Hola soy .." + nombre;
        }

        //sobrecarga de metodos
        public string Saludar(string personaje)
        {
            return "Hola"+personaje+" , soy " +nombre;
        }
    }
}
