using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRERIA
{
    public partial class Cantidad : Form
    {
        public Cantidad()
        {
            InitializeComponent();
        }

        private void Cantidad_Load(object sender, EventArgs e)
        {

        }

        private void Btnadicionar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txtcantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
