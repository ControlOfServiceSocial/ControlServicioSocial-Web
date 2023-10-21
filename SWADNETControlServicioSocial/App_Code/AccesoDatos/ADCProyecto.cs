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

    #region Metodos Publicos
    /// <summary>
    /// Obtener todos los estudiantes
    /// </summary>
    /// <returns>Retorna una lista de estudiantes</returns>
    public void Insertar_CProyecto_I(ECProyecto eCProyecto)
    {
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("CProyecto_I");

            // Configura los parámetros del procedimiento almacenado con los datos del proyecto.
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "NombreProyecto", DbType.String, eCProyecto.NombreProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "DescripcionProyecto", DbType.String, eCProyecto.DescripcionProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "UbicacionProyecto", DbType.String, eCProyecto.UbicacionProyecto); // Configura la ubicación del proyecto según tus necesidades.
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "EstadoProyecto", DbType.String, eCProyecto.EstadoProyecto); // Configura el estado del proyecto según tus necesidades.
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "ImagenProyecto", DbType.String, eCProyecto.ImagenProyecto); // Configura la ruta de la imagen según tus necesidades.
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "HorasEstimadas", DbType.Int16, eCProyecto.HorasEstimadas); // Configura las horas estimadas según tus necesidades.
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "FechaInicioProyecto", DbType.Date, eCProyecto.FechaInicioProyecto); // Configura la fecha de inicio según tus necesidades.
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "FechaFinProyecto", DbType.Date, eCProyecto.FechaFinProyecto); // Configura la fecha de fin según tus necesidades.
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "FechaCreacionProyecto", DbType.DateTime, eCProyecto.FechaCreacionProyecto); // Configura la fecha de creación según tus necesidades.

            // Ejecuta el procedimiento almacenado para realizar la inserción.
            BDSWADNETControlServicioSocial.ExecuteNonQuery(dbCommand);
        }
        catch (SqlException SQLEx)
        {
            // EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_RCampania_O", SQLEx.ToString(), SQLEx.Message);
            // throw new FaultException<EDefectoAD>(eDefectoAD);
        }
    }
    #endregion

}