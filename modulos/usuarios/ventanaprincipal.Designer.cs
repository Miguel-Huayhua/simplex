
namespace Sistema_Ventas_Simplex1.modulos
{
    partial class ventanaprincipal
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
            this.panelmain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBusquedaNombre = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.porUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBusquedaUsuario = new System.Windows.Forms.ToolStripTextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmain
            // 
            this.panelmain.AutoSize = true;
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(0, 80);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1280, 640);
            this.panelmain.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.panelTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 80);
            this.panel1.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(143)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 38);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(1280, 42);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "Buscar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(143)))));
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 42);
            this.toolStripMenuItem1.Text = "Inicio";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(143)))));
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(131, 42);
            this.toolStripMenuItem2.Text = "Herramientas";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(143)))));
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNombreToolStripMenuItem,
            this.porUsuarioToolStripMenuItem});
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(77, 42);
            this.toolStripMenuItem3.Text = "Buscar";
            // 
            // porNombreToolStripMenuItem
            // 
            this.porNombreToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(143)))));
            this.porNombreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtBusquedaNombre,
            this.toolStripMenuItem4});
            this.porNombreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            this.porNombreToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.porNombreToolStripMenuItem.Text = "Por Nombre";
            // 
            // txtBusquedaNombre
            // 
            this.txtBusquedaNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(143)))));
            this.txtBusquedaNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusquedaNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusquedaNombre.ForeColor = System.Drawing.SystemColors.Info;
            this.txtBusquedaNombre.Name = "txtBusquedaNombre";
            this.txtBusquedaNombre.Size = new System.Drawing.Size(200, 34);
            this.txtBusquedaNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusquedaNombre_KeyUp);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(143)))));
            this.toolStripMenuItem4.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(271, 6);
            // 
            // porUsuarioToolStripMenuItem
            // 
            this.porUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(143)))));
            this.porUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtBusquedaUsuario});
            this.porUsuarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.porUsuarioToolStripMenuItem.Name = "porUsuarioToolStripMenuItem";
            this.porUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.porUsuarioToolStripMenuItem.Text = "Por Usuario";
            // 
            // txtBusquedaUsuario
            // 
            this.txtBusquedaUsuario.AccessibleDescription = "Escriba Nombre";
            this.txtBusquedaUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(143)))));
            this.txtBusquedaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusquedaUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBusquedaUsuario.ForeColor = System.Drawing.SystemColors.Info;
            this.txtBusquedaUsuario.Name = "txtBusquedaUsuario";
            this.txtBusquedaUsuario.Size = new System.Drawing.Size(200, 34);
            this.txtBusquedaUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusquedaNombre_KeyUp);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(143)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1280, 38);
            this.panelTop.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            // 
            // ventanaprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "ventanaprincipal";
            this.Text = "ventanaprincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ventanaprincipal_FormClosed);
            this.Load += new System.EventHandler(this.ventanaprincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtBusquedaNombre;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem porUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtBusquedaUsuario;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
    }
}