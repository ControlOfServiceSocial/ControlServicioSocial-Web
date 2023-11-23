using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADCSede
/// </summary>
public class ADCSede
{
    public DTOCSede ObtenerSedeIdProyecto(int idProyecto)
    {
        DTOCSede dTOCSede = new DTOCSede();
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("ObtnerSedeProyecto");
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "IdProyecto", System.Data.DbType.Int32, idProyecto);
            BDSWADNETControlServicioSocial.LoadDataSet(dbCommand, dTOCSede, "CSede");
        }
        catch (SqlException SQLEx)
        {
            throw;
        }
        return dTOCSede;
    }
}