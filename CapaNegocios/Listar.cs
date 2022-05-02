using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Listar las librerias de SQL
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocios
{
    public class Listar
    {
        /*Intsancia de la clase ConexionDB*/
        private CD_Conexion Conexion = new CD_Conexion();

        private SqlCommand Comando = new SqlCommand();
        /*Data reader para leer filas*/
        private SqlDataReader LeerFilas;

        public DataTable ListarProductos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarProducto";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable VerEmpleados()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "VerTrabajadores";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;

        }

        public DataTable ListarUsuarios()
        {
            //Instancia la clase DataTable para almacenar los datos en ella
            DataTable Tabla = new DataTable();
            //Abrimos la conexion con la BD
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarUsuarios";
            //Especificamos que es mediante un procedimiento almacenado
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable ListarCorreos()
        {
            //Instancia la clase DataTable para almacenar los datos en ella
            DataTable Tabla = new DataTable();
            //Abrimos la conexion con la BD
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarMails";
            //Especificamos que es mediante un procedimiento almacenado
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable ListarRoles()
        {
            //Instancia la clase DataTable para almacenar los datos en ella
            DataTable Tabla = new DataTable();
            //Abrimos la conexion con la BD
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarRoles";
            //Especificamos que es mediante un procedimiento almacenado
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable ListarProveedores()
        {
            //Instancia la clase DataTable para almacenar los datos en ella
            DataTable Tabla = new DataTable();
            //Abrimos la conexion con la BD
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarProv";
            //Especificamos que es mediante un procedimiento almacenado
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable ListarCompras()
        {
            //Instancia la clase DataTable para almacenar los datos en ella
            DataTable Tabla = new DataTable();
            //Abrimos la conexion con la BD
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarCompras";
            //Especificamos que es mediante un procedimiento almacenado
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarInventario()
        {
            //Instancia la clase DataTable para almacenar los datos en ella
            DataTable Tabla = new DataTable();
            //Abrimos la conexion con la BD
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "VerInventario";
            //Especificamos que es mediante un procedimiento almacenado
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable InventarioVta()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "VerInvent";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable ConfirmarVta()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ConfirmarVta";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
    }
}
