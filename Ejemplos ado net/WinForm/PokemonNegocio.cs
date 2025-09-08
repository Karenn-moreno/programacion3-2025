using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WinForm
{
    internal class PokemonNegocio // metodos que me permiten el acceso a los datos 
    {
        public List<Pokemon> listar()
        {
        List<Pokemon> lista = new List<Pokemon>();
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;

        try 
	{	        
           conexion.ConnectionString= "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=false; user=sa;password=eddie;";
           comando.CommandType= System.Data.CommandType.Text;
           comando.CommandText = "select Numero,Nombre,Descripcion from POKEMONS";
           comando.Connection = conexion;

                conexion.Open();
                lector= comando.ExecuteReader();

                while (lector.Read()) //si pudo leer el registro apunta al primer registro
                { 
                   Pokemon aux= new Pokemon();
                    aux.Numero = lector.GetInt32(0); //le agrego el valor del indice virtual
                    aux.Nombre = (string)lector["Nombre"];//aclaro que es string
                    aux.Descripcion = (string)lector["Descripcion"];

                    lista.Add(aux);
                
                }

                conexion.Close();

        return lista;
	}
	catch (Exception ex)
	{

		throw ex;
	}


         }

    }
}
