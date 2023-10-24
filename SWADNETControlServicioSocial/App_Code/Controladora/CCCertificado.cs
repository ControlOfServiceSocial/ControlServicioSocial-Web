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


    public List<ECCertificado> Obtener_CCertificadosEstudiante(int idEstudiante)
    {
        List<ECCertificado> lstECCertificado = new List<ECCertificado>();
        DTOCCertificado dTOCertificado = aDCertificado.ObtenerCertificadosEstudiante(idEstudiante);

        if (dTOCertificado != null)
        {
            foreach (DTOCCertificado.CCertificadoRow drCCertificado in dTOCertificado.CCertificado.Rows)
            {
                ECCertificado eCCertificado = new ECCertificado
                {
                    IdCertificado = drCCertificado.IdCertificado,
                    DocumentoCertificado = drCCertificado.DocumentoCertificado,
                    IdEstudiante = drCCertificado.IdEstudiante,
                    TituloCertificado = drCCertificado.TituloCertificado,
                    CargaHoraria = drCCertificado.CargaHoraria
                };

                lstECCertificado.Add(eCCertificado);
            }
        }
        else
        {
            // Aquí podrías lanzar una excepción o manejarla de acuerdo a tus requerimientos.
        }

        return lstECCertificado;
    }

    #endregion
}