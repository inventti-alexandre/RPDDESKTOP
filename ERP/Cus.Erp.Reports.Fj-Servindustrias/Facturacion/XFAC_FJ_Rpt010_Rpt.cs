﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt010_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XFAC_FJ_Rpt010_Rpt()
        {
            InitializeComponent();
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XFAC_FJ_Rpt010_Info> lst_rpt = new List<XFAC_FJ_Rpt010_Info>();
        XFAC_FJ_Rpt010_Bus bus_rpt = new XFAC_FJ_Rpt010_Bus();
        private void XFAC_FJ_Rpt010_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lst_rpt=bus_rpt.get_list(param.IdEmpresa,IdCentroCosto.Value.ToString(),IdCentroCosto_sub_centro_costo.Value.ToString(),Convert.ToInt32( IdPeriodo_ini.Value),Convert.ToInt32( IdPeriodo_fin.Value),Convert.ToInt32( IdPunto_cargo.Value)); 
                lb_empresa.Text = param.InfoEmpresa.NombreComercial;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                lb_periodo.Text ="Periodo desde "+ IdPeriodo_ini.Value.ToString() + " hasta " + IdPeriodo_fin.Value.ToString();
                this.DataSource = lst_rpt;
            }
            catch (Exception)
            {
                
            }
        }

    }
}
