namespace LIBRERIA
{
    partial class Crear_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_usuario));
            this.Btnaceptar = new System.Windows.Forms.Button();
            this.Btncancelar = new System.Windows.Forms.Button();
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.Txtusuario = new System.Windows.Forms.TextBox();
            this.Txtcontrasena = new System.Windows.Forms.TextBox();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbVendedor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnaceptar
            // 
            this.Btnaceptar.Location = new System.Drawing.Point(94, 395);
            this.Btnaceptar.Name = "Btnaceptar";
            this.Btnaceptar.Size = new System.Drawing.Size(94, 29);
            this.Btnaceptar.TabIndex = 0;
            this.Btnaceptar.Text = "Aceptar";
            this.Btnaceptar.UseVisualStyleBackColor = true;
            this.Btnaceptar.Click += new System.EventHandler(this.Btnaceptar_Click);
            // 
            // Btncancelar
            // 
            this.Btncancelar.Location = new System.Drawing.Point(267, 395);
            this.Btncancelar.Name = "Btncancelar";
            this.Btncancelar.Size = new System.Drawing.Size(94, 29);
            this.Btncancelar.TabIndex = 1;
            this.Btncancelar.Text = "Cancelar";
            this.Btncancelar.UseVisualStyleBackColor = true;
            this.Btncancelar.Click += new System.EventHandler(this.Btncancelar_Click);
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(226, 131);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(125, 27);
            this.Txtnombre.TabIndex = 2;
            // 
            // Txtusuario
            // 
            this.Txtusuario.Location = new System.Drawing.Point(226, 181);
            this.Txtusuario.Name = "Txtusuario";
            this.Txtusuario.Size = new System.Drawing.Size(125, 27);
            this.Txtusuario.TabIndex = 2;
            // 
            // Txtcontrasena
            // 
            this.Txtcontrasena.Location = new System.Drawing.Point(226, 235);
            this.Txtcontrasena.Name = "Txtcontrasena";
            this.Txtcontrasena.Size = new System.Drawing.Size(125, 27);
            this.Txtcontrasena.TabIndex = 2;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(94, 314);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(125, 24);
            this.rbAdmin.TabIndex = 3;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Administrador";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbVendedor
            // 
            this.rbVendedor.AutoSize = true;
            this.rbVendedor.Location = new System.Drawing.Point(244, 314);
            this.rbVendedor.Name = "rbVendedor";
            this.rbVendedor.Size = new System.Drawing.Size(94, 24);
            this.rbVendedor.TabIndex = 4;
            this.rbVendedor.TabStop = true;
            this.rbVendedor.Text = "Vendedor";
            this.rbVendedor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Crear_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(462, 467);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbVendedor);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.Txtcontrasena);
            this.Controls.Add(this.Txtusuario);
            this.Controls.Add(this.Txtnombre);
            this.Controls.Add(this.Btncancelar);
            this.Controls.Add(this.Btnaceptar);
            this.Name = "Crear_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear_usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btnaceptar;
        private Button Btncancelar;
        private TextBox Txtnombre;
        private TextBox Txtusuario;
        private TextBox Txtcontrasena;
        private RadioButton rbAdmin;
        private RadioButton rbVendedor;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}