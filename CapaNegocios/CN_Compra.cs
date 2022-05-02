using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
   public class CN_Compra
    {
        CD_Compra objCompra = new CD_Compra();
        /*Este metodo debe llamarse en donde queramos meter los datos*/
        public void InsertCompraDet(string cantidad, float iva, float subtotal,string idProv)
        {
            objCompra.InsertDetalleCompra( Convert.ToInt32(cantidad), iva, subtotal,Convert.ToInt32(idProv));

        }

        public void InsertarCompra(string detalleID, double total)
        {
            objCompra.CompraAdd(Convert.ToInt32(detalleID),total);
        }

        public void SetIven(string idProd, string cantidad, string precioVta)
        {
            objCompra.SetInvent(Convert.ToInt32(idProd),Convert.ToInt32(cantidad), float.Parse(precioVta));
        }
    }
}
