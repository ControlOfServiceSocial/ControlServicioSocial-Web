using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Proyecto_PtableroProyecto : System.Web.UI.Page
{
    ECProyecto eCProyecto = new ECProyecto();
    List<ECProyecto> lstECProyecto = new List<ECProyecto>();
    CCProyecto cProyecto = new CCProyecto();
    int IdProyecto = int.MinValue;
    private static int index;
    protected void Page_Load(object sender, EventArgs e)
    {
        CargarDatos();
    }

    protected void gvListaProyectos_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvListaProyectos.PageIndex = e.NewPageIndex;
        CargarDatos();
    }

    private void CargarDatos()
    {
        gvListaProyectos.DataSource = null;
        lstECProyecto = cProyecto.Obtener_CProyecto_O();
        gvListaProyectos.DataSource = lstECProyecto;
        gvListaProyectos.DataBind();
    }

    protected void btnVer_Click(object sender, EventArgs e)
    {
        Session["EditarProyecto"] = 0;
        Session["flag"] = 1;
        Response.Redirect("PCrearProyecto.aspx");
    }
}