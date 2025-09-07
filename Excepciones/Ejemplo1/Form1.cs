using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado;

            try
            {
                resultado = calcular();//llamado a la funcion
                lblResultado.Text = "=" + resultado;
                
            }
            catch (Exception ex) //tantos cath como execepciones quiera
            {
                MessageBox.Show("Error al ejecutar.. Contacte al dev");
            }
            finally //lo que  quiero que si o si se ejecute indefente al resto 
            {
                //instrucciones 
                //operacion sensible ...


            }
        }


        private int calcular() //puede devolver resultado o lanzar excepcion
        {
            int a, b, r;
            try
            {
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);
                r = a / b;

                return r;
            }
            catch (Exception ex)
            {
                //guardar registro de error en archivo
                throw ex;
            }
        }



        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
