
namespace Sistema_Ventas_Simplex1.modulos
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panelmain = new System.Windows.Forms.Panel();
            this.btnForgetPass = new System.Windows.Forms.Button();
            this.panelUsuario = new System.Windows.Forms.FlowLayoutPanel();
            this.lblInicioSesion = new System.Windows.Forms.Label();
            this.lblTienda = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(143)))));
            this.panelmain.Controls.Add(this.btnForgetPass);
            this.panelmain.Controls.Add(this.panelUsuario);
            this.panelmain.Controls.Add(this.lblInicioSesion);
            this.panelmain.Controls.Add(this.lblTienda);
            this.panelmain.Controls.Add(this.pictureBox1);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(0, 0);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1262, 673);
            this.panelmain.TabIndex = 0;
            // 
            // btnForgetPass
            // 
            this.btnForgetPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForgetPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(65)))), ((int)(((byte)(135)))));
            this.btnForgetPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnForgetPass.FlatAppearance.BorderSize = 2;
            this.btnForgetPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgetPass.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnForgetPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnForgetPass.Location = new System.Drawing.Point(469, 564);
            this.btnForgetPass.Margin = new System.Windows.Forms.Padding(0);
            this.btnForgetPass.Name = "btnForgetPass";
            this.btnForgetPass.Size = new System.Drawing.Size(274, 53);
            this.btnForgetPass.TabIndex = 46;
            this.btnForgetPass.Text = "Olvidé mi contraseña";
            this.btnForgetPass.UseVisualStyleBackColor = false;
            this.btnForgetPass.Click += new System.EventHandler(this.btnForgetPass_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUsuario.Location = new System.Drawing.Point(177, 151);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(900, 400);
            this.panelUsuario.TabIndex = 4;
            // 
            // lblInicioSesion
            // 
            this.lblInicioSesion.AutoSize = true;
            this.lblInicioSesion.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblInicioSesion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInicioSesion.Location = new System.Drawing.Point(204, 112);
            this.lblInicioSesion.Name = "lblInicioSesion";
            this.lblInicioSesion.Size = new System.Drawing.Size(320, 25);
            this.lblInicioSesion.TabIndex = 3;
            this.lblInicioSesion.Text = "¿QUIÉN ESTÁ INICIANDO SESIÓN?";
            // 
            // lblTienda
            // 
            this.lblTienda.AutoSize = true;
            this.lblTienda.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTienda.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTienda.Location = new System.Drawing.Point(3, 123);
            this.lblTienda.Name = "lblTienda";
            this.lblTienda.Size = new System.Drawing.Size(163, 25);
            this.lblTienda.TabIndex = 2;
            this.lblTienda.Text = "TIENDA VIRTUAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelmain);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panelmain.ResumeLayout(false);
            this.panelmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel panelUsuario;
        private System.Windows.Forms.Label lblInicioSesion;
        private System.Windows.Forms.Label lblTienda;
        private System.Windows.Forms.Button btnForgetPass;
    }
}