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
    public partial class Crear_usuario : Form
    {
        public Crear_usuario()
        {
            InitializeComponent();
        }

        private void Btnaceptar_Click(object sender, EventArgs e)
        {
            Conexionbd bd = new Conexionbd();
            int idRol = 0;
            if (rbAdmin.Checked)
            {
                idRol = 1;
            }
            else if (rbVendedor.Checked)
            {
                idRol = 2;
            }

            if (idRol == 0)
            {
                MessageBox.Show("Debe seleccionar un rol");
            }
            else 
            {
                string query = "INSERT INTO USUARIO (NOMBRE_COMPLETO, USUARIO, CONTRASENA, ID_ROL) VALUES ('" + Txtnombre.Text + "', '" + Txtusuario.Text + "', '" + Txtcontrasena.Text + "', '" + idRol + "')";

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
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
