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
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "UbicacionProyecto", DbType.String, eCProyecto.UbicacionProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "EstadoProyecto", DbType.AnsiStringFixedLength, eCProyecto.EstadoProyecto);
            // Configura el parámetro de ImagenProyecto como byte[]
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "ImagenProyecto", DbType.Binary, eCProyecto.ImagenProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "HorasEstimadas", DbType.Int16, eCProyecto.HorasEstimadas);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "FechaInicioProyecto", DbType.Date, eCProyecto.FechaInicioProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "FechaFinProyecto", DbType.Date, eCProyecto.FechaFinProyecto);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "FechaCreacionProyecto", DbType.DateTime, eCProyecto.FechaCreacionProyecto);

            // Ejecuta el procedimiento almacenado para realizar la inserción.
            BDSWADNETControlServicioSocial.ExecuteNonQuery(dbCommand);
        }
        catch (SqlException SQLEx)
        {
            // Maneja las excepciones aquí, puedes descomentar y personalizar esta parte para manejar los errores de acuerdo a tus necesidades.
        }

    }
    #endregion

}