using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Descripción breve de ADCEstudiante
/// </summary>
public class ADCEstudiante
{
    // Creamos nuestros metodos que van a hacer la comunicacion con el acceso a datos.

    #region Metodos Publicos
    /// <summary>
    /// Obtener todos los estudiantes
    /// </summary>
    /// <returns>Retorna una lista de estudiantes</returns>
    public DTOCEstudiante Obtener_CEstudiante_O()
    {
        DTOCEstudiante dTOCEstudiante = new DTOCEstudiante();
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("CEstudiante_O");

            BDSWADNETControlServicioSocial.LoadDataSet(dbCommand, dTOCEstudiante, "CEstudiante");
        }

        catch (SqlException SQLEx)
        {
            // EDefectoAD eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_RCampania_O", SQLEx.ToString(), SQLEx.Message);
            // throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dTOCEstudiante;
    }

    public DTOCEstudiante Obtener_CEstudiante_O(int idEstudiante)
    {
        DTOCEstudiante dTOCEstudiante = new DTOCEstudiante();
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("CEstudiante_id_O");
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "@IdEstudiante", DbType.Int32, idEstudiante);

            BDSWADNETControlServicioSocial.LoadDataSet(dbCommand, dTOCEstudiante, "CEstudiante");
        }
        catch (SqlException SQLEx)
        {
            // Manejar excepciones aquí
        }
        return dTOCEstudiante;
    }

    #endregion
}