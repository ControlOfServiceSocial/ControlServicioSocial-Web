 using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Estudiante_TableroEstudiante : System.Web.UI.Page
{
    ECEstudiante eCEstudiante = new ECEstudiante();
    List<ECEstudiante> lstECEstudiante = new List<ECEstudiante>();
    CEstudiante cEstudiante = new CEstudiante();

    protected void Page_Load(object sender, EventArgs e)
    {
        CargarDatos();
    }


    private void CargarDatos()
    {
        gvListaEstudiantes.DataSource = null;
        lstECEstudiante = cEstudiante.Obtener_CEstudiante_O_CC();
        gvListaEstudiantes.DataSource = lstECEstudiante;
        gvListaEstudiantes.DataBind();
    }

    protected void gvListaEstudiantes_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvListaEstudiantes.PageIndex = e.NewPageIndex;
        CargarDatos();
    }
}