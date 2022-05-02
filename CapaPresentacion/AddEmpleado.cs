using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;


namespace CapaPresentacion
{
    public partial class AddEmpleado : Form
    {
        public AddEmpleado()
        {
            InitializeComponent();
            ListarUsuarios();
            ListarCorreos();
            ListarRoles();
        }

        public void ListarUsuarios()
        {
            Listar objList = new Listar();

            cboxUsuario.DataSource = objList.ListarUsuarios();
            cboxUsuario.DisplayMember = "loginName";
            cboxUsuario.ValueMember = "userID";

        }

        public void ListarCorreos()
        {
            Listar objList = new Listar();

            cboxCorreo.DataSource = objList.ListarCorreos();
            cboxCorreo.DisplayMember = "email";
            cboxCorreo.ValueMember = "idEmail";

        }

        public void ListarRoles()
        {
            Listar objList = new Listar();

            cboxRoles.DataSource = objList.ListarRoles();
            cboxRoles.DisplayMember = "rol";
            cboxRoles.ValueMember = "idRol";

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Insertar();                                 
        }

        private void Insertar()
        {
            if (DataEmpty(txtFirstName.Text, txtMiddleName.Text, txtFSurname.Text, txtSSurname.Text) == false)
            {
                CN_Trabajador objTrab = new CN_Trabajador();

                objTrab.AddEmpleado(txtFirstName.Text, txtMiddleName.Text, txtFSurname.Text, txtSSurname.Text
                    , Convert.ToInt32(cboxUsuario.SelectedValue), Convert.ToInt32(cboxCorreo.SelectedValue)
                    , Convert.ToInt32(cboxRoles.SelectedValue));
                MessageBox.Show("Los datos se guardaron correctamente", "Información guardada", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Hide();
            }
            else
                MessageBox.Show("Por Favor verifique que los datos estén correctos", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private bool DataEmpty(string firstName, string middleName, string FSurname, string Ssurname)
        {
            if (firstName == string.Empty || middleName == string.Empty || FSurname == string.Empty ||
                Ssurname == string.Empty)
                return true;
            else
                return false;             
        }
    }
}
