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
    public partial class AdminUsuarios : Form
    {
        Conexionbd bd = new Conexionbd();
        public AdminUsuarios()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Leer()
        {
            bd.abrir();
            string query = "SELECT ID_USUARIO, NOMBRE_COMPLETO, USUARIO, DESCRIPCION FROM USUARIO INNER JOIN ROL ON USUARIO.ID_ROL = ROL.ID_ROL";

            SqlCommand comando = new SqlCommand(query, bd.conexion);

            SqlDataReader datos = comando.ExecuteReader();

            try
            {

                if (datos.HasRows)
                {
                    Lvwusuarios.Items.Clear();
                    while (datos.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item = Lvwusuarios.Items.Add(datos.GetInt32(0).ToString());
                        item.SubItems.Add(datos.GetString(1));
                        item.SubItems.Add(datos.GetString(2));
                        item.SubItems.Add(datos.GetString(3));
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos :(");
                    Lvwusuarios.Items.Clear();
                }
                bd.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminUsuarios_Load(object sender, EventArgs e)
        {
            Leer();
        }

        private void Lvwusuarios_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Txtid.Text = e.Item.SubItems[0].Text;
            Txtnombre.Text = e.Item.SubItems[1].Text;
            Txtusuario.Text = e.Item.SubItems[2].Text;
        }

        private void Lbnombre_Click(object sender, EventArgs e)
        {

        }

        private void Btneditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txtid.Text))
            {
                MessageBox.Show("Para actualizar debe seleccionar un usuario.");
            }
            else
            {
                string query = "UPDATE USUARIO SET NOMBRE_COMPLETO='" + Txtnombre.Text + "', USUARIO='" + Txtusuario.Text + "' WHERE ID_USUARIO='" + Txtid.Text + "'";

                SqlCommand comando = new SqlCommand(query, bd.conexion);

                try
                {
                    bd.abrir();
                    SqlDataReader datos = comando.ExecuteReader();
                    bd.cerrar();
                    MessageBox.Show("Registro actualizado");
                    Leer();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void limpiar()
        {
            Txtid.Clear();
            Txtnombre.Clear();
            Txtusuario.Clear();
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txtid.Text))
            {
                MessageBox.Show("Para eliminar debe seleccionar un usuario.");
            }
            else
            {
                var result = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM USUARIO WHERE ID_USUARIO='" + Txtid.Text + "'";

                    SqlCommand comando = new SqlCommand(query, bd.conexion);

                    try
                    {
                        bd.abrir();
                        SqlDataReader datos = comando.ExecuteReader();
                        bd.cerrar();
                        Leer();
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Btncrear_Click(object sender, EventArgs e)
        {
            Crear_usuario Crear = new Crear_usuario();
            Crear.ShowDialog();
            Leer();
        }
    }
}
