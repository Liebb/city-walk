using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Ventas
    {
        CD_Ventas objVentas = new CD_Ventas();

        public void InsertarDetalleVtas(string idProd, DateTime date, string nombreC, float iva, float subtotal, int cantidadVendida)
        {
            objVentas.DetalleVta(Convert.ToInt32(idProd), date, nombreC, iva, subtotal,cantidadVendida);
        }

        public void InsertarVentas(string idDetalle, string vendedor,float total)
        {
            objVentas.tbVenta(Convert.ToInt32(idDetalle),vendedor,total);
        }

        public void CrearRespaldo()
        {
            objVentas.RespaldoVenta();
        }
    }
}
