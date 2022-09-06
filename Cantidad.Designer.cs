namespace LIBRERIA
{
    partial class Cantidad
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
            this.Btnadicionar = new System.Windows.Forms.Button();
            this.Lbllibro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtcantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btnadicionar
            // 
            this.Btnadicionar.Location = new System.Drawing.Point(148, 116);
            this.Btnadicionar.Name = "Btnadicionar";
            this.Btnadicionar.Size = new System.Drawing.Size(94, 29);
            this.Btnadicionar.TabIndex = 0;
            this.Btnadicionar.Text = "Adicionar";
            this.Btnadicionar.UseVisualStyleBackColor = true;
            this.Btnadicionar.Click += new System.EventHandler(this.Btnadicionar_Click);
            // 
            // Lbllibro
            // 
            this.Lbllibro.AutoSize = true;
            this.Lbllibro.Location = new System.Drawing.Point(82, 25);
            this.Lbllibro.Name = "Lbllibro";
            this.Lbllibro.Size = new System.Drawing.Size(50, 20);
            this.Lbllibro.TabIndex = 1;
            this.Lbllibro.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese la cantidad a facturar:";
            // 
            // Txtcantidad
            // 
            this.Txtcantidad.Location = new System.Drawing.Point(248, 64);
            this.Txtcantidad.Name = "Txtcantidad";
            this.Txtcantidad.Size = new System.Drawing.Size(67, 27);
            this.Txtcantidad.TabIndex = 3;
            this.Txtcantidad.TextChanged += new System.EventHandler(this.Txtcantidad_TextChanged);
            this.Txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Libro:";
            // 
            // Cantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(367, 178);
            this.Controls.Add(this.Txtcantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbllibro);
            this.Controls.Add(this.Btnadicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cantidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cantidad";
            this.Load += new System.EventHandler(this.Cantidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btnadicionar;
        private Label label2;
        public Label Lbllibro;
        public TextBox Txtcantidad;
        public Label label1;
    }
}