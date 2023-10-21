using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Proyecto_PCrearProyecto : System.Web.UI.Page
{
    ECProyecto eCProyecto = new ECProyecto();
    CProyecto cProyecto = new CProyecto();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    private void crearProyecto()
    {
        byte[] fileBytes = null;
        
        eCProyecto = new ECProyecto(0, txtnombre.ToString(), desc.ToString(), ubicacion.ToString(), estado.ToString(), fileBytes, horas.ToString(), 
            inicio.ToString(), fin.ToString(), creacion.ToString());
        eCProyecto.NombreProyecto = txtnombre.ToString();
        eCProyecto.DescripcionProyecto = desc.ToString();
        eCProyecto.UbicacionProyecto = ubicacion.ToString();
        eCProyecto.EstadoProyecto = estado.ToString();
        eCProyecto.ImagenProyecto = fileBytes;
        eCProyecto.HorasEstimadas = horas.ToString();
        eCProyecto.FechaInicioProyecto = inicio.ToString();
        eCProyecto.FechaFinProyecto = fin.ToString();
        eCProyecto.FechaCreacionProyecto = creacion.ToString();
        cProyecto.Insertar_CProyecto_I(eCProyecto);
    }


}