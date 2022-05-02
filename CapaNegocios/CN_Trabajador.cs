using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadimos sus respectivas directivas
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
namespace CapaNegocios
{
   public class CN_Trabajador
    {


        CD_Trabajador objTrab = new CD_Trabajador();

          public void AddCorreo(string correo)
        {
            objTrab.AddEmail(correo);
            
        }

        public void AddUsuario(string usuario,string contra)
        {
            objTrab.AddUser(usuario, contra);
            
        }
      public void AddEmpleado(string firstName, string middleName, string fSurname, string sSurname, int idUser, int idMail,
            int idRol)
       {
            objTrab.AgregarEmpleado(firstName, middleName, fSurname, sSurname, idUser, idMail, idRol);
       }

        public void DeleteEmpleado(string id)
        {
            objTrab.Eliminar(Convert.ToInt32(id));
        }
        
        public void MailUpdate (string correo, string nuevoCorreo)
        {
            objTrab.MailEdit(correo, nuevoCorreo);
        }

        public void UserUpdate(string usuario, string nuevoUsuario, string pass)
        {
            objTrab.UsersUpdate(usuario, nuevoUsuario, pass);
        }

        public void UpdateEmpleado(string ID, string FName, string SName, string FSurname, string SSurname, int IdRol)
        {
            objTrab.UpdateEmpleado(Convert.ToInt32(ID), FName, SName, FSurname, SSurname, IdRol);
        }
    }
}
