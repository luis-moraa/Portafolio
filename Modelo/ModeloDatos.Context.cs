﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AlmacenEntities : DbContext
    {
        public AlmacenEntities()
            : base("name=AlmacenEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ABONO> ABONO { get; set; }
        public virtual DbSet<BOLETA> BOLETA { get; set; }
        public virtual DbSet<CATEGORIA> CATEGORIA { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<DETALLE_BOLETA> DETALLE_BOLETA { get; set; }
        public virtual DbSet<DETALLE_PEDIDO> DETALLE_PEDIDO { get; set; }
        public virtual DbSet<ESTADO_FIADO> ESTADO_FIADO { get; set; }
        public virtual DbSet<ESTADO_ORDEN> ESTADO_ORDEN { get; set; }
        public virtual DbSet<MEDIO_PAGO> MEDIO_PAGO { get; set; }
        public virtual DbSet<ORDEN_PEDIDO> ORDEN_PEDIDO { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTO { get; set; }
        public virtual DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public virtual DbSet<REGISTRO_FIADO> REGISTRO_FIADO { get; set; }
        public virtual DbSet<TIPO_CLIENTE> TIPO_CLIENTE { get; set; }
        public virtual DbSet<TIPO_RUBRO> TIPO_RUBRO { get; set; }
        public virtual DbSet<TIPO_USUARIO> TIPO_USUARIO { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
    
        public virtual int SP_ACTUALIZARPRECIO2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ACTUALIZARPRECIO2");
        }
    }
}
