using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace Sistema_Ventas_Simplex1.modulos
{
    public partial class ventanarestaurar : Form
    {
        public ventanarestaurar()
        {
            InitializeComponent();
            html.Visible = false;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            using (var con = new conexion.conectar().crearConexion())
            {
                var com = con.CreateCommand();
                com.CommandText = "comprueba_email";
                com.Parameters.AddWithValue("@correo", txtCorreo.Text);
                com.CommandType = CommandType.StoredProcedure;
                try {
                    var data = com.ExecuteReader();
                    while (data.Read())
                    {
                        html.Text = html.Text.Replace("@user", data.GetString(0));
                        html.Text = html.Text.Replace("@pass", data.GetString(1));
                        enviarEmail("aristiasmaz@gmail.com", txtCorreo.Text, "69848691", html.Text);

                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
        private Boolean enviarEmail(string emisor,string receptor,string contra,string body)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress(emisor);
            message.To.Add(new MailAddress(receptor));
            message.Subject = "RESTAURAR CONTRASEÑA";
            message.IsBodyHtml = true;
            message.Body = body;
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(emisor, contra);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);

            return true;
        }


    }
}
