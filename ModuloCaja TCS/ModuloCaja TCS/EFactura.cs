using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCaja_TCS
{
    class EFactura
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string mesa { get; set; }
       
        public double subtotal { get; set; }
        public double iva { get; set; }
        public double total { get; set; }
        public DateTime FechaFacturacion { get; set; }

        //Creamos una lista con una nueva Instancia de la clase Articulo
        //esta lista contendra el detalle de la factura
        public List<EDetalle> Detail = new List<EDetalle>();
    }
}
