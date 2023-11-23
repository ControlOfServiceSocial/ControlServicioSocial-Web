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
/// Descripción breve de ADCFacultad
/// </summary>
public class ADCFacultad
{
    public ADCFacultad()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    #region Metodos publicos
    public DTOCFacultad ObtenerCFacultadPorId(int idEstudiante)
    {
        DTOCFacultad dTOCFacultad = new DTOCFacultad();
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("CFacultad_EstudianteId");
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "@IdEstudiante", DbType.Int32, idEstudiante);

            BDSWADNETControlServicioSocial.LoadDataSet(dbCommand, dTOCFacultad, "CFacultad");
        }
        catch (SqlException SQLEx)
        {
            // Manejar excepciones aquí
        }
        return dTOCFacultad;
    }
    #endregion
}