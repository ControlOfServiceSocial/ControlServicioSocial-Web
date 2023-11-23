using System;
using System.Activities.Expressions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CCEstudiante
/// </summary>
public class CCEstudiante
{
    #region Metodos Privados
    private ADCEstudiante adCEstudiante;
    #endregion

    #region Metodos Publicos
    public CCEstudiante() 
    {
        adCEstudiante = new ADCEstudiante();
    }

    public List<ECEstudiante> Obtener_CEstudiante_O()
    {
        ECEstudiante eCEstudiante;
        List<ECEstudiante> lstECEstudiante = new List<ECEstudiante>();
        DTOCEstudiante dtoCEstudiante = adCEstudiante.Obtener_CEstudiante_O();
        if (dtoCEstudiante != null)
        {
            foreach (DTOCEstudiante.CEstudianteRow drCEstudiante in dtoCEstudiante.CEstudiante.Rows)
            {
                eCEstudiante = new ECEstudiante();
                eCEstudiante.IdEstudiante = drCEstudiante.IdEstudiante;
                eCEstudiante.NombreEstudiante = drCEstudiante.NombreEstudiante.TrimEnd();
                eCEstudiante.ApellidoPaternoEstudiante = drCEstudiante.ApellidoPaternoEstudiante.TrimEnd();
                eCEstudiante.ApellidoMaternoEstudiante = drCEstudiante.ApellidoMaternoEstudiante.TrimEnd();
                eCEstudiante.EmailEstudiante = drCEstudiante.EmailEstudiante.TrimEnd();
                eCEstudiante.TelefonoEstudiante = drCEstudiante.TelefonoEstudiante.TrimEnd();
                eCEstudiante.FechaRegistroEstudiante = drCEstudiante.FechaRegistroEstudiante;
                eCEstudiante.FechaActualizacion = drCEstudiante.FechaActualizacion;
                lstECEstudiante.Add(eCEstudiante);
            }
        }
        else
        {
            dtoCEstudiante = new DTOCEstudiante();
        }

        return lstECEstudiante;
    }

    public ECEstudiante ObtenerEstudiantePorId(int idEstudiante)
    {
        DTOCEstudiante dtoCEstudiante = adCEstudiante.Obtener_CEstudiante_O(idEstudiante);
        if (dtoCEstudiante != null && dtoCEstudiante.CEstudiante.Rows.Count > 0)
        {
            DTOCEstudiante.CEstudianteRow drCEstudiante = dtoCEstudiante.CEstudiante[0];
            ECEstudiante eCEstudiante = new ECEstudiante();
            eCEstudiante.IdEstudiante = drCEstudiante.IdEstudiante;
            eCEstudiante.NombreEstudiante = drCEstudiante.NombreEstudiante.TrimEnd();
            eCEstudiante.ApellidoPaternoEstudiante = drCEstudiante.ApellidoPaternoEstudiante.TrimEnd();
            eCEstudiante.ApellidoMaternoEstudiante = drCEstudiante.ApellidoMaternoEstudiante.TrimEnd();
            eCEstudiante.EmailEstudiante = drCEstudiante.EmailEstudiante.TrimEnd();
            eCEstudiante.TelefonoEstudiante = drCEstudiante.TelefonoEstudiante.TrimEnd();
            eCEstudiante.FechaRegistroEstudiante = drCEstudiante.FechaRegistroEstudiante;
            eCEstudiante.FechaActualizacion = drCEstudiante.FechaActualizacion;
            return eCEstudiante;
        }
        else
        {
            // Manejar el caso en el que el estudiante no se encontró
            // Puedes lanzar una excepción, devolver un valor por defecto, o tomar otra acción según tus necesidades.
            return null; // En este ejemplo, se devuelve null si el estudiante no se encuentra.
        }
    }

    #endregion
}