using System.Data.SqlClient;

namespace LIBRERIA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btniniciar_Click(object sender, EventArgs e)
        {

            // traemos la clase conexíon al boton crear.
            Conexionbd bd = new Conexionbd();
            bd.abrir();

            string usuario = Txtusuario.Text;
            string contra = Txtcontrasena.Text;

            string query = "SELECT ID_USUARIO, NOMBRE_COMPLETO, USUARIO, ID_ROL FROM USUARIO WHERE USUARIO = '" + usuario + "' AND CONTRASENA = '" + contra + "'";

            SqlCommand comando = new SqlCommand(query, bd.conexion);

            SqlDataReader datos = comando.ExecuteReader();

            if (datos.HasRows)
            {
                // si el usuario esta logeado se abre el form 2.
                Usuario us = new Usuario();
                while (datos.Read())
                {
                    us.usuario = datos.GetString(2);
                    us.rol = datos.GetInt32(3);
                }
                Home ventana1 = new Home(us);
                this.Hide();
                ventana1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Validar Usuario/Contraseña");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}