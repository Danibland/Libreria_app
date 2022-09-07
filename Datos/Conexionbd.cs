using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LIBRERIA
{
    internal class Conexionbd
    {

        // Cadena de conexíon
        string cadena = "Data Source=LAPTOP-37TFBLUS\\SQLEXPRESS;Initial Catalog=LIBRERIA_APP;Persist Security Info=True;User ID=sa;Password=sa123456";

        public SqlConnection conexion = new SqlConnection();

        public Conexionbd()
        {
            //Asignar la cadena de conexíon a una variable.
            conexion.ConnectionString = cadena;
        }

        //Metodo abrir conexíon.
        public void abrir()
        {
            // Esta valida si se hace la conexion a la base de datos 
            // y saca por una ventana de texto si esta conectada o no.
            try
            {
                conexion.Open();
                //MessageBox.Show("Conectado correctamente");

            }
            catch (Exception ex)
            {

                MessageBox.Show("No fue posible la conexíon" + ex.Message);
            }
        }
        //cierra la conexion a la base de datos.
        public void cerrar()
        {
            conexion.Close();
        }
    }
}

    

