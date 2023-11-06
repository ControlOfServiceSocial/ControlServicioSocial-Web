using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CCProyectoEstudiante
/// </summary>
public class CCProyectoEstudiante
{
    #region Metodos Privados
    private ADCProyectoEstudiante aDCProyectoEstudiante;
    #endregion
    #region Metodos Publicos
    public CCProyectoEstudiante()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
        aDCProyectoEstudiante = new ADCProyectoEstudiante();
    }
    public List<ECProyectoEstudiante> Obtener_CProyectoEstudiante_O()
    {
        ECProyectoEstudiante eCProyectoEstudiante;
        List<ECProyectoEstudiante> lstECProyectoEstudiante = new List<ECProyectoEstudiante>();
        DTOCProyectoEstudiante dTOCProyectoEstudiante = aDCProyectoEstudiante.Obtener_CProyectoEstudiante_O();
        if (dTOCProyectoEstudiante != null)
        {
            foreach (DTOCProyectoEstudiante.CProyectoEstudianteRow drCProyectoEstudiante in dTOCProyectoEstudiante.CProyectoEstudiante.Rows)
            {
                eCProyectoEstudiante = new ECProyectoEstudiante();
                eCProyectoEstudiante.IdProyectoEstudiante = drCProyectoEstudiante.IdProyectoEstudiante;
                eCProyectoEstudiante.IdProyecto = drCProyectoEstudiante.IdProyecto;
                eCProyectoEstudiante.IdEstudiante = drCProyectoEstudiante.IdEstudiante;
                eCProyectoEstudiante.HoraAcumulada = drCProyectoEstudiante.HoraAcumulada;
                eCProyectoEstudiante.HoraInicio = drCProyectoEstudiante.HoraInicio;
                eCProyectoEstudiante.HoraFinal= drCProyectoEstudiante.HoraFinal;
                eCProyectoEstudiante.LatitudInicial = drCProyectoEstudiante.LatitudInicial;
                eCProyectoEstudiante.LongitudInicial = drCProyectoEstudiante.LongitudInicial;
                eCProyectoEstudiante.LatitudInicial = drCProyectoEstudiante.LatitudInicial;
                eCProyectoEstudiante.LatitudFinal = drCProyectoEstudiante.LatitudFinal;
                lstECProyectoEstudiante.Add(eCProyectoEstudiante);
            }

        }
        else
        {
            dTOCProyectoEstudiante = new DTOCProyectoEstudiante();
        }
        return lstECProyectoEstudiante;
    }

    public ECProyectoEstudiante ObtenerCProyectoEstudiantePorIds(int idProyecto, int idEstudiante)
    {
        ECProyectoEstudiante eCProyectoEstudiante = null;
        DTOCProyectoEstudiante dTOCProyectoEstudiante = aDCProyectoEstudiante.ObtenerCProyectoEstudiantePorIds(idProyecto, idEstudiante);
        if (dTOCProyectoEstudiante != null)
        {
            foreach (DTOCProyectoEstudiante.CProyectoEstudianteRow drCProyectoEstudiante in dTOCProyectoEstudiante.CProyectoEstudiante.Rows)
            {
                eCProyectoEstudiante = new ECProyectoEstudiante();
                eCProyectoEstudiante.IdProyectoEstudiante = drCProyectoEstudiante.IdProyectoEstudiante;
                eCProyectoEstudiante.IdProyecto = drCProyectoEstudiante.IdProyecto;
                eCProyectoEstudiante.IdEstudiante = drCProyectoEstudiante.IdEstudiante;
                eCProyectoEstudiante.HoraAcumulada = drCProyectoEstudiante.HoraAcumulada;
                eCProyectoEstudiante.HoraInicio = drCProyectoEstudiante.HoraInicio;
                eCProyectoEstudiante.HoraFinal = drCProyectoEstudiante.HoraFinal;
                eCProyectoEstudiante.LatitudInicial = drCProyectoEstudiante.LatitudInicial;
                eCProyectoEstudiante.LongitudInicial = drCProyectoEstudiante.LongitudInicial;
                eCProyectoEstudiante.LatitudInicial = drCProyectoEstudiante.LatitudInicial;
                eCProyectoEstudiante.LatitudFinal = drCProyectoEstudiante.LatitudFinal;
                break; // Como solo queremos un ECProyectoEstudiante, rompemos el ciclo después de la primera iteración
            }
        }
        return eCProyectoEstudiante;
    }
    #endregion
}