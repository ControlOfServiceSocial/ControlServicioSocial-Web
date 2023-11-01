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
    CProyecto cProyecto = new CProyecto();
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
        lstECProyecto = cProyecto.Obtener_CProyecto_O_CC();
        gvListaProyectos.DataSource = lstECProyecto;
        gvListaProyectos.DataBind();
    }

    protected void btnVer_Click(object sender, EventArgs e)
    {
        Response.Redirect("PCrearProyecto.aspx");
    }

    protected void gvListaProyectos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        index = Convert.ToInt32(e.CommandArgument);
        string IdProyectoString = System.Net.WebUtility.HtmlDecode(gvListaProyectos.Rows[index].Cells[0].Text);
        IdProyecto = int.Parse(IdProyectoString);
        
        if (e.CommandName == "btnActualizar")
        {
            Session["EditarProyecto"] = IdProyecto;
            Response.Redirect("PCrearProyecto.aspx");
        }
        
    }
}