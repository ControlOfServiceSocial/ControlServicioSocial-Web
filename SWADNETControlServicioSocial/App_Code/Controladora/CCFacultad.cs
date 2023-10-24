using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

/// <summary>
/// Descripción breve de CCFacultad
/// </summary>
public class CCFacultad
{
    private ADCFacultad adCEFacultad;

    public CCFacultad()
    {
        adCEFacultad = new ADCFacultad();
    }
    public ECFacultad ObtenerFacultadPorIdEstudiante(int idEstudiante)
    {
        DTOCFacultad dtoCEFacultad = adCEFacultad.ObtenerCFacultadPorId(idEstudiante); // Reemplaza con tu lógica de acceso a datos

        if (dtoCEFacultad != null && dtoCEFacultad.CFacultad.Rows.Count > 0)
        {
            DTOCFacultad.CFacultadRow drCFacultad = dtoCEFacultad.CFacultad[0];
            ECFacultad eCFacultad = new ECFacultad();
            eCFacultad.IdFacultad = drCFacultad.IdFacultad;
            eCFacultad.NombreFacultad = drCFacultad.NombreFacultad.TrimEnd();
            eCFacultad.IdEstudiante = drCFacultad.IdEstudiante;
            eCFacultad.IdSede = drCFacultad.IdSede;

            return eCFacultad;
        }
        else
        {
            // Manejar el caso en el que la facultad no se encontró para el estudiante dado
            // Puedes lanzar una excepción, devolver un valor por defecto o tomar otra acción según tus necesidades.
            return null; // En este ejemplo, se devuelve null si la facultad no se encuentra para el estudiante dado.
        }
    }

}