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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
            VerEmpleados();
        }

        private string idTrabajador = null;
        //Guarda el valor temporal del correo a editar
        private string mailCache = null;
        //Cache para los datos de usuario
        private string userName = null;


        CN_Trabajador objTrab = new CN_Trabajador();
        private void VerEmpleados()
        {
            Listar objList = new Listar();
           dtgEmpleados.DataSource =  objList.VerEmpleados();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MailsAdd objMailsAdd = new MailsAdd();
            objMailsAdd.Show();
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar al trabajador?","Advertencia",MessageBoxButtons.YesNo
                ,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dtgEmpleados.SelectedRows.Count > 0)
                {
                    idTrabajador = dtgEmpleados.CurrentRow.Cells["ID"].Value.ToString();
                    objTrab.DeleteEmpleado(idTrabajador);
                    //Esto deberia ser solo si se guarda bien en la BD y no porque si
                    MessageBox.Show("El trbajador se ha eliminado correctamente");
                    VerEmpleados();


                }
                else
                {
                    MessageBox.Show("Por favor inserte la fila a editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se borrará ningún empleado","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Recordar lo sig: Al ser tablas distintas deben ser 3 SP de updates para cada tabla

            if (dtgEmpleados.SelectedRows.Count > 0)
            {
                //Variable que indique la edicion
                idTrabajador = dtgEmpleados.CurrentRow.Cells["ID"].Value.ToString();
                txtFirstName.Text = dtgEmpleados.CurrentRow.Cells["Primer Nombre"].Value.ToString();
                txtSecondName.Text = dtgEmpleados.CurrentRow.Cells["Segundo Nombre"].Value.ToString();
                txtFApellido.Text = dtgEmpleados.CurrentRow.Cells["Primer Apellido"].Value.ToString();
                txtSApellido.Text = dtgEmpleados.CurrentRow.Cells["Segundo Apellido"].Value.ToString();
                txtUserName.Text = dtgEmpleados.CurrentRow.Cells["Nombre de usuario"].Value.ToString();
                userName = txtUserName.Text;
                txtPass.Text = dtgEmpleados.CurrentRow.Cells["Contraseña"].Value.ToString();
                txtEmail.Text = dtgEmpleados.CurrentRow.Cells["Correo"].Value.ToString();
                //Le asigno el valor a el mailCache
                mailCache = txtEmail.Text;
                txtOficio.Text = dtgEmpleados.CurrentRow.Cells["Oficio"].Value.ToString();
                //FALTA Bloquear las demas opciones del crud
                MostarBotones();
                txtFirstName.Focus();

            }
            else
                MessageBox.Show("Debe seleccionar un empleado","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void MostarBotones()
        {
            lineVertical.Visible = true;
            lblFirstName.Visible = true;
            txtFirstName.Visible = true;
            lblSecondName.Visible = true;
            txtSecondName.Visible = true;
            lblFApellido.Visible = true;
            txtFApellido.Visible = true;
            lblSApellido.Visible = true;
            txtSApellido.Visible = true;
            lblUserName.Visible = true;
            txtUserName.Visible = true;
            lblPass.Visible = true;
            txtPass.Visible = true;
            txtEmail.Visible = true;
            lblEmail.Visible = true;
            lblOficio.Visible = true;
            txtOficio.Visible = true;
            lblRol.Visible = true;
            cboxRoles.Visible = true;
            btnSveChanges.Enabled = true;
            btnSveChanges.Visible = true;

            //Bloquear los controles del CRUD
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;

            ListarRoles();
        }
        private void OcultarBotones()
        {
            lineVertical.Visible = false;
            lblFirstName.Visible = false;
            txtFirstName.Visible = false;
            lblSecondName.Visible = false;
            txtSecondName.Visible = false;
            lblFApellido.Visible = false;
            txtFApellido.Visible = false;
            lblSApellido.Visible = false;
            txtSApellido.Visible = false;
            lblUserName.Visible = false;
            txtUserName.Visible = false;
            lblPass.Visible = false;
            txtPass.Visible = false;
            txtEmail.Visible = false;
            lblEmail.Visible = false;
            lblOficio.Visible = false;
            txtOficio.Visible = false;
            lblRol.Visible = false;
            cboxRoles.Visible = false;
            btnSveChanges.Visible = false;
            //desbloquear los controles del CRUD
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnAdd.Enabled = true;

        }

        public void ListarRoles()
        {
            Listar objList = new Listar();

            cboxRoles.DataSource = objList.ListarRoles();
            cboxRoles.DisplayMember = "rol";
            cboxRoles.ValueMember = "idRol";

        }

        private void btnSveChanges_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty && txtUserName.Text != string.Empty && txtPass.Text != string.Empty
                && txtFirstName.Text != string.Empty && txtSecondName.Text != string.Empty && txtFApellido.Text !=
                string.Empty && txtSApellido.Text != string.Empty)
            {
                //Guardar primero el CORREO}
                objTrab.MailUpdate(mailCache, txtEmail.Text);
                //Ahora Guardar los datos de usuario
                objTrab.UserUpdate(userName, txtUserName.Text, txtPass.Text);
                //Guardar en la tabla trabajadores
                objTrab.UpdateEmpleado(idTrabajador, txtFirstName.Text, txtSecondName.Text, txtFApellido.Text, txtSApellido.Text,
                    Convert.ToInt32(cboxRoles.SelectedValue));
                MessageBox.Show("Los datos se han guardado correctamente","Guardado Correctamente",MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                OcultarBotones();
                VerEmpleados();
            }
            else
                MessageBox.Show("Por favor asegurese que todos los datos estén correctos", "Error al guardar", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);

        }

        
    }
}
