using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ventas2.Models
{
    public class producto
    {
        public int IdpOrducto { get; set; }
        public string NombrewProducto { get; set; }
        public float Precio { get; set; }
        public List<Models.tipoProducto> Categoria { get; set; }

        public List<Models.Sucursal> Nombre { get; set; }
        

    }
}