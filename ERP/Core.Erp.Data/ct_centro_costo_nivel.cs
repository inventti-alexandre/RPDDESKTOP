//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ct_centro_costo_nivel
    {
        public ct_centro_costo_nivel()
        {
            this.ct_centro_costo = new HashSet<ct_centro_costo>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdNivel { get; set; }
        public string ni_descripcion { get; set; }
        public byte ni_digitos { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transaccion { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
    
        public virtual ICollection<ct_centro_costo> ct_centro_costo { get; set; }
    }
}
