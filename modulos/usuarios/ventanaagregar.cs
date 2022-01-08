using Sistema_Ventas_Simplex1.modulos.conexion;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ventana1.agregaForms;

namespace Sistema_Ventas_Simplex1.modulos
{
    public partial class ventanaagregar : Form
    {
        public ventanaagregar(Panel pmain)
        {
            this.pmain = pmain;
            InitializeComponent();
            init();
        }
        public void llenardatos(object[] data)
        {
            this.data = data;
            this.txtNombre.Text = data[0].ToString();
            this.txtLogin.Text = data[1].ToString();
            this.txtCorreo.Text = data[2].ToString();
            this.txtPass.Text = data[5].ToString();
            this.cmbRol.SelectedIndex = (int)data[3];
            var img = (System.Byte[])data[4];
            using (var ms = new MemoryStream(img))
            {
                var image = Image.FromStream(ms);
                this.icono.Image = image;
                this.icono.SizeMode = PictureBoxSizeMode.Zoom;
                this.datosimg = new MemoryStream();
                this.icono.Image.Save(datosimg, image.RawFormat);
            }

        }
        private void init()
        {
            cmbRol.Items.Add("Solo Ventas (No está autorizado para manejar dinero)");
            cmbRol.Items.Add("Cajero (Si está autorizado para manejar dinero)");
            cmbRol.Items.Add("Administrador (Control Total)");
            cmbRol.SelectedIndex = 0;
            txtPass.PasswordChar = '●';
        }


        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private Boolean ValidaCorreo(string correo)
        {
            if (correo.Contains("@") && correo.Contains(".")) return true;
            else return false;
        }
        private void btnGCambios_Click(object sender, System.EventArgs e)
        {
            if (ValidaCorreo(txtCorreo.Text))
            {
                if(ValidaPass(txtPass.Text))
                {
                    if(txtNombre.Text.Length == 0 || txtLogin.Text.Length == 0 || txtCorreo.Text.Length==0)
                    {
                        MessageBox.Show("Por favor llene todos los campos vacíos...");
                    }
                    else {
                        try
                        {
                            using (var con = new conectar().crearConexion())
                            {
                                SqlCommand sql_com = new SqlCommand("insertar_usuario", con);
                                sql_com.CommandType = System.Data.CommandType.StoredProcedure;
                                sql_com.Parameters.AddWithValue("@nombre", txtNombre.Text);
                                sql_com.Parameters.AddWithValue("@login", txtLogin.Text);
                                sql_com.Parameters.AddWithValue("@icono", datosimg.GetBuffer());
                                sql_com.Parameters.AddWithValue("@nombreicono", "Icono-" + txtLogin.Text);
                                sql_com.Parameters.AddWithValue("@correo", txtCorreo.Text);
                                sql_com.Parameters.AddWithValue("@rol", valorRol);
                                sql_com.Parameters.AddWithValue("@password", txtPass.Text);
                                sql_com.ExecuteNonQuery();
                                con.Close();
                                new AgregaForm().agrega(pmain, new ventanamostrar(pmain));
                            }
                        }
                        catch (NullReferenceException ex)
                        {
                            MessageBox.Show("Por favor seleccione un ícono...");
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Contraseña debe tener solo números...");

                }
            }
            else
            {
                MessageBox.Show("Por favor introduzca un correo válido...");
            }



        }

        private void icono_Click(object sender, System.EventArgs e)
        {
            new ventanaicono(this).Show();
        }
        public void desactivaBtn()
        {
            this.btnGuardar.Enabled = false;
        }

        private void cmbRol_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            valorRol = cmb.SelectedIndex;
        }


        private void btnVolver_Click(object sender, System.EventArgs e)
        {
            new AgregaForm().agrega(pmain, new ventanamostrar(pmain));
        }
        public void ColocaImagen(Image img)
        {
            this.icono.Image = img;
            this.icono.SizeMode = PictureBoxSizeMode.Zoom;
            this.datosimg = new MemoryStream();
            this.icono.Image.Save(datosimg, img.RawFormat);
        }
        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (ValidaCorreo(txtCorreo.Text))
            {
                if (ValidaPass(txtPass.Text))
                {
                    using (var con = new conectar().crearConexion())
                    {
                        try
                        {
                            SqlCommand sql_com = new SqlCommand("actualizar_usuario", con);
                            sql_com.CommandType = System.Data.CommandType.StoredProcedure;
                            sql_com.Parameters.AddWithValue("@id", data[7].ToString());
                            sql_com.Parameters.AddWithValue("@nombre", txtNombre.Text);
                            sql_com.Parameters.AddWithValue("@login", txtLogin.Text);
                            sql_com.Parameters.AddWithValue("@icono", datosimg.GetBuffer());
                            sql_com.Parameters.AddWithValue("@nombreicono", "Icono-" + txtNombre.Text);
                            sql_com.Parameters.AddWithValue("@correo", txtCorreo.Text);
                            sql_com.Parameters.AddWithValue("@rol", valorRol);
                            sql_com.Parameters.AddWithValue("@pass", txtPass.Text);
                            sql_com.Parameters.AddWithValue("@nombreicono2", data[6].ToString());
                            sql_com.Parameters.AddWithValue("@login2", data[1].ToString());
                            try
                            {
                                sql_com.ExecuteNonQuery();
                                new AgregaForm().agrega(pmain, new ventanamostrar(pmain));
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show( ex.Message);
                            }
                            con.Close();
                        }
                        catch (Exception )
                        {
                            MessageBox.Show("Por favor seleccione un ícono...");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña debe tener solo números...");

                }
            }
            else
            {
                MessageBox.Show("Por favor introduzca un correo válido...");
            }
        }
        private Boolean ValidaPass(string valor)
        {
            Boolean esletra = true;
            foreach (char val in valor)
            {
                if (Char.IsLetter(val))
                {
                    esletra= false;
                    break;
                }
            }
            return esletra;
        }
        private void btnicono_Click(object sender, EventArgs e)
        {
            new ventanaicono(this).Show();
            this.Enabled = false;
        }
        

        

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            char[] letras = txtPass.Text.ToCharArray();

            foreach (char val in letras)
            {
                if (Char.IsLetter(val))
                {
                    lblIsNum.Visible = true;
                    break;
                }

                else
                    lblIsNum.Visible = false;


            }
        }
        private Panel pmain;
        private object[] data;

        private System.IO.MemoryStream datosimg;
        private int valorRol;
    }
}
