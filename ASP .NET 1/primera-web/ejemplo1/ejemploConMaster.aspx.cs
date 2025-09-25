using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejemplo1
{
    public partial class ejemploConMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BtnAceptar_Click(object sender, EventArgs e) 
        {
            string nombre= txtNombre.Text;
            LblSaludo.Text = "hola" + nombre;
            Response.Redirect("ejemploASPX.aspx", false); //objeto.redirecciono - navegar a otra pantalla ,False (para no cancelar el flujo de redireccion)
        }
    }
}