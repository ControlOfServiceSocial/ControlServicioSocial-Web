using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Proyecto_PCrearProyecto : System.Web.UI.Page
{
    CProyecto cProyecto = new CProyecto();
    List<ECProyecto> lstECProyecto = new List<ECProyecto>();
    int flag = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["idProyecto"] != null)
            {
                lstECProyecto = cProyecto.Obtener_CProyecto_O_CC_ID(int.Parse(Request.QueryString["idProyecto"]));

                foreach (ECProyecto proyecto in lstECProyecto)
                {
                    txtnombre.Text = proyecto.NombreProyecto;
                    ubicacion.Text = proyecto.UbicacionProyecto;
                    inicio.Text = proyecto.FechaInicioProyecto.ToString("yyyy-MM-dd");
                    fin.Text = proyecto.FechaFinProyecto.ToString("yyyy-MM-dd");
                    creacion.Text = proyecto.FechaCreacionProyecto.ToString("yyyy-MM-dd");
                    estado.SelectedIndex = proyecto.EstadoProyecto;
                    horas.Text = proyecto.HorasEstimadas.ToString();
                    desc.Text = proyecto.DescripcionProyecto;
                    if (proyecto.IdSede != 0)
                        sede.SelectedIndex = proyecto.IdSede;

                    Session["flag"] = 1;
                }
            }
        } 
    }

    private void crearProyecto()
    {
        if (img.HasFile)
        {
            // Verifica si el archivo es una imagen
            string extension = Path.GetExtension(img.FileName);
            if (extension != "")
            {
                string fileName = Path.GetFileName(img.PostedFile.FileName);
                string filePath = Server.MapPath("../../Imagenes/Proyecto/") + txtnombre.Text;
                img.SaveAs(filePath);

                string rutaImagen = "../../Imagenes/Proyecto/" + txtnombre.Text;           
                try
                {
                    cProyecto.Insertar_CProyecto_I_CC(txtnombre.Text, desc.Text, ubicacion.Text, byte.Parse(estado.SelectedValue), rutaImagen, byte.Parse(horas.Text), DateTime.Parse(inicio.Text), DateTime.Parse(fin.Text), DateTime.Parse(creacion.Text), int.Parse(sede.SelectedValue));
                    mensaje.InnerText="El proyecto se guardo correctamente";
                    Session["EditarProyecto"] = 0;
                    Response.Redirect("PtableroProyecto.aspx");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {

            }
        }
        else
        {
            mensaje.InnerText = "Debe subir una imagen";
        }
 
    }

    private void actualizar()
    {
        if (img.HasFile)
        {
            // Verifica si el archivo es una imagen
            string extension = Path.GetExtension(img.FileName);
            if (extension != "")
            {
                string fileName = Path.GetFileName(img.PostedFile.FileName);
                string filePath = Server.MapPath("../../Imagenes/Proyecto/") + txtnombre.Text;
                img.SaveAs(filePath);

                string rutaImagen = "../../Imagenes/Proyecto/" + txtnombre.Text;
                try
                {
                    cProyecto.Actualizar_CProyecto_A_CC(int.Parse(Session["EditarProyecto"].ToString()), txtnombre.Text, desc.Text, ubicacion.Text, byte.Parse(estado.SelectedValue), rutaImagen, byte.Parse(horas.Text), DateTime.Parse(inicio.Text), DateTime.Parse(fin.Text), DateTime.Parse(creacion.Text), int.Parse(sede.SelectedValue));
                    mensaje.InnerText = "El proyecto se actualizo correctamente";
                    Session["EditarProyecto"] = 0;
                    Response.Redirect("PtableroProyecto.aspx");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {

            }
        }
        else
        {
            mensaje.InnerText = "Debe subir una imagen";
        }

    }


    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (int.Parse(Session["EditarProyecto"].ToString()) > 0)
        {
            actualizar();
        }
        else
        {
            crearProyecto();
        }
            
    }

}