using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CCCertificado
/// </summary>
public class CCCertificado
{
    #region Metodos Privados
    private ADCCertificado aDCertificado;
    #endregion
    #region Metodos Publicos
    public CCCertificado()
    {
        aDCertificado = new ADCCertificado();
    }
    public List<ECCertificado> Obtener_CCertificado_O()
    {
        ECCertificado eCCertificado = new ECCertificado();  
        List<ECCertificado> lstECCertificado = new List<ECCertificado>();
        DTOCCertificado dTOCCertificado=aDCertificado.Obtener_CCertificado_O();
        if (dTOCCertificado!=null)
        {
            foreach (DTOCCertificado.CCertificadoRow drCCertificado in dTOCCertificado.CCertificado.Rows)
            {
                eCCertificado = new ECCertificado();
                eCCertificado.IdCertificado = drCCertificado.IdCertificado;
                eCCertificado.DocumentoCertificado = drCCertificado.DocumentoCertificado;
                eCCertificado.IdEstudiante = drCCertificado.IdEstudiante;
                eCCertificado.TituloCertificado = drCCertificado.TituloCertificado;
                eCCertificado.CargaHoraria = drCCertificado.CargaHoraria;
                lstECCertificado.Add(eCCertificado);
            }
        }
        else
        {
            dTOCCertificado = new DTOCCertificado();
        }
        return lstECCertificado;
    }

    public List<ECCertificado> Obtener_CCertificado_O_IdEstudiante(int idEstudiante)
    {
        ECCertificado eCCertificado = new ECCertificado();
        List<ECCertificado> lstECCertificado = new List<ECCertificado>();
        DTOCCertificado dTOCCertificado = aDCertificado.Obtener_CCertificado_O_IdEstudiante(idEstudiante);
        if (dTOCCertificado!=null)
        {
            foreach (DTOCCertificado.CCertificadoRow drCCertificado in dTOCCertificado.CCertificado.Rows)
            {
                eCCertificado = new ECCertificado();
                eCCertificado.IdCertificado = drCCertificado.IdCertificado;
                eCCertificado.DocumentoCertificado = drCCertificado.DocumentoCertificado;
                eCCertificado.IdEstudiante = drCCertificado.IdEstudiante;
                eCCertificado.TituloCertificado = drCCertificado.TituloCertificado;
                eCCertificado.CargaHoraria = drCCertificado.CargaHoraria;
                lstECCertificado.Add(eCCertificado);
            }
        }
        else
        {
            dTOCCertificado = new DTOCCertificado();
        }
        return lstECCertificado;
    }

    public void Insertar_CCertificado_I(ECCertificado eCCertificado)
    {
        aDCertificado.Insertar_CCertificado_I(eCCertificado);
    }
    #endregion
}