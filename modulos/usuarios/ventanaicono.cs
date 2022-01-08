using System;
using System.Windows.Forms;

namespace Sistema_Ventas_Simplex1.modulos
{
    public partial class ventanaicono : Form
    {
        public ventanaicono(Form main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.main.Enabled = true;
            this.main.Activate();
        }

        private void icon1_Click(object sender, EventArgs e)
        {
            PictureBox img = (PictureBox)sender;
            ventanaagregar ventana = (ventanaagregar)main;
            ventana.ColocaImagen(img.Image);
            this.Hide();
            this.main.Enabled = true;
            this.main.Activate();
        }
        private Form main;

    }
}

