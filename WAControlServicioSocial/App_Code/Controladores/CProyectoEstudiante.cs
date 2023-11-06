using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CProyectoEstudiante
/// </summary>
public class CProyectoEstudiante
{
    LNServicio lNServicio = new LNServicio();

    public ECProyectoEstudiante ObtenerProyectoEstudiantePorIds(int idProyecto, int idEstudiante)
    {
        ECProyectoEstudiante proyectoEstudiante = new ECProyectoEstudiante();
        try
        {
            proyectoEstudiante = lNServicio.ObtenerProyectoEstudiantePorIds(idProyecto, idEstudiante);
        }
        catch (Exception)
        {

            throw;
        }
        return proyectoEstudiante;
    }
}