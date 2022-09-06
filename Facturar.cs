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
    public partial class Facturar : Form
    {
        Conexionbd bd = new Conexionbd();
        int pos = 0;
        int pos2 = 0;
        double total = 0;

        public Facturar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Facturar_Load(object sender, EventArgs e)
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

        private void Lvlibros_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            pos = e.ItemIndex;
        }

        private void Btnenviar_Click(object sender, EventArgs e)
        {
            if (Lvlibros.SelectedItems.Count > 0)
            {
                Cantidad frm = new Cantidad();
                ListViewItem item = new ListViewItem();
                item = Lvlibros.Items[pos];
                frm.Lbllibro.Text = item.SubItems[1].Text;
                frm.ShowDialog();
                if (frm.Txtcantidad.Text != "")
                {
                    int cant = int.Parse(frm.Txtcantidad.Text);
                    int precio = int.Parse(item.SubItems[4].Text);
                    double subtotal = precio * cant;
                    ListViewItem itemC = new ListViewItem();
                    itemC = Lvcarro.Items.Add(item.SubItems[1].Text);
                    itemC.SubItems.Add(frm.Txtcantidad.Text);
                    itemC.SubItems.Add(subtotal.ToString());
                    total = total + subtotal;
                    Lbltotal.Text = "$ " + total.ToString();
                }
            }
        }

        private void Btnquitar_Click(object sender, EventArgs e)
        {
            if (Lvcarro.SelectedItems.Count > 0)
            {
                ListViewItem item = new ListViewItem();
                item = Lvcarro.Items[pos2];
                item.Remove();
                Lvcarro.Refresh();
                var subtotal = int.Parse(item.SubItems[2].Text.ToString());
                total = total - subtotal;
                Lbltotal.Text = "$ " + total.ToString();
            }
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void Lvcarro_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            pos2 = e.ItemIndex;
        }

        private void Btnvender_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Pagina en construcción :c");
            }
        }
    }
}
