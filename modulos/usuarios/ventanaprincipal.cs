using Sistema_Ventas_Simplex1.modulos.conexion;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ventana1.agregaForms;

namespace Sistema_Ventas_Simplex1.modulos
{
    public partial class ventanaprincipal : Form
    {

        public ventanaprincipal(Form main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void ventanaprincipal_Load(object sender, EventArgs e)
        {
            ventana = new ventanamostrar(panelmain);
            new AgregaForm().agrega(panelmain, ventana);
        }

        private void txtBusquedaNombre_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                using (var con = new conectar().crearConexion())
                {
                    SqlCommand command = new SqlCommand("buscar_usuario",con);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@username", txtBusquedaNombre.Text);
                    command.Parameters.AddWithValue("@userlogin", txtBusquedaUsuario.Text);
                    new AgregaForm().agrega(panelmain, ventana);
                    ventana.mostrarTabla(command);
                    con.Close();

                }
            }
            
        }
        private ventanamostrar ventana;

        private void ventanaprincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.main.Show();
        }
        private Form main;
    }
}
