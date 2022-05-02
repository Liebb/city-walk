using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias de SQL SERVER
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Compra
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand command = new SqlCommand();

        public void InsertDetalleCompra(int cantidad, float iva, float subtotal, int idProv)
        {
            DateTime fecha = DateTime.Today;
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "DetalleCompra";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@cantidad", cantidad);
            command.Parameters.AddWithValue("@iva", iva);
            command.Parameters.AddWithValue("@subtotal", subtotal);
            command.Parameters.AddWithValue("@fechaCompra", fecha);
            command.Parameters.AddWithValue("@idProv", idProv);
            command.ExecuteNonQuery();
            command.Parameters.Clear();

        }
   
        public void CompraAdd(int detalleID,double total)
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "Compra";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@detalleID", detalleID);
            command.Parameters.AddWithValue("@total", total);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public void SetInvent(int idProducto, int cantidad, float precioVta)
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "SetInvent";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idCompra", idProducto);
            command.Parameters.AddWithValue("@cantidad", cantidad);
            command.Parameters.AddWithValue("@precioVta", precioVta);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

    }
}
