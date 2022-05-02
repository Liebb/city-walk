﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Estas seguro de que quieres salir?", "Advertencia", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes) 
            {
                Application.Exit();
            }
                         
        }

        private void LoadUserData()
        {
            lblNombre.Text = "Trabajador: "+Class1.FirstName + " " + Class1.Fsurname;
            lblRol.Text = "Cargo: " +Class1.Rol;
            lblUsuario.Text = "Nombre de usuario: " + Class1.UserLogin;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btninicio_Click(null ,e);
            LoadUserData();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
        }

        private void btnrptventa_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            CN_Ventas objV = new CN_Ventas();
            objV.CrearRespaldo();
            MessageBox.Show("¡Se ha creado el respaldo de ventas!");
        }

        private void btnrptcompra_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnrptpagos_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
           
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new productos());          
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new inicio());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?","Adverencia",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Compras());
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Empleados());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Ventas());
        }
    }
}
