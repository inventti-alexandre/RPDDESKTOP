﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntitiesCaja : DbContext
    {
        public EntitiesCaja()
            : base("name=EntitiesCaja")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<vwcaj_MovCaja_x_Cobro_Anticipo> vwcaj_MovCaja_x_Cobro_Anticipo { get; set; }
        public DbSet<vwcaj_caj_Caja> vwcaj_caj_Caja { get; set; }
        public DbSet<vwcaj_Caja_Movimiento_x_Conciliar> vwcaj_Caja_Movimiento_x_Conciliar { get; set; }
        public DbSet<vwCaj_Talonario_Recibo> vwCaj_Talonario_Recibo { get; set; }
        public DbSet<caj_parametro> caj_parametro { get; set; }
        public DbSet<Caj_Talonario_Recibo> Caj_Talonario_Recibo { get; set; }
        public DbSet<caj_Caja_Movimiento_Tipo_grupo> caj_Caja_Movimiento_Tipo_grupo { get; set; }
        public DbSet<caj_Caja> caj_Caja { get; set; }
        public DbSet<caj_Caja_Movimiento_Tipo> caj_Caja_Movimiento_Tipo { get; set; }
        public DbSet<caj_Caja_Movimiento_Tipo_x_CtaCble> caj_Caja_Movimiento_Tipo_x_CtaCble { get; set; }
        public DbSet<caj_catalogo> caj_catalogo { get; set; }
        public DbSet<caj_catalogo_tipo> caj_catalogo_tipo { get; set; }
        public DbSet<vwcaj_Caja_Movimiento_Tipo_conCta> vwcaj_Caja_Movimiento_Tipo_conCta { get; set; }
        public DbSet<caj_Caja_Movimiento> caj_Caja_Movimiento { get; set; }
        public DbSet<caj_Caja_Movimiento_det> caj_Caja_Movimiento_det { get; set; }
        public DbSet<vwcaj_caj_Caja_Movimiento> vwcaj_caj_Caja_Movimiento { get; set; }
        public DbSet<vwcaj_Caja_Movimiento_det_cancelado> vwcaj_Caja_Movimiento_det_cancelado { get; set; }
        public DbSet<vwcaj_Movi_x_Despositar> vwcaj_Movi_x_Despositar { get; set; }
        public DbSet<vwcaj_MovCaja_x_Cobro> vwcaj_MovCaja_x_Cobro { get; set; }
        public DbSet<vwcaj_Caja_Movimiento_Tipo> vwcaj_Caja_Movimiento_Tipo { get; set; }
    }
}
