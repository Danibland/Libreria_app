namespace LIBRERIA
{
    partial class Facturar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturar));
            this.Lvlibros = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtbuscar = new System.Windows.Forms.TextBox();
            this.Btnbuscar = new System.Windows.Forms.Button();
            this.Lvcarro = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.Btnenviar = new System.Windows.Forms.Button();
            this.Btnquitar = new System.Windows.Forms.Button();
            this.label88 = new System.Windows.Forms.Label();
            this.Btnvender = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbltotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lvlibros
            // 
            this.Lvlibros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.Lvlibros.FullRowSelect = true;
            this.Lvlibros.GridLines = true;
            this.Lvlibros.Location = new System.Drawing.Point(53, 130);
            this.Lvlibros.Name = "Lvlibros";
            this.Lvlibros.Size = new System.Drawing.Size(639, 601);
            this.Lvlibros.TabIndex = 0;
            this.Lvlibros.UseCompatibleStateImageBehavior = false;
            this.Lvlibros.View = System.Windows.Forms.View.Details;
            this.Lvlibros.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.Lvlibros_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID_LIBRO";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NOMBRE";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "AUTOR";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "GENERO";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "VALOR";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "CANTIDAD";
            this.columnHeader6.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(878, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carro de compras";
            // 
            // Txtbuscar
            // 
            this.Txtbuscar.Location = new System.Drawing.Point(51, 76);
            this.Txtbuscar.Name = "Txtbuscar";
            this.Txtbuscar.PlaceholderText = "Buscar ";
            this.Txtbuscar.ShortcutsEnabled = false;
            this.Txtbuscar.Size = new System.Drawing.Size(496, 27);
            this.Txtbuscar.TabIndex = 2;
            // 
            // Btnbuscar
            // 
            this.Btnbuscar.Location = new System.Drawing.Point(553, 76);
            this.Btnbuscar.Name = "Btnbuscar";
            this.Btnbuscar.Size = new System.Drawing.Size(139, 29);
            this.Btnbuscar.TabIndex = 3;
            this.Btnbuscar.Text = "Buscar";
            this.Btnbuscar.UseVisualStyleBackColor = true;
            this.Btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
            // 
            // Lvcarro
            // 
            this.Lvcarro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.Lvcarro.FullRowSelect = true;
            this.Lvcarro.GridLines = true;
            this.Lvcarro.Location = new System.Drawing.Point(798, 130);
            this.Lvcarro.Name = "Lvcarro";
            this.Lvcarro.Size = new System.Drawing.Size(354, 465);
            this.Lvcarro.TabIndex = 4;
            this.Lvcarro.UseCompatibleStateImageBehavior = false;
            this.Lvcarro.View = System.Windows.Forms.View.Details;
            this.Lvcarro.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.Lvcarro_ItemSelectionChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "NOMBRE";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "CANTIDAD";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "SUBTOTAL";
            this.columnHeader9.Width = 100;
            // 
            // Btnenviar
            // 
            this.Btnenviar.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btnenviar.Location = new System.Drawing.Point(698, 276);
            this.Btnenviar.Name = "Btnenviar";
            this.Btnenviar.Size = new System.Drawing.Size(94, 73);
            this.Btnenviar.TabIndex = 5;
            this.Btnenviar.Text = ">>";
            this.Btnenviar.UseVisualStyleBackColor = true;
            this.Btnenviar.Click += new System.EventHandler(this.Btnenviar_Click);
            // 
            // Btnquitar
            // 
            this.Btnquitar.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btnquitar.Location = new System.Drawing.Point(698, 388);
            this.Btnquitar.Name = "Btnquitar";
            this.Btnquitar.Size = new System.Drawing.Size(94, 76);
            this.Btnquitar.TabIndex = 6;
            this.Btnquitar.Text = "<<";
            this.Btnquitar.UseVisualStyleBackColor = true;
            this.Btnquitar.Click += new System.EventHandler(this.Btnquitar_Click);
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label88.Location = new System.Drawing.Point(804, 611);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(79, 30);
            this.label88.TabIndex = 7;
            this.label88.Text = "TOTAL:";
            // 
            // Btnvender
            // 
            this.Btnvender.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btnvender.ForeColor = System.Drawing.Color.Crimson;
            this.Btnvender.Location = new System.Drawing.Point(840, 649);
            this.Btnvender.Name = "Btnvender";
            this.Btnvender.Size = new System.Drawing.Size(284, 82);
            this.Btnvender.TabIndex = 8;
            this.Btnvender.Text = "VENDER";
            this.Btnvender.UseVisualStyleBackColor = true;
            this.Btnvender.Click += new System.EventHandler(this.Btnvender_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(51, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Facturación";
            // 
            // Lbltotal
            // 
            this.Lbltotal.AutoSize = true;
            this.Lbltotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbltotal.Location = new System.Drawing.Point(903, 611);
            this.Lbltotal.Name = "Lbltotal";
            this.Lbltotal.Size = new System.Drawing.Size(25, 30);
            this.Lbltotal.TabIndex = 7;
            this.Lbltotal.Text = "$";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1201, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1308, 787);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btnvender);
            this.Controls.Add(this.Lbltotal);
            this.Controls.Add(this.label88);
            this.Controls.Add(this.Btnquitar);
            this.Controls.Add(this.Btnenviar);
            this.Controls.Add(this.Lvcarro);
            this.Controls.Add(this.Btnbuscar);
            this.Controls.Add(this.Txtbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lvlibros);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Facturar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Facturar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView Lvlibros;
        private Label label1;
        private TextBox Txtbuscar;
        private Button Btnbuscar;
        private ListView Lvcarro;
        private Button Btnenviar;
        private Button Btnquitar;
        private Label label88;
        private Button Btnvender;
        private Label label3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Label Lbltotal;
        private PictureBox pictureBox1;
    }
}