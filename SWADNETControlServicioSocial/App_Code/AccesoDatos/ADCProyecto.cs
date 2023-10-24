using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADCProyecto
/// </summary>
public class ADCProyecto
{
    Database BDSWADNETReciclado = SBaseDatos.BDSWADNETControlServicioSocial;
    #region Metodos Publicos
    public DTOCProyecto Obtener_CProyecto_O()
    {
        DTOCProyecto dTOCProyecto = new DTOCProyecto();
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("CProyecto_O");
            BDSWADNETControlServicioSocial.LoadDataSet(dbCommand, dTOCProyecto, "CProyecto");
        }
        catch (Exception ex)
        {

            throw;
        }
        return dTOCProyecto;
    }
    public DTOCProyecto Obtener_CProyecto_O_IdProyecto(int IdProyecto)
    {
        DTOCProyecto dTOCProyecto = new DTOCProyecto();
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("CProyecto_O_IdProyecto");
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "IdProyecto", System.Data.DbType.Int32, IdProyecto);
            BDSWADNETControlServicioSocial.LoadDataSet(dbCommand, dTOCProyecto, "CProyecto");
        }
        catch (SqlException SQLEx)
        {
            throw;
        }
        return dTOCProyecto;
    }

    public DTOCProyecto Obtener_CProyectoEstudiante_O_CProyecto(int idEstudiante)
    {
        DTOCProyecto dTOCProyecto = new DTOCProyecto();
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            // Ojo cambie su procedimiento almacenado
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("CProyectos_IdEstudiante");
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "IdEstudiante", System.Data.DbType.Int32, idEstudiante);
            BDSWADNETControlServicioSocial.LoadDataSet(dbCommand, dTOCProyecto, "CProyecto");
        }
        catch (SqlException SQLEx)
        {
            throw;
        }
        return dTOCProyecto;
    }
    #endregion
}