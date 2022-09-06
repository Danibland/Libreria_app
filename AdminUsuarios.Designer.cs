namespace LIBRERIA
{
    partial class AdminUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUsuarios));
            this.Lvwusuarios = new System.Windows.Forms.ListView();
            this.ID_USUARIO = new System.Windows.Forms.ColumnHeader();
            this.NOMBRE_COMPLETO = new System.Windows.Forms.ColumnHeader();
            this.USUARIO = new System.Windows.Forms.ColumnHeader();
            this.DESCRIPCION = new System.Windows.Forms.ColumnHeader();
            this.Btncrear = new System.Windows.Forms.Button();
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.Txtusuario = new System.Windows.Forms.TextBox();
            this.Lbnombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btneditar = new System.Windows.Forms.Button();
            this.Btneliminar = new System.Windows.Forms.Button();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lvwusuarios
            // 
            this.Lvwusuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_USUARIO,
            this.NOMBRE_COMPLETO,
            this.USUARIO,
            this.DESCRIPCION});
            this.Lvwusuarios.FullRowSelect = true;
            this.Lvwusuarios.GridLines = true;
            this.Lvwusuarios.Location = new System.Drawing.Point(63, 82);
            this.Lvwusuarios.Name = "Lvwusuarios";
            this.Lvwusuarios.Size = new System.Drawing.Size(479, 513);
            this.Lvwusuarios.TabIndex = 0;
            this.Lvwusuarios.UseCompatibleStateImageBehavior = false;
            this.Lvwusuarios.View = System.Windows.Forms.View.Details;
            this.Lvwusuarios.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.Lvwusuarios_ItemSelectionChanged);
            this.Lvwusuarios.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID_USUARIO
            // 
            this.ID_USUARIO.Text = "ID";
            // 
            // NOMBRE_COMPLETO
            // 
            this.NOMBRE_COMPLETO.Text = "NOMBRE COMPLETO";
            this.NOMBRE_COMPLETO.Width = 150;
            // 
            // USUARIO
            // 
            this.USUARIO.Text = "USUARIO";
            this.USUARIO.Width = 100;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.Text = "ROL";
            this.DESCRIPCION.Width = 100;
            // 
            // Btncrear
            // 
            this.Btncrear.Location = new System.Drawing.Point(63, 33);
            this.Btncrear.Name = "Btncrear";
            this.Btncrear.Size = new System.Drawing.Size(146, 29);
            this.Btncrear.TabIndex = 1;
            this.Btncrear.Text = "Crear usuario";
            this.Btncrear.UseVisualStyleBackColor = true;
            this.Btncrear.Click += new System.EventHandler(this.Btncrear_Click);
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(713, 251);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(125, 27);
            this.Txtnombre.TabIndex = 2;
            // 
            // Txtusuario
            // 
            this.Txtusuario.Location = new System.Drawing.Point(713, 339);
            this.Txtusuario.Name = "Txtusuario";
            this.Txtusuario.Size = new System.Drawing.Size(125, 27);
            this.Txtusuario.TabIndex = 3;
            // 
            // Lbnombre
            // 
            this.Lbnombre.AutoSize = true;
            this.Lbnombre.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lbnombre.Location = new System.Drawing.Point(608, 255);
            this.Lbnombre.Name = "Lbnombre";
            this.Lbnombre.Size = new System.Drawing.Size(64, 20);
            this.Lbnombre.TabIndex = 5;
            this.Lbnombre.Text = "Nombre";
            this.Lbnombre.Click += new System.EventHandler(this.Lbnombre_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(608, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario";
            // 
            // Btneditar
            // 
            this.Btneditar.Location = new System.Drawing.Point(608, 449);
            this.Btneditar.Name = "Btneditar";
            this.Btneditar.Size = new System.Drawing.Size(94, 29);
            this.Btneditar.TabIndex = 7;
            this.Btneditar.Text = "Editar";
            this.Btneditar.UseVisualStyleBackColor = true;
            this.Btneditar.Click += new System.EventHandler(this.Btneditar_Click);
            // 
            // Btneliminar
            // 
            this.Btneliminar.Location = new System.Drawing.Point(744, 449);
            this.Btneliminar.Name = "Btneliminar";
            this.Btneliminar.Size = new System.Drawing.Size(94, 29);
            this.Btneliminar.TabIndex = 8;
            this.Btneliminar.Text = "Eliminar";
            this.Btneliminar.UseVisualStyleBackColor = true;
            this.Btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(713, 167);
            this.Txtid.Name = "Txtid";
            this.Txtid.ReadOnly = true;
            this.Txtid.Size = new System.Drawing.Size(125, 27);
            this.Txtid.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(608, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(789, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // AdminUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(926, 631);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtid);
            this.Controls.Add(this.Btneliminar);
            this.Controls.Add(this.Btneditar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbnombre);
            this.Controls.Add(this.Txtusuario);
            this.Controls.Add(this.Txtnombre);
            this.Controls.Add(this.Btncrear);
            this.Controls.Add(this.Lvwusuarios);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUsuarios";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "AdminUsuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListView Lvwusuarios;
        private Button Btncrear;
        private ColumnHeader NOMBRE_COMPLETO;
        private ColumnHeader USUARIO;
        private ColumnHeader DESCRIPCION;
        private ColumnHeader ID_USUARIO;
        private TextBox Txtnombre;
        private TextBox Txtusuario;
        private Label Lbnombre;
        private Label label3;
        private Button Btneditar;
        private Button Btneliminar;
        private TextBox Txtid;
        private Label label1;
        private PictureBox pictureBox1;
    }
}