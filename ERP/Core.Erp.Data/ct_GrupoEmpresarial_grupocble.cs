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
    
    public partial class ct_GrupoEmpresarial_grupocble
    {
        public ct_GrupoEmpresarial_grupocble()
        {
            this.ct_GrupoEmpresarial_plancta = new HashSet<ct_GrupoEmpresarial_plancta>();
        }
    
        public string IdGrupoCble_gr { get; set; }
        public string gc_GrupoCble_gr { get; set; }
        public int gc_Orden { get; set; }
        public string gc_estado_financiero { get; set; }
        public int gc_signo_operacion { get; set; }
    
        public virtual ICollection<ct_GrupoEmpresarial_plancta> ct_GrupoEmpresarial_plancta { get; set; }
    }
}
