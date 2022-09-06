namespace LIBRERIA
{
    partial class AdminLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLibros));
            this.Lvlibros = new System.Windows.Forms.ListView();
            this.ID_LIBRO = new System.Windows.Forms.ColumnHeader();
            this.NOMBRE = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.btnCrear = new System.Windows.Forms.Button();
            this.Txtbuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.Txtvalor = new System.Windows.Forms.TextBox();
            this.Txtcantidad = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtautor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtgenero = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lvlibros
            // 
            this.Lvlibros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_LIBRO,
            this.NOMBRE,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.Lvlibros.FullRowSelect = true;
            this.Lvlibros.GridLines = true;
            this.Lvlibros.Location = new System.Drawing.Point(28, 129);
            this.Lvlibros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lvlibros.Name = "Lvlibros";
            this.Lvlibros.Size = new System.Drawing.Size(841, 439);
            this.Lvlibros.TabIndex = 0;
            this.Lvlibros.UseCompatibleStateImageBehavior = false;
            this.Lvlibros.View = System.Windows.Forms.View.Details;
            this.Lvlibros.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.Lvlibros_ItemSelectionChanged);
            this.Lvlibros.SelectedIndexChanged += new System.EventHandler(this.Lvlibros_SelectedIndexChanged);
            // 
            // ID_LIBRO
            // 
            this.ID_LIBRO.Text = "ID_LIBRO";
            // 
            // NOMBRE
            // 
            this.NOMBRE.Text = "NOMBRE";
            this.NOMBRE.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "AUTOR";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "GENERO";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "VALOR";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CANTIDAD";
            this.columnHeader6.Width = 80;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(1191, 535);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(120, 31);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear productos";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // Txtbuscar
            // 
            this.Txtbuscar.Location = new System.Drawing.Point(28, 75);
            this.Txtbuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtbuscar.Name = "Txtbuscar";
            this.Txtbuscar.PlaceholderText = "Escribir nombre, autor, género ó valor a buscar";
            this.Txtbuscar.Size = new System.Drawing.Size(339, 27);
            this.Txtbuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(404, 73);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 31);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(1059, 176);
            this.Txtid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtid.Name = "Txtid";
            this.Txtid.ReadOnly = true;
            this.Txtid.Size = new System.Drawing.Size(252, 27);
            this.Txtid.TabIndex = 3;
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(1059, 240);
            this.Txtnombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(252, 27);
            this.Txtnombre.TabIndex = 3;
            // 
            // Txtvalor
            // 
            this.Txtvalor.Location = new System.Drawing.Point(1059, 406);
            this.Txtvalor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtvalor.Name = "Txtvalor";
            this.Txtvalor.Size = new System.Drawing.Size(252, 27);
            this.Txtvalor.TabIndex = 3;
            // 
            // Txtcantidad
            // 
            this.Txtcantidad.Location = new System.Drawing.Point(1059, 467);
            this.Txtcantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtcantidad.Name = "Txtcantidad";
            this.Txtcantidad.Size = new System.Drawing.Size(252, 27);
            this.Txtcantidad.TabIndex = 3;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1059, 535);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 31);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(918, 535);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 31);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(918, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(918, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(918, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(918, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad";
            // 
            // Txtautor
            // 
            this.Txtautor.Location = new System.Drawing.Point(1059, 298);
            this.Txtautor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Txtautor.Name = "Txtautor";
            this.Txtautor.Size = new System.Drawing.Size(252, 27);
            this.Txtautor.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(918, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Autor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(918, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Genero";
            // 
            // Txtgenero
            // 
            this.Txtgenero.Location = new System.Drawing.Point(1059, 354);
            this.Txtgenero.Name = "Txtgenero";
            this.Txtgenero.Size = new System.Drawing.Size(252, 27);
            this.Txtgenero.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1222, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1359, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txtgenero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txtautor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.Txtcantidad);
            this.Controls.Add(this.Txtvalor);
            this.Controls.Add(this.Txtnombre);
            this.Controls.Add(this.Txtid);
            this.Controls.Add(this.Txtbuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.Lvlibros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminLibros";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView Lvlibros;
        private Button btnCrear;
        private TextBox Txtbuscar;
        private Button btnBuscar;
        private TextBox Txtid;
        private TextBox Txtnombre;
        private TextBox Txtvalor;
        private TextBox Txtcantidad;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ColumnHeader ID_LIBRO;
        private ColumnHeader NOMBRE;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TextBox Txtautor;
        private Label label5;
        private Label label6;
        private TextBox Txtgenero;
        private PictureBox pictureBox1;
    }
}