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
    
    public partial class EntitiesSeguAcceso : DbContext
    {
        public EntitiesSeguAcceso()
            : base("name=EntitiesSeguAcceso")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<seg_Menu> seg_Menu { get; set; }
        public DbSet<seg_Menu_Categoria> seg_Menu_Categoria { get; set; }
        public DbSet<seg_Menu_Grupo> seg_Menu_Grupo { get; set; }
        public DbSet<seg_Menu_Grupo_x_seg_Menu_Item> seg_Menu_Grupo_x_seg_Menu_Item { get; set; }
        public DbSet<seg_Menu_Item> seg_Menu_Item { get; set; }
        public DbSet<seg_Menu_Item_Tipo> seg_Menu_Item_Tipo { get; set; }
        public DbSet<seg_Menu_Pagina> seg_Menu_Pagina { get; set; }
        public DbSet<seg_Menu_x_Empresa> seg_Menu_x_Empresa { get; set; }
        public DbSet<seg_Menu_x_Empresa_x_Usuario> seg_Menu_x_Empresa_x_Usuario { get; set; }
        public DbSet<seg_usuario> seg_usuario { get; set; }
        public DbSet<seg_Usuario_x_Empresa> seg_Usuario_x_Empresa { get; set; }
        public DbSet<seg_usuario_x_tb_sis_reporte> seg_usuario_x_tb_sis_reporte { get; set; }
        public DbSet<vwseg_Menu_x_Usuario_x_Empresa> vwseg_Menu_x_Usuario_x_Empresa { get; set; }
        public DbSet<vwseg_Usuario_x_Empresa> vwseg_Usuario_x_Empresa { get; set; }
        public DbSet<vwseg_usuario_x_tb_sis_reporte> vwseg_usuario_x_tb_sis_reporte { get; set; }
        public DbSet<vw_Seg_Menu_x_Usuario_x_Empresa> vw_Seg_Menu_x_Usuario_x_Empresa { get; set; }
    }
}
