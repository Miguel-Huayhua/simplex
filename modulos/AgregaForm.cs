using System.Windows.Forms;

namespace ventana1.agregaForms
{
    class AgregaForm
    {

        public void agrega(Panel principal, Form sec)
        {
            principal.Controls.Clear();
            sec.TopLevel = false;
            sec.FormBorderStyle = FormBorderStyle.None;
            sec.Dock = DockStyle.Fill;
            principal.Controls.Add(sec);
            principal.Tag = sec;
            sec.Show();
        }
    }
}
