using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Trabajador
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();
        //Este valor ID es con el que vamos a trabajar los metodos CRUD que faltan

        
        public void AddEmail(string correo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AddMail";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@email", correo);

            comando.ExecuteNonQuery();
            /*Se sobre carga de parametros y no deja guardar registros por ende debe limpiarze */
            comando.Parameters.Clear();

        }
        //Este metodo solo se ejecutara si los txt no estan vacios
        public void MailEdit(string correo, string nuevoCorreo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MailUpdate";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@correoAntig", correo);
            comando.Parameters.AddWithValue("@newMail", nuevoCorreo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void AddUser(string user, string pass)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AddUser";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@loginName", user);
            comando.Parameters.AddWithValue("@password", pass);

            comando.ExecuteNonQuery();
            /*Se sobre carga de parametros y no deja guardar registros por ende debe limpiarze */
            comando.Parameters.Clear();

        }

        public void UsersUpdate(string usuario, string nuevoUsuario, string pass)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UsersUpdate";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@nuevoUsuario", nuevoUsuario);
            comando.Parameters.AddWithValue("@pass", pass);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void AgregarEmpleado(string firstName, string middleName, string fSurname, string sSurname, int idUser, int idMail,
            int idRol)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AddTrabajador";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@firstName", firstName);
            comando.Parameters.AddWithValue("@middleName", middleName);
            comando.Parameters.AddWithValue("@fSurname", fSurname);
            comando.Parameters.AddWithValue("@sSurname", sSurname);
            comando.Parameters.AddWithValue("@idUser", idUser);
            comando.Parameters.AddWithValue("@idMail", idMail);
            comando.Parameters.AddWithValue("@idRol", idRol);


            comando.ExecuteNonQuery();
            //Para no tener errores refrescamos
            comando.Parameters.Clear();
        }

        public void UpdateEmpleado(int ID, string FName, string SName, string FSurname, string SSurname, int IdRol)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UpdateEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdEmpleado", ID);
            comando.Parameters.AddWithValue("@NewFname", FName);
            comando.Parameters.AddWithValue("@NewSname", SName);
            comando.Parameters.AddWithValue("@NewFApell", FSurname);
            comando.Parameters.AddWithValue("@NewSApell", SSurname);
            comando.Parameters.AddWithValue("@idRol", IdRol);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DeleteEmpleado";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);

            comando.BeginExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}
