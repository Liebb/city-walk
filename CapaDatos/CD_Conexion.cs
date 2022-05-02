using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private static readonly string Conexion = "server = LAPTOP-OUVJDVTQ; DataBase = City_Walk; Integrated Security = True";
        private SqlConnection Conexion2 = new SqlConnection(Conexion);


        protected SqlConnection GetConnection()
        {
            return new SqlConnection(Conexion);
        }

        public SqlConnection AbrirConexion()
        {
            if (Conexion2.State == ConnectionState.Closed)
                Conexion2.Open();
            return Conexion2;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion2.State == ConnectionState.Open)
                Conexion2.Close();
            return Conexion2;
        }


    }
}
