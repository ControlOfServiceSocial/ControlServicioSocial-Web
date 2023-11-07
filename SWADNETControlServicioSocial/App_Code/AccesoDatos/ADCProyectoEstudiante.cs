using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;

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

    public DTOCProyectoEstudiante ObtenerCProyectoEstudiantePorIds(int idProyecto, int idEstudiante)
    {
        DTOCProyectoEstudiante dTOCProyectoEstudiante = new DTOCProyectoEstudiante();
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("ObtenerCProyectoEstudiantePorIds");

            // Agrega los parámetros al comando
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "@IdProyecto", DbType.Int32, idProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "@IdEstudiante", DbType.Int32, idEstudiante);

            BDSWADNETControlServicioSocial.LoadDataSet(dbCommand, dTOCProyectoEstudiante, "CProyectoEstudiante");
        }
        catch (Exception ex)
        {
            throw;
        }
        return dTOCProyectoEstudiante;
    }

    public DTOCProyectoEstudiante ObtenerCProyectoEstudiantePorIdEstudiante(int idEstudiante)
    {
        DTOCProyectoEstudiante dTOCProyectoEstudiante = new DTOCProyectoEstudiante();
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("ObtenerCProyectoEstudiantePorIdEstudiante");
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "@IdEstudiante", DbType.Int32, idEstudiante);
            BDSWADNETControlServicioSocial.LoadDataSet(dbCommand, dTOCProyectoEstudiante, "CProyectoEstudiante");
        }
        catch (Exception ex)
        {
            throw;
        }
        return dTOCProyectoEstudiante;
    }
}