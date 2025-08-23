using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Articulo
    {
        //-Codigo de Articulo(3 digitos con correlativos)
        //-Precio
        //-Codigo de Marca(1-10)

        //private int codArticulo;
        public int CodigoArticulo { get; set; } //prop tab tab  (se crea la propiedad y atributo temporal) FORMA CORTA

        //private float precio;
        public float Precio { get; set; }

        private int codMarca;
        public int CodigoMarca //propiedad FORMA LARGA manipulo el atributo
        {
            get { return codMarca; }
            set //pseudomedtodo
            {
                if(value>0 && value <11)
                    codMarca=value;
                else 
                    codMarca=1;
            }
    }
}
