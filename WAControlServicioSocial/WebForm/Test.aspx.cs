using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNControlServicioSocial;
public partial class WebForm_Test : System.Web.UI.Page
{
    ECProyecto eCProyecto = new ECProyecto();
    List<ECProyecto> lstECProyecto = new List<ECProyecto>();
    CCProyecto cProyecto = new CCProyecto();
    protected void Page_Load(object sender, EventArgs e)
    {
        CargarDatos();
    }
    public void CargarDatos()
    {
        lstECProyecto = cProyecto.Obtener_CProyecto_O();

        Console.WriteLine(lstECProyecto.Count+"AQUIUIIIIOIO");
    }
}