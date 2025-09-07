using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {
            //capturar el valor 
            DateTime fecha1;

            fecha1 = dtpFecha.Value; //le asigno a la variable un valor tipo fecha

            //trabajo con la variable
            MessageBox.Show("La fecha seleccionada es : " + fecha1.ToString("dd/MM/yy"));
        }

        private void btnPrueba2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fecha seleccionada es : " + calFecha.SelectionStart.ToString("dd/MM/yy"));
        }
    }
}
