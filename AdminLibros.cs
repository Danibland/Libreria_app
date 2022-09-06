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
    public partial class AdminLibros : Form
    {
        Conexionbd bd = new Conexionbd();

        public AdminLibros()
        {
            InitializeComponent();
        }

        public void CargarLibros()
        {
            bd.abrir();
            string query = "SELECT * FROM LIBRO";

            SqlCommand comando = new SqlCommand(query, bd.conexion);

            SqlDataReader datos = comando.ExecuteReader();

            try
            {

                if (datos.HasRows)
                {
                    Lvlibros.Items.Clear();
                    while (datos.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item = Lvlibros.Items.Add(datos.GetInt32(0).ToString());
                        item.SubItems.Add(datos.GetString(1));
                        item.SubItems.Add(datos.GetString(2));
                        item.SubItems.Add(datos.GetString(3));
                        item.SubItems.Add(datos.GetInt32(4).ToString());
                        item.SubItems.Add(datos.GetInt32(5).ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos :(");
                    Lvlibros.Items.Clear();
                }
                bd.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminLibros_Load(object sender, EventArgs e)
        {
            CargarLibros();
        }

        private void Lvlibros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Crear_libro Crear = new Crear_libro();
            Crear.ShowDialog();
            CargarLibros();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txtid.Text))
            {
                MessageBox.Show("Para actualizar debe seleccionar una fila.");
            }
            else
            {
                string query = "UPDATE LIBRO SET NOMBRE='"+Txtnombre.Text+"', AUTOR='"+Txtautor.Text+"', GENERO='"+Txtgenero.Text+"', VALOR='"+Txtvalor.Text+"', CANTIDAD='"+Txtcantidad.Text+"' WHERE ID_LIBRO='"+Txtid.Text+"'";

                SqlCommand comando = new SqlCommand(query, bd.conexion);

                try
                {
                    bd.abrir();
                    SqlDataReader datos = comando.ExecuteReader();
                    bd.cerrar();
                    MessageBox.Show("Registro actualizado");
                    CargarLibros();
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
            Txtautor.Clear();
            Txtgenero.Clear();
            Txtvalor.Clear();
            Txtcantidad.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txtid.Text))
            {
                MessageBox.Show("Para eliminar debe seleccionar una fila.");
            }
            else
            {
                var result = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM LIBRO WHERE ID_LIBRO='" + Txtid.Text + "'";

                    SqlCommand comando = new SqlCommand(query, bd.conexion);

                    try
                    {
                        bd.abrir();
                        SqlDataReader datos = comando.ExecuteReader();
                        bd.cerrar();
                        CargarLibros();
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Lvlibros_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Txtid.Text = e.Item.SubItems[0].Text;
            Txtnombre.Text = e.Item.SubItems[1].Text;
            Txtautor.Text = e.Item.SubItems[2].Text;
            Txtgenero.Text = e.Item.SubItems[3].Text;
            Txtvalor.Text = e.Item.SubItems[4].Text;
            Txtcantidad.Text = e.Item.SubItems[5].Text;
        }

        private void SeleccionarBusqueda(int item)
        {
            foreach (ListViewItem lvw in Lvlibros.Items)
            {
                lvw.Selected = false;
            }

            Lvlibros.Items[item].Selected = true;
            Lvlibros.Items[item].Focused = true;
            Lvlibros.Select();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txtbuscar.Text))
            {
                for (int i = 0; i <= Lvlibros.Items.Count -1; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item = Lvlibros.Items[i];
                    var id = item.SubItems[0].Text;
                    var nombre = item.SubItems[1].Text;
                    var autor = item.SubItems[2].Text;
                    var genero = item.SubItems[3].Text;
                    var valor = item.SubItems[4].Text;

                    if (id == Txtbuscar.Text)
                    {
                        SeleccionarBusqueda(i);
                    }
                    else if (nombre == Txtbuscar.Text)
                    {
                        SeleccionarBusqueda(i);
                    }
                    else if (autor == Txtbuscar.Text)
                    {
                        SeleccionarBusqueda(i);
                    }
                    else if (genero == Txtbuscar.Text)
                    {
                        SeleccionarBusqueda(i);
                    }
                    else if (valor == Txtbuscar.Text)
                    {
                        SeleccionarBusqueda(i);
                    }
                }
            }
        }
    }
    
}
