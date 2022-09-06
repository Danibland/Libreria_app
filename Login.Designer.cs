namespace LIBRERIA
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Txtusuario = new System.Windows.Forms.TextBox();
            this.Txtcontrasena = new System.Windows.Forms.TextBox();
            this.Btniniciar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Txtusuario
            // 
            resources.ApplyResources(this.Txtusuario, "Txtusuario");
            this.Txtusuario.Name = "Txtusuario";
            // 
            // Txtcontrasena
            // 
            resources.ApplyResources(this.Txtcontrasena, "Txtcontrasena");
            this.Txtcontrasena.Name = "Txtcontrasena";
            // 
            // Btniniciar
            // 
            resources.ApplyResources(this.Btniniciar, "Btniniciar");
            this.Btniniciar.Name = "Btniniciar";
            this.Btniniciar.UseVisualStyleBackColor = true;
            this.Btniniciar.Click += new System.EventHandler(this.Btniniciar_Click);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Btniniciar);
            this.Controls.Add(this.Txtcontrasena);
            this.Controls.Add(this.Txtusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Txtusuario;
        private TextBox Txtcontrasena;
        private Button Btniniciar;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}