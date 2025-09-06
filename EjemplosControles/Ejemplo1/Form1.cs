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

        private void Form1_Load(object sender, EventArgs e)
        {
            cboFavorito.Items.Add("rojo");
            cboFavorito.Items.Add("verde");
            cboFavorito.Items.Add("azul");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem=txtNombre.Text;
            lwElementos.Items.Add(elem);    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cboFavorito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;

            // Operador ternario
            string chocolate = ckbChocolate.Checked == true ? "Le gusta el chocholate" : "Odia el chocolate";

            string tipo;

            if (rbtMuggle.Checked)
                tipo = "Muggle";
            else if (rbtWizard.Checked)
                tipo = "Wizard";
            else 
                tipo = "Squibs";


            string colorFavorito=cboFavorito.SelectedItem.ToString();
            string numeroFavorito= numNumeroFavorito.Value.ToString();

            MessageBox.Show("Nombre " + nombre + " Fecha " + fechaNacimiento + " Tipo " + tipo + " Color Favorito " + colorFavorito + " Numero Favorito " + numeroFavorito);

        }

        private void lblNumeroFavorito_Click(object sender, EventArgs e)
        {

        }
    }
}
