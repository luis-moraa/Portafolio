//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_ORDEN_PEDIDO
    {
        public decimal NUMERO { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public int TOTAL { get; set; }
        public System.DateTime FECHA_RECEPCION { get; set; }
        public decimal PROVEEDOR_RUT { get; set; }
        public string PROVEEDOR { get; set; }
        public decimal IDESTADO { get; set; }
        public string ESTADO_ORDEN { get; set; }
        public string USUARIO { get; set; }
    }
}
