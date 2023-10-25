using System;
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
    public DTOCProyectoEstudiante Obtener_CProyectoEstudiante_O_IdEstudiante(int IdEstudiante)
    {
        DTOCProyectoEstudiante dTOCProyectoEstudiante = new DTOCProyectoEstudiante();
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("CProyectoEstudiante_O_IdEstudiante");
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "IdEstudiante", System.Data.DbType.Int32, IdEstudiante);
            BDSWADNETControlServicioSocial.LoadDataSet(dbCommand, dTOCProyectoEstudiante, "CProyectoEstudiante");
        }
        catch (Exception ex)
        {

            throw;
        }
        return dTOCProyectoEstudiante;
    }
    public DTOCProyecto Obtener_CProyectoEstudiante_O_CProyecto(int IdEstudiante)
    {
        DTOCProyecto dTOCProyecto = new DTOCProyecto();
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("CProyectoEstudiante_O_CProyecto");
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "IdEstudiante", System.Data.DbType.Int32, IdEstudiante);
            BDSWADNETControlServicioSocial.LoadDataSet(dbCommand, dTOCProyecto, "CProyecto");
        }
        catch (Exception ex)
        {

            throw;
        }
        return dTOCProyecto;
    }

    public void Actualizar_CProyectoEstudiante_A_Inicio(ECProyectoEstudiante eCProyectoEstudiante)
    {
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("Actualizar_CProyectoEstudiante_A_Inicio");
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "IdEstudiante", System.Data.DbType.Int32, eCProyectoEstudiante.IdEstudiante);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "HoraInicio", System.Data.DbType.DateTime,eCProyectoEstudiante.HoraInicio);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "LatitudInicial",System.Data.DbType.String,eCProyectoEstudiante.LatitudInicial);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "LongitudInicial", System.Data.DbType.String,eCProyectoEstudiante.LongitudInicial);
            BDSWADNETControlServicioSocial.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public void Actualizar_CProyectoEstudiante_A_HoraAcumulada(ECProyectoEstudiante eCProyectoEstudiante)
    {
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("Actualizar_CProyectoEstudiante_A_HoraAcumulada");
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "IdEstudiante", System.Data.DbType.Int32, eCProyectoEstudiante.IdEstudiante);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "HoraFinal", System.Data.DbType.DateTime, eCProyectoEstudiante.HoraFinal);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "LatitudFinal", System.Data.DbType.String, eCProyectoEstudiante.LatitudFinal);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "LongitudFinal", System.Data.DbType.String, eCProyectoEstudiante.LongitudFinal);
            BDSWADNETControlServicioSocial.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {

            throw;
        }
    }
}