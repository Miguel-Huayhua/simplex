using Sistema_Ventas_Simplex1.modulos.conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ventana1.agregaForms;

namespace Sistema_Ventas_Simplex1.modulos
{
    public partial class ventanalog : Form
    {
        public ventanalog(Panel panelmain,object[] datos)
        {
            this.panelmain = panelmain;
            this.datos = datos;
            InitializeComponent();
            this.lblUser.Text = datos[0].ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtPass.Text = txtPass.Text + btn.Text;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new AgregaForm().agrega(panelmain, new login());
        }
        private Panel panelmain;
        private object[] datos;

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            using (var con = new conectar().crearConexion())
            {
                SqlCommand com = new SqlCommand("existe_usuario",con);

                com.CommandType = CommandType.StoredProcedure;
                try {
                    com.Parameters.AddWithValue("@login", datos[0]);
                    com.Parameters.AddWithValue("@pass", txtPass.Text);
                    var data = com.ExecuteNonQuery();
                    if (data == -1)
                    {
                        MessageBox.Show("Bienvenido " + datos[0].ToString());
                        var main = (Form)this.Parent.Parent;
                        main.Hide();
                        new ventanaprincipal(main).Show();
                    }
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btnOlvidarPass_Click(object sender, EventArgs e)
        {

        }
    }
}
