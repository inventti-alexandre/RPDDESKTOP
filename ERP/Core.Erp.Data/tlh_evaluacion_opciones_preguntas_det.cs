//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tlh_evaluacion_opciones_preguntas_det
    {
        public tlh_evaluacion_opciones_preguntas_det()
        {
            this.tlh_evaluacion_opciones_preguntas_respuesta_det = new HashSet<tlh_evaluacion_opciones_preguntas_respuesta_det>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdPregunta { get; set; }
        public int secuencia { get; set; }
        public string Descripcion_opcion { get; set; }
    
        public virtual tlh_evaluacion_opciones_preguntas tlh_evaluacion_opciones_preguntas { get; set; }
        public virtual ICollection<tlh_evaluacion_opciones_preguntas_respuesta_det> tlh_evaluacion_opciones_preguntas_respuesta_det { get; set; }
    }
}
