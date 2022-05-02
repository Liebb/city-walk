using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocios;
using Common;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = string.Empty;
                txtUser.ForeColor = Color.Maroon;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == string.Empty)
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.Maroon;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = string.Empty;
                txtPass.ForeColor = Color.Maroon;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == string.Empty)
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.Maroon;
                /*Para que ahora si se vea lo que dice el text box*/
                txtPass.UseSystemPasswordChar = false;

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "USUARIO")
            {
                if (txtPass.Text != "CONTRASEÑA")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUser.Text, txtPass.Text);
                    if (validLogin == true)
                    {
                        Form1 menu = new Form1();
                        MessageBox.Show("¡Bienvenido de nuevo "+Class1.FirstName+ " "+Class1.Fsurname + "!"
                            ,"Bievenido",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        menu.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        msgError("El usuario o contraseña ingresado no existen");

                        
                        txtUser.Focus();
                    }
                }
                else
                {
                    msgError("Por favor ingrese su contraseña");
                }
            }
            else
            {
                msgError("Por favor ingrese su nombre de usuario");
            }
        }

        public void msgError(string tipoError)
        {
            lblError.Text = tipoError;
            lblError.Visible = true;
            pboxError.Visible = true;
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txtUser.Text != "USUARIO")
                {
                    if (txtPass.Text != "CONTRASEÑA")
                    {
                        UserModel user = new UserModel();
                        var validLogin = user.LoginUser(txtUser.Text, txtPass.Text);
                        if (validLogin == true)
                        {
                            Form1 menu = new Form1();
                            MessageBox.Show("¡Bienvenido de nuevo " + Class1.FirstName + " " + Class1.Fsurname + "!"
                           , "Bievenido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            menu.Show();
                            this.Hide();

                        }
                        else
                        {
                            msgError("El usuario o contraseña ingresado no existen");


                            txtUser.Focus();
                        }
                    }
                    else
                    {
                        msgError("Por favor ingrese su contraseña");
                    }
                }
                else
                {
                    msgError("Por favor ingrese su nombre de usuario");
                }
            }
        }

        
    }

   
}
