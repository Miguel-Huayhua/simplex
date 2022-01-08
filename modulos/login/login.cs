using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Sistema_Ventas_Simplex1.modulos.conexion;
using ventana1.agregaForms;

namespace Sistema_Ventas_Simplex1.modulos
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            using (var con = new conectar().crearConexion())
            {
                SqlCommand com = new SqlCommand("mostrar_usuario",con);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = com.ExecuteReader();

                while (rd.Read())
                {
                    var btn = new Button();
                    btn.BackColor = Color.FromArgb(36, 71, 143);
                    btn.Size = new Size(180, 180);
                    btn.ForeColor = Color.WhiteSmoke;
                    btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                    Byte[] datos = (Byte[])rd.GetValue(4);
                    using (var ms = new MemoryStream(datos))
                    {
                        var image = Image.FromStream(ms).GetThumbnailImage(btn.Width,btn.Height-30,null,IntPtr.Zero);
                        btn.Image = image;
                    }
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.TextImageRelation = TextImageRelation.TextAboveImage;
                    btn.Text = rd.GetString(2);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Margin = new Padding(10);
                    btn.Click += new EventHandler(Click_btn);
                    panelUsuario.Controls.Add(btn);

                }
                con.Close();
            }
        }
        private void Click_btn(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            object[] datos = {btn.Text,btn.Image};
            new AgregaForm().agrega(panelmain, new ventanalog(this.panelmain,datos));   
        }

        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            new AgregaForm().agrega(panelmain, new ventanarestaurar());
        }
    }
}
