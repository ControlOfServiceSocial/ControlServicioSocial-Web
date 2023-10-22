﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

/// <summary>
/// Descripción breve de ADCProyectoEstudiante
/// </summary>
public class ADCProyectoEstudiante
{
    public ADCProyectoEstudiante()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public DTOCProyectoEstudiante Obtener_CProyectoEstudiante_O()
    {
        DTOCProyectoEstudiante dTOCProyectoEstudiante = new DTOCProyectoEstudiante();
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("CProyectoEstudiante_O");
            BDSWADNETControlServicioSocial.LoadDataSet(dbCommand, dTOCProyectoEstudiante, "CProyectoEstudiante");
        }
        catch (Exception ex)
        {

            throw;
        }
        return dTOCProyectoEstudiante;
    }
}