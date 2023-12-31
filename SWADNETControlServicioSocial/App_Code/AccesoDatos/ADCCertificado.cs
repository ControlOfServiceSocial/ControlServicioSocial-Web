﻿using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
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

    public DTOCCertificado ObtenerCertificadosEstudiante(int idEstudiante)
    {
        DTOCCertificado dTOCCertificado = new DTOCCertificado();
        try
        {
            Database BDSWADNETControlServicioSocial = SBaseDatos.BDSWADNETControlServicioSocial;
            DbCommand dbCommand = BDSWADNETControlServicioSocial.GetStoredProcCommand("CCertificado_IdEstudiante");
            BDSWADNETControlServicioSocial.AddInParameter(dbCommand, "@EstudianteId", DbType.Int32, idEstudiante);

            BDSWADNETControlServicioSocial.LoadDataSet(dbCommand, dTOCCertificado, "CCertificado");
        }
        catch (SqlException SQLEx)
        {

            throw;
        }
        return dTOCCertificado;
    }
 
    #endregion
}