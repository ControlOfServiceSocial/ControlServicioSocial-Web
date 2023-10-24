using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

/// <summary>
/// Descripción breve de ADCCertificado
/// </summary>
public class ADCCertificado
{
    public ADCCertificado()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    #region Metodos Publicos
    public DTOCCertificado Obtener_CCertificado_O()
    {
        DTOCCertificado dTOCCertificado = new DTOCCertificado();
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("CCertificado_O");
            BDSWADNETControlServicioSocial.LoadDataSet(dbCommand, dTOCCertificado, "CCertificado");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOCCertificado;
    }

    public DTOCCertificado Obtener_CCertificado_O_IdEstudiante(int idEstudiante)
    {
        DTOCCertificado dTOCCertificado = new DTOCCertificado();
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("CCertificado_O_IdEstudiante");
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "IdEstudiante", System.Data.DbType.Int32, idEstudiante);
            BDSWADNETControlServicioSocial.LoadDataSet(dbCommand, dTOCCertificado, "CCertificado");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOCCertificado;
    }

    public void Insertar_CCertificado_I(ECCertificado eCCertificado)
    {
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("Insertar_CCertificado_I");
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "DocumentoCertificado", System.Data.DbType.String, eCCertificado.DocumentoCertificado);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "IdEstudiante", System.Data.DbType.Int32, eCCertificado.IdEstudiante);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "TituloCertificado", System.Data.DbType.String, eCCertificado.TituloCertificado);
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "CargaHoraria", System.Data.DbType.Int32, eCCertificado.CargaHoraria);
            BDSWADNETControlServicioSocial.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {

            throw;
        }
    }

    #endregion
}