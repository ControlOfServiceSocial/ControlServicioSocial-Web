using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
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

    #region insert de proyectos
    public void Insertar_CProyecto_I(ECProyecto eCProyecto)
    {
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("CProyecto_I");

            // Configura los parámetros del procedimiento almacenado con los datos del proyecto.
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "NombreProyecto", DbType.String, eCProyecto.NombreProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "DescripcionProyecto", DbType.String, eCProyecto.DescripcionProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "UbicacionProyecto", DbType.String, eCProyecto.UbicacionProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "EstadoProyecto", DbType.Byte, eCProyecto.EstadoProyecto);
            // Configura el parámetro de ImagenProyecto como byte[]
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "ImagenProyecto", DbType.String, eCProyecto.ImagenProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "HorasEstimadas", DbType.Byte, eCProyecto.HorasEstimadas);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "FechaInicioProyecto", DbType.Date, eCProyecto.FechaInicioProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "FechaFinProyecto", DbType.Date, eCProyecto.FechaFinProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "FechaCreacionProyecto", DbType.DateTime, eCProyecto.FechaCreacionProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "IdSede", DbType.Int32, eCProyecto.IdSede);
            // Ejecuta el procedimiento almacenado para realizar la inserción.
            BDSWADNETControlServicioSocial.ExecuteNonQuery(dbCommand);
        }
        catch (SqlException SQLEx)
        {
            // Maneja las excepciones aquí, puedes descomentar y personalizar esta parte para manejar los errores de acuerdo a tus necesidades.
        }

    }
    #endregion


    #region get de un proyecto
    public DTOCProyecto Obtener_CProyecto_O_ID(int Idproyecto)
    {
        DTOCProyecto dTOCProyecto = new DTOCProyecto();
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("CProyecto_O_ID");

            // Configura los parámetros del procedimiento almacenado con los datos del proyecto.
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "IdProyecto", DbType.String, Idproyecto);

            // Ejecuta el procedimiento almacenado para realizar la inserción.
            BDSWADNETControlServicioSocial.LoadDataSet(dbCommand, dTOCProyecto, "CProyecto");
        }
        catch (SqlException SQLEx)
        {
            // Maneja las excepciones aquí, puedes descomentar y personalizar esta parte para manejar los errores de acuerdo a tus necesidades.
        }
        return dTOCProyecto;

    }
    #endregion

    #region update de un proyecto
    public void Actualizar_CProyecto_A(ECProyecto eCProyecto)
    {
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("CProyecto_A");
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "IdProyecto", DbType.Int32, eCProyecto.IdProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "NombreProyecto", DbType.String, eCProyecto.NombreProyecto);          
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "DescripcionProyecto", DbType.String, eCProyecto.DescripcionProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "UbicacionProyecto", DbType.String, eCProyecto.UbicacionProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "EstadoProyecto", DbType.Byte, eCProyecto.EstadoProyecto);
            // Configura el parámetro de ImagenProyecto como byte[]
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "ImagenProyecto", DbType.String, eCProyecto.ImagenProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "HorasEstimadas", DbType.Byte, eCProyecto.HorasEstimadas);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "FechaInicioProyecto", DbType.Date, eCProyecto.FechaInicioProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "FechaFinProyecto", DbType.Date, eCProyecto.FechaFinProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "FechaCreacionProyecto", DbType.DateTime, eCProyecto.FechaCreacionProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "IdSede", DbType.Int32, eCProyecto.IdSede);
            // Ejecuta el procedimiento almacenado para realizar la inserción.
            BDSWADNETControlServicioSocial.ExecuteNonQuery(dbCommand);
        }

        catch (SqlException SQLEx)
        {

        }
    }
    #endregion
}