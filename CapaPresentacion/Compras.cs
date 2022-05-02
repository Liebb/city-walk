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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }
        /*Nulo para que no ocupe espacion en memoria*/
        public string idProducto = null;
        //Para añadir a inventario y detalle compra
        public string idDetalleC = null;
        //Para calcular el total
        public double total;

        Form1 form1 = new Form1();
        public void ListarProductos()
        {
            Listar obj = new Listar();
            dtgProductos.DataSource = obj.ListarProveedores();
        }

        public void ListarComprasD()
        {
            Listar obj = new Listar();
            dtgProductos.DataSource = obj.ListarCompras();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            ListarProductos();
            //Valores del Combo Box

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (dtgProductos.SelectedRows.Count == 1)
            {
                txtDescripcion.Text = dtgProductos.CurrentRow.Cells["Tipo"].Value.ToString();
                txtMarca.Text = dtgProductos.CurrentRow.Cells["Marca"].Value.ToString();
                txtPrecio.Text = dtgProductos.CurrentRow.Cells["Costo"].Value.ToString();
                txtFabricacion.Text = dtgProductos.CurrentRow.Cells["Fabricación"].Value.ToString();
                idProducto = dtgProductos.CurrentRow.Cells["ID"].Value.ToString();

                Visible();
                txtCantidad.Focus();
               
                
            }
            
        }

        //Hacer visible los detalles

        private new void Visible()
        {
            lblDesc.Visible = true;
            txtDescripcion.Visible = true;
            label3.Visible = true;
            txtMarca.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            txtPrecio.Visible = true;
            label4.Visible = true;
            txtFabricacion.Visible = true;
            label5.Visible = true;
            btnAceptar.Visible = true;
            lineShape1.Visible = true;
            btnLogo.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            label9.Visible = true;
            txtPrecioVta.Visible = true;
            lblPrecioVta.Visible = true;
            txtCantidad.Visible = true;
            txtIva.Visible = true;
        }

        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //En este y varios puntos una forma de validar es que cuando hagamos migracion de datos no podamos presionar
            //otros botones
            CN_Compra objComp = new CN_Compra();
            //Realizar los respectivos calculos del iva
            const float iva = 0.15F;
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            float precio = float.Parse(txtPrecio.Text);

            float valorIVA = (cantidad * precio) * iva;
            total = (precio * cantidad) + valorIVA;

            objComp.InsertCompraDet(txtCantidad.Text, valorIVA, (cantidad * precio), idProducto);

            MessageBox.Show("Se ha guardado con exito en la base de datos");
            ListarComprasD();
            lblTitulo.Text = "Por favor elija la ultima compra para añadirla al inventario";
            btnSendInven.Visible = true;
            lblConfirmar.Visible = true;
            btnAceptar.Enabled = false;
            btnEnviar.Enabled = false;
            txtCantidad.Enabled = false;
        }


        
        private void btnSendInven_Click(object sender, EventArgs e)
        {
            //FALTARIA MOSTRAR: UNA FACTURA CON LAS CREDENCIALES Y LO MAS IMPORTANTE GUARDA LA TABLA DE DETALLE ANTES Y ESO PUEDE GENERAR UN BUG
            CN_Compra objComp = new CN_Compra();

            if (dtgProductos.CurrentRow.Index == 0)
            {
                idDetalleC = dtgProductos.CurrentRow.Cells["ID"].Value.ToString();
                //Añadido a la tabla de inventario
                objComp.InsertarCompra(idDetalleC,total); ;
                objComp.SetIven(idDetalleC,txtCantidad.Text,txtPrecioVta.Text);
                MessageBox.Show("Por favor verifique el inventario de productos", "Los datos se guardaron perfectamente", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                form1.AbrirFormEnPanel(new productos());
                this.Hide();
                
                
            }
            else
                MessageBox.Show("Debe elegir la ultima compra ");
        }


    }
}
