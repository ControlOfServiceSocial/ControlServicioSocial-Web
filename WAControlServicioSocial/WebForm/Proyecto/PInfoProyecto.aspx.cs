using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Proyecto_PInfoProyecto : System.Web.UI.Page
{
    CCProyecto cCProyecto = new CCProyecto();
    CCSede cCSede = new CCSede();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["idProyecto"] != null)
            {
                int proyectoId = Convert.ToInt32(Request.QueryString["idProyecto"]);
                ECProyecto proyecto = cCProyecto.ObtenerProyectoPorId_C(proyectoId);
                ECSede sede = cCSede.ObtenerSedeIdProyecto(proyectoId);
                lblSede.Text = sede.NombreSede;
                lblSubtitulo.Text = proyecto.NombreProyecto;
                lblNombreProyecto.Text = proyecto.NombreProyecto;
                lblFechaInicio.Text = proyecto.FechaInicioProyecto.ToString("dd/MM/yyyy");
                lblUbicacion.Text = proyecto.UbicacionProyecto;
                lblFechaCreacion.Text = proyecto.FechaCreacionProyecto.ToString("dd/MM/yyyy");
                lblFechaFin.Text = proyecto.FechaFinProyecto.ToString("dd/MM/yyyy");
                if (proyecto.EstadoProyecto == 1)
                {
                    lblEstado.Text = "Activo";
                } else
                {
                    lblEstado.Text = "Finalizado";
                }

                if (proyecto.HorasEstimadas == 1)
                {
                    lblHorasEstimadas.Text = proyecto.HorasEstimadas + " hora";
                } else
                {
                    lblHorasEstimadas.Text = proyecto.HorasEstimadas + " horas";
                }

                lblDescripcion.Text = proyecto.DescripcionProyecto;
                imgProyecto.ImageUrl = ResolveUrl("~/Imagenes/Proyecto/" + proyecto.ImagenProyecto);
            }
        }
    }
}