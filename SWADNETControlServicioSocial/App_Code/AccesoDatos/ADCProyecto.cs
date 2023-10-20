using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADCProyecto
/// </summary>
public class ADCProyecto
{
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
    #endregion
}