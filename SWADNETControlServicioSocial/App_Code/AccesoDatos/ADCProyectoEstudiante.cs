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

    public void InsertarProyectoEstudiante(ECProyectoEstudiante eCProyectoEstudiante)
    {
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("InsertarProyectoEstudiante");

            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "@IdProyecto", DbType.Int32, eCProyectoEstudiante.IdProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "@IdEstudiante", DbType.Int32, eCProyectoEstudiante.IdEstudiante);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "@HoraAcumulada", DbType.Int32, eCProyectoEstudiante.HoraAcumulada);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "@HoraInicio", DbType.DateTime, eCProyectoEstudiante.HoraInicio);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "@HoraFinal", DbType.DateTime, eCProyectoEstudiante.HoraFinal);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "@LatitudInicial", DbType.String, eCProyectoEstudiante.LatitudInicial);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "@LongitudInicial", DbType.String, eCProyectoEstudiante.LongitudInicial);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "@LatitudFinal", DbType.String, eCProyectoEstudiante.LatitudFinal);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "@LongitudFinal", DbType.String, eCProyectoEstudiante.LongitudFinal);

            BDSWADNETControlServicioSocial.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {

            throw;
        }
    }
}