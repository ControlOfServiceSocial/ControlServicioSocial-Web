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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (int.Parse(Session["EditarProyecto"].ToString()) > 0)
        {
            lstECProyecto = cProyecto.Obtener_CProyecto_O_CC_ID(int.Parse(Session["EditarProyecto"].ToString()));

            foreach (ECProyecto proyecto in lstECProyecto)
            {
                txtnombre.Text = proyecto.NombreProyecto;
                ubicacion.Text = proyecto.UbicacionProyecto;
                inicio.Text = proyecto.FechaInicioProyecto.ToString();
                fin.Text = proyecto.FechaFinProyecto.ToString();
                creacion.Text = proyecto.FechaCreacionProyecto.ToString();
                estado.SelectedIndex = proyecto.EstadoProyecto;
                horas.Text = proyecto.HorasEstimadas.ToString();
                desc.Text = proyecto.DescripcionProyecto;
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
                    cProyecto.Insertar_CProyecto_I_CC(txtnombre.Text, desc.Text, ubicacion.Text, byte.Parse(estado.SelectedValue), rutaImagen, byte.Parse(horas.Text), DateTime.Parse(inicio.Text), DateTime.Parse(fin.Text), DateTime.Parse(creacion.Text));
                    mensaje.InnerText="El proyecto se guardo correctamente";
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
        crearProyecto();
    }
}