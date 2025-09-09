using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {

        private List<Pokemon> listaPokemon;//
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio= new PokemonNegocio();
            listaPokemon = negocio.listar();//
            dgvPokemons.DataSource = listaPokemon;//
            cargarImagen(listaPokemon[0].UrlImagen);
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
           Pokemon Seleccionado=(Pokemon) dgvPokemons.CurrentRow.DataBoundItem;//fila actual "pokemon"
            cargarImagen(Seleccionado.UrlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                picturePokemon.Load(imagen);
            }
            catch (Exception ex)
            {
                picturePokemon.Load("https://redthread.uoregon.edu/files/original/affd16fd5264cab9197da4cd1a996f820e601ee4.png");
   
            }
        }
    }
}
