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
   public class CD_Ventas
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand command = new SqlCommand();
          
        public void DetalleVta(int idProducto, DateTime fecha, string ClientName, float iva, float subtotal,int cantidad)
        {
            fecha = DateTime.Today;
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "DetalleVta";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdInventario", idProducto);
            command.Parameters.AddWithValue("@Fecha", fecha);
            command.Parameters.AddWithValue("@Cliente", ClientName);
            command.Parameters.AddWithValue("@Iva", iva);
            command.Parameters.AddWithValue("@Subtotal", subtotal);
            command.Parameters.AddWithValue("@cantidadVta", cantidad);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public void tbVenta(int idDetalle, string vendedor, float total)
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "Venta";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdDetalle", idDetalle);
            command.Parameters.AddWithValue("@Vendedor", vendedor);
            command.Parameters.AddWithValue("@Total", total);
            command.ExecuteNonQuery();
            command.Parameters.Clear();

        }

        public void RespaldoVenta()
        {
            command.Connection = conexion.AbrirConexion();
            command.CommandText = "RespaldoV";
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            command.Parameters.Clear();

        }


    }
}
