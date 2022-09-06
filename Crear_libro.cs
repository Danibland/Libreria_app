using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRERIA
{
    public partial class Crear_libro : Form
    {
        public Crear_libro()
        {
            InitializeComponent();
        }

        private void Crear_libro_Load(object sender, EventArgs e)
        {

        }

        private void Btnaceptar_Click(object sender, EventArgs e)
        {
            Conexionbd bd = new Conexionbd();
            
            string query = "INSERT INTO LIBRO (NOMBRE, AUTOR, GENERO,VALOR,CANTIDAD) VALUES ('" +Txtnombre.Text +"', '" +Txtautor.Text+ "', '" +Txtgenero.Text +"', '" +Txtvalor.Text +"','"+Txtcantidad.Text+"')";

            SqlCommand comando = new SqlCommand(query, bd.conexion);

            try
            {
                bd.abrir();
                SqlDataReader datos = comando.ExecuteReader();
                bd.cerrar();
                MessageBox.Show("Registro creado");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
