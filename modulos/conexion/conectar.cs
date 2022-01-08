using System;
using System.Data.SqlClient;
namespace Sistema_Ventas_Simplex1.modulos.conexion
{
    class conectar
    {
        SqlConnection conexion
        {
            get;
            set;
        }

        public SqlConnection crearConexion()
        {


            conexion = new SqlConnection("server=localhost ; database=BASESIMPLEX ; integrated security = true ");

            try
            {
                conexion.Open();
                return conexion;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
