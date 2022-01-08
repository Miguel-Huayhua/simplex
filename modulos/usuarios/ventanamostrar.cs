using Sistema_Ventas_Simplex1.modulos.conexion;
using System.Data.SqlClient;
using System.Windows.Forms;
using ventana1.agregaForms;

namespace Sistema_Ventas_Simplex1.modulos
{
    public partial class ventanamostrar : Form
    {
        public ventanamostrar(Panel pmain)
        {
            this.pmain = pmain;
            InitializeComponent();
            tabla.Columns[0].Width = 50;
        }


        private void panel6_Click(object sender, System.EventArgs e)
        {
            new AgregaForm().agrega(pmain, new ventanaagregar(pmain));

        }

        private void tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var form = new ventanaagregar(pmain);
            object[] val = { tabla.Rows[e.RowIndex].Cells[1].Value, tabla.Rows[e.RowIndex].Cells[2].Value, tabla.Rows[e.RowIndex].Cells[3].Value, null, null, tabla.Rows[e.RowIndex].Cells[5].Value, null ,null};

            using (var con = new conectar().crearConexion())
            {
                SqlCommand command = new SqlCommand("mostrar_usuario", con);
                SqlDataReader data = command.ExecuteReader();

                while (data.Read())
                {
                    if (data.GetValue(1).ToString() == val[0].ToString())
                    {
                        val.SetValue(data.GetInt32(7), 3);
                        val.SetValue(data.GetValue(4), 4);
                        val.SetValue(data.GetValue(5), 6);
                        val.SetValue(data.GetValue(0), 7);
                    }

                }
            }
            form.llenardatos(val);
            form.desactivaBtn();
            new AgregaForm().agrega(pmain, form);
        }

        public void mostrarTabla(SqlCommand command)
        {
            tabla.Rows.Clear();
            SqlDataReader data = command.ExecuteReader();
            arr = new System.Collections.ArrayList();
            while (data.Read())
            {
                object[] datos = { "Borrar", data.GetValue(1), data.GetValue(2), data.GetValue(6), GetRol(data.GetInt32(7)), data.GetValue(3) };
                object[] todo = { datos, data.GetValue(0) };
                arr.Add(todo);
                tabla.Rows.Add(datos);

            }
            data = null;
        }
        private string GetRol(int valor)
        {
            string[] rol = {"Solo ventas","Cajero", "Administrador" };
            return rol[valor];
        }
        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                using (var con = new conectar().crearConexion())
                {
                    SqlCommand sql_com = new SqlCommand("eliminar_usuario", con);
                    sql_com.CommandType = System.Data.CommandType.StoredProcedure;
                    var select = (object[])arr[e.RowIndex];
                    sql_com.Parameters.AddWithValue("@id_usuario", select[1]);
                    sql_com.ExecuteNonQuery();
                    SqlCommand command = new SqlCommand("mostrar_usuario", con);
                    mostrarTabla(command);
                    con.Close();
                }
            }
        }
        System.Collections.ArrayList arr;

        private Panel pmain;

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ventanamostrar_Load(object sender, System.EventArgs e)
        {
            using (var con = new conectar().crearConexion())
            {
                SqlCommand command = new SqlCommand("mostrar_usuario", con);
                mostrarTabla(command);
                con.Close();
            }
        }
    }

}
