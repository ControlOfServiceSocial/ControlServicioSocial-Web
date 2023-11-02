using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SWLNControlServicioSocial;
/// <summary>
/// Descripción breve de CCProyecto
/// </summary>
public class CCProyecto
{
    LNServicio lNServicio=new LNServicio();
    public CCProyecto()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    public List<ECProyecto> Obtener_CProyecto_O()
    {
        List<ECProyecto> lstECProyectos = new List<ECProyecto>();
        try
        {
            lstECProyectos = lNServicio.Obtener_CProyecto_O();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + " ERRROROROROR ");
        }
        return lstECProyectos;
    }

    public List<ECProyecto> Obtener_CProyecto_O_CProyecto(int idEstudiante)
    {
        List<ECProyecto> lstECProyecto = new List<ECProyecto>();
        try
        {
            lstECProyecto = lNServicio.Obtener_CProyecto_O_CProyecto(idEstudiante);
        }
        catch (Exception)
        {

            throw;
        }
        return lstECProyecto;
    }

    public ECProyecto ObtenerProyectoPorId_C(int idProyecto)
    {
        ECProyecto proyecto = new ECProyecto();
        try
        {
            proyecto = lNServicio.ObtenerProyectoPorId(idProyecto);
        }
        catch (Exception)
        {
            // Manejar excepciones aquí
            throw;
        }
        return proyecto;
    }
}