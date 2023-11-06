using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CCSede
/// </summary>
public class CCSede
{
    #region Metodos Privados
    private ADCSede aDCSede;

    public CCSede()
    {
            aDCSede = new ADCSede();
    }
    #endregion
    public ECSede ObtenerSedeIdProyecto(int idProyecto)
    {
        ECSede eCSede = new ECSede();
        DTOCSede dTOCSede = aDCSede.ObtenerSedeIdProyecto(idProyecto);
        if (dTOCSede != null)
        {
            foreach (DTOCSede.CSedeRow drCSede in dTOCSede.CSede.Rows)
            {
                eCSede.IdSede = drCSede.IdSede;
                eCSede.NombreSede = drCSede.NombreSede;
            }

        }
        else
        {
            dTOCSede = new DTOCSede();
        }
        return eCSede;
    }
}