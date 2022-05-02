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
    public partial class MailsAdd : Form
    {
        public MailsAdd()
        {
            InitializeComponent();
        }

        //Instancia de la clase de negocios Trabajador
        CN_Trabajador objTrabajador = new CN_Trabajador();


        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            AddCorreo();           
        }

        private void AddCorreo()
        {
            if (txtCorreo.Text != string.Empty)
            {
                objTrabajador.AddCorreo(txtCorreo.Text);
                lineVertical.Visible = true;
                lblUserLogin.Visible = true;
                txtUserLogin.Visible = true;
                lblPassword.Visible = true;
                txtPassWord.Visible = true;
                btAceptar2.Visible = true;
                //Desactivamos el resto

                txtCorreo.Enabled = false;
                btnAceptar.Enabled = false;
                btnAtras.Enabled = false;

            }
            else
                errorProviderCorreo.SetError(txtCorreo, "Este campo no puede estar vacio");
        }

        private void btAceptar2_Click(object sender, EventArgs e)
        {
            if (EmptyData(txtUserLogin.Text, txtPassWord.Text) == false)
            {
                objTrabajador.AddUsuario(txtUserLogin.Text, txtPassWord.Text);
                AddEmpleado objAddEmpleados = new AddEmpleado();

                objAddEmpleados.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Por Favor verifique que los datos estén correctos", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        public bool EmptyData(string usuario, string contra)
        {
            if (usuario == string.Empty || contra == string.Empty)
                return true;
            else
                return false;
            
        }
    }
}
