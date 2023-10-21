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
        byte[] imageBytes = img.FileBytes;
        string base64String = Convert.ToBase64String(imageBytes);

        DateTime dateValueInicio;
        DateTime dateValueFin;
        DateTime dateValueCreacion;
        if (DateTime.TryParse(inicio.ToString(), out dateValueInicio))
        {
            if (DateTime.TryParse(fin.ToString(), out dateValueFin)) 
            {
                if (DateTime.TryParse(creacion.ToString(), out dateValueCreacion))
                {
                    eCProyecto.NombreProyecto = txtnombre.ToString();
                    eCProyecto.DescripcionProyecto = desc.ToString();
                    eCProyecto.UbicacionProyecto = ubicacion.ToString();
                    eCProyecto.EstadoProyecto = estado.ToString();
                    eCProyecto.ImagenProyecto = base64String;
                    eCProyecto.HorasEstimadas = byte.Parse(horas.ToString());
                    eCProyecto.FechaInicioProyecto = dateValueInicio;
                    eCProyecto.FechaFinProyecto = dateValueFin;
                    eCProyecto.FechaCreacionProyecto = dateValueCreacion;
                    cProyecto.Insertar_CProyecto_I(eCProyecto);
                }                   
            }              
        }
        else
        {
            // La cadena no se pudo convertir a DateTime.
        }

        
    }



    protected void btnSend_Click(object sender, EventArgs e)
    {
        crearProyecto();
    }
}