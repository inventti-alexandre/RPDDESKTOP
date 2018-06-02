﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
  public  class ro_Horario_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdHorario { get; set; }
        public System.TimeSpan HoraIni { get; set; }
        public System.TimeSpan HoraFin { get; set; }
        public int ToleranciaEnt { get; set; }
        public int ToleranciaReg_lunh { get; set; }
        public System.TimeSpan SalLunch { get; set; }
        public System.TimeSpan RegLunch { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }
        public bool CheckDefault { get; set; }
        public bool Check { get; set; }

        public ro_Horario_Info()
        {

        }

        public TimeSpan TotalHoras { get; set; }
    }
}
