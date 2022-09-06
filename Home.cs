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
    public partial class Home : Form
    {
        Usuario us = new Usuario();
        public Home(Usuario usuario)
        {
            us = usuario;
            InitializeComponent();
            if (us.rol != 1)
            {
                administraciónToolStripMenuItem.Visible = false;
            }
        }

        private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStripContainer1.ContentPanel.Controls.Clear();
            AdminUsuarios frmUsuario = new AdminUsuarios();
            frmUsuario.MdiParent = this;
            this.toolStripContainer1.ContentPanel.Controls.Add(frmUsuario);
            frmUsuario.Show();
        }

        private void administrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStripContainer1.ContentPanel.Controls.Clear();
            AdminLibros frm = new AdminLibros();
            frm.MdiParent = this;
            this.toolStripContainer1.ContentPanel.Controls.Add(frm);
            frm.Show();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStripContainer1.ContentPanel.Controls.Clear();
            Facturar frm = new Facturar();
            frm.MdiParent = this;
            this.toolStripContainer1.ContentPanel.Controls.Add(frm);
            frm.Show();
        }

        private void administraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
