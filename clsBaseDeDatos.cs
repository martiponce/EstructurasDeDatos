using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryPonceDeLeonMartinaEstrucDatos
{
    internal class clsBaseDeDatos
    {
        private OleDbConnection conexion = new OleDbConnection(); //hago la conexion con la base
        private OleDbCommand comando = new OleDbCommand(); //es la "orden" a la base de dtos
        private OleDbDataAdapter adaptador = new OleDbDataAdapter(); //adaptamos la orden

        //Cadena de conexion
       //cadena vieja:
       private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";

        //cadena nueva
       // private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";
        public void Listar (DataGridView Grilla)
        {
            try
            {
                //conexion
                conexion.ConnectionString = CadenaConexion;//base que conecti
                conexion.Open (); //Abro

                //comandos
                comando.Connection = conexion; //ordeno que se conecte
                comando.CommandType = CommandType.TableDirect; //traemos una tabla
                comando.CommandText = "Autor"; // vamos a trabajar con esta tabla "autor"

                //adaptadores
                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando); //adapto el comando al lenguaje
                adaptador.Fill(DS, "Autor"); //lleno el adaptador con la info obtenida

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Autor"]; //


                conexion.Close(); //cierro

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                conexion.Close();
            }
        }

        //Sobrecarga
        public void Listar(DataGridView Grilla, String sql)
        {
            //sql es una consulta puede ser tipo: "SELECT * FROM Libro"
            try
            {
                //conexion
                conexion.ConnectionString = CadenaConexion;//base que conecti
                conexion.Open(); //Abro

                //comandos
                comando.Connection = conexion; //ordeno que se conecte
                comando.CommandType = CommandType.Text; //traemos una tabla mediante el sql
                comando.CommandText = sql; // vamos a trabajar con la query 

                //adaptadores
                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando); //adapto el comando al lenguaje
                adaptador.Fill(DS, "ResultadoConsulta"); //lleno el adaptador con la info obtenida

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["ResultadoConsulta"]; //


                conexion.Close(); //cierro

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                conexion.Close();
            }
        }
    }
}
