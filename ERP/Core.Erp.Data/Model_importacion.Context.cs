﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities_importacion : DbContext
    {
        public Entities_importacion()
            : base("name=Entities_importacion")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<imp_catalogo> imp_catalogo { get; set; }
        public DbSet<imp_catalogo_tipo> imp_catalogo_tipo { get; set; }
        public DbSet<imp_gasto> imp_gasto { get; set; }
        public DbSet<imp_parametro> imp_parametro { get; set; }
        public DbSet<imp_gasto_x_ct_plancta> imp_gasto_x_ct_plancta { get; set; }
        public DbSet<imp_orden_compra_ext_recepcion> imp_orden_compra_ext_recepcion { get; set; }
        public DbSet<imp_orden_compra_ext_ct_cbteble_det_gastos> imp_orden_compra_ext_ct_cbteble_det_gastos { get; set; }
        public DbSet<vwimp_orden_compra_ext_ct_cbteble_det_gastos> vwimp_orden_compra_ext_ct_cbteble_det_gastos { get; set; }
        public DbSet<imp_liquidacion_det_x_imp_orden_compra_ext> imp_liquidacion_det_x_imp_orden_compra_ext { get; set; }
        public DbSet<imp_orden_compra_ext_det> imp_orden_compra_ext_det { get; set; }
        public DbSet<imp_liquidacion> imp_liquidacion { get; set; }
        public DbSet<imp_orden_compra_ext> imp_orden_compra_ext { get; set; }
    }
}
